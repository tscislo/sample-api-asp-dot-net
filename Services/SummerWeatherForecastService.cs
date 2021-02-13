using System;
using System.Collections.Generic;
using SampleWebAPI.Model;

namespace SampleWebAPI.Services
{
    public class SummerWeatherForecastService : IWeatherForecastService
    {
        public List<WeatherForecast> Get() => new List<WeatherForecast>
        {
            new()
            {
                City = "Kielce",
                Date = DateTime.Now,
                Summary = "Zimno",
                TemperatureC = 23,
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
    }
}