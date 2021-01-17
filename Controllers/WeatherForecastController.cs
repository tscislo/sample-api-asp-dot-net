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
        private static List<WeatherForecast> days = new List<WeatherForecast>
        {
            new WeatherForecast
            {
                City = "Kielce",
                Date = DateTime.Now,
                Summary = "Zimno",
                TemperatureC = 1,
            },
            new WeatherForecast
            {
                City = "Warsaw",
                Date = DateTime.Now,
                Summary = "Ciepło",
                TemperatureC = 30,
            },
            new WeatherForecast
            {
                City = "Legionowo",
                Date = DateTime.Now,
                Summary = "Ciepło",
                TemperatureC = 30,
            }
        };

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
        public IEnumerable<WeatherForecast> GetAll()
        {
            return days;
        }

        [HttpGet("{city}")]
        public WeatherForecast GetOne(string city)
        {
            var cieplo = days
                .FirstOrDefault(forecast => forecast.City == city);
            return cieplo;
        }
        
    }
}