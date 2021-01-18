using System.Collections.Generic;

namespace SampleWebAPI.Services
{
    public interface IWeatherForecastService
    {
        public List<WeatherForecast> Get();
    }
}