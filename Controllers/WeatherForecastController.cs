using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleWebAPI.Model;
using SampleWebAPI.Services;

namespace SampleWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IWeatherForecastService weatherForecastService
    )
        : ControllerBase
    {
        [HttpGet]
        public IEnumerable<WeatherForecast> GetAll()
        {
            logger.LogInformation("GetAll");
            return weatherForecastService.Get();
        }

        [HttpGet("{city}")]
        public WeatherForecast GetOne(string city)
        {
            var cieplo = weatherForecastService.Get()
                .FirstOrDefault(forecast => forecast.City == city);
            logger.LogInformation("GetOne");
            return cieplo;
        }
    }
}