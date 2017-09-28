using System.Threading.Tasks;
using Abp.Application.Services;
using Don.PhoneBookSpa.Authorization.Accounts.Dto;

namespace Don.PhoneBookSpa.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
