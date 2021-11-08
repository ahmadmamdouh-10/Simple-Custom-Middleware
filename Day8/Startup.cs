using Day8.Extensions;
using Day8.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day8
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CheckUserAuthentication>();

        }
        public void Configure(IApplicationBuilder app)
        {


            app.UseDeveloperExceptionPage();
            app.UseRouting();

            app.UseCheckUserAuthentication();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Authentication\n");
            //    await next();
            //    await context.Response.WriteAsync("Authentication 2\n");
            //});


            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("End Of Request \n");
            //});


            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Authorization\n");
            //    await next();
            //    await context.Response.WriteAsync("Authorization 2\n");
            //});





            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
