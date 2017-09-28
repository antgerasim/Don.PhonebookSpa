using Abp.MultiTenancy;
using Don.PhoneBookSpa.Authorization.Users;

namespace Don.PhoneBookSpa.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}