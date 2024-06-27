using Aviate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aviate.DBContext;
using Aviate.CRUD;
using Microsoft.EntityFrameworkCore;
using System.CodeDom;
using FMS.SubUtills;
using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FMS.AdminPanels
{
     public partial class ad_fm : Form
     {

          private string? departureAr;
          private string? arrivalAr;
          private string? departureTime;
          private string? arrivalTime;
          private string? Status;
          private string? aircraftModel;
          private int? flightId;
          public ad_fm()
          {
               InitializeComponent();
          }

          private async Task retrieveAircrafts()
          {
               // finding the aircraft that have usable value as false
               AviateContext aviateContext = new AviateContext();
               List<Aircraft>? aircraft = await (from f in aviateContext.Aircrafts select f).ToListAsync();
               if (aircraft == null)
               {
                    return;
               }

               // setting the listbox items to all aircrafts model

               Aircrafts.Items.Clear();

               foreach (Aircraft item in aircraft)
               {
                    Aircrafts.Items.Add(item.AircraftName);
               }
          }

          private async Task retrieveFlights()
          {
               AviateContext aviateContext = new AviateContext();
               var flights = await (from flight in aviateContext.Flights select flight).ToListAsync();
               FlightsDataGrid.DataSource = flights;
          }
          private void validateDateTime(DateTime departureDateTime, DateTime arrivalDateTime)
          {
               // checking if the date provided has already passed or not
               int comparisonResult = DateTime.Compare(departureDateTime, DateTime.Now);

               if (comparisonResult < 0)
               {
                    throw new Exception("Given departure date has already passed");
               }

               comparisonResult = DateTime.Compare(arrivalDateTime, DateTime.Now);

               if (comparisonResult < 0)
               {
                    throw new Exception("Given arrival date has already passed");
               }


               comparisonResult = DateTime.Compare(departureDateTime, arrivalDateTime);

               if (comparisonResult == 0)
               {
                    throw new Exception("Departure and arrival time can't be same!");
               }
               else if (comparisonResult > 0)
               {
                    throw new Exception("Departure time can't be before arrival time");

               }

          }

          private void button2_Click(object sender, EventArgs e)
          {
               adminPanel adminPanel = new adminPanel();
               adminPanel.Show();
               this.Hide();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private async void create_fm_button_Click(object sender, EventArgs e)
          {
               // verifying all the values are not null
               if (departureAr == "" || arrivalAr == "" || arrivalTime == "" || departureTime == "" || Status == "" || f_dept_time.Text == "" || f_arrival_time.Text == "")
               {
                    MessageBox.Show("Please fill in all the fields");
                    return;
               }

               create_fm_button.Enabled = false;

               string flightDeptTime = f_dept_time.Text;
               string flightArrivalTime = f_arrival_time.Text;

               // 


               string departure_Time = $"{departureTime} {flightDeptTime}";
               string arrival_Time = $"{arrivalTime} {flightArrivalTime}";




               // validating the date and time
               try
               {

                    validateDateTime(Convert.ToDateTime(departure_Time), Convert.ToDateTime(arrival_Time));


               }
               catch (Exception exc)
               {
                    MessageBox.Show(exc.Message);
                    create_fm_button.Enabled = true;
                    return;
               }



               // verifying that the aricraft exists

               AviateContext aircraftContext = new AviateContext();


               Aircraft? aircraft = (await (from a in aircraftContext.Aircrafts where a.AircraftName == aircraftModel select a).ToListAsync()).FirstOrDefault();


               if (aircraft == null)
               {
                    MessageBox.Show("Added Aircraft does not exists!");
                    AircraftModel.Text = "";
               }


               // creating a new instance of the flight model
               Flight flight = new Flight();
               FlightCRUD flightCRUD = new FlightCRUD();

               int id = flightCRUD.assignID() + 1;
               MessageBox.Show($"id {id}");
               // setting the values of the flight model
               flight.FlightID = id;
               flight.DepartureLocation = departureAr;
               flight.Destination = arrivalAr;
               flight.DepartureTime = Convert.ToDateTime(departure_Time);
               flight.ArrivalTime = Convert.ToDateTime(arrival_Time);
               flight.AircraftID = aircraftModel;
               flight.Status = Status;


               // adding the flight to the database
               try
               {
                    using (var db = new AviateContext())
                    {
                         await db.Flights.AddAsync(flight);
                         await db.SaveChangesAsync();
                    }


               }
               catch (Exception ex)
               {
                    ToastMessage toastMessage = new ToastMessage("error", "Flight can't be saved");
                    toastMessage.Show();
                    create_fm_button.Enabled = true;
                    return;
               }
               ToastMessage toastMessage2 = new ToastMessage("success", "Flight record saved");
               toastMessage2.Show();
               create_fm_button.Enabled = true;


          }

          

          private void f_deptAirport_TextChanged(object sender, EventArgs e)
          {
               departureAr = f_deptAirport.Text;
          }

          private void f_ArrivalAirport_TextChanged(object sender, EventArgs e)
          {
               arrivalAr = f_ArrivalAirport.Text;
          }

          private void f_deptTime_ValueChanged(object sender, EventArgs e)
          {
               departureTime = f_deptTime.Text;
          }


          private void f_arrivalTime_ValueChanged(object sender, EventArgs e)
          {
               // arrivalTime = f_arrivalTime.Text;
          }

          private void f_status_TextChanged(object sender, EventArgs e)
          {
               Status = f_status.Text;
          }

          private void AircraftModel_TextChanged(object sender, EventArgs e)
          {
               aircraftModel = AircraftModel.Text;
          }

          private async void ad_fm_Load(object sender, EventArgs e)
          {
               await retrieveAircrafts();
               await retrieveFlights();
          }

          private async void f_reload_Click(object sender, EventArgs e)
          {
               await retrieveAircrafts();
               await retrieveFlights();
          }

          private void Aircrafts_SelectedIndexChanged(object sender, EventArgs e)
          {
               // changing the value of AircraftModal input box to the selected item
               AircraftModel.Text = Aircrafts.SelectedItem?.ToString();
          }

          private void f_arrivalTime_ValueChanged_1(object sender, EventArgs e)
          {
               arrivalTime = f_arrivalTime.Text;
          }

          

          private async void button1_Click_1(object sender, EventArgs e)
          {
               if (RescheduleStatus.Text == "")
               {
                    MessageBox.Show("Please fill in all the fields");
                    return;
               }
               if (rescheduleDeptDate.Text == "" || RescheduleArrivalDate.Text == "" || RescheduleDeptTime.Text == "" || RescheduleArrivalTime.Text == "")
               {
                    MessageBox.Show("Don't forget to select date and time");
                    return;
               }


               string departure_Time = $"{rescheduleDeptDate.Text} {RescheduleDeptTime.Text}";
               string arrival_Time = $"{RescheduleArrivalDate.Text} {RescheduleArrivalTime.Text}";

               

               // validating the date and time
               try
               {

                    validateDateTime(Convert.ToDateTime(departure_Time), Convert.ToDateTime(arrival_Time));


               }
               catch (Exception exc)
               {
                    MessageBox.Show(exc.Message);
                    return;
               }

               AviateContext aviateContext = new AviateContext();

               Flight? editedFlight = (await (from ef in aviateContext.Flights where ef.FlightID == flightId select ef).ToListAsync()).FirstOrDefault();

               editedFlight.DepartureTime = Convert.ToDateTime(departure_Time);
               editedFlight.ArrivalTime = Convert.ToDateTime(arrival_Time);

               editedFlight.Status = RescheduleStatus.Text;

               try
               {

                    aviateContext.Flights.Update(editedFlight);

                    await aviateContext.SaveChangesAsync();
               }
               catch (Exception ex)
               {
                    ToastMessage toastMessage = new ToastMessage("error", "Flight can't be saved");
                    toastMessage.Show();
                    return;
               }

               ToastMessage toastMessage2 = new ToastMessage("success", "Flight record saved");
               toastMessage2.Show();
          }

          private void FlightsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
               // getting the selected row
               Flight? selectedFlight;
               if (e.RowIndex >= 0 && e.RowIndex < FlightsDataGrid.Rows.Count)
               {
                    selectedFlight = FlightsDataGrid.Rows[e.RowIndex].DataBoundItem as Flight;
                    rescheduleDeptDate.Text = selectedFlight.DepartureTime.ToString();
                    RescheduleArrivalDate.Text = selectedFlight.ArrivalTime.ToString();
                    RescheduleDeptTime.Text = selectedFlight.DepartureTime.ToString();
                    RescheduleArrivalTime.Text = selectedFlight.ArrivalTime.ToString();

                    flightId = selectedFlight.FlightID;
               }
          }

          
     }
}
