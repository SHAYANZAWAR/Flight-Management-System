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
using Aviate.CRUD;
using Aviate.Utils;
namespace FMS.AdminPanels
{
     public partial class ad_um : Form
     {
          private string name;
          private string cnic;
          private string password;
          private string phoneNumber;
          private string username;
          private string role;


          string activeSearchText;
          public ad_um()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               adminPanel adminPanel = new adminPanel();
               adminPanel.Show();
               this.Hide();
          }

          private void cr_userrole_SelectedIndexChanged(object sender, EventArgs e)
          {
               role = cr_userrole.Text;
          }

          private async void cr_create_Click(object sender, EventArgs e)
          {
               // creating a new user
               if (name == null || cnic == null || password == null || phoneNumber == null || username == null || role == null)
               {
                    MessageBox.Show("Please fill all the fields");
               }
               else
               {
                    // creating a new user and respective credentials
                    User user = new User();
                    user.Name = name;
                    user.PhoneNumber = phoneNumber;
                    user.Cnic = cnic;
                    user.UserType = role;
                    user.isActive = true;

                    cr_create.Enabled = false;

                    UserAuthCredential userAuthCredential = new UserAuthCredential();
                    userAuthCredential.Username = username;
                    userAuthCredential.Email = "";
                    userAuthCredential.PasswordHash = password;

                    Auth auth = new Auth();
                    try
                    {

                         await auth.RegisterUser(user, userAuthCredential);
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show(ex.Message);
                         cr_create.Enabled = true;
                         return;
                    }


                    MessageBox.Show("User Created Successfully");
               }
          }

          private void cr_name_TextChanged(object sender, EventArgs e)
          {
               name = cr_name.Text;
          }

          private void cr_username_TextChanged(object sender, EventArgs e)
          {
               username = cr_username.Text;
          }

          private void cr_cnic_TextChanged(object sender, EventArgs e)
          {
               cnic = cr_cnic.Text;
          }

          private void cr_phonenumber_TextChanged(object sender, EventArgs e)
          {
               phoneNumber = cr_phonenumber.Text;
          }

          private void cr_password_TextChanged(object sender, EventArgs e)
          {
               password = cr_password.Text;
          }

          private void cr_activate_search_TextChanged(object sender, EventArgs e)
          {
               activeSearchText = cr_activate_search.Text;
          }

          private async void deactivate_Click(object sender, EventArgs e)
          {
               // marking the user as inactive
               if (activeSearchText == null)
               {
                    MessageBox.Show("Please enter the username to deactivate");
               }
               else
               {
                    UserCRUD userCRUD = new UserCRUD();


                    User? user = await userCRUD.GetUser(activeSearchText);

                    if (user == null)
                    {
                         MessageBox.Show("User not found");
                         return;
                    }
                    bool res = await userCRUD.markInactive(activeSearchText);

                    if (!res)
                    {
                         MessageBox.Show("User Deactivation Failed");
                    }
                    else
                    {
                         MessageBox.Show("User Deactivated Successfully");
                    }

               }
          }

          
     }
}
