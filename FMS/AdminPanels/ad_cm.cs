using Aviate.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aviate.Utils;
using Aviate.Models;
using Aviate.CRUD;
using FMS.SubUtills;
using Aviate.DBContext;

using Microsoft.EntityFrameworkCore;
namespace FMS.AdminPanels
{
     public partial class ad_cm : Form
     {

          private string name;
          private string username;
          private string password;
          private string cnic;
          private string phoneNumber;
          private string activeSearchText;
          private string role;
          private string qualifications;
          private string position;
          public ad_cm()
          {
               InitializeComponent();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               adminPanel adminPanel = new adminPanel();
               adminPanel.Show();
               this.Hide();
          }



          private void cr_name_TextChanged(object sender, EventArgs e)
          {
               name = cr_name.Text;
          }

          private void cr_username_TextChanged(object sender, EventArgs e)
          {
               username = cr_username.Text;
          }

          private void cr_password_TextChanged(object sender, EventArgs e)
          {
               password = cr_password.Text;
          }



          private void cr_phoneNumber_TextChanged(object sender, EventArgs e)
          {
               phoneNumber = cr_phonenumber.Text;
          }

          private void cr_activate_search_TextChanged(object sender, EventArgs e)
          {
               activeSearchText = cr_activate_search.Text;

          }

          private async void deactivate_Click(object sender, EventArgs e)
          {
               // marking the user as inactive
               if (activeSearchText == "")
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

          private async void cr_create_Click(object sender, EventArgs e)
          {
               if (name == null || cnic == null || password == null || phoneNumber == null || username == null)
               {
                    MessageBox.Show("Please fill all the fields");
               }
               else
               {
                    // creating a new user and respective credentials
                    User user = new User();
                    UserCRUD userCrud = new UserCRUD();
                    int id = userCrud.assignID() + 1;
                    user.Id = id;
                    user.Name = name;
                    user.PhoneNumber = phoneNumber;
                    user.Cnic = cnic;
                    user.UserType = "employee";
                    user.isActive = true;

                    Crew crew = new Crew();
                    CrewCRUD crewCRUD = new CrewCRUD();

                    crew.CrewID = crewCRUD.assignID() + 1;
                    crew.UserID = id;
                    crew.Name = name;
                    crew.ContactNumber = phoneNumber;
                    crew.Qualifications = qualifications;
                    crew.Position = position;

                    AviateContext aviateContext = new AviateContext();

                    await aviateContext.Crews.AddAsync(crew);
                    await aviateContext.SaveChangesAsync();

                    cr_create.Enabled = false;

                    UserAuthCredential userAuthCredential = new UserAuthCredential();
                    userAuthCredential.UserId = id;
                    userAuthCredential.Username = username;
                    userAuthCredential.Email = "";
                    userAuthCredential.PasswordHash = password;

                    Auth auth = new Auth();
                    //try
                    //{

                    if (await auth.RegisterUser(user, userAuthCredential))
                    {
                         ToastMessage toastMessage = new ToastMessage("success", $"User {Name} registered successfully");

                    }
                    else
                    {
                         ToastMessage toastMessage = new ToastMessage("error", $"User {Name} can't be registered.");
                    }

               }
          }

          private void cr_username_TextChanged_1(object sender, EventArgs e)
          {
               username = cr_username.Text;
          }

          private void cr_cnic_TextChanged_1(object sender, EventArgs e)
          {
               qualifications = qualificationTextBox.Text;
          }

          private void cr_phonenumber_TextChanged_1(object sender, EventArgs e)
          {
               phoneNumber = cr_phonenumber.Text;
          }

          private void cr_password_TextChanged_1(object sender, EventArgs e)
          {
               password = cr_password.Text;
          }

          private void cnicTextBox_TextChanged(object sender, EventArgs e)
          {
               cnic = cnicTextBox.Text;
          }

          private void positionTextBox_TextChanged(object sender, EventArgs e)
          {
               position = positionTextBox.Text;
          }

          private void edit_cnic_search_TextChanged(object sender, EventArgs e)
          {
               activeSearchText = edit_cnic_search.Text;

          }

          private async void edit_us_submit_Click(object sender, EventArgs e)
          {

               AviateContext aviateContext = new AviateContext();
               var employee = (await (from u in aviateContext.Users where u.Cnic == activeSearchText select u).ToListAsync()).FirstOrDefault();

               // getting the userauthcredentials

               var empCredentials = (await (from u in aviateContext.UserAuthCredentials where u.UserId == employee.Id select u).ToListAsync());

               dataGridView2.DataSource = empCredentials;

          }

          private void edit_us_username_TextChanged(object sender, EventArgs e)
          {
               username = edit_us_username.Text;
          }

          private void edit_passwordBox_TextChanged(object sender, EventArgs e)
          {
               password = edit_passwordBox.Text;
          }

          private async void edit_ur_make_changes_Click(object sender, EventArgs e)
          {
               if (username == "" || password == "")
               {
                    MessageBox.Show("Please fill all the fields");
                    return;
               }

               AviateContext aviateContext = new AviateContext();
               var employee = (await (from u in aviateContext.Users where u.Cnic == activeSearchText select u).ToListAsync()).FirstOrDefault();

               // getting the userauthcredentials

               var empCredentials = (await (from u in aviateContext.UserAuthCredentials where u.UserId == employee.Id select u).ToListAsync()).FirstOrDefault();
               empCredentials.Username = username;
               empCredentials.PasswordHash = password;

               try
               {

                    aviateContext.UserAuthCredentials.Update(empCredentials);
                    await aviateContext.SaveChangesAsync();
               }
               catch (Exception ex)
               {
                    ToastMessage toastMessage = new ToastMessage("error", "Error updating employee credentials");
                    toastMessage.Show();
                    return;
               }


               ToastMessage toastMessage1 = new ToastMessage("success", "Employee credentials updated successfully");
               toastMessage1.Show();

          }
     }
}
