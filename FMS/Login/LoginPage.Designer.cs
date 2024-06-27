namespace FMS
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            exitButton = new Button();
            pictureBox2 = new PictureBox();
            sign_up_butt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Berlin Sans FB", 13F);
            button1.ForeColor = Color.FromArgb(102, 0, 51);
            button1.Location = new Point(80, 382);
            button1.Name = "button1";
            button1.Size = new Size(187, 42);
            button1.TabIndex = 22;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(2, 1, 17);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(51, 286);
            textBox2.Margin = new Padding(6, 7, 6, 7);
            textBox2.MinimumSize = new Size(245, 35);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "   Password";
            textBox2.Size = new Size(245, 37);
            textBox2.TabIndex = 21;
            textBox2.UseWaitCursor = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(2, 1, 17);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.WhiteSmoke;
            textBox1.Location = new Point(51, 229);
            textBox1.MinimumSize = new Size(245, 35);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "   Username/Email";
            textBox1.Size = new Size(245, 37);
            textBox1.TabIndex = 20;
            
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.Font = new Font("Segoe UI", 16.1194019F, FontStyle.Bold);
            exitButton.ForeColor = Color.FromArgb(102, 0, 51);
            exitButton.Location = new Point(931, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(54, 53);
            exitButton.TabIndex = 25;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.project_20240428_2018062_01;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(997, 575);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            
            // 
            // sign_up_butt
            // 
            sign_up_butt.BackColor = Color.FromArgb(2, 1, 17);
            sign_up_butt.FlatAppearance.BorderSize = 0;
            sign_up_butt.FlatStyle = FlatStyle.Flat;
            sign_up_butt.Font = new Font("Copperplate Gothic Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sign_up_butt.ForeColor = Color.White;
            sign_up_butt.Location = new Point(51, 333);
            sign_up_butt.Name = "sign_up_butt";
            sign_up_butt.Size = new Size(121, 42);
            sign_up_butt.TabIndex = 26;
            sign_up_butt.Text = "Sign up now";
            sign_up_butt.UseVisualStyleBackColor = false;
            sign_up_butt.Click += sign_up_butt_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(997, 575);
            Controls.Add(sign_up_butt);
            Controls.Add(exitButton);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FMS";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button exitButton;
        private PictureBox pictureBox2;
        private Button sign_up_butt;
     }
}
