using Aviate.DBContext;
using Aviate.Utils;
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
using FMS.SubUtills;
using Aviate.CRUD;

namespace FMS.User_Panels
{
     public partial class userPanel_feedback : Form
     {
          public userPanel_feedback()
          {
               InitializeComponent();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               /*userPanel userPanel = new userPanel();
               userPanel.Show();*/
               this.Hide();
          }

          private async void feedback_um_sumbit_Click(object sender, EventArgs e)
          {

               // checking which one radio button is checked
               string experience = "";

               if (radioButton4.Checked)
               {
                    experience = "Bad";
               }
               else if (radioButton5.Checked)
               {
                    experience = "Average";
               }
               else if (radioButton6.Checked)
               {
                    experience = "Good";
               }
               else if (radioButton7.Checked)
               {
                    experience = "Excellent";
               }

               string message = textBox1.Text;

               AviateContext aviateContext = new AviateContext();
               FeedbackCRUD feedbackCRUD = new FeedbackCRUD();
               Feedback feedback = new Feedback()
               {
                    Id = feedbackCRUD.assignID() + 1,
                    Name = GlobalContext.getGlobalUser().Name,
                    Email = GlobalContext.getGlobalUserEmail(),
                    Experience = experience,
                    Message = message
               };


               try
               {

                    await aviateContext.UserFeedbacks.AddAsync(feedback);
                    await aviateContext.SaveChangesAsync();

               }
               catch (Exception ex)
               {
                    ToastMessage toastMessage = new ToastMessage("Error", "Error while submitting feedback");
                    toastMessage.Show();
                    return;
               }

               ToastMessage toastMessage1 = new ToastMessage("Success", "Feedback submitted successfully");
               toastMessage1.Show();

          }

          
     }
}
