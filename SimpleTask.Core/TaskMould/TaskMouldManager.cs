using System.Collections.Generic;
using System.Linq;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Linq.Extensions;
using System.Threading.Tasks;
using Abp.UI;
namespace SimpleTask.TaskMoulds
{
    public class TaskMouldManager : DomainService, ITaskMouldManager
    {
        public readonly IRepository<TaskMould> taskMouldRepository;

        public TaskMouldManager(IRepository<TaskMould> taskMouldRepository)
        {
            this.taskMouldRepository = taskMouldRepository;
        }
        public async Task Create(TaskMould input)
        {
            await this.taskMouldRepository.InsertAsync(input);
        }

        public async Task Update(TaskMould input)
        {
            await this.taskMouldRepository.UpdateAsync(input);
        }
    }
}
