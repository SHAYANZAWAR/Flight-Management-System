using FMS.Employees;
using FMS.User_Panels;
using ReaLTaiizor.Controls;
using Aviate.Utils;
using Aviate.DBContext;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Aviate.Models;
using FMS.SubUtills;
namespace FMS
{
     public partial class LoginPage : Form
     {
          string username;
          string password;
          string email;
          

          public bool isValidEmail(string value)
          {
               // checks if a valid email using custom regex
               bool isEmail = Regex.IsMatch(value, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
               return isEmail;


          }

          public LoginPage()
          {
               InitializeComponent();
            

        }

          private void exit_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private void exitButton_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          

          

          private void exitButton_Click_1(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private async void button1_Click_1(object sender, EventArgs e)
          {

               // disabaling the button

               button1.Enabled = false;

               bool authByEmail;
               // checking if the value is email or username using the regex
               if (isValidEmail(textBox1.Text))
               {
                    email = textBox1.Text;
                    authByEmail = true;
               }
               else
               {
                    username = textBox1.Text;
                    authByEmail = false;
               }

               if (username == "admin" && password == "admin")
               {
                    adminPanel adminPanel = new adminPanel();
                    this.Hide();
                    adminPanel.Show();
                    return;
               }

               // doing a dummy check for the user
               // if the user is authenticated then getting its data from the database
               //if (username == "admin" && password == "admin")
               //{
               //     adminPanel adminPanel = new adminPanel();
               //     this.Hide();
               //     adminPanel.Show();
               //}
               
               Auth auth = new();
               User? authResult;
               if (authByEmail)
               {
                    authResult = await auth.CheckAuth(email, password);
               }
               else
               {
                    authResult = await auth.CheckAuthByUsername(username, password);
               }

               // if the user is authenticated then getting its data from the database
               if (authResult != null)
               {



                    if (authResult.UserType.ToLower() == "admin")
                    {
                         adminPanel adminPanel = new adminPanel();
                         this.Hide();
                         adminPanel.Show();
                    }
                    else if (authResult.UserType.ToLower() == "employee")
                    {
                         empPanel employeePanel = new empPanel();
                         this.Hide();
                         employeePanel.Show();
                    }
                    else if (authResult.UserType.ToLower() == "passenger")
                    {
                         userPanel UserPanel = new userPanel();
                         this.Hide();
                         UserPanel.Show();
                    }
                    else if (authResult.UserType.ToLower() == "crew")
                    {
                         empPanel ep = new();
                         this.Hide();
                         ep.Show();
                    }

               } else
               {
                    ToastMessage toastMessage = new ToastMessage("error", "Invalid Username/Email");
                    toastMessage.Show();
               }

               button1.Enabled = true;
          }

          private void sign_up_butt_Click(object sender, EventArgs e)
          {

               signupForm signupForm = new signupForm();
               signupForm.Show();
               this.Hide();

          }

          private void textBox2_TextChanged(object sender, EventArgs e)
          {
               password = textBox2.Text;
          }
     }
}
