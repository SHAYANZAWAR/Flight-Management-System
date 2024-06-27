namespace FMS.Employees
{
    partial class empPanel
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empPanel));
               panel2 = new Panel();
               reload = new ReaLTaiizor.Controls.PoisonTile();
               logout = new ReaLTaiizor.Controls.PoisonTile();
               emp_profile = new ReaLTaiizor.Controls.PoisonTile();
               emp_todo = new ReaLTaiizor.Controls.PoisonTile();
               emp_viewSalary = new ReaLTaiizor.Controls.PoisonTile();
               emp_feedback = new ReaLTaiizor.Controls.PoisonTile();
               emp_sell = new ReaLTaiizor.Controls.PoisonTile();
               label1 = new Label();
               pictureBox1 = new PictureBox();
               bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
               panel1 = new Panel();
               profilePicture = new PictureBox();
               pictureBox2 = new PictureBox();
               EmailLabel = new Label();
               username = new Label();
               panel2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
               panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
               ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
               SuspendLayout();
               // 
               // panel2
               // 
               panel2.Controls.Add(reload);
               panel2.Controls.Add(logout);
               panel2.Controls.Add(emp_profile);
               panel2.Controls.Add(emp_todo);
               panel2.Controls.Add(emp_viewSalary);
               panel2.Controls.Add(emp_feedback);
               panel2.Controls.Add(emp_sell);
               panel2.Font = new Font("Segoe UI", 15F);
               panel2.Location = new Point(-1, 230);
               panel2.Name = "panel2";
               panel2.Size = new Size(1156, 473);
               panel2.TabIndex = 7;
               // 
               // reload
               // 
               reload.ActiveControl = null;
               reload.BackColor = Color.FromArgb(92, 7, 49);
               reload.Cursor = Cursors.Hand;
               reload.Font = new Font("Poppins Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
               reload.ForeColor = Color.White;
               reload.Location = new Point(983, 431);
               reload.Name = "reload";
               reload.Size = new Size(72, 39);
               reload.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
               reload.TabIndex = 7;
               reload.Text = "Reload";
               reload.TextAlign = ContentAlignment.BottomCenter;
               reload.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
               reload.TileImageAlign = ContentAlignment.MiddleCenter;
               reload.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
               reload.UseCustomBackColor = true;
               reload.UseCustomForeColor = true;
               reload.UseSelectable = true;
               reload.UseStyleColors = true;
               reload.UseTileImage = true;
               reload.UseVisualStyleBackColor = false;
               // 
               // logout
               // 
               logout.ActiveControl = null;
               logout.BackColor = Color.White;
               logout.Cursor = Cursors.Hand;
               logout.ForeColor = Color.Black;
               logout.Location = new Point(1071, 431);
               logout.Name = "logout";
               logout.Size = new Size(72, 39);
               logout.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
               logout.TabIndex = 6;
               logout.Text = "Log out";
               logout.TextAlign = ContentAlignment.BottomCenter;
               logout.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
               logout.TileImageAlign = ContentAlignment.MiddleCenter;
               logout.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
               logout.UseCustomBackColor = true;
               logout.UseCustomForeColor = true;
               logout.UseSelectable = true;
               logout.UseStyleColors = true;
               logout.UseTileImage = true;
               logout.UseVisualStyleBackColor = false;
               logout.Click += logout_Click;
               // 
               // emp_profile
               // 
               emp_profile.ActiveControl = null;
               emp_profile.BackColor = Color.White;
               emp_profile.Cursor = Cursors.Hand;
               emp_profile.ForeColor = Color.Black;
               emp_profile.Location = new Point(427, 283);
               emp_profile.Name = "emp_profile";
               emp_profile.Size = new Size(260, 176);
               emp_profile.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
               emp_profile.TabIndex = 1;
               emp_profile.Text = "View Profile";
               emp_profile.TextAlign = ContentAlignment.BottomCenter;
               emp_profile.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
               emp_profile.TileImage = Properties.Resources._4092564_about_mobile_ui_profile_ui_user_website_114033;
               emp_profile.TileImageAlign = ContentAlignment.MiddleCenter;
               emp_profile.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
               emp_profile.UseCustomBackColor = true;
               emp_profile.UseCustomForeColor = true;
               emp_profile.UseSelectable = true;
               emp_profile.UseStyleColors = true;
               emp_profile.UseTileImage = true;
               emp_profile.UseVisualStyleBackColor = false;
               emp_profile.Click += emp_profile_Click;
               // 
               // emp_todo
               // 
               emp_todo.ActiveControl = null;
               emp_todo.BackColor = Color.White;
               emp_todo.Cursor = Cursors.Hand;
               emp_todo.ForeColor = Color.Black;
               emp_todo.Location = new Point(795, 46);
               emp_todo.Name = "emp_todo";
               emp_todo.Size = new Size(260, 176);
               emp_todo.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
               emp_todo.TabIndex = 1;
               emp_todo.Text = "To do list";
               emp_todo.TextAlign = ContentAlignment.BottomCenter;
               emp_todo.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
               emp_todo.TileImage = Properties.Resources.reporting_noun_report_document_file_icon_148360;
               emp_todo.TileImageAlign = ContentAlignment.MiddleCenter;
               emp_todo.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
               emp_todo.UseCustomBackColor = true;
               emp_todo.UseCustomForeColor = true;
               emp_todo.UseSelectable = true;
               emp_todo.UseStyleColors = true;
               emp_todo.UseTileImage = true;
               emp_todo.UseVisualStyleBackColor = false;
               emp_todo.Click += emp_todo_Click;
               // 
               // emp_viewSalary
               // 
               emp_viewSalary.ActiveControl = null;
               emp_viewSalary.BackColor = Color.White;
               emp_viewSalary.Cursor = Cursors.Hand;
               emp_viewSalary.ForeColor = Color.Black;
               emp_viewSalary.Location = new Point(69, 46);
               emp_viewSalary.Name = "emp_viewSalary";
               emp_viewSalary.Size = new Size(260, 176);
               emp_viewSalary.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
               emp_viewSalary.TabIndex = 4;
               emp_viewSalary.Text = "View Salary";
               emp_viewSalary.TextAlign = ContentAlignment.BottomCenter;
               emp_viewSalary.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
               emp_viewSalary.TileImage = Properties.Resources.cash_payment_earning_salary_income_wages_icon_210486;
               emp_viewSalary.TileImageAlign = ContentAlignment.MiddleCenter;
               emp_viewSalary.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
               emp_viewSalary.UseCustomBackColor = true;
               emp_viewSalary.UseCustomForeColor = true;
               emp_viewSalary.UseSelectable = true;
               emp_viewSalary.UseStyleColors = true;
               emp_viewSalary.UseTileImage = true;
               emp_viewSalary.UseVisualStyleBackColor = false;
               emp_viewSalary.Click += emp_viewSalary_Click;
               // 
               // emp_feedback
               // 
               emp_feedback.ActiveControl = null;
               emp_feedback.BackColor = Color.White;
               emp_feedback.Cursor = Cursors.Hand;
               emp_feedback.ForeColor = Color.Black;
               emp_feedback.Location = new Point(69, 283);
               emp_feedback.Name = "emp_feedback";
               emp_feedback.Size = new Size(260, 176);
               emp_feedback.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
               emp_feedback.TabIndex = 3;
               emp_feedback.Text = "View Feedback";
               emp_feedback.TextAlign = ContentAlignment.BottomCenter;
               emp_feedback.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
               emp_feedback.TileImage = Properties.Resources._3709747_contentment_customer_feedback_review_satisfaction_108084;
               emp_feedback.TileImageAlign = ContentAlignment.MiddleCenter;
               emp_feedback.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
               emp_feedback.UseCustomBackColor = true;
               emp_feedback.UseCustomForeColor = true;
               emp_feedback.UseSelectable = true;
               emp_feedback.UseStyleColors = true;
               emp_feedback.UseTileImage = true;
               emp_feedback.UseVisualStyleBackColor = false;
               emp_feedback.Click += emp_feedback_Click;
               // 
               // emp_sell
               // 
               emp_sell.ActiveControl = null;
               emp_sell.BackColor = Color.White;
               emp_sell.Cursor = Cursors.Hand;
               emp_sell.ForeColor = Color.Black;
               emp_sell.Location = new Point(427, 46);
               emp_sell.Name = "emp_sell";
               emp_sell.Size = new Size(260, 176);
               emp_sell.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
               emp_sell.TabIndex = 2;
               emp_sell.Text = "Sell Ticket";
               emp_sell.TextAlign = ContentAlignment.BottomCenter;
               emp_sell.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
               emp_sell.TileImage = Properties.Resources.roster_flight_icon_216248;
               emp_sell.TileImageAlign = ContentAlignment.MiddleCenter;
               emp_sell.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
               emp_sell.UseCustomBackColor = true;
               emp_sell.UseCustomForeColor = true;
               emp_sell.UseSelectable = true;
               emp_sell.UseStyleColors = true;
               emp_sell.UseTileImage = true;
               emp_sell.UseVisualStyleBackColor = false;
               emp_sell.Click += emp_sell_Click;
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Font = new Font("Segoe UI", 5F);
               label1.Location = new Point(982, 721);
               label1.Name = "label1";
               label1.Size = new Size(160, 12);
               label1.TabIndex = 8;
               label1.Text = "Work by Huraira and Shayan Zawar\r\n";
               // 
               // pictureBox1
               // 
               pictureBox1.Cursor = Cursors.No;
               pictureBox1.Enabled = false;
               pictureBox1.Image = Properties.Resources._884510a2d764ce27643bcca063c1855e;
               pictureBox1.Location = new Point(3, 0);
               pictureBox1.Name = "pictureBox1";
               pictureBox1.Size = new Size(311, 228);
               pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
               pictureBox1.TabIndex = 2;
               pictureBox1.TabStop = false;
               // 
               // bigLabel1
               // 
               bigLabel1.AutoSize = true;
               bigLabel1.BackColor = Color.Transparent;
               bigLabel1.Font = new Font("Poppins ExtraBold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
               bigLabel1.ForeColor = Color.White;
               bigLabel1.Location = new Point(288, 30);
               bigLabel1.Name = "bigLabel1";
               bigLabel1.Size = new Size(790, 127);
               bigLabel1.TabIndex = 0;
               bigLabel1.Text = "Welcome Employee";
               bigLabel1.Click += bigLabel1_Click;
               // 
               // panel1
               // 
               panel1.BackColor = Color.FromArgb(92, 7, 49);
               panel1.Controls.Add(profilePicture);
               panel1.Controls.Add(pictureBox2);
               panel1.Controls.Add(EmailLabel);
               panel1.Controls.Add(username);
               panel1.Controls.Add(pictureBox1);
               panel1.Controls.Add(bigLabel1);
               panel1.Location = new Point(-1, 3);
               panel1.Name = "panel1";
               panel1.Size = new Size(1156, 232);
               panel1.TabIndex = 6;
               // 
               // profilePicture
               // 
               profilePicture.Image = Properties.Resources.noUser;
               profilePicture.Location = new Point(1085, 157);
               profilePicture.Margin = new Padding(4, 5, 4, 5);
               profilePicture.Name = "profilePicture";
               profilePicture.Size = new Size(60, 60);
               profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
               profilePicture.TabIndex = 11;
               profilePicture.TabStop = false;
               // 
               // pictureBox2
               // 
               pictureBox2.Cursor = Cursors.Hand;
               pictureBox2.Image = Properties.Resources.system_regular_12_arrow_down;
               pictureBox2.Location = new Point(894, 148);
               pictureBox2.Name = "pictureBox2";
               pictureBox2.Size = new Size(35, 35);
               pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
               pictureBox2.TabIndex = 14;
               pictureBox2.TabStop = false;
               pictureBox2.Click += pictureBox2_Click;
               // 
               // EmailLabel
               // 
               EmailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
               EmailLabel.AutoEllipsis = true;
               EmailLabel.AutoSize = true;
               EmailLabel.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
               EmailLabel.ForeColor = Color.White;
               EmailLabel.Location = new Point(1019, 187);
               EmailLabel.Name = "EmailLabel";
               EmailLabel.Size = new Size(69, 35);
               EmailLabel.TabIndex = 13;
               EmailLabel.Text = "Email";
               // 
               // username
               // 
               username.Anchor = AnchorStyles.Top | AnchorStyles.Right;
               username.AutoSize = true;
               username.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold);
               username.ForeColor = Color.White;
               username.Location = new Point(935, 157);
               username.Name = "username";
               username.Size = new Size(120, 35);
               username.TabIndex = 12;
               username.Text = "Username";
               // 
               // empPanel
               // 
               AutoScaleDimensions = new SizeF(10F, 25F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(1154, 737);
               Controls.Add(panel2);
               Controls.Add(label1);
               Controls.Add(panel1);
               Icon = (Icon)resources.GetObject("$this.Icon");
               MaximizeBox = false;
               Name = "empPanel";
               StartPosition = FormStartPosition.CenterScreen;
               Text = "Employee Panel";
               Load += empPanel_Load;
               panel2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
               panel1.ResumeLayout(false);
               panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
               ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Panel panel2;
        private ReaLTaiizor.Controls.PoisonTile reload;
        private ReaLTaiizor.Controls.PoisonTile logout;
        private ReaLTaiizor.Controls.PoisonTile emp_profile;
        private ReaLTaiizor.Controls.PoisonTile emp_todo;
        private ReaLTaiizor.Controls.PoisonTile emp_viewSalary;
        private ReaLTaiizor.Controls.PoisonTile emp_feedback;
        private ReaLTaiizor.Controls.PoisonTile emp_sell;
        private Label label1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Panel panel1;
          private PictureBox profilePicture;
          private PictureBox pictureBox2;
          private Label EmailLabel;
          private Label username;
     }
}