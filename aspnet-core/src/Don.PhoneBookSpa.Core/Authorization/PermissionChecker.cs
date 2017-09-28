using Abp.Authorization;
using Don.PhoneBookSpa.Authorization.Roles;
using Don.PhoneBookSpa.Authorization.Users;

namespace Don.PhoneBookSpa.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
