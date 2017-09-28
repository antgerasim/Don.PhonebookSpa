using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Don.PhoneBookSpa.Domain.People.Dto;

namespace Don.PhoneBookSpa.Domain.People
{
    public interface IPersonAppService : IApplicationService
    {
        ListResultDto<PersonListDto> GetPeople(GetPeopleInput input);
    }
}