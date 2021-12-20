using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using LBTDTools;
using LBTDTools.ServerApp.Config.Objects.System;

namespace LBTDTools
{
    public class Program
    {
        public static Server Server = new Server();
        
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}