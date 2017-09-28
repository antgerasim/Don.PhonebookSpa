using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Don.PhoneBookSpa.Domain.People.Dto
{
    [AutoMapFrom(typeof(Person))]//as for list, no required attributes
    public class PersonListDto : FullAuditedEntityDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
    }
}