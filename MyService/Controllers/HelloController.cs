using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace MyService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly IStringLocalizer<HelloController> local;

        public HelloController(IStringLocalizer<HelloController> localizer)
        {
            local = localizer;
        }

        [HttpGet]
        public string Get()
        {
            return local["standardGreeting"];
        }
    }
}
