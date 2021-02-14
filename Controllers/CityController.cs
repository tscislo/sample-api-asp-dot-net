using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.Model;

namespace SampleWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CityController : ControllerBase
    {
        [HttpPost("{city}")]
        public IActionResult Post(City cityBody, string city)
        {
            return Ok(cityBody);
        }
    }
}