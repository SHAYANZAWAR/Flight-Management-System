using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aviate.Models;
using Aviate.DBContext;
using Microsoft.EntityFrameworkCore;
namespace FMS.Employees
{
     public partial class emp_viewFeedback : Form
     {
          public emp_viewFeedback()
          {
               InitializeComponent();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               empPanel empPanel = new empPanel();
               empPanel.Show();
               this.Hide();
          }

          private async void emp_viewFeedback_Load(object sender, EventArgs e)
          {
               // getting all the feedbacks

               AviateContext aviateContext = new AviateContext();

               List<Feedback> feedbacks = await (from f in aviateContext.UserFeedbacks select f).ToListAsync();

               dataGridView1.DataSource = feedbacks;   
               
                 
          }
     }
}
