using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Aviate.Models; // Path ../Models
using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using Aviate.CRUD;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Design;
using DocumentFormat.OpenXml.Spreadsheet;



namespace Aviate.DBContext
{
     public class NotificationContext : DbContext
     {
          
          public DbSet<DatabaseNotifications> Notifications { get; set; }

          string userID;
          string password;
          string hostName;

          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {

               // set them according to your database
               userID = "AVIATION";
               password = "aviationoracle";
               hostName = "localhost";
               optionsBuilder.UseOracle($"User id={userID}; password={password}; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST = {hostName})(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE))); Pooling=False",
                                                                                                                                   b => b.UseOracleSQLCompatibility(OracleSQLCompatibility.DatabaseVersion19));
          }
     }

     public class AviateContext : DbContext
     {
          public DbSet<Feedback> UserFeedbacks { get; set; }
          public DbSet<User> Users { get; set; }
          public DbSet<UserAuthCredential> UserAuthCredentials { get; set; }
          public DbSet<UserImage> UserImages { get; set; }
          public DbSet<Flight> Flights { get; set; }
          public DbSet<Aircraft> Aircrafts { get; set; }
          public DbSet<Baggage> Baggage { get; set; }
          public DbSet<Security> Securities { get; set; }
          public DbSet<Revenue> Revenues { get; set; }
          public DbSet<PassengerServices> PassengerServices { get; set; }
          public DbSet<Booking> Bookings { get; set; }
          public DbSet<Crew> Crews { get; set; }
          public DbSet<Maintenance> MaintenanceRecords { get; set; }
          public DbSet<Analytics> AnalyticsRecords { get; set; }


          string userID;
          string password;
          string hostName;

          

          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
               // set them according to your database
               userID = "AVIATION";
               password = "aviationoracle";
               hostName = "DESKTOP-NDDFH30";
               optionsBuilder.UseOracle($"User id={userID}; password={password}; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST = {hostName})(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE))); Pooling=False",
                                                                                                                                   b => b.UseOracleSQLCompatibility(OracleSQLCompatibility.DatabaseVersion19));
          }

          public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
          {
               var entries = ChangeTracker.Entries()
                   .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified || e.State == EntityState.Deleted);

               NotificationsCRUD notificationsCRUD = new NotificationsCRUD();

               using (var notificationDbContext = new NotificationContext())
               {
                    foreach (var entry in entries)
                    {
                         var tableName = entry.Metadata.GetTableName();
                         var action = entry.State.ToString();

                         // only keeping track of changes in Flight_Table to show
                         // the notification to the Users (can be changed to accomodate other features)
                         if (tableName?.ToLower() != "flight_table" && action.ToLower() != "modified")
                         {
                              return await base.SaveChangesAsync(); // Save changes in the main DbContext
                         }

                         var primaryKey = entry.Metadata.FindPrimaryKey();
                         var keyValue = entry.Property(primaryKey.Properties.Single().Name).CurrentValue;

                         int id = notificationsCRUD.assignID() + 1;
                         List<string>? changingColumnNames = null;

                         if (entry.State == EntityState.Modified)
                         {
                              changingColumnNames = entry.Properties
                                  .Where(p => p.IsModified)
                                  .Select(p => p.Metadata.Name).ToList();

                         }

                         notificationDbContext.Notifications.Add(new DatabaseNotifications
                         {
                              Id = id,
                              TableName = tableName,
                              Action = action,
                              Timestamp = DateTime.Now,
                              rowId = Convert.ToInt16(keyValue),
                              alteringRows = changingColumnNames
                         });
                    }

                    await notificationDbContext.SaveChangesAsync(); // Save notifications
               }

               return await base.SaveChangesAsync(); // Save changes in the main DbContext
          }
     }


     public class AuthContext : DbContext
     {

          string userID;
          string password;
          string hostName;


          public DbSet<User> Users { get; set; }
          public DbSet<UserAuthCredential> UserAuthCredentials { get; set; }


         
          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
               // set them according to your database
               userID = "AVIATION";
               password = "aviationoracle";
               hostName = "DESKTOP-NDDFH30";
               optionsBuilder.UseOracle($"User id={userID}; password={password}; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={hostName})(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE))); Pooling=False",
                                                                                                                                b => b.UseOracleSQLCompatibility(OracleSQLCompatibility.DatabaseVersion19));
          }

          public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
          {
               var entries = ChangeTracker.Entries()
                   .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified || e.State == EntityState.Deleted);

               NotificationsCRUD notificationsCRUD = new NotificationsCRUD();

               using (var notificationDbContext = new NotificationContext())
               {
                    foreach (var entry in entries)
                    {
                         var tableName = entry.Metadata.GetTableName();
                         var action = entry.State.ToString();
                         var primaryKey = entry.Metadata.FindPrimaryKey();
                         var keyValue = entry.Property(primaryKey.Properties.Single().Name).CurrentValue;

                         int id = notificationsCRUD.assignID() + 1;
                         List<string>? changingColumnNames = null;

                         if (entry.State == EntityState.Modified)
                         {
                              changingColumnNames = entry.Properties
                                  .Where(p => p.IsModified)
                                  .Select(p => p.Metadata.Name).ToList();


                         }

                         notificationDbContext.Notifications.Add(new DatabaseNotifications
                         {
                              Id = id,
                              TableName = tableName,
                              Action = action,
                              Timestamp = DateTime.UtcNow,
                              rowId = Convert.ToInt16(keyValue),
                              alteringRows = changingColumnNames
                         });
                    }

                    await notificationDbContext.SaveChangesAsync(); // Save notifications
               }

               return await base.SaveChangesAsync(); // Save changes in the main DbContext
          }

     }

}