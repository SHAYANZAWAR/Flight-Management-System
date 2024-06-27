using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aviate.Utils;

namespace FMS
{
     public partial class splashScreen : Form
     {
          Task<bool> connection;
          public splashScreen()
          {
               InitializeComponent();
               aloneProgressBar1.Value = 0;
               timer1.Start();

               _Internet internet = new();

               connection = internet.CheckConnectivity();
          }

          private void timer1_Tick(object sender, EventArgs e)
          {
               aloneProgressBar1.Value += 20;
               if (aloneProgressBar1.Value >= 100)
               {
                    timer1.Stop();

                    bool res = connection.Result;
                    //bool res = true;
                    if (!res)
                    {
                         MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                         DialogResult result;
                         result = MessageBox.Show("No Internet Connection.\nTry Again?", "Internet", buttons);
                         if (result == DialogResult.Yes)
                         {
                              this.Hide();
                              Thread.Sleep(200);
                              splashScreen splashScreen = new splashScreen();
                              splashScreen.Show();

                         }
                         else {
                              
                              Application.Exit();
                         }
                    }


                    if (res)
                    {

                         LoginPage loginPage = new LoginPage();
                         loginPage.Show();

                    }


                    
               }
          }

     }
}
