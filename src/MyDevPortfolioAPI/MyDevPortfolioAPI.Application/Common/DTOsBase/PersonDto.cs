using MyDevPortfolioAPI.Application.Common.Mappings;
using MyDevPortfolioAPI.Application.Person.Commands;
using System;

namespace MyDevPortfolioAPI.Application.Common.DTOsBase
{
    public class PersonDto : IMapFrom<AddBasicPersonalInfoCommand>
    {
        public Guid Id { get; set; }
        public int DocumentTypeID { get; set; }
        public string DocumentNumber { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string SeconLastName { get; set; }
        public DateTime BirthDay { get; set; }
        public char Gender { get; set; }
        public string PhotoFile { get; set; }
        public string Phone { get; set; }
    }
}
