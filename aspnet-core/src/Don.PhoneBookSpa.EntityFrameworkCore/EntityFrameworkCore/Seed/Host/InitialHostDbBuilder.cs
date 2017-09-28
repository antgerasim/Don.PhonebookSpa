using Don.PhoneBookSpa.EntityFrameworkCore.Seed.Domain.People;

namespace Don.PhoneBookSpa.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly PhoneBookSpaDbContext _context;

        public InitialHostDbBuilder(PhoneBookSpaDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
            new DefaultPeopleCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
