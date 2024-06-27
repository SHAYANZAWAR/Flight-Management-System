using Aviate.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Aviate.Models;
using Aviate.CRUD;
using FMS.SubUtills;
namespace FMS
{
     public partial class signupForm : Form
     {
          private string uName;
          private string Uusername;
          private string cnic;
          private string uPassword;
          private string uEmail;
          public string otpValue;
          public signupForm()
          {
               InitializeComponent();
          }

          private bool isValidEmail(string value)
          {
               // checks if a valid email using custom regex
               bool isEmail = Regex.IsMatch(value, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
               return isEmail;
          }

          
          private void button1_Click(object sender, EventArgs e)
          {
               LoginPage loginPage = new LoginPage();
               this.Hide();
               loginPage.Show();
          }

          private void password_TextChanged(object sender, EventArgs e)
          {
               uPassword = password.Text;
          }

          

          private async void button2_Click(object sender, EventArgs e)
          {
               button2.Enabled = false;

               if (uName == "" || cnic == "" || uPassword == "" || uEmail == "")
               {
                    MessageBox.Show("Please fill all the fields");
                    return;
               }
               // registering the user

               string userType = "";

               // checking if the email is valid using regex
               if (isValidEmail(uEmail))
               {
                    userType = "passenger";

               }

               else
               {
                    MessageBox.Show("Invalid email address");
                    return;
               }


               // first verfiy the otp
               Email email = new Email();
               OtpVerification otpVerification = new OtpVerification();
               string otp = OtpVerification.GenerateOtp();
               email.SendMail(uEmail, "QatarAirways OTP", $"Otp is {otp}");


               VerifyOTPForm verifyOTPForm = new VerifyOTPForm();
               string otpValue = "";
               verifyOTPForm.ShowDialog(out otpValue);



               if (otpValue != otp)
               {
                    ToastMessage toastMsg = new ToastMessage("error", "Invalid OTP");
                    return;
               }

               UserCRUD userCRUD = new();

               int id = userCRUD.assignID() + 1;

               // first creating a user and userCredentials from given data

               User user = new()
               {
                    Id = id,
                    Name = uName,
                    UserType = userType,
                    PhoneNumber = "",
                    Cnic = cnic,
                    isActive = true
               };

               UserAuthCredential credentials = new()
               {
                    UserId = id,
                    Username = Uusername,
                    Email = uEmail,
                    PasswordHash = uPassword
               };

               Auth auth = new();

               try
               {
                    if (await auth.RegisterUser(user, credentials))
                    {
                         ToastMessage toastMessage = new ToastMessage("success", "User registered successfully");
                         toastMessage.Show();
                         LoginPage loginPage = new LoginPage();
                         this.Hide();
                         loginPage.Show();
                    }
                    else
                    {
                         ToastMessage toastMessage = new ToastMessage("error", "User registration failed");
                         toastMessage.Show();
                         button2.Enabled = true;
                    }

               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
                    button2.Enabled = true;
               }

               button2.Enabled = true;

          }

          private void name_TextChanged_1(object sender, EventArgs e)
          {
               uName = name.Text;
          }

          private void exitButton_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          

          private void username_TextChanged(object sender, EventArgs e)
          {
               cnic = cnicInput.Text;
          }

          private void email_TextChanged(object sender, EventArgs e)
          {
               uEmail = email.Text;
          }

          private void username_TextChanged_1(object sender, EventArgs e)
          {
               Uusername = username.Text;
          }
     }
}
