using Abp.Zero.EntityFrameworkCore;
using Don.PhoneBookSpa.Authorization.Roles;
using Don.PhoneBookSpa.Authorization.Users;
using Don.PhoneBookSpa.Domain.People;
using Don.PhoneBookSpa.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Don.PhoneBookSpa.EntityFrameworkCore
{
    public class PhoneBookSpaDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookSpaDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        public virtual DbSet<Person> Persons { get; set; }
        
        public PhoneBookSpaDbContext(DbContextOptions<PhoneBookSpaDbContext> options)
            : base(options)
        {

        }
    }
}
