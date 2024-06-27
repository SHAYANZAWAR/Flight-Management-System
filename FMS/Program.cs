using Microsoft.Extensions.Hosting;
using Aviate.DBContext;
using Aviate.Models;
using Aviate.Utils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Text;
using System.Net.NetworkInformation;
namespace FMS
{
     internal static class Program
     {

          private static Thread _HostThread;

          /// <summary>
          ///  The main entry point for the application.
          /// </summary>
          [STAThread]
          static async Task Main()
          {


               // To customize application configuration such as set high DPI settings or default font,
               // see https://aka.ms/applicationconfiguration.
               ApplicationConfiguration.Initialize();

               var host = CreateHostBuilder().Build();

               var services = host.Services;

               _HostThread = new Thread(async () =>
               {
                    await host.StartAsync();
                    
               });
               _HostThread.SetApartmentState(ApartmentState.STA); // Ensure STA mode
               _HostThread.Start();

               // Configure and run the WinForms application
               Application.SetHighDpiMode(HighDpiMode.SystemAware);
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);

               //await host.StartAsync();
               //var SplashScreen = services.GetRequiredService<splashScreen>();

               Application.Run(new splashScreen());


               _HostThread.Join();
               
               // Stop the host when the application exits
               await host.StopAsync();


          }



          static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureLogging(logging =>
                {
                     logging.ClearProviders();
                     logging.AddConsole();
                     logging.SetMinimumLevel(LogLevel.Information); // Adjust the logging level as needed
                })
                .ConfigureServices((context, services) =>
                {
                     // Register the DbContext and other services
                     services.AddDbContext<NotificationContext>();
                     services.AddHostedService<NotificationPollingService>();

                     // Register WinForms dependencies
                     //services.AddSingleton<splashScreen>();
                });
     }
}