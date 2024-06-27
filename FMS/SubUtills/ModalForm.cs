using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aviate.CRUD;
using Aviate.DBContext;
using Aviate.Models;
using Aviate.Utils;
using Microsoft.EntityFrameworkCore;
namespace FMS.SubUtills
{
     public partial class ModalForm : Form
     {
          private Bitmap? profileImage;
          public ModalForm()
          {
               int i = 0;
               InitializeComponent();
               profileImage = null;

               // making pictureBox1 rounded
               System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
               gp.AddEllipse(0, 0, profilePicture.Width - 3, profilePicture.Height - 3);
               Region rg = new Region(gp);
               profilePicture.Region = rg;


          }

          

          private async void profilePicturePicker_Click(object sender, EventArgs e)
          {
               string fileName = "";


               // "OpenFileDialog" creates another Thread which in my case was not
               // STA so I created one myself and set it to STA and opened File Dialog in it
               Thread _fileDialogThread = new Thread(() =>
               {

                    OpenFileDialog fileDialog = new OpenFileDialog();
                    fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                         fileName = fileDialog.FileName;
                    }

               });
               _fileDialogThread.SetApartmentState(ApartmentState.STA);
               _fileDialogThread.Start();
               _fileDialogThread.Join();

               if (fileName != "")
               {

                    // resizing the image to 340 x 340 to fit the pictureBox
                    //Bitmap image = new Bitmap(fileDialog.FileName);
                    Imaging imaging = new Imaging();

                    Bitmap resizedImage = imaging.ResizeImage(new Bitmap(fileName), 280, 280);

                    profilePicture.Image = resizedImage;

                    profileImage = resizedImage;

               }



          }

          


          private void ModalForm_Load(object sender, EventArgs e)
          {
               // disabaling the text boxes initially 
               // enabling them when user clicks on the edit button
               usernameTextBox.Enabled = false;
               NameTextBox.Enabled = false;
               PhoneNoTextbox.Enabled = false;

               // setting their values to the current logged in User
               User? user = GlobalContext.getGlobalUser();
               usernameTextBox.Text = GlobalContext.getGlobalUserName() == null ? "Not Set" : GlobalContext.getGlobalUserName();
               NameTextBox.Text = GlobalContext.getGlobalUser()?.Name;
               PhoneNoTextbox.Text = GlobalContext.getGlobalUser()?.PhoneNumber == null ? "Not Set" : GlobalContext.getGlobalUser()?.PhoneNumber;


               /*i = adminPanel.ParentY + 150;
               this.Location = new Point(adminPanel.ParentX + 250, adminPanel.ParentY + 180);*/
          }

          private void ModalEffect_Timer_Tick(object sender, EventArgs e)
          {
               if (Opacity >= 1)
               {
                    ModalEffect_Timer.Stop();
               }
               else
               {
                    Opacity += .03;
               }
          }

          private void pictureBox2_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void EditButton_Click(object sender, EventArgs e)
          {
               // enabling the text boxes
               usernameTextBox.Enabled = true;
               NameTextBox.Enabled = true;
               PhoneNoTextbox.Enabled = true;

          }

          private async void SabeButton_Click(object sender, EventArgs e)
          {
               SabeButton.Enabled = false;

               UserCRUD userCRUD = new UserCRUD();
               AviateContext aviateContext = new AviateContext();
               if (profileImage != null)
               {
                    Imaging imaging = new Imaging();
                    int? id = GlobalContext.getGlobalUser().Id;
                    UserImage? currImage = (await (from i in aviateContext.UserImages where i.UserId == id select i).ToListAsync()).FirstOrDefault();
                    if (currImage == null) {

                         await userCRUD.storeImage(id, imaging.ImageToByteArray(profileImage));
                    } else
                    {
                         currImage.Image = imaging.ImageToByteArray(profileImage);
                         aviateContext.UserImages.Update(currImage);
                         await aviateContext.SaveChangesAsync();
                    }
                    
                    
               }

               // updating the user
               try
               {
                    await userCRUD.UpdateUser(GlobalContext.getGlobalUser(), NameTextBox.Text, PhoneNoTextbox.Text);
                    await userCRUD.UpdateUserAuthCredential(GlobalContext.getGlobalAuthCredentials(), usernameTextBox.Text);
               }
               catch (Exception ex)
               {
                    ToastMessage toastMessage = new ToastMessage("error", "User profile can't be updated!");
                    toastMessage.Show();
                    SabeButton.Enabled = true;
                    return;
               }

               ToastMessage toastMessage2 = new ToastMessage("success", "User profile successfully updated!");
               toastMessage2.Show();
               SabeButton.Enabled = true;

          }
     }
}
