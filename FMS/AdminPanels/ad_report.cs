using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aviate.Utils;
using Aviate.DBContext;
using Microsoft.EntityFrameworkCore;
namespace FMS.AdminPanels
{
     public partial class ad_report : Form
     {
          public ad_report()
          {
               InitializeComponent();
          }

          private async void generateReport()
          {
               // generating an excel file for revenue report
               // contains each flight revenue

               ExcelWrite excelWrite = new ExcelWrite();

               TestModelList tmList = new TestModelList();

               tmList.testData = new List<TestModel>();

               TestModel testModel = new TestModel();

               // getting all the flights
               AviateContext aviateContext = new AviateContext();

               var flights = aviateContext.Flights.ToList();

               foreach (var flight in flights) { 
                    

                    testModel.FlightId = Convert.ToString(flight.FlightID);
                    testModel.departureLocation = flight.DepartureLocation;
                    testModel.destination = flight.Destination;
                    testModel.departureTime = Convert.ToString(flight.FlightID);
                    testModel.arrivalTime = Convert.ToString(flight.FlightID);
                    testModel.status = flight.Status;
                    testModel.aircraftID = Convert.ToString(flight.AircraftID);

                    // calculating the revenue
                    // by adding all the booking with flightId
                    int revenue = 0;
                    var bookings = await aviateContext.Bookings.Where(b => b.FlightID == flight.FlightID).ToListAsync();

                    foreach (var booking in bookings)
                    {
                         revenue += (int)booking.Price;
                    }

                    testModel.revenue = revenue.ToString();

                    tmList.testData.Add(testModel);
               
               }
               try
               {

               excelWrite.CreateExcelFile(tmList, @"C:\Users\c2tlhah\Desktop\repos - V2\repos - Copy\FMS", "RevenueReport.xlsx", "Revenue");
               } catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }

          }

          private void button2_Click(object sender, EventArgs e)
          {
               adminPanel adminPanel = new adminPanel();
               adminPanel.Show();
               this.Hide();
          }

          private async void revenueButton_Click(object sender, EventArgs e)
          {
               await Task.Run(() => generateReport());
          }
     }
}
