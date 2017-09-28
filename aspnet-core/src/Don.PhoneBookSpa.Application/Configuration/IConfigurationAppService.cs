using System.Threading.Tasks;
using Don.PhoneBookSpa.Configuration.Dto;

namespace Don.PhoneBookSpa.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}