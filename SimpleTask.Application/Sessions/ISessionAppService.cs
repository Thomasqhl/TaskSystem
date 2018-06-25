using System.Threading.Tasks;
using Abp.Application.Services;
using SimpleTask.Sessions.Dto;

namespace SimpleTask.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
