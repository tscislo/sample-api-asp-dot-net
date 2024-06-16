using System;
using System.Collections.Generic;
using SampleWebAPI.Model;

namespace SampleWebAPI.Services
{
    public class WinterWeatherForecastService : IWeatherForecastService
    {
        public List<WeatherForecast> Get() =>
        [
            new WeatherForecast
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
        ];
    }
}