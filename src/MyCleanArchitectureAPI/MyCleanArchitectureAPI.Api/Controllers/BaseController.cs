using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Mvc;
using MyDevPortfolioAPI.Api.Common;
using Newtonsoft.Json;
using Serilog;

namespace MyDevPortfolioAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : Controller
    {
        protected new IActionResult Ok()
        {
            Log.Information($"Success Operation");
            return base.Ok(Envelope.Ok());
        }

        protected IActionResult Ok<T>(T result)
        {
            Log.Information($"Success Operation {JsonConvert.SerializeObject(result)}");
            return base.Ok(Envelope.Ok(result));
        }

        protected IActionResult Error(string errorMessage)
        {
            Log.Error($"Error {errorMessage}");
            return BadRequest(Envelope.Error(errorMessage));
        }

        protected IActionResult FromResult(Result result)
        {
            return result.IsSuccess ? Ok() : Error(result.Error);
        }
    }
}