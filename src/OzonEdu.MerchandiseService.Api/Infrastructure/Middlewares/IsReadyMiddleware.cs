using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OzonEdu.MerchandiseService.Api.Infrastructure.Middlewares
{
    public class IsReadyMiddleware
    {
        public IsReadyMiddleware(RequestDelegate next)
        {
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.StatusCode = StatusCodes.Status200OK;
            await context.Response.WriteAsync("We are ready");
        }
    }
}