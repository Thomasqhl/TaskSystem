
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;

using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using SimpleTask.Dto;
using SimpleTask.TaskMoulds.Dto;

namespace SimpleTask.TaskMoulds
{
    public class TaskMouldAppService: SimpleTaskAppServiceBase,ITaskMouldAppService
    {
        private readonly IRepository<TaskMould> taskMouldRepository;
        private readonly ITaskMouldManager taskMouldManager;

        public TaskMouldAppService(IRepository<TaskMould> taskMouldRepository, ITaskMouldManager taskMouldManager)
        {
            this.taskMouldManager = taskMouldManager;
            this.taskMouldRepository = taskMouldRepository;
        }

        public async Task<PagedResultDto<TaskMouldDto>> ListTaskMoulds(TaskMouldRequestDto input)
        {
            var query = this.taskMouldRepository.GetAll()
                .WhereIf(!input.Search.Value.IsNullOrEmpty(), s => s.Type.Equals(input.Type)|| s.Project.Contains(input.Search.Value));

            var count = await query.CountAsync();
            var result = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();
            var record = result.Join(this.UserManager.Users,t => t.CreatorUserId,u => u.Id,
                (t,u) => new { TaskMould = t,Users = u}).Select(r => new TaskMouldDto
                {
                    Id = r.TaskMould.Id,
                    Type = r.TaskMould.Type,
                    Project = r.TaskMould.Project,
                    Brief = r.TaskMould.Brief,
                    PersonInCharge = r.TaskMould.PersonInCharge,
                    TaskPriority = r.TaskMould.TaskPriority,
                    State = r.TaskMould.State,
                    UserName = r.Users.UserName,
                    CreationTime = r.TaskMould.CreationTime,
                    LastModificationTime = r.TaskMould.LastModificationTime
                 }).ToList();
            return new DatatablesPagedResultOutput<TaskMouldDto>(count, record, count);
        }

        public async Task Delete(EntityDto input)
        {
            await this.taskMouldRepository.DeleteAsync(input.Id);
        }

        public async Task CreateOrEdit(TaskMouldRequestDto input)
        {
            if (input.Id.HasValue)
            {
                var entity = await this.taskMouldRepository.GetAsync(input.Id.Value);
                entity = input.MapTo<TaskMould>();
                await this.taskMouldRepository.UpdateAsync(entity);
            }
            else
            {
                var entity = input.MapTo<TaskMould>();
                await this.taskMouldManager.Create(entity);
            }
        }

        public async Task<TaskMould> Detail(TaskMouldRequestDto input)
        {
            return await this.taskMouldRepository.GetAsync(input.Id.Value);
        }

    }
}
