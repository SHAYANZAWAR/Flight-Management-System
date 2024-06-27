namespace FMS.AdminPanels
{
     partial class ad_profile
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }


          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ad_profile));
               panel1 = new Panel();
               bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
               button2 = new Button();
               pictureBox1 = new PictureBox();
               create_user = new TabPage();
               dungeonTabPage1 = new ReaLTaiizor.Controls.DungeonTabPage();
               panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
               dungeonTabPage1.SuspendLayout();
               SuspendLayout();
               // 
               // panel1
               // 
               panel1.BackColor = Color.FromArgb(92, 7, 49);
               panel1.Controls.Add(bigLabel1);
               panel1.Controls.Add(button2);
               panel1.Controls.Add(pictureBox1);
               panel1.Dock = DockStyle.Fill;
               panel1.Location = new Point(0, 0);
               panel1.Margin = new Padding(1, 1, 1, 1);
               panel1.Name = "panel1";
               panel1.Size = new Size(808, 443);
               panel1.TabIndex = 4;
               // 
               // bigLabel1
               // 
               bigLabel1.AutoSize = true;
               bigLabel1.BackColor = Color.Transparent;
               bigLabel1.Font = new Font("Poppins ExtraBold", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
               bigLabel1.ForeColor = Color.White;
               bigLabel1.Location = new Point(247, 26);
               bigLabel1.Margin = new Padding(1, 0, 1, 0);
               bigLabel1.Name = "bigLabel1";
               bigLabel1.Size = new Size(363, 83);
               bigLabel1.TabIndex = 5;
               bigLabel1.Text = "Admin Profile";
               // 
               // button2
               // 
               button2.BackColor = Color.FromArgb(92, 7, 49);
               button2.Font = new Font("Segoe UI", 12F);
               button2.ForeColor = SystemColors.ButtonFace;
               button2.Location = new Point(1, 1);
               button2.Margin = new Padding(1, 1, 1, 1);
               button2.Name = "button2";
               button2.Size = new Size(38, 32);
               button2.TabIndex = 4;
               button2.Text = "🔙";
               button2.UseVisualStyleBackColor = false;
               button2.Click += button2_Click;
               // 
               // pictureBox1
               // 
               pictureBox1.Image = Properties.Resources._884510a2d764ce27643bcca063c1855e1;
               pictureBox1.Location = new Point(0, -5);
               pictureBox1.Margin = new Padding(1, 1, 1, 1);
               pictureBox1.Name = "pictureBox1";
               pictureBox1.Size = new Size(218, 137);
               pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
               pictureBox1.TabIndex = 0;
               pictureBox1.TabStop = false;
               // 
               // create_user
               // 
               create_user.BackColor = Color.FromArgb(247, 246, 246);
               create_user.Location = new Point(4, 28);
               create_user.Margin = new Padding(1, 1, 1, 1);
               create_user.Name = "create_user";
               create_user.Padding = new Padding(1, 1, 1, 1);
               create_user.Size = new Size(801, 288);
               create_user.TabIndex = 0;
               create_user.Text = "Admin Profiles";
               // 
               // dungeonTabPage1
               // 
               dungeonTabPage1.ActivePageBackColor = Color.FromArgb(247, 246, 246);
               dungeonTabPage1.ActivePageBorderColor = Color.FromArgb(201, 198, 195);
               dungeonTabPage1.ActivePageTextColor = Color.FromArgb(80, 76, 76);
               dungeonTabPage1.BaseColor = Color.Black;
               dungeonTabPage1.Controls.Add(create_user);
               dungeonTabPage1.DeactivePageTextColor = Color.White;
               dungeonTabPage1.Font = new Font("Microsoft Sans Serif", 9F);
               dungeonTabPage1.ItemSize = new Size(80, 24);
               dungeonTabPage1.Location = new Point(-1, 121);
               dungeonTabPage1.Margin = new Padding(1, 1, 1, 1);
               dungeonTabPage1.Name = "dungeonTabPage1";
               dungeonTabPage1.PageBackColor = Color.FromArgb(247, 246, 246);
               dungeonTabPage1.PageEdgeBorderColor = Color.FromArgb(201, 198, 195);
               dungeonTabPage1.PageEdgeColor = Color.FromArgb(247, 246, 246);
               dungeonTabPage1.SelectedIndex = 0;
               dungeonTabPage1.Size = new Size(809, 320);
               dungeonTabPage1.TabIndex = 5;
               // 
               // ad_profile
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(808, 443);
               Controls.Add(dungeonTabPage1);
               Controls.Add(panel1);
               Icon = (Icon)resources.GetObject("$this.Icon");
               Margin = new Padding(1, 1, 1, 1);
               MaximizeBox = false;
               Name = "ad_profile";
               StartPosition = FormStartPosition.CenterScreen;
               Text = "ad_profile";
               panel1.ResumeLayout(false);
               panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
               dungeonTabPage1.ResumeLayout(false);
               ResumeLayout(false);
          }

          #endregion
          private Panel panel1;
          private ReaLTaiizor.Controls.BigLabel bigLabel1;
          private Button button2;
          private PictureBox pictureBox1;
          private TabPage create_user;
          private ReaLTaiizor.Controls.DungeonTabPage dungeonTabPage1;
     }
}