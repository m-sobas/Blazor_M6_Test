using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using Test.Shared.Queries;

namespace Test.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAllPersons()
        {
            return Ok(await Mediator.Send(new GetPersonsQuery()));
        }
    }
}
