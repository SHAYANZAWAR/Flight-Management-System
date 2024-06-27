using Aviate.DBContext;
using Aviate.Models;
using Aviate.Utils;
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
     public partial class empSal : Form
     {
          public empSal()
          {
               InitializeComponent();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               empPanel empPanel = new empPanel();
               empPanel.Show();
               this.Hide();
          }

          private async void empSal_Load(object sender, EventArgs e)
          {
               int? empId = GlobalContext.getGlobalUser()?.Id;

               // finding the employee with the given id
               AviateContext aviateContext = new AviateContext();
               Crew? emp = (await (from c in aviateContext.Crews where c.UserID == empId select c).ToListAsync()).FirstOrDefault();

               label2.Text = emp.Position;
          }
     }
}
