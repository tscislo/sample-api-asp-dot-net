using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleWebAPI.Services;

namespace SampleWebAPI.Middlewares
{
    public class FirstMiddleware(
        RequestDelegate next,
        ILogger<FirstMiddleware> logger)
    {
        public async Task InvokeAsync(HttpContext context,
            [FromServices] IWeatherForecastService weatherForecastService)
        {
            logger.LogInformation("request first middleware");
            await next(context);
        }
    }
}