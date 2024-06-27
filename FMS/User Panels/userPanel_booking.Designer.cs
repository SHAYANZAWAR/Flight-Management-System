namespace FMS.User_Panels
{
    partial class userPanel_booking
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userPanel_booking));
               panel2 = new Panel();
               AviateBussinessSeats = new Label();
               label7 = new Label();
               AvailableSeats = new Label();
               label5 = new Label();
               BussinessFair = new Label();
               economyFair = new Label();
               label4 = new Label();
               label3 = new Label();
               listBox1 = new ListBox();
               label2 = new Label();
               edit_fm_search = new Button();
               dataGridView1 = new DataGridView();
               label1 = new Label();
               bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
               pictureBox1 = new PictureBox();
               panel1 = new Panel();
               f_reload = new ReaLTaiizor.Controls.PoisonTile();
               pictureBox2 = new PictureBox();
               button2 = new Button();
               panel2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
               panel1.SuspendLayout();
               f_reload.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
               SuspendLayout();
               // 
               // panel2
               // 
               panel2.BackColor = Color.White;
               panel2.Controls.Add(AviateBussinessSeats);
               panel2.Controls.Add(label7);
               panel2.Controls.Add(AvailableSeats);
               panel2.Controls.Add(label5);
               panel2.Controls.Add(BussinessFair);
               panel2.Controls.Add(economyFair);
               panel2.Controls.Add(label4);
               panel2.Controls.Add(label3);
               panel2.Controls.Add(listBox1);
               panel2.Controls.Add(label2);
               panel2.Controls.Add(edit_fm_search);
               panel2.Controls.Add(dataGridView1);
               panel2.Controls.Add(label1);
               panel2.Location = new Point(0, 227);
               panel2.Name = "panel2";
               panel2.Size = new Size(1154, 510);
               panel2.TabIndex = 6;
               // 
               // AviateBussinessSeats
               // 
               AviateBussinessSeats.AutoSize = true;
               AviateBussinessSeats.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               AviateBussinessSeats.Location = new Point(837, 358);
               AviateBussinessSeats.Name = "AviateBussinessSeats";
               AviateBussinessSeats.Size = new Size(23, 32);
               AviateBussinessSeats.TabIndex = 18;
               AviateBussinessSeats.Text = "*";
               // 
               // label7
               // 
               label7.AutoSize = true;
               label7.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               label7.ForeColor = Color.FromArgb(92, 7, 49);
               label7.Location = new Point(598, 358);
               label7.Name = "label7";
               label7.Size = new Size(245, 32);
               label7.TabIndex = 17;
               label7.Text = "Available Bussiness Seats:";
               // 
               // AvailableSeats
               // 
               AvailableSeats.AutoSize = true;
               AvailableSeats.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               AvailableSeats.Location = new Point(502, 358);
               AvailableSeats.Name = "AvailableSeats";
               AvailableSeats.Size = new Size(23, 32);
               AvailableSeats.TabIndex = 16;
               AvailableSeats.Text = "*";
               // 
               // label5
               // 
               label5.AutoSize = true;
               label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               label5.ForeColor = Color.FromArgb(92, 7, 49);
               label5.Location = new Point(265, 358);
               label5.Name = "label5";
               label5.Size = new Size(244, 32);
               label5.TabIndex = 15;
               label5.Text = "Available Economy Seats:";
               // 
               // BussinessFair
               // 
               BussinessFair.AutoSize = true;
               BussinessFair.Location = new Point(797, 399);
               BussinessFair.Name = "BussinessFair";
               BussinessFair.Size = new Size(22, 25);
               BussinessFair.TabIndex = 14;
               BussinessFair.Text = "$";
               // 
               // economyFair
               // 
               economyFair.AutoSize = true;
               economyFair.Location = new Point(495, 400);
               economyFair.Name = "economyFair";
               economyFair.Size = new Size(22, 25);
               economyFair.TabIndex = 13;
               economyFair.Text = "$";
               // 
               // label4
               // 
               label4.AutoSize = true;
               label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               label4.ForeColor = Color.FromArgb(92, 7, 49);
               label4.Location = new Point(651, 399);
               label4.Name = "label4";
               label4.Size = new Size(141, 32);
               label4.TabIndex = 12;
               label4.Text = "Bussiness Fair:";
               // 
               // label3
               // 
               label3.AutoSize = true;
               label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               label3.ForeColor = Color.FromArgb(92, 7, 49);
               label3.Location = new Point(354, 399);
               label3.Name = "label3";
               label3.Size = new Size(140, 32);
               label3.TabIndex = 11;
               label3.Text = "Economy Fair:";
               // 
               // listBox1
               // 
               listBox1.FormattingEnabled = true;
               listBox1.ItemHeight = 25;
               listBox1.Items.AddRange(new object[] { "Economy", "Business" });
               listBox1.Location = new Point(465, 319);
               listBox1.Name = "listBox1";
               listBox1.Size = new Size(243, 29);
               listBox1.TabIndex = 10;
               listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
               label2.ForeColor = Color.FromArgb(92, 7, 49);
               label2.Location = new Point(483, 274);
               label2.Name = "label2";
               label2.Size = new Size(225, 42);
               label2.TabIndex = 9;
               label2.Text = "Select Seat Class";
               // 
               // edit_fm_search
               // 
               edit_fm_search.BackColor = Color.FromArgb(92, 7, 49);
               edit_fm_search.Font = new Font("Poppins", 10F);
               edit_fm_search.ForeColor = Color.White;
               edit_fm_search.Location = new Point(516, 439);
               edit_fm_search.Name = "edit_fm_search";
               edit_fm_search.Size = new Size(155, 38);
               edit_fm_search.TabIndex = 8;
               edit_fm_search.Text = "Book Flight";
               edit_fm_search.UseVisualStyleBackColor = false;
               edit_fm_search.Click += edit_fm_search_Click;
               // 
               // dataGridView1
               // 
               dataGridView1.BackgroundColor = SystemColors.ControlLight;
               dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               dataGridView1.GridColor = SystemColors.Menu;
               dataGridView1.Location = new Point(34, 62);
               dataGridView1.Name = "dataGridView1";
               dataGridView1.RowHeadersWidth = 62;
               dataGridView1.Size = new Size(1086, 197);
               dataGridView1.TabIndex = 1;
               dataGridView1.CellContentClick += dataGridView1_CellContentClick;
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.BackColor = Color.White;
               label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
               label1.ForeColor = Color.FromArgb(92, 7, 49);
               label1.Location = new Point(465, 17);
               label1.Name = "label1";
               label1.Size = new Size(261, 42);
               label1.TabIndex = 0;
               label1.Text = "Select flight to book";
               // 
               // bigLabel1
               // 
               bigLabel1.AutoSize = true;
               bigLabel1.BackColor = Color.Transparent;
               bigLabel1.Font = new Font("Poppins ExtraBold", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
               bigLabel1.ForeColor = Color.White;
               bigLabel1.Location = new Point(400, 44);
               bigLabel1.Name = "bigLabel1";
               bigLabel1.Size = new Size(410, 123);
               bigLabel1.TabIndex = 5;
               bigLabel1.Text = "Book Seat";
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
               panel1.Controls.Add(f_reload);
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
               // f_reload
               // 
               f_reload.ActiveControl = null;
               f_reload.BackColor = Color.White;
               f_reload.Controls.Add(pictureBox2);
               f_reload.Cursor = Cursors.Hand;
               f_reload.Font = new Font("Poppins Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
               f_reload.ForeColor = Color.FromArgb(92, 7, 49);
               f_reload.Location = new Point(1060, 171);
               f_reload.Margin = new Padding(2);
               f_reload.Name = "f_reload";
               f_reload.Size = new Size(71, 38);
               f_reload.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
               f_reload.TabIndex = 15;
               f_reload.Text = " ";
               f_reload.TextAlign = ContentAlignment.BottomCenter;
               f_reload.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
               f_reload.TileImageAlign = ContentAlignment.MiddleCenter;
               f_reload.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
               f_reload.UseCustomBackColor = true;
               f_reload.UseCustomForeColor = true;
               f_reload.UseSelectable = true;
               f_reload.UseStyleColors = true;
               f_reload.UseTileImage = true;
               f_reload.UseVisualStyleBackColor = false;
               f_reload.Click += f_reload_Click;
               // 
               // pictureBox2
               // 
               pictureBox2.Enabled = false;
               pictureBox2.Image = Properties.Resources.reload;
               pictureBox2.Location = new Point(13, 0);
               pictureBox2.Name = "pictureBox2";
               pictureBox2.Size = new Size(46, 38);
               pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
               pictureBox2.TabIndex = 15;
               pictureBox2.TabStop = false;
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
               // userPanel_booking
               // 
               AutoScaleDimensions = new SizeF(10F, 25F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(1154, 737);
               Controls.Add(panel1);
               Icon = (Icon)resources.GetObject("$this.Icon");
               MaximizeBox = false;
               Name = "userPanel_booking";
               StartPosition = FormStartPosition.CenterScreen;
               Text = "Book Seat";
               Load += userPanel_booking_Load;
               panel2.ResumeLayout(false);
               panel2.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
               panel1.ResumeLayout(false);
               panel1.PerformLayout();
               f_reload.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
               ResumeLayout(false);
          }

          #endregion

          private Panel panel2;
        private Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button edit_fm_search;
        private Label label2;
        private ListBox listBox1;
          private Label BussinessFair;
          private Label economyFair;
          private Label label4;
          private Label label3;
          private ReaLTaiizor.Controls.PoisonTile f_reload;
          private PictureBox pictureBox2;
          private Label label5;
          private Label AvailableSeats;
          private Label AviateBussinessSeats;
          private Label label7;
     }
}