using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Don.PhoneBookSpa.Controllers
{
    public abstract class PhoneBookSpaControllerBase: AbpController
    {
        protected PhoneBookSpaControllerBase()
        {
            LocalizationSourceName = PhoneBookSpaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}