using Microsoft.AspNetCore.Builder;

public static class AppBuilderExtensions
{
    public static IApplicationBuilder UseConsoleMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ConsoleMiddleware>();
    }
}