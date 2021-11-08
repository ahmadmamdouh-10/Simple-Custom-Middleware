using Day8.Middlewares;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day8.Extensions
{
    public static class MiddlewareExtensions
    {
        public static void UseCheckUserAuthentication
            (this IApplicationBuilder app)
        {
            app.UseMiddleware<CheckUserAuthentication>();
        }
    }
}
