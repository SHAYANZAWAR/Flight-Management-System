namespace FMS.User_Panels
{
    partial class userPanel_Billing
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userPanel_Billing));
               panel2 = new Panel();
               Message = new Label();
               button1 = new Button();
               label3 = new Label();
               history_up_search = new Button();
               label2 = new Label();
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
               panel2.Controls.Add(Message);
               panel2.Controls.Add(button1);
               panel2.Controls.Add(label3);
               panel2.Controls.Add(history_up_search);
               panel2.Controls.Add(label2);
               panel2.Controls.Add(dataGridView1);
               panel2.Controls.Add(label1);
               panel2.Location = new Point(0, 227);
               panel2.Name = "panel2";
               panel2.Size = new Size(1154, 510);
               panel2.TabIndex = 6;
               // 
               // Message
               // 
               Message.AutoSize = true;
               Message.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
               Message.ForeColor = Color.FromArgb(92, 7, 49);
               Message.Location = new Point(29, 90);
               Message.Name = "Message";
               Message.Size = new Size(18, 32);
               Message.TabIndex = 17;
               Message.Text = " ";
               // 
               // button1
               // 
               button1.BackColor = Color.FromArgb(92, 7, 49);
               button1.Font = new Font("Poppins", 10F);
               button1.ForeColor = Color.White;
               button1.Location = new Point(532, 443);
               button1.Name = "button1";
               button1.Size = new Size(155, 38);
               button1.TabIndex = 16;
               button1.Text = "Pay Now";
               button1.UseVisualStyleBackColor = false;
               button1.Click += button1_Click;
               // 
               // label3
               // 
               label3.AutoSize = true;
               label3.Font = new Font("Poppins", 8F);
               label3.ForeColor = Color.FromArgb(92, 7, 49);
               label3.Location = new Point(549, 329);
               label3.Name = "label3";
               label3.Size = new Size(118, 28);
               label3.TabIndex = 15;
               label3.Text = "Select to Pay ";
               // 
               // history_up_search
               // 
               history_up_search.BackColor = Color.FromArgb(92, 7, 49);
               history_up_search.Font = new Font("Poppins", 10F);
               history_up_search.ForeColor = Color.White;
               history_up_search.Location = new Point(520, 71);
               history_up_search.Name = "history_up_search";
               history_up_search.Size = new Size(155, 38);
               history_up_search.TabIndex = 14;
               history_up_search.Text = "Retrive List";
               history_up_search.UseVisualStyleBackColor = false;
               history_up_search.Click += history_up_search_Click;
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.Font = new Font("Poppins", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
               label2.ForeColor = Color.FromArgb(92, 7, 49);
               label2.Location = new Point(497, 12);
               label2.Name = "label2";
               label2.Size = new Size(204, 56);
               label2.TabIndex = 13;
               label2.Text = "Flight Data";
               // 
               // dataGridView1
               // 
               dataGridView1.BackgroundColor = SystemColors.ControlLight;
               dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               dataGridView1.GridColor = SystemColors.Menu;
               dataGridView1.Location = new Point(29, 125);
               dataGridView1.Name = "dataGridView1";
               dataGridView1.RowHeadersWidth = 62;
               dataGridView1.Size = new Size(1096, 190);
               dataGridView1.TabIndex = 12;
               dataGridView1.CellContentClick += dataGridView1_CellContentClick;
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Location = new Point(497, 327);
               label1.Name = "label1";
               label1.Size = new Size(0, 25);
               label1.TabIndex = 0;
               // 
               // bigLabel1
               // 
               bigLabel1.AutoSize = true;
               bigLabel1.BackColor = Color.Transparent;
               bigLabel1.Font = new Font("Poppins ExtraBold", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
               bigLabel1.ForeColor = Color.White;
               bigLabel1.Location = new Point(352, 52);
               bigLabel1.Name = "bigLabel1";
               bigLabel1.Size = new Size(525, 123);
               bigLabel1.TabIndex = 5;
               bigLabel1.Text = "Bill Payment ";
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
               panel1.TabIndex = 10;
               // 
               // f_reload
               // 
               f_reload.ActiveControl = null;
               f_reload.BackColor = Color.White;
               f_reload.Controls.Add(pictureBox2);
               f_reload.Cursor = Cursors.Hand;
               f_reload.Font = new Font("Poppins Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
               f_reload.ForeColor = Color.FromArgb(92, 7, 49);
               f_reload.Location = new Point(1054, 173);
               f_reload.Margin = new Padding(2);
               f_reload.Name = "f_reload";
               f_reload.Size = new Size(71, 38);
               f_reload.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
               f_reload.TabIndex = 17;
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
               // userPanel_Billing
               // 
               AutoScaleDimensions = new SizeF(10F, 25F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(1154, 737);
               Controls.Add(panel1);
               Icon = (Icon)resources.GetObject("$this.Icon");
               MaximizeBox = false;
               Name = "userPanel_Billing";
               StartPosition = FormStartPosition.CenterParent;
               Text = "Billing";
               Load += userPanel_Billing_Load;
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
        private Button button1;
        private Label label3;
        private Button history_up_search;
        private Label label2;
        private DataGridView dataGridView1;
          private ReaLTaiizor.Controls.PoisonTile f_reload;
          private PictureBox pictureBox2;
          private Label Message;
     }
}