using System;
using System.Collections.Generic;

namespace SampleWebAPI.Services
{
    public class WinterWeatherForecastService : IWeatherForecastService
    {
        public List<WeatherForecast> Get() => new List<WeatherForecast>
        {
            new()
            {
                City = "Kielce",
                Date = DateTime.Now,
                Summary = "Zimno",
                TemperatureC = -15,
            },
            new WeatherForecast
            {
                City = "Warsaw",
                Date = DateTime.Now,
                Summary = "Ciepło",
                TemperatureC = -5,
            },
            new WeatherForecast
            {
                City = "Legionowo",
                Date = DateTime.Now,
                Summary = "Ciepło",
                TemperatureC = -10,
            }
        };
    }
}