using Microsoft.AspNetCore.Mvc;

namespace TestingEF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            return "kk";
        }
    }
}
