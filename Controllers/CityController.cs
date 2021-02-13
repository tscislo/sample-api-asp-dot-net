using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.Model;

namespace SampleWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CityController
    {
        [HttpPost("{city}")]
        public City Post(City cityBody, string city)
        {
            return cityBody;
        }
    }
}