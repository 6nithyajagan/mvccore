//using Book;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        CreateHostBuilder(args).Build().Run();
//    }

//    public static IHostBuilder CreateHostBuilder(string[] args) =>
//        Host.CreateDefaultBuilder(args)
//            .ConfigureLogging(logging =>
//            {
//                logging.ClearProviders(); // Clear existing providers
//                logging.AddConsole(); // Add console logger to capture stdout
//            })
//            .ConfigureWebHostDefaults(webBuilder =>
//            {
//                webBuilder.UseStartup<Startup>();
//            });
//}

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book
{
    public class Program
    {
        //        public static void Main(string[] args)
        //        {
        //            CreateHostBuilder(args).Build().Run();
        //        }

        //        public static IHostBuilder CreateHostBuilder(string[] args) =>
        //      Host.CreateDefaultBuilder(args)
        //          .ConfigureLogging(logging =>
        //          {
        //              logging.ClearProviders();
        //              logging.AddConsole();
        //          })
        //          .ConfigureWebHostDefaults(webBuilder =>
        //          {
        //              webBuilder.UseStartup<Startup>();
        //          });

        public static void Main(string[] args)
{
    CreateHostBuilder(args).Build().Run();
}

public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });
    }
}
