using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SampleWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var days = new List<WeatherForecast>
            {
                new WeatherForecast
                {
                    Date = DateTime.Now,
                    Summary = "Zimno",
                    TemperatureC = 1,
                },
                new WeatherForecast
                {
                    Date = DateTime.Now,
                    Summary = "Ciepło",
                    TemperatureC = 30,
                }
            };

            var cieplo = days
                .Where(forecast => forecast.Summary == "Ciepło");
                // .Select(forecast => new
                // {
                //     forecast.Date
                // }).ToList();
            return cieplo;

            // var rng = new Random();
            // return Enumerable.Range(1, 5)
            //     .Where(i => i > 4)
            //     .Select(index => new WeatherForecast
            //     {
            //         Date = DateTime.Now.AddDays(index),
            //         TemperatureC = rng.Next(-20, 55),
            //         Summary = Summaries[rng.Next(Summaries.Length)]
            //     })
            //     .ToArray();
        }
    }
}