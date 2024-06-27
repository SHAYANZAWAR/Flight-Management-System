using System;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using System.Threading.Tasks;
using Aviate.DBContext;
using Aviate.Models;
using Aviate.Utils;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
public class NotificationPollingService : BackgroundService
{
     private readonly IServiceProvider _serviceProvider;
     private readonly ILogger<NotificationPollingService> _logger;

     public NotificationPollingService(IServiceProvider serviceProvider, ILogger<NotificationPollingService> logger)
     {
          _serviceProvider = serviceProvider;
          _logger = logger;
     }

     protected override async Task ExecuteAsync(CancellationToken stoppingToken)
     {
          _logger.LogInformation("Notification Polling Service is starting.");

          while (!stoppingToken.IsCancellationRequested)
          {
               _logger.LogInformation("Checking for database changes...");

               using (var scope = _serviceProvider.CreateScope())
               {
                    var notificationDbContext = scope.ServiceProvider.GetRequiredService<NotificationContext>();

                    var notifications = await notificationDbContext.Notifications
                        .Where(n => !n.Processed)
                        .OrderByDescending(n => n.Timestamp)
                        .ToListAsync(stoppingToken);

                    foreach (var notification in notifications)
                    {
                         await ProcessNotification(notification);
                    }

                    await notificationDbContext.SaveChangesAsync(stoppingToken);
               }


               // Adjust the interval as needed
               // Service at each interval, periodically requests the database 
               // to track the changes
               await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken); 
          }

          _logger.LogInformation("Notification Polling Service is stopping.");
     }

     // Notifications table in the database would contain all the changes record but
     // I'm only processing the records related to the change in the Flight_Table only
     // you can change the code to process any type of record you want
     private async Task ProcessNotification(DatabaseNotifications notification)
     {
          _logger.LogInformation($"Notification: {notification.TableName} - {notification.Action} added at {notification.Timestamp}");

          // wait till the userID is not null (ie the user got logged in)

          int? userID = null;
          while (userID == null)
          {
               _logger.LogInformation($"Waiting for user {userID} to log in...");
               userID = GlobalContext.getGlobalUser()?.Id;
               await Task.Delay(1000); // Wait for 1 second before checking again
          }



          // all the processing should be done by users/employees

          // only Users UI should react to the change (ie. Show Notification or do something else)
          // hence setting Processed to False so that user can process it
          if (GlobalContext.getGlobalUser()?.UserType?.ToLower() == "admin")
          {
               // if the current user is admin then don't process the notification
               notification.Processed = false;
               return;
          }
          
          if (notification.TableName == "Flight_Table" && notification.Action == "Modified" &&
               (notification.alteringRows.Contains("ArrivalTime")
               || notification.alteringRows.Contains("DepartureTime")))
          {
               // if the flight table is changed and the changing columns are
               // departureTime or arrivalTime then send notification to the current 
               // logged-in user if the row affected is his record
               AviateContext aviateContext = new AviateContext();


               // if the user made the booking in the flight which is changed
               Booking? booking = (await (from b in aviateContext.Bookings where b.FlightID == notification.rowId select b).ToListAsync()).FirstOrDefault();

               if (booking == null || booking.UserID != GlobalContext.getGlobalUser()?.Id.ToString())
               {
                    notification.Processed = false;
                    return;
               }

               // setting the needNotification in global Context to true
               GlobalContext.doesNeedNotification("info", "Flight possibly rescheduled!");

               notification.Processed = true;


          }
     }
}
