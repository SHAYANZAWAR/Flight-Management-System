
using FMS.AdminPanels;
using FMS.SubUtills;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMS
{
     public partial class adminPanel : Form
     {
          public static int ParentX, ParentY;
          public adminPanel()
          {
               InitializeComponent();
               System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
               gp.AddEllipse(0, 0, profilePicture.Width - 3, profilePicture.Height - 3);
               Region rg = new Region(gp);
               profilePicture.Region = rg;


          }


          private void cyberButton1_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          
          private void user_management_Click(object sender, EventArgs e)
          {
               ad_um ad_Um = new ad_um();
               ad_Um.Show();
               this.Hide();
          }

          private void flight_managment_Click(object sender, EventArgs e)
          {
               ad_fm ad_Fm = new ad_fm();


               ad_Fm.Show();

               this.Hide();

               //ad_Fm.Show();
               //this.Hide();
          }

          private void poisonTile1_Click(object sender, EventArgs e)
          {
               LoginPage loginPage = new LoginPage();
               loginPage.Show();
               this.Hide();
          }

          private void aircraft_managment_Click(object sender, EventArgs e)
          {
               ad_am ad_am = new ad_am();
               ad_am.Show();
               this.Hide();
          }

          private void Reporting_and_Analytics_Click(object sender, EventArgs e)
          {
               ad_report adminReport = new ad_report();
               adminReport.Show();
               this.Hide();
          }

          private void poisonTile1_Click_1(object sender, EventArgs e)
          {
               ad_profile ad_Profile = new ad_profile();
               ad_Profile.Show();
               this.Hide();
          }

          private void system_configuration_Click(object sender, EventArgs e)
          {
               ad_booking adminBooking = new ad_booking();
               adminBooking.Show();
               this.Hide();
          }

          private void crew_managment_Click(object sender, EventArgs e)
          {
               ad_cm adminCrew = new ad_cm();
               adminCrew.Show();
               this.Hide();
          }

          
          private void pictureBox2_Click_1(object sender, EventArgs e)
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
                    modalForm.Location = this.Location;
                    modalForm.ShowDialog();
                    modalBackground.Dispose();
               }
          }

          
     }
}
