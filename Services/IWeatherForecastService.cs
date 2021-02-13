using System.Collections.Generic;
using SampleWebAPI.Model;

namespace SampleWebAPI.Services
{
    public interface IWeatherForecastService
    {
        public List<WeatherForecast> Get();
    }
}