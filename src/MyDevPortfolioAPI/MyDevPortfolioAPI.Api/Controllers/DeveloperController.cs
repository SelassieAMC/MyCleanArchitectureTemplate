using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyDevPortfolioAPI.Application.DTOs;
using MyDevPortfolioAPI.Application.Person.Commands;
using MyDevPortfolioAPI.Infraestructure.Services;

namespace MyDevPortfolioAPI.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public sealed class DeveloperController : BaseController
    {
        public readonly MessageService _messages;
        private readonly IMapper _mapper;

        public DeveloperController(MessageService messages, IMapper mapper)
        {
            _messages = messages;
            _mapper = mapper;
        }

        public IActionResult AddBasicPersonalInfo([FromBody] CreateUpdatePersonDto personDto)
        {
            var command = _mapper.Map<AddBasicPersonalInfoCommand>(personDto);
            var result = _messages.Dispatch(command);
            return FromResult(result);
        }
    }
}