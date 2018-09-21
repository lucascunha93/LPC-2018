using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace AppHosting
{
    class Program
    {
                static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run();


            /* implementação inicial do web hosting
             var host = new WebHostBuilder()
                .UseKestrel()
                .Configure(
                    app => {
                        app.Run(context =>
                         context.Response.WriteAsync("Hello world"));
                    }
                )
                .Build();
            host.Run();
             */
        }
    }
}
