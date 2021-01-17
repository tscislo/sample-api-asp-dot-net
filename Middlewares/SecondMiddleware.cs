using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace SampleWebAPI.Middlewares
{
    public class SecondMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<SecondMiddleware> _logger;

        public SecondMiddleware(RequestDelegate next,
            ILogger<SecondMiddleware> logger
            )
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation("request second middleware");
            await _next(context);
        }
    }
}