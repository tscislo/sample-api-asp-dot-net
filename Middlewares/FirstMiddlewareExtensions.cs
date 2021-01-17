using Microsoft.AspNetCore.Builder;

namespace SampleWebAPI.Middlewares
{
    public static class FirstMiddlewareExtensions
    {
        public static IApplicationBuilder UseSampleMiddleware(this IApplicationBuilder builder)
        {
            return builder
                // .Map("/api/WeatherForecast/Kielce", applicationBuilder =>
                //     applicationBuilder.UseMiddleware<SecondMiddleware>())
                .UseMiddleware<FirstMiddleware>()
                .UseMiddleware<SecondMiddleware>();
        }
    }
}