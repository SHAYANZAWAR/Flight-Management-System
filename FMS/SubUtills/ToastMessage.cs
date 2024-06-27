using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMS.SubUtills
{
     public partial class ToastMessage : Form
     {
          private int toastX, toastY;
          private bool isInner;
          private int appWidth, appHeight;
          public ToastMessage(string type, string message)
          {
               InitializeComponent();

               typeLabel.Text = type;
               messageLabel.Text = message;

               switch (type)
               {
                    case "success":
                         toastBorder.BackColor = Color.FromArgb(0, 192, 0);
                         toastImage.Image = Properties.Resources.succes;
                         break;
                    case "error":
                         toastBorder.BackColor = Color.FromArgb(192, 0, 0);
                         toastImage.Image = Properties.Resources.error;
                         break;
                    case "warning":
                         toastBorder.BackColor = Color.FromArgb(255, 128, 0);
                         toastImage.Image = Properties.Resources.system_regular_56_warning;
                         break;

                    case "info":
                         toastBorder.BackColor = Color.FromArgb(0, 0, 192);
                         toastImage.Image = Properties.Resources.info;
                         break;
               }

          }

          public ToastMessage(string type, string message, bool inner, int nWidth, int nHeight) : this(type, message)
          {
               isInner = true;
               appWidth = nWidth;
               appHeight = nHeight;
          }

          

          private void ToastMessage_Load(object sender, EventArgs e)
          {
               Position();
          }

          private void Position()
          {
               int width, height;
               if (isInner)
               {

                    width = appWidth;

                    height = appHeight;

               } else
               {

                    width = Screen.PrimaryScreen.WorkingArea.Width;

                    height = Screen.PrimaryScreen.WorkingArea.Height;

               }

               // getting the application width and height
               
               toastX = width - this.Width - 15;
               toastY = height + this.Height - (this.Height / 2);

               this.Location = new Point(toastX, toastY);

          }

          private void toastAnimationTimer_Tick(object sender, EventArgs e)
          {
               toastY -= 10;
               this.Location = new Point(toastX, toastY);

               if (toastY <= (Screen.PrimaryScreen.WorkingArea.Height - this.Height - (this.Height / 2)))
               {
                    toastAnimationTimer.Stop();
                    toastHideTimer.Start();
               }
          }

          int y = 150;

          private void toastHideTimer_Tick(object sender, EventArgs e)
          {
               y--;

               if (y <= 0)
               {
                    toastY += 1;

                    this.Location = new Point(toastX, toastY += 10);

                    if (toastY >= Screen.PrimaryScreen.WorkingArea.Height)
                    {
                         toastHideTimer.Stop();
                         y = 100;
                         this.Close();
                    }
               }
          }

     }
}
