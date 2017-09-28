using Don.PhoneBookSpa.Configuration;
using Don.PhoneBookSpa.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Don.PhoneBookSpa.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PhoneBookSpaDbContextFactory : IDesignTimeDbContextFactory<PhoneBookSpaDbContext>
    {
        public PhoneBookSpaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PhoneBookSpaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PhoneBookSpaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PhoneBookSpaConsts.ConnectionStringName));

            return new PhoneBookSpaDbContext(builder.Options);
        }
    }
}