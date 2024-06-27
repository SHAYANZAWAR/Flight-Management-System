using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aviate.Models;
using Aviate.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using Aviate.Utils;

namespace Aviate.CRUD
{

     public class UserCRUD
     {
          public int assignID()
          {
               using AviateContext userCRUDContext = new();
               int id = userCRUDContext.Users.Count();
               return id;
          }
          async public Task<bool> AddUser(User user)
          {

               using AviateContext UserCRUDContext = new();
               await UserCRUDContext.Users.AddAsync(user);
               int res = await UserCRUDContext.SaveChangesAsync();
               return res != 0;
          }

          async public Task<bool> AddUserAuthCredential(UserAuthCredential userAuthCredential)
          {
               using AviateContext UserCRUDContext = new();
               await UserCRUDContext.UserAuthCredentials.AddAsync(userAuthCredential);
               int res = await UserCRUDContext.SaveChangesAsync();
               return res != 0;
          }

          async public Task<User?> GetUser(string cnic)
          {
               using AviateContext userCRUDContext = new();
               // finding the user with the given cnic using LINQ
               User? user = (await (from u in userCRUDContext.Users where u.Cnic == cnic select u).ToListAsync()).FirstOrDefault();

               if (user == null)
               {

                    return null;
               }
               return user;
          }


          async public Task<User?> GetUserGeneral(string searchBase, string searchValue)
          {
               // searchBase can be either "cnic" or "Name" or UserType
               using AviateContext userCRUDContext = new();
               User? user = null;
               switch (searchBase)
               {
                    case "cnic":
                         user = await (from u in userCRUDContext.Users where u.Cnic == searchValue select u).FirstOrDefaultAsync();
                         break;
                    case "Name":
                         user = await (from u in userCRUDContext.Users where u.Name == searchValue select u).FirstOrDefaultAsync();
                         break;
                    case "UserType":
                         user = await (from u in userCRUDContext.Users where u.UserType == searchValue select u).FirstOrDefaultAsync();
                         break;
                    default:
                         break;
               }

               return user;

          }

          async public Task<UserAuthCredential?> GetUserAuthCredential(string username)
          {
               using AviateContext userCRUDContext = new();
               UserAuthCredential? usercred = await (from u in userCRUDContext.UserAuthCredentials where u.Username == username select u).FirstOrDefaultAsync();
               if (usercred == null)
               {
                    return null;
               }
               return usercred;
          }

          async public Task<bool> storeImage(int? ID, byte[] image)
          {
               using AviateContext userCRUDContext = new();


               // storing image into UserImage table
               UserImage userImage = new()
               {
                    UserId = ID,
                    Image = image
               };

               await userCRUDContext.UserImages.AddAsync(userImage);

               await userCRUDContext.SaveChangesAsync();
               return true;
          }

          async public Task<Image?> getImage(int? userId)
          {
               using AviateContext userCRUDContext = new();

               UserImage? userImage = (await (from u in userCRUDContext.UserImages where u.UserId == userId select u).ToListAsync()).FirstOrDefault();

               if (userImage == null)
               {
                    return null;
               }

               // converting byte array to image
               Imaging imaging = new();

               Image image = imaging.ByteArrayToImage(userImage.Image);

               return image;
          }

          async public Task<bool> UpdateUser(User? user, string? name, string? phone)
          {
               using AviateContext userCRUDContext = new();

               if (user == null)
               {
                    return false;
               }

               user.Name = name;
               user.PhoneNumber = phone;

               userCRUDContext.Users.Update(user);
               await userCRUDContext.SaveChangesAsync();
               return true;
          }

          async public Task<bool> UpdateUserAuthCredential(UserAuthCredential userAuthCredential, string? username)
          {
               using AviateContext userCRUDContext = new();
               userAuthCredential.Username = username;
               userCRUDContext.UserAuthCredentials.Update(userAuthCredential);
               await userCRUDContext.SaveChangesAsync();
               return true;
          }

          async public Task<bool> markInactive(string cnic)
          {

               using AviateContext userCRUDContext = new();

               User? user = (await (from u in userCRUDContext.Users where u.Cnic == cnic select u).ToListAsync())?[0];
               if (user == null)
               {
                    return false;
               }

               user.isActive = false;

               userCRUDContext.Users.Update(user);
               await userCRUDContext.SaveChangesAsync();

               return true;
          }

          async public Task<bool> DeleteUserAuthCredential(int userId)
          {
               using AviateContext userCRUDContext = new();
               userCRUDContext.UserAuthCredentials.Remove(await userCRUDContext.UserAuthCredentials.FindAsync(userId));
               await userCRUDContext.SaveChangesAsync();
               return true;
          }



     }



     public class FlightCRUD
     {
          public int assignID()
          {
               using AviateContext flightCRUDContext = new();
               int id = flightCRUDContext.Flights.Count();
               return id;
          }
          public async Task<bool> AddFlight(Flight flight)
          {
               using AviateContext flightCRUDContext = new();
               await flightCRUDContext.Flights.AddAsync(flight);
               int res = await flightCRUDContext.SaveChangesAsync();
               return res != 0;
          }

          public async Task<Flight?> GetFlight(int flightID)
          {
               using AviateContext flightCRUDContext = new();
               Flight? flight = await (from f in flightCRUDContext.Flights where f.FlightID == flightID select f).FirstOrDefaultAsync();
               if (flight == null)
               {
                    return null;
               }
               return flight;
          }


          public async Task<bool> UpdateFlight(int flightID, Flight editedFlight)
          {
               using AviateContext flightCRUDContext = new();
               Flight? flight = await (from f in flightCRUDContext.Flights where f.FlightID == flightID select f).FirstOrDefaultAsync();
               if (flight == null)
               {
                    return false;
               }

               flight.FlightID = editedFlight.FlightID;
               flight.DepartureLocation = editedFlight.DepartureLocation;
               flight.Destination = editedFlight.Destination;
               flight.DepartureTime = editedFlight.DepartureTime;
               flight.ArrivalTime = editedFlight.ArrivalTime;
               flight.AircraftID = editedFlight.AircraftID;
               flight.Status = editedFlight.Status;


               flightCRUDContext.Flights.Update(editedFlight);
               await flightCRUDContext.SaveChangesAsync();
               return true;
          }

          public async Task<bool> DeleteFlight(string flightID)
          {
               using AviateContext flightCRUDContext = new();
               flightCRUDContext.Flights.Remove(await flightCRUDContext.Flights.FindAsync(flightID));
               await flightCRUDContext.SaveChangesAsync();
               return true;
          }

     }


     public class BookingCRUD
     {

          public int assignID()
          {
               using AviateContext bookingCRUDContext = new();
               int id = bookingCRUDContext.Bookings.Count();
               return id;
          }
          public async Task<bool> AddBooking(Booking booking)
          {
               using AviateContext bookingCRUDContext = new();
               await bookingCRUDContext.Bookings.AddAsync(booking);
               int res = await bookingCRUDContext.SaveChangesAsync();
               return res != 0;
          }

          public async Task<Booking?> GetBooking(int bookingID)
          {
               using AviateContext bookingCRUDContext = new();
               Booking? booking = await bookingCRUDContext.Bookings.FindAsync(bookingID);
               if (booking == null)
               {
                    return null;
               }
               return booking;
          }

          public async Task<bool> UpdateBooking(int bookingID, Booking editedBooking)
          {
               using AviateContext bookingCRUDContext = new();
               Booking? booking = await bookingCRUDContext.Bookings.FindAsync(bookingID);
               if (booking == null)
               {
                    return false;
               }

               booking.BookingID = editedBooking.BookingID;
               booking.FlightID = editedBooking.FlightID;
               booking.UserID = editedBooking.UserID;
               booking.SeatNumber = editedBooking.SeatNumber;
               booking.BookingTime = editedBooking.BookingTime;
               booking.SeatType = editedBooking.SeatType;
               booking.Price = editedBooking.Price;

               bookingCRUDContext.Bookings.Update(editedBooking);
               await bookingCRUDContext.SaveChangesAsync();
               return true;
          }

          public async Task<bool> DeleteBooking(int bookingID)
          {
               using AviateContext bookingCRUDContext = new();
               bookingCRUDContext.Bookings.Remove(await bookingCRUDContext.Bookings.FindAsync(bookingID));
               await bookingCRUDContext.SaveChangesAsync();
               return true;
          }

     }


     public class AircraftCRUD
     {

          public int assignID()
          {
               using AviateContext aircraftCRUDContext = new();
               int id = aircraftCRUDContext.Aircrafts.Count();
               return id;
          }
          public async Task<bool> AddAircraft(Aircraft aircraft)
          {
               using AviateContext aircraftCRUDContext = new();
               await aircraftCRUDContext.Aircrafts.AddAsync(aircraft);
               int res = await aircraftCRUDContext.SaveChangesAsync();
               return res != 0;
          }

          public async Task<Aircraft?> GetAircraft(string aircraftID)
          {
               using AviateContext aircraftCRUDContext = new();
               Aircraft? aircraft = await aircraftCRUDContext.Aircrafts.FindAsync(aircraftID);
               if (aircraft == null)
               {
                    return null;
               }
               return aircraft;
          }

          public async Task<bool> UpdateAircraft(string aircraftID, Aircraft editedAircraft)
          {
               using AviateContext aircraftCRUDContext = new();
               Aircraft? aircraft = await aircraftCRUDContext.Aircrafts.FindAsync(aircraftID);
               if (aircraft == null)
               {
                    return false;
               }

               aircraft.AircraftID = editedAircraft.AircraftID;
               aircraft.AircraftType = editedAircraft.AircraftType;
               aircraft.AircraftName = editedAircraft.AircraftName;
               aircraft.TotalSeats = editedAircraft.TotalSeats;
               aircraft.BusinessSeats = editedAircraft.BusinessSeats;
               aircraft.EconomySeats = editedAircraft.EconomySeats;
               aircraft.BusinessPrice = editedAircraft.BusinessPrice;
               aircraft.EconomyPrice = editedAircraft.EconomyPrice;

               aircraftCRUDContext.Aircrafts.Update(editedAircraft);
               await aircraftCRUDContext.SaveChangesAsync();
               return true;
          }

          public async Task<bool> DeleteAircraft(string aircraftID)
          {
               using AviateContext aircraftCRUDContext = new();
               aircraftCRUDContext.Aircrafts.Remove(await aircraftCRUDContext.Aircrafts.FindAsync(aircraftID));
               await aircraftCRUDContext.SaveChangesAsync();
               return true;
          }

     }

     public class AnalyticsCRUD
     {

          public int assignID()
          {
               using AviateContext analyticsCRUDContext = new();
               int id = analyticsCRUDContext.AnalyticsRecords.Count();
               return id;
          }
          public async Task<bool> AddAnalytics(Analytics analytics)
          {
               using AviateContext analyticsCRUDContext = new();
               await analyticsCRUDContext.AnalyticsRecords.AddAsync(analytics);
               int res = await analyticsCRUDContext.SaveChangesAsync();
               return res != 0;
          }

          public async Task<Analytics?> GetAnalytics(int reportID)
          {
               using AviateContext analyticsCRUDContext = new();
               Analytics? analytics = await analyticsCRUDContext.AnalyticsRecords.FindAsync(reportID);
               if (analytics == null)
               {
                    return null;
               }
               return analytics;
          }

          public async Task<bool> UpdateAnalytics(int reportID, Analytics editedAnalytics)
          {
               using AviateContext analyticsCRUDContext = new();
               Analytics? analytics = await analyticsCRUDContext.AnalyticsRecords.FindAsync(reportID);
               if (analytics == null)
               {
                    return false;
               }

               analytics.ReportID = editedAnalytics.ReportID;
               analytics.ReportType = editedAnalytics.ReportType;
               analytics.GeneratedDate = editedAnalytics.GeneratedDate;
               analytics.Details = editedAnalytics.Details;
               analytics.Analysis = editedAnalytics.Analysis;

               analyticsCRUDContext.AnalyticsRecords.Update(editedAnalytics);
               await analyticsCRUDContext.SaveChangesAsync();
               return true;
          }

          public async Task<bool> DeleteAnalytics(int reportID)
          {
               using AviateContext analyticsCRUDContext = new();
               analyticsCRUDContext.AnalyticsRecords.Remove(await analyticsCRUDContext.AnalyticsRecords.FindAsync(reportID));
               await analyticsCRUDContext.SaveChangesAsync();
               return true;
          }

     }

     public class CrewCRUD
     {
          public int assignID()
          {
               using AviateContext crewCRUDContext = new();
               int id = crewCRUDContext.Crews.Count();
               return id;
          }
          public async Task<bool> AddCrew(Crew crew)
          {
               using AviateContext crewCRUDContext = new();
               await crewCRUDContext.Crews.AddAsync(crew);
               int res = await crewCRUDContext.SaveChangesAsync();
               return res != 0;
          }

          public async Task<Crew?> GetCrew(int crewID)
          {
               using AviateContext crewCRUDContext = new();
               Crew? crew = await crewCRUDContext.Crews.FindAsync(crewID);
               if (crew == null)
               {
                    return null;
               }
               return crew;
          }

          public async Task<bool> UpdateCrew(int crewID, Crew editedCrew)
          {
               using AviateContext crewCRUDContext = new();
               Crew? crew = await crewCRUDContext.Crews.FindAsync(crewID);
               if (crew == null)
               {
                    return false;
               }

               crew.CrewID = editedCrew.CrewID;
               crew.Name = editedCrew.Name;
               crew.Position = editedCrew.Position;
               crew.Qualifications = editedCrew.Qualifications;
               crew.ContactNumber = editedCrew.ContactNumber;


               crewCRUDContext.Crews.Update(editedCrew);
               await crewCRUDContext.SaveChangesAsync();
               return true;
          }

          public async Task<bool> DeleteCrew(int crewID)
          {
               using AviateContext crewCRUDContext = new();
               crewCRUDContext.Crews.Remove(await crewCRUDContext.Crews.FindAsync(crewID));
               await crewCRUDContext.SaveChangesAsync();
               return true;
          }

     }

     public class MaintenanceCRUD
     {
          public int assignID()
          {
               using AviateContext maintenanceCRUDContext = new();
               int id = maintenanceCRUDContext.MaintenanceRecords.Count();
               return id;
          }
          public async Task<bool> AddMaintenance(Maintenance maintenance)
          {
               using AviateContext maintenanceCRUDContext = new();
               await maintenanceCRUDContext.MaintenanceRecords.AddAsync(maintenance);
               int res = await maintenanceCRUDContext.SaveChangesAsync();
               return res != 0;
          }

          public async Task<Maintenance?> GetMaintenance(int maintenanceID)
          {
               using AviateContext maintenanceCRUDContext = new();
               Maintenance? maintenance = await maintenanceCRUDContext.MaintenanceRecords.FindAsync(maintenanceID);
               if (maintenance == null)
               {
                    return null;
               }
               return maintenance;
          }

          public async Task<bool> UpdateMaintenance(int maintenanceID, Maintenance editedMaintenance)
          {
               using AviateContext maintenanceCRUDContext = new();
               Maintenance? maintenance = await maintenanceCRUDContext.MaintenanceRecords.FindAsync(maintenanceID);
               if (maintenance == null)
               {
                    return false;
               }

               maintenance.MaintenanceID = editedMaintenance.MaintenanceID;
               maintenance.AircraftID = editedMaintenance.AircraftID;
               maintenance.TaskDescription = editedMaintenance.TaskDescription;
               maintenance.StartDate = editedMaintenance.StartDate;
               maintenance.EndDate = editedMaintenance.EndDate;
               maintenance.Status = editedMaintenance.Status;

               maintenanceCRUDContext.MaintenanceRecords.Update(editedMaintenance);
               await maintenanceCRUDContext.SaveChangesAsync();
               return true;
          }

          public async Task<bool> DeleteMaintenance(int maintenanceID)
          {
               using AviateContext maintenanceCRUDContext = new();
               maintenanceCRUDContext.MaintenanceRecords.Remove(await maintenanceCRUDContext.MaintenanceRecords.FindAsync(maintenanceID));
               await maintenanceCRUDContext.SaveChangesAsync();
               return true;
          }

     }

     public class PassengerServicesCRUD
     {

          public int assignID()
          {
               using AviateContext passengerServicesCRUDContext = new();
               int id = passengerServicesCRUDContext.PassengerServices.Count();
               return id;
          }
          public async Task<bool> AddPassengerServices(PassengerServices passengerServices)
          {
               using AviateContext passengerServicesCRUDContext = new();
               await passengerServicesCRUDContext.PassengerServices.AddAsync(passengerServices);
               int res = await passengerServicesCRUDContext.SaveChangesAsync();
               return res != 0;
          }

          public async Task<PassengerServices?> GetPassengerServices(int serviceID)
          {
               using AviateContext passengerServicesCRUDContext = new();
               PassengerServices? passengerServices = await passengerServicesCRUDContext.PassengerServices.FindAsync(serviceID);
               if (passengerServices == null)
               {
                    return null;
               }
               return passengerServices;
          }

          public async Task<bool> UpdatePassengerServices(int serviceID, PassengerServices editedPassengerServices)
          {
               using AviateContext passengerServicesCRUDContext = new();
               PassengerServices? passengerServices = await passengerServicesCRUDContext.PassengerServices.FindAsync(serviceID);
               if (passengerServices == null)
               {
                    return false;
               }

               passengerServices.ServiceID = editedPassengerServices.ServiceID;
               passengerServices.PassengerID = editedPassengerServices.PassengerID;
               passengerServices.ServiceType = editedPassengerServices.ServiceType;
               passengerServices.FlightID = editedPassengerServices.FlightID;
               passengerServices.ServiceDetails = editedPassengerServices.ServiceDetails;
               passengerServices.ServiceTime = editedPassengerServices.ServiceTime;


               passengerServicesCRUDContext.PassengerServices.Update(editedPassengerServices);
               await passengerServicesCRUDContext.SaveChangesAsync();
               return true;
          }

          public async Task<bool> DeletePassengerServices(int serviceID)
          {
               using AviateContext passengerServicesCRUDContext = new();
               passengerServicesCRUDContext.PassengerServices.Remove(await passengerServicesCRUDContext.PassengerServices.FindAsync(serviceID));
               await passengerServicesCRUDContext.SaveChangesAsync();
               return true;
          }

     }

     public class SecurityCRUD
     {
          public int assignID()
          {
               using AviateContext securityCRUDContext = new();
               int id = securityCRUDContext.Securities.Count();
               return id;
          }
          public async Task<bool> addSecurity(Security security)
          {
               using AviateContext securityCRUDContext = new();
               await securityCRUDContext.Securities.AddAsync(security);
               int res = await securityCRUDContext.SaveChangesAsync();
               return res != 0;
          }

          public async Task<Security?> getSecurity(int safetyID)
          {
               using AviateContext securityCRUDContext = new();
               Security? security = await securityCRUDContext.Securities.FindAsync(safetyID);
               if (security == null)
               {
                    return null;
               }
               return security;
          }

          public async Task<bool> updateSecurity(int safetyID, Security editedSecurity)
          {
               using AviateContext securityCRUDContext = new();
               Security? security = await securityCRUDContext.Securities.FindAsync(safetyID);
               if (security == null)
               {
                    return false;
               }

               security.SafetyID = editedSecurity.SafetyID;
               security.EventDate = editedSecurity.EventDate;
               security.Description = editedSecurity.Description;
               security.Severity = editedSecurity.Severity;
               security.Resolution = editedSecurity.Resolution;

               securityCRUDContext.Securities.Update(editedSecurity);
               await securityCRUDContext.SaveChangesAsync();
               return true;
          }
     }


     public class RevenueCRUD
     {

          public int assignID()
          {
               using AviateContext revenueCRUDContext = new();
               int id = revenueCRUDContext.Revenues.Count();
               return id;
          }
          public async Task<bool> addRevenue(Revenue revenue)
          {
               using AviateContext revenueCRUDContext = new();
               await revenueCRUDContext.Revenues.AddAsync(revenue);
               int res = await revenueCRUDContext.SaveChangesAsync();
               return res != 0;
          }

          public async Task<Revenue?> getRevenue(int revenueID)
          {
               using AviateContext revenueCRUDContext = new();
               Revenue? revenue = await revenueCRUDContext.Revenues.FindAsync(revenueID);
               if (revenue == null)
               {
                    return null;
               }
               return revenue;
          }

          public async Task<bool> updateRevenue(int revenueID, Revenue editedRevenue)
          {
               using AviateContext revenueCRUDContext = new();
               Revenue? revenue = await revenueCRUDContext.Revenues.FindAsync(revenueID);
               if (revenue == null)
               {
                    return false;
               }

               revenue.RevenueID = editedRevenue.RevenueID;
               revenue.TransactionDate = editedRevenue.TransactionDate;
               revenue.Amount = editedRevenue.Amount;
               revenue.Source = editedRevenue.Source;
               revenue.Description = editedRevenue.Description;

               revenueCRUDContext.Revenues.Update(editedRevenue);
               await revenueCRUDContext.SaveChangesAsync();
               return true;
          }

          public async Task<bool> deleteRevenue(int revenueID)
          {
               using AviateContext revenueCRUDContext = new();
               revenueCRUDContext.Revenues.Remove(await revenueCRUDContext.Revenues.FindAsync(revenueID));
               await revenueCRUDContext.SaveChangesAsync();
               return true;
          }
     }


     public class BaggageCRUD
     {

          public int assignID()
          {
               using AviateContext baggageCRUDContext = new();
               int id = baggageCRUDContext.Baggage.Count();
               return id;
          }
          public async Task<bool> addBaggage(Baggage baggage)
          {
               using AviateContext baggageCRUDContext = new();
               await baggageCRUDContext.Baggage.AddAsync(baggage);
               int res = await baggageCRUDContext.SaveChangesAsync();
               return res != 0;
          }

          public async Task<Baggage?> getBaggage(int baggageID)
          {
               using AviateContext baggageCRUDContext = new();
               Baggage? baggage = await baggageCRUDContext.Baggage.FindAsync(baggageID);
               if (baggage == null)
               {
                    return null;
               }
               return baggage;
          }

          public async Task<bool> updateBaggage(int baggageID, Baggage editedBaggage)
          {
               using AviateContext baggageCRUDContext = new();
               Baggage? baggage = await baggageCRUDContext.Baggage.FindAsync(baggageID);
               if (baggage == null)
               {
                    return false;
               }

               baggage.BaggageID = editedBaggage.BaggageID;
               baggage.PassengerID = editedBaggage.PassengerID;
               baggage.FlightID = editedBaggage.FlightID;
               baggage.Status = editedBaggage.Status;
               baggage.Location = editedBaggage.Location;

               baggageCRUDContext.Baggage.Update(editedBaggage);
               await baggageCRUDContext.SaveChangesAsync();
               return true;
          }
     }


     public class NotificationsCRUD()
     {
          public int assignID()
          {
               using NotificationContext notificationsCRUDContext = new();
               int id = notificationsCRUDContext.Notifications.Count();
               return id;
          }
     }

     public class FeedbackCRUD()
     {
          public int assignID()
          {
               using AviateContext feedbackCRUDContext = new();
               int id = feedbackCRUDContext.UserFeedbacks.Count();
               return id;
          }
     }
}
