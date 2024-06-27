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
     public partial class VerifyOTPForm : Form
     {
          public string otpValue;
          public VerifyOTPForm()
          {
               InitializeComponent();
          }

          private void VerifyButton_Click(object sender, EventArgs e)
          {
               otpValue = materialTextBoxEdit1.Text;
               this.Hide();

          }

          public DialogResult ShowDialog(out string result)
          {
               DialogResult dialogResult = base.ShowDialog();

               result = otpValue;
               return dialogResult;
          }

     }
}
