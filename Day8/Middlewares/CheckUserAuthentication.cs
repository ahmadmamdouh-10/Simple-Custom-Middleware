using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day8.Middlewares
{
    public class CheckUserAuthentication
        : IMiddleware
    {
        List<Employee> EmpList
           = new List<Employee>()
           {
                new Employee{ID=1, Name="Ahmed" , Password= "123456"},
                new Employee{ID=2, Name="Moataz", Password= "123456"}
           };

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Employee SelectedEmp =
                EmpList.FirstOrDefault(i => i.Name == context.Request.Headers["name"] &&
                i.Password == context.Request.Headers["password"]);

            if (SelectedEmp != null)
                await next(context);
            else if (context.Request.Headers["Token"] == "ASDASDASD3432464534423FDSFDSAASD5")
                await next(context);
            else
                await context.Response.WriteAsync("Sorry, You are not  Authenticated");
        }
    }
}
