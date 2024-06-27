namespace FMS.User_Panels
{
    partial class userPanel_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userPanel_profile));
            panel2 = new Panel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(0, 227);
            panel2.Name = "panel2";
            panel2.Size = new Size(1154, 510);
            panel2.TabIndex = 6;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Poppins Medium", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(394, 40);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(465, 123);
            bigLabel1.TabIndex = 5;
            bigLabel1.Text = "User Profile";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(180, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(366, 393);
            dataGridView1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(679, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 212);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // userPanel_profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 737);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "userPanel_profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Profile";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button2;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
    }
}