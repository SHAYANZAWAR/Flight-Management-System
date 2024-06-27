namespace FMS.Employees
{
    partial class emp_sell
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emp_sell));
               panel1 = new Panel();
               panel2 = new Panel();
               dataGridView1 = new DataGridView();
               bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
               button2 = new Button();
               pictureBox1 = new PictureBox();
               label1 = new Label();
               panel1.SuspendLayout();
               panel2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
               SuspendLayout();
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
               panel1.TabIndex = 8;
               // 
               // panel2
               // 
               panel2.BackColor = Color.White;
               panel2.Controls.Add(label1);
               panel2.Controls.Add(dataGridView1);
               panel2.Location = new Point(0, 227);
               panel2.Name = "panel2";
               panel2.Size = new Size(1154, 510);
               panel2.TabIndex = 6;
               // 
               // dataGridView1
               // 
               dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               dataGridView1.Location = new Point(93, 131);
               dataGridView1.Name = "dataGridView1";
               dataGridView1.RowHeadersWidth = 62;
               dataGridView1.Size = new Size(990, 225);
               dataGridView1.TabIndex = 0;
               // 
               // bigLabel1
               // 
               bigLabel1.AutoSize = true;
               bigLabel1.BackColor = Color.Transparent;
               bigLabel1.Font = new Font("Poppins Medium", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
               bigLabel1.ForeColor = Color.White;
               bigLabel1.Location = new Point(379, 52);
               bigLabel1.Name = "bigLabel1";
               bigLabel1.Size = new Size(489, 123);
               bigLabel1.TabIndex = 5;
               bigLabel1.Text = "Sell a Ticket";
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
               // label1
               // 
               label1.AutoSize = true;
               label1.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
               label1.Location = new Point(94, 88);
               label1.Name = "label1";
               label1.Size = new Size(273, 42);
               label1.TabIndex = 1;
               label1.Text = "All Registered Flights";
               // 
               // emp_sell
               // 
               AutoScaleDimensions = new SizeF(10F, 25F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(1154, 737);
               Controls.Add(panel1);
               Icon = (Icon)resources.GetObject("$this.Icon");
               MaximizeBox = false;
               Name = "emp_sell";
               StartPosition = FormStartPosition.CenterScreen;
               Text = "Sell Ticket";
               Load += emp_sell_Load;
               panel1.ResumeLayout(false);
               panel1.PerformLayout();
               panel2.ResumeLayout(false);
               panel2.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
               ResumeLayout(false);
          }

          #endregion

          private Panel panel1;
        private Panel panel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Button button2;
        private PictureBox pictureBox1;
          private DataGridView dataGridView1;
          private Label label1;
     }
}