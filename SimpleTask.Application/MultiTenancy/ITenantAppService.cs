using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SimpleTask.MultiTenancy.Dto;

namespace SimpleTask.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
