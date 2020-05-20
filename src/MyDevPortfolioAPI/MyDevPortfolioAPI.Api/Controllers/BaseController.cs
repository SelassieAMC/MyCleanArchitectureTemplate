using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Mvc;
using MyDevPortfolioAPI.Api.Common;

namespace MyDevPortfolioAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : Controller
    {
        protected new IActionResult Ok()
        {
            return base.Ok(Envelope.Ok());
        }

        protected IActionResult Ok<T>(T result)
        {
            return base.Ok(Envelope.Ok(result));
        }

        protected IActionResult Error(string errorMessage)
        {
            return BadRequest(Envelope.Error(errorMessage));
        }

        protected IActionResult FromResult(Result result)
        {
            return result.IsSuccess ? Ok() : Error(result.Error);
        }
    }
}