using Abp.AutoMapper;
using SimpleTask.Sessions.Dto;

namespace SimpleTask.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}