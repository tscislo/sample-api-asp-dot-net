using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleWebAPI.Services;

namespace SampleWebAPI.Middlewares
{
    public class FirstMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<FirstMiddleware> _logger;

        public FirstMiddleware(RequestDelegate next,
            ILogger<FirstMiddleware> logger
        )
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context,
            [FromServices] IWeatherForecastService weatherForecastService)
        {
            _logger.LogInformation("request first middleware");
            // context.Response.StatusCode = 201;
            await _next(context);
        }
    }
}