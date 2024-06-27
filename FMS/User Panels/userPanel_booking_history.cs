using Aviate.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace FMS.User_Panels
{
     public partial class userPanel_booking_history : Form
     {
          public userPanel_booking_history()
          {
               InitializeComponent();
          }
          private async Task getBookings()
          {
               AviateContext aviateContext = new AviateContext();
               var bookings = await (from booking in aviateContext.Bookings select booking).ToListAsync();

               histroy_up_grid.DataSource = bookings;
          }
          private void button2_Click(object sender, EventArgs e)
          {
               /*userPanel userPanel = new userPanel();
               userPanel.Show();*/
               this.Hide();
          }


          private async void f_reload_Click(object sender, EventArgs e)
          {
               // get the data from the booking table
               await getBookings();
          }

          

          private async void book_up_retrive_Click(object sender, EventArgs e)
          {
               await getBookings();
          }
     }
}
