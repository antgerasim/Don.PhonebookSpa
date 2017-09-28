using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Don.PhoneBookSpa.Configuration.Dto;

namespace Don.PhoneBookSpa.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PhoneBookSpaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
