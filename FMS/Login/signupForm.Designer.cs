namespace FMS
{
    partial class signupForm
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signupForm));
               pictureBox1 = new PictureBox();
               name = new TextBox();
               exitButton = new Button();
               button1 = new Button();
               password = new TextBox();
               cnicInput = new TextBox();
               button2 = new Button();
               email = new TextBox();
               radioButton1 = new RadioButton();
               username = new TextBox();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
               SuspendLayout();
               // 
               // pictureBox1
               // 
               pictureBox1.Dock = DockStyle.Fill;
               pictureBox1.Image = Properties.Resources.project_20240428_2111571_012;
               pictureBox1.Location = new Point(0, 0);
               pictureBox1.Name = "pictureBox1";
               pictureBox1.Padding = new Padding(5, 5, 0, 0);
               pictureBox1.Size = new Size(997, 575);
               pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
               pictureBox1.TabIndex = 0;
               pictureBox1.TabStop = false;
               
               // 
               // name
               // 
               name.BackColor = Color.FromArgb(2, 1, 17);
               name.BorderStyle = BorderStyle.FixedSingle;
               name.Font = new Font("Poppins Light", 10F, FontStyle.Bold);
               name.ForeColor = Color.White;
               name.Location = new Point(27, 180);
               name.Margin = new Padding(5);
               name.MinimumSize = new Size(130, 35);
               name.Name = "name";
               name.PlaceholderText = "  Name";
               name.Size = new Size(130, 37);
               name.TabIndex = 21;
               name.TextChanged += name_TextChanged_1;
               // 
               // exitButton
               // 
               exitButton.BackColor = Color.Transparent;
               exitButton.FlatAppearance.BorderSize = 0;
               exitButton.Font = new Font("Segoe UI", 16.1194019F, FontStyle.Bold);
               exitButton.ForeColor = Color.FromArgb(102, 0, 51);
               exitButton.Location = new Point(931, 12);
               exitButton.Name = "exitButton";
               exitButton.Size = new Size(54, 54);
               exitButton.TabIndex = 26;
               exitButton.Text = "X";
               exitButton.UseVisualStyleBackColor = false;
               exitButton.Click += exitButton_Click;
               // 
               // button1
               // 
               button1.BackColor = Color.Transparent;
               button1.FlatAppearance.BorderSize = 0;
               button1.Font = new Font("Segoe UI", 16.1194019F, FontStyle.Bold);
               button1.ForeColor = Color.FromArgb(102, 0, 51);
               button1.Location = new Point(862, 12);
               button1.Name = "button1";
               button1.Size = new Size(54, 54);
               button1.TabIndex = 27;
               button1.Text = "🔙";
               button1.UseVisualStyleBackColor = false;
               button1.Click += button1_Click;
               // 
               // password
               // 
               password.BackColor = Color.FromArgb(2, 1, 17);
               password.BorderStyle = BorderStyle.FixedSingle;
               password.Font = new Font("Poppins Light", 10F, FontStyle.Bold);
               password.ForeColor = Color.White;
               password.Location = new Point(39, 343);
               password.MinimumSize = new Size(245, 35);
               password.Name = "password";
               password.PlaceholderText = "  Password";
               password.Size = new Size(245, 37);
               password.TabIndex = 28;
               password.TextChanged += password_TextChanged;
               // 
               // cnicInput
               // 
               cnicInput.BackColor = Color.FromArgb(2, 1, 17);
               cnicInput.BorderStyle = BorderStyle.FixedSingle;
               cnicInput.Font = new Font("Poppins Light", 10F, FontStyle.Bold);
               cnicInput.ForeColor = Color.White;
               cnicInput.Location = new Point(165, 180);
               cnicInput.MinimumSize = new Size(130, 35);
               cnicInput.Name = "cnicInput";
               cnicInput.PlaceholderText = "  Cnic";
               cnicInput.Size = new Size(130, 37);
               cnicInput.TabIndex = 29;
               cnicInput.TextChanged += username_TextChanged;
               // 
               // button2
               // 
               button2.BackColor = Color.White;
               button2.Cursor = Cursors.Hand;
               button2.FlatStyle = FlatStyle.Flat;
               button2.Font = new Font("Berlin Sans FB", 13F);
               button2.ForeColor = Color.FromArgb(102, 0, 51);
               button2.Location = new Point(39, 438);
               button2.Name = "button2";
               button2.Size = new Size(245, 49);
               button2.TabIndex = 30;
               button2.Text = "Register";
               button2.UseVisualStyleBackColor = false;
               button2.Click += button2_Click;
               // 
               // email
               // 
               email.BackColor = Color.FromArgb(2, 1, 17);
               email.BorderStyle = BorderStyle.FixedSingle;
               email.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
               email.ForeColor = Color.White;
               email.Location = new Point(40, 291);
               email.MinimumSize = new Size(245, 35);
               email.Name = "email";
               email.PlaceholderText = "  Email";
               email.Size = new Size(245, 37);
               email.TabIndex = 31;
               email.TextChanged += email_TextChanged;
               // 
               // radioButton1
               // 
               radioButton1.AutoSize = true;
               radioButton1.BackColor = Color.FromArgb(2, 1, 17);
               radioButton1.Font = new Font("Segoe UI", 7.5F);
               radioButton1.ForeColor = Color.Transparent;
               radioButton1.Location = new Point(40, 396);
               radioButton1.Name = "radioButton1";
               radioButton1.Size = new Size(249, 24);
               radioButton1.TabIndex = 32;
               radioButton1.TabStop = true;
               radioButton1.Text = "Accept our Terms and Conditons";
               radioButton1.UseVisualStyleBackColor = false;
               // 
               // username
               // 
               username.BackColor = Color.FromArgb(2, 1, 17);
               username.BorderStyle = BorderStyle.FixedSingle;
               username.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
               username.ForeColor = Color.White;
               username.Location = new Point(39, 235);
               username.MinimumSize = new Size(245, 35);
               username.Name = "username";
               username.PlaceholderText = "  Username";
               username.Size = new Size(245, 37);
               username.TabIndex = 33;
               username.TextChanged += username_TextChanged_1;
               // 
               // signupForm
               // 
               AutoScaleDimensions = new SizeF(10F, 25F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(997, 575);
               Controls.Add(username);
               Controls.Add(radioButton1);
               Controls.Add(email);
               Controls.Add(button2);
               Controls.Add(cnicInput);
               Controls.Add(password);
               Controls.Add(button1);
               Controls.Add(exitButton);
               Controls.Add(name);
               Controls.Add(pictureBox1);
               FormBorderStyle = FormBorderStyle.None;
               Icon = (Icon)resources.GetObject("$this.Icon");
               Name = "signupForm";
               StartPosition = FormStartPosition.CenterScreen;
               Text = "signupForm";
               ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private PictureBox pictureBox1;
        private TextBox name;
        private Button exitButton;
        private Button button1;
        private TextBox password;
        private TextBox cnicInput;
        private Button button2;
        private TextBox email;
        private RadioButton radioButton1;
          private TextBox username;
     }
}