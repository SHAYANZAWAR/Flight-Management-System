namespace FMS.Employees
{
    partial class empSal
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empSal));
               panel2 = new Panel();
               label4 = new Label();
               label2 = new Label();
               label1 = new Label();
               label3 = new Label();
               bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
               pictureBox1 = new PictureBox();
               panel1 = new Panel();
               button2 = new Button();
               panel2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
               panel1.SuspendLayout();
               SuspendLayout();
               // 
               // panel2
               // 
               panel2.BackColor = Color.White;
               panel2.Controls.Add(label4);
               panel2.Controls.Add(label2);
               panel2.Controls.Add(label1);
               panel2.Controls.Add(label3);
               panel2.Location = new Point(0, 227);
               panel2.Name = "panel2";
               panel2.Size = new Size(1154, 510);
               panel2.TabIndex = 6;
               // 
               // label4
               // 
               label4.AutoSize = true;
               label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
               label4.Location = new Point(362, 288);
               label4.Name = "label4";
               label4.Size = new Size(93, 42);
               label4.TabIndex = 9;
               label4.Text = "50000";
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
               label2.Location = new Point(362, 128);
               label2.Name = "label2";
               label2.Size = new Size(77, 42);
               label2.TabIndex = 8;
               label2.Text = "Peon";
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
               label1.Location = new Point(163, 207);
               label1.Name = "label1";
               label1.Size = new Size(181, 42);
               label1.TabIndex = 7;
               label1.Text = "Your Package";
               // 
               // label3
               // 
               label3.AutoSize = true;
               label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
               label3.Location = new Point(163, 53);
               label3.Name = "label3";
               label3.Size = new Size(128, 42);
               label3.TabIndex = 6;
               label3.Text = "Your Role";
               // 
               // bigLabel1
               // 
               bigLabel1.AutoSize = true;
               bigLabel1.BackColor = Color.Transparent;
               bigLabel1.Font = new Font("Poppins Medium", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
               bigLabel1.ForeColor = Color.White;
               bigLabel1.Location = new Point(484, 46);
               bigLabel1.Name = "bigLabel1";
               bigLabel1.Size = new Size(286, 123);
               bigLabel1.TabIndex = 5;
               bigLabel1.Text = "Salary";
               // 
               // pictureBox1
               // 
               pictureBox1.Image = Properties.Resources._884510a2d764ce27643bcca063c1855e1;
               pictureBox1.Location = new Point(0, -7);
               pictureBox1.Name = "pictureBox1";
               pictureBox1.Size = new Size(311, 228);
               pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
               pictureBox1.TabIndex = 0;
               pictureBox1.TabStop = false;
               // 
               // panel1
               // 
               panel1.BackColor = Color.FromArgb(92, 7, 49);
               panel1.Controls.Add(panel2);
               panel1.Controls.Add(bigLabel1);
               panel1.Controls.Add(button2);
               panel1.Controls.Add(pictureBox1);
               panel1.Dock = DockStyle.Fill;
               panel1.Location = new Point(0, 0);
               panel1.Name = "panel1";
               panel1.Size = new Size(1154, 737);
               panel1.TabIndex = 7;
               // 
               // button2
               // 
               button2.BackColor = Color.FromArgb(92, 7, 49);
               button2.Font = new Font("Segoe UI", 12F);
               button2.ForeColor = SystemColors.ButtonFace;
               button2.Location = new Point(3, 3);
               button2.Name = "button2";
               button2.Size = new Size(54, 54);
               button2.TabIndex = 4;
               button2.Text = "🔙";
               button2.UseVisualStyleBackColor = false;
               button2.Click += button2_Click;
               // 
               // empSal
               // 
               AutoScaleDimensions = new SizeF(10F, 25F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(1154, 737);
               Controls.Add(panel1);
               Icon = (Icon)resources.GetObject("$this.Icon");
               MaximizeBox = false;
               Name = "empSal";
               StartPosition = FormStartPosition.CenterScreen;
               Text = "Salary";
               Load += empSal_Load;
               panel2.ResumeLayout(false);
               panel2.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
               panel1.ResumeLayout(false);
               panel1.PerformLayout();
               ResumeLayout(false);
          }

          #endregion

          private Panel panel2;
        private Label label3;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button2;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}