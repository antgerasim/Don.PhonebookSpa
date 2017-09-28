using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Don.PhoneBookSpa.MultiTenancy.Dto;

namespace Don.PhoneBookSpa.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
