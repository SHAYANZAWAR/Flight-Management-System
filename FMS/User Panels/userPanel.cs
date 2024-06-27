using Aviate.Utils;
using FMS.SubUtills;
using Aviate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aviate.CRUD;


namespace FMS.User_Panels
{
     public partial class userPanel : Form
     {

          private int ParentX;
          private int ParentY;
          private System.Windows.Forms.Timer notificationTimer;
          public userPanel()
          {
               InitializeComponent();

               FormClosing += userPanel_FormClosing;
          }

          private void logout_Click(object sender, EventArgs e)
          {
               LoginPage loginPage = new LoginPage();
               loginPage.Show();
               this.Hide();
          }

          private void up_profile_Click(object sender, EventArgs e)
          {
               /*userPanel_profile userPanel_Profile = new userPanel_profile();
               userPanel_Profile.Show();*/
               pictureBox2_Click(sender, e);
               //this.Hide();
          }

          private void up_feedback_Click(object sender, EventArgs e)
          {
               userPanel_feedback userPanl_Feedback = new userPanel_feedback();
               userPanl_Feedback.Show();
               //this.Hide();
          }

          private void up_book_seat_Click(object sender, EventArgs e)
          {
               userPanel_booking userPanel_Booking = new userPanel_booking();
               userPanel_Booking.Show();
               //this.Hide();
          }

          private void up_booking_history_Click(object sender, EventArgs e)
          {
               userPanel_booking_history userPanel_Booking_History = new userPanel_booking_history();
               userPanel_Booking_History.Show();
               //this.Hide();
          }

          private void Reporting_and_Analytics_Click(object sender, EventArgs e)
          {
               userPanel_Billing userPanel_Billing = new userPanel_Billing();
               userPanel_Billing.Show();
               //this.Hide();
          }

          private void pictureBox2_Click(object sender, EventArgs e)
          {
               Form modalBackground = new Form();

               using (ModalForm modalForm = new ModalForm())
               {
                    modalBackground.StartPosition = FormStartPosition.Manual;
                    modalBackground.FormBorderStyle = FormBorderStyle.None;
                    modalBackground.Opacity = .50d;
                    modalBackground.BackColor = Color.Black;
                    modalBackground.Size = this.Size;
                    modalBackground.Location = this.Location;
                    modalBackground.ShowInTaskbar = false;
                    modalBackground.Show();
                    modalForm.Owner = modalBackground;


                    ParentX = this.Location.X;
                    ParentY = this.Location.Y;
                    modalForm.Location = new Point(ParentX + 250, ParentY + 180);
                    modalForm.ShowDialog();
                    modalBackground.Dispose();
               }
          }

          private async void userPanel_Load(object sender, EventArgs e)
          {
               // Create a new Timer
               notificationTimer = new System.Windows.Forms.Timer();

               // Set the timer interval to 5000 milliseconds (5 seconds)
               notificationTimer.Interval = 5000;

               // Set the timer Tick event handler
               notificationTimer.Tick += (s, args) =>
               {
                    if (GlobalContext.needNotification == true)
                    {
                         ToastMessage toastMessage = new ToastMessage(GlobalContext.notificationType, GlobalContext.notificationMessage);
                         toastMessage.Show();
                         GlobalContext.needNotification = false;
                         GlobalContext.notificationMessage = "";
                         GlobalContext.notificationType = "";
                    }
               };

               // Start the timer
               notificationTimer.Start();

               System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
               gp.AddEllipse(0, 0, profilePicture.Width - 3, profilePicture.Height - 3);
               Region rg = new Region(gp);
               profilePicture.Region = rg;


               string? loggedInUserEmail = GlobalContext.getGlobalUserEmail();
               string? loggedInUserName = GlobalContext.getGlobalUserName();
               if (loggedInUserName == "")
                    username.Text = GlobalContext.getGlobalUser()?.Name;
               else
               {
                    username.Text = loggedInUserName;
               }
               EmailLabel.Text = loggedInUserEmail;

               UserCRUD userCRUD = new UserCRUD();
               Imaging imaging = new Imaging();

               Image? image = await userCRUD.getImage(GlobalContext.getGlobalUser()?.Id);

               if (image != null)
               {
                    Image resizedImage = imaging.ResizeImage(image, 60, 60);
                    profilePicture.Image = image;
               }



          }


          private async void userPanel_FormClosing(object sender, EventArgs e)
          {
               notificationTimer.Stop();
               GlobalContext.needNotification = false;
          }

          private async void reload_Click(object sender, EventArgs e)
          {
               string? loggedInUserName = GlobalContext.getGlobalUserName();
               if (loggedInUserName == "")
                    username.Text = GlobalContext.getGlobalUser()?.Name;
               else
               {
                    username.Text = loggedInUserName;
               }


               UserCRUD userCRUD = new UserCRUD();
               Imaging imaging = new Imaging();

               Image? image = await userCRUD.getImage(GlobalContext.getGlobalUser()?.Id);

               if (image != null)
               {
                    Image resizedImage = imaging.ResizeImage(image, 60, 60);
                    profilePicture.Image = image;
               }
          }

          
     }
}
