namespace FMS.Employees
{
    partial class emp_todo
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emp_todo));
               panel2 = new Panel();
               label17 = new Label();
               label16 = new Label();
               label15 = new Label();
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
               panel2.Controls.Add(label17);
               panel2.Controls.Add(label16);
               panel2.Controls.Add(label15);
               panel2.Controls.Add(label3);
               panel2.Location = new Point(0, 227);
               panel2.Name = "panel2";
               panel2.Size = new Size(1154, 510);
               panel2.TabIndex = 6;
               // 
               // label17
               // 
               label17.AutoSize = true;
               label17.Font = new Font("Poppins", 8F);
               label17.Location = new Point(129, 252);
               label17.Name = "label17";
               label17.Size = new Size(127, 28);
               label17.TabIndex = 13;
               label17.Text = "3. Wash Again.";
               // 
               // label16
               // 
               label16.AutoSize = true;
               label16.Font = new Font("Poppins", 8F);
               label16.Location = new Point(129, 213);
               label16.Name = "label16";
               label16.Size = new Size(117, 28);
               label16.TabIndex = 12;
               label16.Text = "2. Wash A380";
               // 
               // label15
               // 
               label15.AutoSize = true;
               label15.Font = new Font("Poppins", 8F);
               label15.Location = new Point(129, 176);
               label15.Name = "label15";
               label15.Size = new Size(199, 28);
               label15.TabIndex = 11;
               label15.Text = "1. Analyze the Feedback";
               // 
               // label3
               // 
               label3.AutoSize = true;
               label3.Font = new Font("Poppins Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
               label3.Location = new Point(486, 30);
               label3.Name = "label3";
               label3.Size = new Size(281, 63);
               label3.TabIndex = 6;
               label3.Text = "Your Task List";
               // 
               // bigLabel1
               // 
               bigLabel1.AutoSize = true;
               bigLabel1.BackColor = Color.Transparent;
               bigLabel1.Font = new Font("Poppins Medium", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
               bigLabel1.ForeColor = Color.White;
               bigLabel1.Location = new Point(466, 41);
               bigLabel1.Name = "bigLabel1";
               bigLabel1.Size = new Size(399, 123);
               bigLabel1.TabIndex = 5;
               bigLabel1.Text = "To Do List";
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
               // emp_todo
               // 
               AutoScaleDimensions = new SizeF(10F, 25F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(1154, 737);
               Controls.Add(panel1);
               Icon = (Icon)resources.GetObject("$this.Icon");
               MaximizeBox = false;
               Name = "emp_todo";
               StartPosition = FormStartPosition.CenterScreen;
               Text = "To Do List";
               panel2.ResumeLayout(false);
               panel2.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
               panel1.ResumeLayout(false);
               panel1.PerformLayout();
               ResumeLayout(false);
          }

          #endregion

          private Panel panel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button2;
        private Label label3;
        private Label label17;
        private Label label16;
        private Label label15;
    }
}