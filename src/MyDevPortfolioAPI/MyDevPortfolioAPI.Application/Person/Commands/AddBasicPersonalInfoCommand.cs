using CSharpFunctionalExtensions;
using MyDevPortfolioAPI.Application.Common.Interfaces;
using MyDevPortfolioAPI.Application.Common.Mappings;
using MyDevPortfolioAPI.Application.DataTransferObjects;
using System;

namespace MyDevPortfolioAPI.Application.Person.Commands
{
    public sealed class AddBasicPersonalInfoCommand : IMapFrom<PersonDto>, ICommand
    {
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

        public AddBasicPersonalInfoCommand() { }

        internal sealed class AddBasicPersonalInfoCommandHandler : ICommandHandler<AddBasicPersonalInfoCommand>
        {
            //Inject Dependencies (repositories, unitofwork, etc)
            public AddBasicPersonalInfoCommandHandler() { }
            public Result Handle(AddBasicPersonalInfoCommand command)
            {
                return Result.Ok();
            }

        }
    }
}
