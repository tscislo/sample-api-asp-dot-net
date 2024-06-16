using Microsoft.AspNetCore.Builder;

namespace SampleWebAPI.Middlewares
{
    public static class FirstMiddlewareExtensions
    {
        public static IApplicationBuilder UseSampleMiddleware(this IApplicationBuilder builder)
        {
            return builder
                .UseMiddleware<FirstMiddleware>()
                .UseMiddleware<SecondMiddleware>();
        }
    }
}