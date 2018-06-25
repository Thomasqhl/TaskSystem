using SimpleTask.TaskMoulds;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using SimpleTask.TaskMoulds.Dto;

namespace SimpleTask.TaskMoulds
{
    public interface ITaskMouldAppService :IApplicationService
    {
        Task<PagedResultDto<TaskMouldDto>> ListTaskMoulds(TaskMouldRequestDto input);

        Task Delete(EntityDto input);

        Task CreateOrEdit(TaskMouldRequestDto input);
        Task<TaskMould> Detail(TaskMouldRequestDto input);
    }
}
