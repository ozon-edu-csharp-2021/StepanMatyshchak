using System;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace OzonEdu.MerchandiseService.Api.Infrastructure.Middlewares
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            LogRequest(context);
            await _next(context);
        }

        private void LogRequest(HttpContext context)
        {
            try
            {
                if (context.Request.ContentType == "application/grpc")
                    return;
                
                var route = context.Request.Path.Value;
                var headers = JsonSerializer.Serialize(context.Request.Headers);
                _logger.LogInformation(
                    $"\nLogging http request from middleware.\nRequest route: {route}\nRequest headers: {headers}");
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Could not log request");
            }
        }
    }
}