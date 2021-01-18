using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleWebAPI.Services;

namespace SampleWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherForecastService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IWeatherForecastService weatherForecastService
        )
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> GetAll()
        {
            return _weatherForecastService.Get();
        }

        [HttpGet("{city}")]
        public WeatherForecast GetOne(string city)
        {
            var cieplo = _weatherForecastService.Get()
                .FirstOrDefault(forecast => forecast.City == city);
            return cieplo;
        }
        
    }
}