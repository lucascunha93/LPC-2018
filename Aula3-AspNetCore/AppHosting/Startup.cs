using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace AppHosting
{
    public  class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Use(async (context, next) => {
                context.Response.Headers.Add("Test-middleware","teste middleare hearders");
                await next.Invoke();
            });

            app.Run(async context =>
                await context.Response.WriteAsync("Ola Mundo")
            );
        }
    }
}