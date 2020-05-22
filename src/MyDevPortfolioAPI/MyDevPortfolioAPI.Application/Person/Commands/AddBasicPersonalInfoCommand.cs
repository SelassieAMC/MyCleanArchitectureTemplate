using CSharpFunctionalExtensions;
using MyDevPortfolioAPI.Application.Common.Interfaces;
using MyDevPortfolioAPI.Application.Common.Mappings;
using ENT = MyDevPortfolioAPI.Core.Entities;
using System;
using AutoMapper;

namespace MyDevPortfolioAPI.Application.Person.Commands
{
    public sealed class AddBasicPersonalInfoCommand : 
        IMapFrom<ENT.Person>, ICommand
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

        public sealed class AddBasicPersonalInfoCommandHandler : ICommandHandler<AddBasicPersonalInfoCommand>
        {
            private readonly IPersonRepository _personRepo;
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public AddBasicPersonalInfoCommandHandler(
                IPersonRepository personRepo, 
                IUnitOfWork unitOfWork,
                IMapper mapper)
            {
                _personRepo = personRepo;
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public Result Handle(AddBasicPersonalInfoCommand command)
            {
                var personEntity = _mapper.Map<ENT.Person>(command);

                try
                {
                    _personRepo.AddPersonalInfo(personEntity);
                    _unitOfWork.CommitAsync();
                }
                catch(Exception ex)
                {
                    return Result.Failure(ex.Message);
                }
                
                return Result.Ok();
            }

        }
    }
}
