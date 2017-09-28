using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Don.PhoneBookSpa.EntityFrameworkCore
{
    public static class PhoneBookSpaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PhoneBookSpaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PhoneBookSpaDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}