using System.Threading.Tasks;
using Abp.Application.Services;
using Don.PhoneBookSpa.Sessions.Dto;

namespace Don.PhoneBookSpa.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
