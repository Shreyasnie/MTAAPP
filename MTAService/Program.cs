using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MTA.BusinessLayer;
using MTA.DataAccessLayer.UnitOfWork;
using System;
using System.IO;

namespace MTAService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var host = new HostBuilder()
             .ConfigureServices((hostContext, services) =>
             {

                 //services.AddLogging(configure => configure.AddConsole());
                 //services.AddTransient<MyApplication>();
                 //services.AddScoped<IBusinessLayer, BusinessLayer>();
                 services.AddSingleton<IAPIService, APIService>();
                 services.AddSingleton<IAreaService, AreaService>();
                 services.AddSingleton<IUnitofwork, UnitofWork>();
                 services.AddSingleton<DbContext>();
                 services.AddSingleton<IAreaBL, AreaBL>();
             }).Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                try
                {
                    var areaService = services.GetService<IAreaService>();
                    //var buildingService = services.GetService<IBuildingService>();
                    var areaDetails = areaService.GetAreaDetails();
                    
                    Console.WriteLine("Success");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Occured");
                }
            }
        }

        static void BuilConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsetting.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"} .json");
        }
    }
}
