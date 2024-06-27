namespace FMS
{
    partial class splashScreen
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
               components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreen));
               pictureBox1 = new PictureBox();
               aloneProgressBar1 = new ReaLTaiizor.Controls.AloneProgressBar();
               timer1 = new System.Windows.Forms.Timer(components);
               ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
               SuspendLayout();
               // 
               // pictureBox1
               // 
               pictureBox1.Image = Properties.Resources.download_image_1714163881932;
               pictureBox1.Location = new Point(0, -2);
               pictureBox1.Margin = new Padding(2, 2, 2, 2);
               pictureBox1.Name = "pictureBox1";
               pictureBox1.Size = new Size(535, 248);
               pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
               pictureBox1.TabIndex = 0;
               pictureBox1.TabStop = false;
               
               // 
               // aloneProgressBar1
               // 
               aloneProgressBar1.BackColor = Color.Transparent;
               aloneProgressBar1.BackgroundColor = Color.Lime;
               aloneProgressBar1.BaseColor = Color.FromArgb(45, 45, 48);
               aloneProgressBar1.BorderColor = Color.DodgerBlue;
               aloneProgressBar1.ForeColor = Color.CornflowerBlue;
               aloneProgressBar1.Location = new Point(143, 220);
               aloneProgressBar1.Margin = new Padding(2, 2, 2, 2);
               aloneProgressBar1.Maximum = 100;
               aloneProgressBar1.Minimum = 0;
               aloneProgressBar1.Name = "aloneProgressBar1";
               aloneProgressBar1.Size = new Size(258, 19);
               aloneProgressBar1.Stripes = Color.FromArgb(102, 0, 51);
               aloneProgressBar1.TabIndex = 1;
               aloneProgressBar1.Text = "LoadingAnimation";
               aloneProgressBar1.Value = 50;
               
               // 
               // timer1
               // 
               timer1.Tick += timer1_Tick;
               // 
               // splashScreen
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(535, 247);
               Controls.Add(aloneProgressBar1);
               Controls.Add(pictureBox1);
               FormBorderStyle = FormBorderStyle.None;
               Icon = (Icon)resources.GetObject("$this.Icon");
               Margin = new Padding(2, 2, 2, 2);
               MaximizeBox = false;
               Name = "splashScreen";
               StartPosition = FormStartPosition.CenterScreen;
               Text = "splashScreen";
               ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
               ResumeLayout(false);
          }

          #endregion

          private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.AloneProgressBar aloneProgressBar1;
        private System.Windows.Forms.Timer timer1;
     }
}