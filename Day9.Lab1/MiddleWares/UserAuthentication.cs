using Day9.Lab1.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day9.Lab1.MiddleWares
{
    public class UserAuthentication
        : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var tokenManager = (ITokenManager)context.RequestServices.GetService(typeof(ITokenManager));
            var result = true;
            if (!context.Request.Headers.ContainsKey("Authorization"))
            {
                result = false;
                await context.Response.WriteAsync("Not Authenticated !!");
            }
            string token = string.Empty;
            if (result)
            {
                token = context.Request.Headers.First(i => i.Key == "Authorization").Value;
                if (!tokenManager.VerifyToken(token))
                    result = false;
            }
           
        }
    }
}
