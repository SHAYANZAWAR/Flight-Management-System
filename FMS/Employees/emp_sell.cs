using Aviate.DBContext;
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

namespace FMS.Employees
{
     public partial class emp_sell : Form
     {
          public emp_sell()
          {
               InitializeComponent();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               /*empPanel empPanel = new empPanel();
               empPanel.Show();*/
               this.Hide();
          }
          private async Task getFilghts()
          {

               AviateContext aviateContext = new AviateContext();

               var flights = await (from flight in aviateContext.Flights select flight).ToListAsync();

               dataGridView1.DataSource = flights;
          }

          private async void emp_sell_Load(object sender, EventArgs e)
          {
               await getFilghts();
          }
     }
}
