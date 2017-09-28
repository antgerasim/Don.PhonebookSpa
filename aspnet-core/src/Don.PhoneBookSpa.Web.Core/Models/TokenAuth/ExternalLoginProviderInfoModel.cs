using Abp.AutoMapper;
using Don.PhoneBookSpa.Authentication.External;

namespace Don.PhoneBookSpa.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
