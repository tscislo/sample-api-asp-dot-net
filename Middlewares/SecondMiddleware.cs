using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace SampleWebAPI.Middlewares
{
    public class SecondMiddleware(
        RequestDelegate next,
        ILogger<SecondMiddleware> logger)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            logger.LogInformation("request second middleware");
            await next(context);
        }
    }
}