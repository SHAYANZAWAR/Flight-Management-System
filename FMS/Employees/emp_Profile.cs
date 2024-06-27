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
     public partial class emp_Profile : Form
     {
          public emp_Profile()
          {
               InitializeComponent();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               empPanel empPanel = new empPanel();
               empPanel.Show();
               this.Hide();
          }

          
     }
}
