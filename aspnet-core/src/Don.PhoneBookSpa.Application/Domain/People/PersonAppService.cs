using System.Collections.Generic;
using System.Linq;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;

using Don.PhoneBookSpa.Domain.People.Dto;

namespace Don.PhoneBookSpa.Domain.People
{
    public class PersonAppService : PhoneBookSpaAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Person> _personRepository;

        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public ListResultDto<PersonListDto> GetPeople(GetPeopleInput input)
        {
            var people = _personRepository.GetAll().WhereIf(!input.Filter.IsNullOrEmpty(),
                p => p.Name.Contains(input.Filter) || 
                p.Surname.Contains(input.Filter)|| 
                p.EmailAddress.Contains(input.Filter))
                .OrderBy(p=>p.Name)
                .ThenBy(p=>p.Surname)
                .ToList();

            //Maps List<Person> to List<PersonListDto> 
            var retVal = new ListResultDto<PersonListDto>(ObjectMapper.Map<List<PersonListDto>>(people));

            return retVal;

        }
    }
}