using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Test.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        private ISender _madiator;
        
        public ISender Mediator => _madiator ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
