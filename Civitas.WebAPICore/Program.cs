using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Civitas.WebAPICore
{
    public class Program
    {
        //public static IConfigurationRoot Configuration { get; set; }

        public static void Main(string[] args)
        {
            System.Console.Out.WriteLine("Entering Main");

            
            ConfigurationBuilder confBuilder = new ConfigurationBuilder();
            
            confBuilder
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                //.AddJsonFile($"appsettings.{EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables()
                .AddCommandLine(args);

            

            System.Console.Out.WriteLine("Configuring and building host.");
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseConfiguration(confBuilder.Build())
                //.UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            System.Console.Out.WriteLine("Starting host");

            host.Run();
        }
    }
}
