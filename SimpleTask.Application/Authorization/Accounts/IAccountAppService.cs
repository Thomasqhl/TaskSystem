using System.Threading.Tasks;
using Abp.Application.Services;
using SimpleTask.Authorization.Accounts.Dto;

namespace SimpleTask.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
