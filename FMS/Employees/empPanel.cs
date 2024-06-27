using Aviate.CRUD;
using Aviate.Models;
using Aviate.Utils;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using FMS.SubUtills;
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

namespace FMS.Employees
{
     public partial class empPanel : Form
     {
          private int ParentX; private int ParentY;
          public empPanel()
          {


               InitializeComponent();
          }

          private void bigLabel1_Click(object sender, EventArgs e)
          {

          }

          private void logout_Click(object sender, EventArgs e)
          {
               LoginPage loginPage = new LoginPage();
               loginPage.Show();
               this.Hide();
          }

          private void emp_viewSalary_Click(object sender, EventArgs e)
          {
               empSal empSal = new empSal();
               empSal.Show();
               //this.Hide();

          }

          private void emp_todo_Click(object sender, EventArgs e)
          {
               emp_todo emp_todo = new emp_todo();
               emp_todo.Show();
               //this.Hide();
          }

          private void emp_profile_Click(object sender, EventArgs e)
          {
               /*emp_Profile emp_Profile = new emp_Profile();
               emp_Profile.Show();*/
               pictureBox2_Click(sender, e);
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

          private void emp_sell_Click(object sender, EventArgs e)
          {
               emp_sell emp_Sell = new emp_sell();
               emp_Sell.Show();
               //this.Hide();
          }

          private void emp_feedback_Click(object sender, EventArgs e)
          {
               emp_viewFeedback emp_ViewFeedback = new emp_viewFeedback();
               emp_ViewFeedback.Show();
               //this.Hide();
          }

          private async void empPanel_Load(object sender, EventArgs e)
          {
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
     }
}
