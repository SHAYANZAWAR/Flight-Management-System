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
using Aviate.Models;
using Aviate.Utils;
using DocumentFormat.OpenXml.Drawing.Charts;
using FMS.SubUtills;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace FMS.User_Panels
{
     public partial class userPanel_Billing : Form
     {
          private Booking? booking;
          public userPanel_Billing()
          {
               InitializeComponent();
          }

          private async Task getPayableBookings()
          {
               int? userId = GlobalContext.getGlobalUser()?.Id;
               string? sUserId = Convert.ToString(userId);
               AviateContext aviateContext = new AviateContext();

               List<Booking> bookings = await aviateContext.Bookings.Where(Booking => Booking.UserID == sUserId && Booking.isPaid == false).ToListAsync();
               if (bookings.Count == 0)
               {

                    Message.Text = "No bills are Due! Hurraah!!!";
                    return;

               }
               dataGridView1.DataSource = bookings;
          }

          private void label2_Click(object sender, EventArgs e)
          {

          }

          private async void button1_Click(object sender, EventArgs e)
          {
               if (booking == null)
               {
                    MessageBox.Show("Please Select a booking from the list!");
                    return;
               }

               button1.Enabled = false;


               string? bookingId = booking.BookingID;
               AviateContext aviateContext = new AviateContext();
               // setting the isPaid property of booking with bookingId as true
               Booking? alterBooking = (await (from b in aviateContext.Bookings where b.BookingID == bookingId select b).ToListAsync()).FirstOrDefault();

               alterBooking.isPaid = true;

               try
               {

                    aviateContext.Bookings.Update(alterBooking);

                    await aviateContext.SaveChangesAsync();

               }
               catch (Exception ex)
               {
                    ToastMessage toastMessage = new ToastMessage("error", $"Payment failed");
                    toastMessage.Show();

                    button1.Enabled = true;
                    return;
               }

               ToastMessage toastMsg = new ToastMessage("success", "Payment successfull");
               toastMsg.Show();
               button1.Enabled = true;



          }

          private async void history_up_search_Click(object sender, EventArgs e)
          {
               await getPayableBookings();
          }

          private async void f_reload_Click(object sender, EventArgs e)
          {
               await getPayableBookings();
          }

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
               if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
               {
                    // getting the selected booking
                    booking = dataGridView1.Rows[e.RowIndex].DataBoundItem as Booking;
               }
          }

          private void userPanel_Billing_Load(object sender, EventArgs e)
          {
               Message.Text = "";
          }

          private void button2_Click(object sender, EventArgs e)
          {
               this.Hide();
          }
     }
}
