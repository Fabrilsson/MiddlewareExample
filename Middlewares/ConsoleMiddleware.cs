using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

public class ConsoleMiddleware
{
    private readonly RequestDelegate _next;

    public ConsoleMiddleware(RequestDelegate next) =>
        _next = next;

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine("\n\r Before next middleware call \n\r");

        await _next(context);

        Console.WriteLine("\n\r After next middleware call \n\r");
    }
}