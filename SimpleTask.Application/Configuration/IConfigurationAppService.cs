using System.Threading.Tasks;
using Abp.Application.Services;
using SimpleTask.Configuration.Dto;

namespace SimpleTask.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}