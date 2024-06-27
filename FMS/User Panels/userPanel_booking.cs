using Aviate.CRUD;
using Aviate.DBContext;
using Aviate.Models;
using Aviate.Utils;
using FMS.SubUtills;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMS.User_Panels
{
     public partial class userPanel_booking : Form
     {
          private string? seatType;
          private Flight? flight;
          private Aircraft? aircraft;
          private ICollection<int> seats;
          public userPanel_booking()
          {
               InitializeComponent();
          }

          private async Task getFilghts()
          {

               AviateContext aviateContext = new AviateContext();

               var flights = await (from flight in aviateContext.Flights select flight).ToListAsync();

               dataGridView1.DataSource = flights;
          }

          private async Task<ICollection<int>> getAvailableSeats(int? flightId)
          {

               AviateContext aviateContext = new AviateContext();

               var bookings = await (from booking in aviateContext.Bookings where booking.FlightID == flightId select booking).ToListAsync();

               // also count based on seatType
               int economySeats = 0;
               int businessSeats = 0;

               foreach (var booking in bookings)
               {
                    if (booking.SeatType == "Economy")
                    {
                         economySeats++;
                    }
                    else if (booking.SeatType == "Business")
                    {
                         businessSeats++;
                    }

               }

               return [economySeats, businessSeats];
          }

          private void button2_Click(object sender, EventArgs e)
          {
               /*userPanel userPanel = new userPanel();
               userPanel.Show();*/
               this.Hide();
          }

          private async void userPanel_booking_Load(object sender, EventArgs e)
          {
               await getFilghts();
          }

          private async void f_reload_Click(object sender, EventArgs e)
          {
               await getFilghts();
          }

          private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
               // getting the item that user selected
               flight = dataGridView1.Rows[e.RowIndex].DataBoundItem as Flight;


               string? aircraftModel = flight?.AircraftID;

               // getting the aircraft model
               AviateContext aviateContext = new AviateContext();

               aircraft = (await (from a in aviateContext.Aircrafts where a.AircraftName == aircraftModel select a).ToListAsync()).FirstOrDefault();

               economyFair.Text = aircraft.EconomyPrice.ToString();
               BussinessFair.Text = aircraft.BusinessPrice.ToString();

               seats = await getAvailableSeats(flight.FlightID);

               AvailableSeats.Text = (Convert.ToInt16(aircraft.EconomySeats) - seats.ElementAt(0)).ToString();
               AviateBussinessSeats.Text = (Convert.ToInt16(aircraft.BusinessSeats) - seats.ElementAt(1)).ToString();

          }

          private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
          {
               seatType = listBox1.SelectedItem?.ToString();
          }

          private async void edit_fm_search_Click(object sender, EventArgs e)
          {
               edit_fm_search.Enabled = false;
               // creating a booking
               AviateContext aviateContext = new AviateContext();

               // getting user Id from the Global context
               int? userId = GlobalContext.getGlobalUser()?.Id;
               string? sUserId = Convert.ToString(userId);
               // checking if the user with userid has already booked
               if (await aviateContext.Bookings.AnyAsync(b => b.UserID == sUserId && b.FlightID == flight.FlightID))
               {
                    ToastMessage toastMessage = new ToastMessage("info", "You have already booked!");
                    toastMessage.Show();
                    edit_fm_search.Enabled = true;
                    return;
               }

               int seatNumber = 0;
               int price = 0;
               // determinig the seatnumber and Price
               if (seatType == "Economy")
               {
                    seatNumber = Convert.ToInt16(aircraft?.BusinessSeats) + (Convert.ToInt16(aircraft?.EconomySeats) - seats.ElementAt(0));
                    price = Convert.ToInt32(aircraft?.EconomyPrice);
               }
               else if (seatType == "Business")
               {
                    seatNumber = (Convert.ToInt16(aircraft?.BusinessSeats) - seats.ElementAt(1));
                    price = Convert.ToInt32(aircraft?.BusinessPrice);
               }

               BookingCRUD bookingCRUD = new BookingCRUD();
               int id = bookingCRUD.assignID() + 1;

               Booking booking = new Booking
               {
                    BookingID = Convert.ToString(id),
                    FlightID = flight?.FlightID,
                    UserID = Convert.ToString(userId),
                    SeatType = seatType,
                    SeatNumber = seatNumber,
                    Price = price,
                    BookingTime = DateTime.Now,
                    isPaid = false
               };

               try
               {

                    await aviateContext.Bookings.AddAsync(booking);
                    await aviateContext.SaveChangesAsync();

               }
               catch (Exception ex)
               {
                    ToastMessage toastMessage = new ToastMessage("error", "Error while booking");
                    toastMessage.Show();
                    edit_fm_search.Enabled = true;
                    return;
               }

               ToastMessage toastMessage1 = new ToastMessage("success", "Booking Successful");
               toastMessage1.Show();
               edit_fm_search.Enabled = true;
          }

          
     }
}
