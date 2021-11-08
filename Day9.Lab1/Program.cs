using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

using System;


namespace Day9.Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Application");
            CreateHostBuilder().Build().Run();
            Console.WriteLine("End of Application");
        }

        static IHostBuilder CreateHostBuilder() =>
                Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webHost =>
                {
                    webHost.UseStartup<Startup>();

                });
    }
}
