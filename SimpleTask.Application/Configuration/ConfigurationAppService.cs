using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SimpleTask.Configuration.Dto;

namespace SimpleTask.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SimpleTaskAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
