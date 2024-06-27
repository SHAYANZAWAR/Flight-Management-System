using System.Windows.Forms;

namespace FMS.AdminPanels
{
    partial class ad_fm
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
          /// </summary>
          private void InitializeComponent()
          {
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ad_fm));
               pictureBox1 = new PictureBox();
               button2 = new Button();
               bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
               panel1 = new Panel();
               f_reload = new ReaLTaiizor.Controls.PoisonTile();
               pictureBox2 = new PictureBox();
               reload = new ReaLTaiizor.Controls.PoisonTile();
               tabPage1 = new TabPage();
               panel8 = new Panel();
               dataGridView1 = new DataGridView();
               panel7 = new Panel();
               label7 = new Label();
               search_fm_searchButton = new Button();
               search_fm_flightID = new ReaLTaiizor.Controls.DreamTextBox();
               label15 = new Label();
               tabPage2 = new TabPage();
               FlightsDataGrid = new DataGridView();
               panel2 = new Panel();
               RescheduleArrivalTime = new DateTimePicker();
               RescheduleDeptTime = new DateTimePicker();
               RescheduleArrivalDate = new ReaLTaiizor.Controls.PoisonDateTime();
               RescheduleStatus = new ReaLTaiizor.Controls.DreamTextBox();
               rescheduleDeptDate = new ReaLTaiizor.Controls.PoisonDateTime();
               label1 = new Label();
               label2 = new Label();
               button1 = new Button();
               label3 = new Label();
               create_user = new TabPage();
               Aircrafts = new ListBox();
               panel4 = new Panel();
               f_arrival_time = new DateTimePicker();
               f_dept_time = new DateTimePicker();
               f_arrivalTime = new ReaLTaiizor.Controls.PoisonDateTime();
               AircraftModel = new ReaLTaiizor.Controls.DreamTextBox();
               f_status = new ReaLTaiizor.Controls.DreamTextBox();
               f_deptTime = new ReaLTaiizor.Controls.PoisonDateTime();
               label13 = new Label();
               label12 = new Label();
               create_fm_button = new Button();
               f_ArrivalAirport = new ReaLTaiizor.Controls.DreamTextBox();
               f_deptAirport = new ReaLTaiizor.Controls.DreamTextBox();
               label8 = new Label();
               dungeonTabPage1 = new ReaLTaiizor.Controls.DungeonTabPage();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
               panel1.SuspendLayout();
               f_reload.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
               tabPage1.SuspendLayout();
               panel8.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
               panel7.SuspendLayout();
               tabPage2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)FlightsDataGrid).BeginInit();
               panel2.SuspendLayout();
               create_user.SuspendLayout();
               panel4.SuspendLayout();
               dungeonTabPage1.SuspendLayout();
               SuspendLayout();
               // 
               // pictureBox1
               // 
               pictureBox1.Image = Properties.Resources._884510a2d764ce27643bcca063c1855e1;
               pictureBox1.Location = new Point(1, 1);
               pictureBox1.Margin = new Padding(1, 1, 1, 1);
               pictureBox1.Name = "pictureBox1";
               pictureBox1.Size = new Size(218, 137);
               pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
               pictureBox1.TabIndex = 0;
               pictureBox1.TabStop = false;
               // 
               // button2
               // 
               button2.BackColor = Color.FromArgb(92, 7, 49);
               button2.Font = new Font("Segoe UI", 12F);
               button2.ForeColor = SystemColors.ButtonFace;
               button2.Location = new Point(11, 12);
               button2.Margin = new Padding(1, 1, 1, 1);
               button2.Name = "button2";
               button2.Size = new Size(38, 31);
               button2.TabIndex = 4;
               button2.Text = "🔙";
               button2.UseVisualStyleBackColor = false;
               button2.Click += button2_Click;
               // 
               // bigLabel1
               // 
               bigLabel1.AutoSize = true;
               bigLabel1.BackColor = Color.Transparent;
               bigLabel1.Font = new Font("Poppins ExtraBold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
               bigLabel1.ForeColor = Color.White;
               bigLabel1.Location = new Point(228, 35);
               bigLabel1.Margin = new Padding(1, 0, 1, 0);
               bigLabel1.Name = "bigLabel1";
               bigLabel1.Size = new Size(412, 70);
               bigLabel1.TabIndex = 5;
               bigLabel1.Text = "Flight Managment";
               // 
               // panel1
               // 
               panel1.BackColor = Color.FromArgb(92, 7, 49);
               panel1.Controls.Add(f_reload);
               panel1.Controls.Add(reload);
               panel1.Controls.Add(bigLabel1);
               panel1.Controls.Add(button2);
               panel1.Controls.Add(pictureBox1);
               panel1.Dock = DockStyle.Fill;
               panel1.Location = new Point(0, 0);
               panel1.Margin = new Padding(1, 1, 1, 1);
               panel1.Name = "panel1";
               panel1.Size = new Size(792, 409);
               panel1.TabIndex = 4;
               // 
               // f_reload
               // 
               f_reload.ActiveControl = null;
               f_reload.BackColor = Color.White;
               f_reload.Controls.Add(pictureBox2);
               f_reload.Cursor = Cursors.Hand;
               f_reload.Font = new Font("Poppins Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
               f_reload.ForeColor = Color.FromArgb(92, 7, 49);
               f_reload.Location = new Point(734, 95);
               f_reload.Margin = new Padding(1, 1, 1, 1);
               f_reload.Name = "f_reload";
               f_reload.Size = new Size(50, 23);
               f_reload.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
               f_reload.TabIndex = 14;
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
               pictureBox2.Location = new Point(9, 0);
               pictureBox2.Margin = new Padding(2, 2, 2, 2);
               pictureBox2.Name = "pictureBox2";
               pictureBox2.Size = new Size(32, 23);
               pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
               pictureBox2.TabIndex = 15;
               pictureBox2.TabStop = false;
               // 
               // reload
               // 
               reload.ActiveControl = null;
               reload.BackColor = Color.White;
               reload.Cursor = Cursors.Hand;
               reload.Font = new Font("Poppins Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
               reload.ForeColor = Color.FromArgb(92, 7, 49);
               reload.Location = new Point(371, 193);
               reload.Margin = new Padding(1, 1, 1, 1);
               reload.Name = "reload";
               reload.Size = new Size(50, 23);
               reload.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
               reload.TabIndex = 10;
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
               // tabPage1
               // 
               tabPage1.BackColor = Color.FromArgb(247, 246, 246);
               tabPage1.Controls.Add(panel8);
               tabPage1.Controls.Add(panel7);
               tabPage1.Location = new Point(4, 28);
               tabPage1.Margin = new Padding(1, 1, 1, 1);
               tabPage1.Name = "tabPage1";
               tabPage1.Padding = new Padding(1, 1, 1, 1);
               tabPage1.Size = new Size(791, 276);
               tabPage1.TabIndex = 2;
               tabPage1.Text = "Search";
               // 
               // panel8
               // 
               panel8.Controls.Add(dataGridView1);
               panel8.Location = new Point(412, 31);
               panel8.Margin = new Padding(1, 1, 1, 1);
               panel8.Name = "panel8";
               panel8.Size = new Size(351, 227);
               panel8.TabIndex = 12;
               // 
               // dataGridView1
               // 
               dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               dataGridView1.Location = new Point(1, 1);
               dataGridView1.Margin = new Padding(1, 1, 1, 1);
               dataGridView1.Name = "dataGridView1";
               dataGridView1.RowHeadersWidth = 62;
               dataGridView1.Size = new Size(349, 222);
               dataGridView1.TabIndex = 0;
               // 
               // panel7
               // 
               panel7.BorderStyle = BorderStyle.FixedSingle;
               panel7.Controls.Add(label7);
               panel7.Controls.Add(search_fm_searchButton);
               panel7.Controls.Add(search_fm_flightID);
               panel7.Controls.Add(label15);
               panel7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 5);
               panel7.Location = new Point(71, 61);
               panel7.Margin = new Padding(1, 1, 1, 1);
               panel7.Name = "panel7";
               panel7.Size = new Size(302, 179);
               panel7.TabIndex = 14;
               // 
               // label7
               // 
               label7.AutoSize = true;
               label7.Location = new Point(14, 49);
               label7.Margin = new Padding(1, 0, 1, 0);
               label7.Name = "label7";
               label7.Size = new Size(121, 15);
               label7.TabIndex = 11;
               label7.Text = "Fill any field to search";
               // 
               // search_fm_searchButton
               // 
               search_fm_searchButton.BackColor = Color.FromArgb(92, 7, 49);
               search_fm_searchButton.Font = new Font("Poppins", 10F);
               search_fm_searchButton.ForeColor = Color.White;
               search_fm_searchButton.Location = new Point(76, 121);
               search_fm_searchButton.Margin = new Padding(1, 1, 1, 1);
               search_fm_searchButton.Name = "search_fm_searchButton";
               search_fm_searchButton.Size = new Size(141, 23);
               search_fm_searchButton.TabIndex = 7;
               search_fm_searchButton.Text = "Search";
               search_fm_searchButton.UseVisualStyleBackColor = false;
               // 
               // search_fm_flightID
               // 
               search_fm_flightID.BackColor = Color.White;
               search_fm_flightID.BorderStyle = BorderStyle.FixedSingle;
               search_fm_flightID.ColorA = Color.FromArgb(31, 31, 31);
               search_fm_flightID.ColorB = Color.FromArgb(41, 41, 41);
               search_fm_flightID.ColorC = Color.FromArgb(51, 51, 51);
               search_fm_flightID.ColorD = Color.FromArgb(0, 0, 0, 0);
               search_fm_flightID.ColorE = Color.FromArgb(25, 255, 255, 255);
               search_fm_flightID.ColorF = Color.Black;
               search_fm_flightID.ForeColor = Color.FromArgb(0, 0, 0);
               search_fm_flightID.Location = new Point(14, 73);
               search_fm_flightID.Margin = new Padding(1, 1, 1, 1);
               search_fm_flightID.Name = "search_fm_flightID";
               search_fm_flightID.PlaceholderText = " Flight ID";
               search_fm_flightID.Size = new Size(281, 23);
               search_fm_flightID.TabIndex = 2;
               // 
               // label15
               // 
               label15.AutoSize = true;
               label15.Font = new Font("Poppins", 15F);
               label15.Location = new Point(92, 7);
               label15.Margin = new Padding(1, 0, 1, 0);
               label15.Name = "label15";
               label15.Size = new Size(144, 35);
               label15.TabIndex = 0;
               label15.Text = "Search Flight";
               // 
               // tabPage2
               // 
               tabPage2.BackColor = Color.FromArgb(247, 246, 246);
               tabPage2.Controls.Add(FlightsDataGrid);
               tabPage2.Controls.Add(panel2);
               tabPage2.Location = new Point(4, 28);
               tabPage2.Margin = new Padding(1, 1, 1, 1);
               tabPage2.Name = "tabPage2";
               tabPage2.Padding = new Padding(1, 1, 1, 1);
               tabPage2.Size = new Size(791, 276);
               tabPage2.TabIndex = 1;
               tabPage2.Text = "Edit";
               // 
               // FlightsDataGrid
               // 
               FlightsDataGrid.BackgroundColor = Color.FromArgb(247, 246, 246);
               FlightsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               FlightsDataGrid.Location = new Point(381, 3);
               FlightsDataGrid.Margin = new Padding(2, 2, 2, 2);
               FlightsDataGrid.Name = "FlightsDataGrid";
               FlightsDataGrid.RowHeadersWidth = 62;
               FlightsDataGrid.Size = new Size(409, 268);
               FlightsDataGrid.TabIndex = 6;
               FlightsDataGrid.CellContentClick += FlightsDataGrid_CellContentClick;
               // 
               // panel2
               // 
               panel2.BorderStyle = BorderStyle.FixedSingle;
               panel2.Controls.Add(RescheduleArrivalTime);
               panel2.Controls.Add(RescheduleDeptTime);
               panel2.Controls.Add(RescheduleArrivalDate);
               panel2.Controls.Add(RescheduleStatus);
               panel2.Controls.Add(rescheduleDeptDate);
               panel2.Controls.Add(label1);
               panel2.Controls.Add(label2);
               panel2.Controls.Add(button1);
               panel2.Controls.Add(label3);
               panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 5);
               panel2.Location = new Point(76, 8);
               panel2.Margin = new Padding(1, 1, 1, 1);
               panel2.Name = "panel2";
               panel2.Size = new Size(302, 259);
               panel2.TabIndex = 5;
               // 
               // RescheduleArrivalTime
               // 
               RescheduleArrivalTime.Format = DateTimePickerFormat.Time;
               RescheduleArrivalTime.Location = new Point(228, 107);
               RescheduleArrivalTime.Margin = new Padding(2, 2, 2, 2);
               RescheduleArrivalTime.Name = "RescheduleArrivalTime";
               RescheduleArrivalTime.ShowUpDown = true;
               RescheduleArrivalTime.Size = new Size(68, 23);
               RescheduleArrivalTime.TabIndex = 19;
               // 
               // RescheduleDeptTime
               // 
               RescheduleDeptTime.Format = DateTimePickerFormat.Time;
               RescheduleDeptTime.Location = new Point(228, 80);
               RescheduleDeptTime.Margin = new Padding(2, 2, 2, 2);
               RescheduleDeptTime.Name = "RescheduleDeptTime";
               RescheduleDeptTime.ShowUpDown = true;
               RescheduleDeptTime.Size = new Size(68, 23);
               RescheduleDeptTime.TabIndex = 18;
               // 
               // RescheduleArrivalDate
               // 
               RescheduleArrivalDate.CustomFormat = "MM/dd/yyyy";
               RescheduleArrivalDate.Format = DateTimePickerFormat.Short;
               RescheduleArrivalDate.Location = new Point(127, 107);
               RescheduleArrivalDate.Margin = new Padding(2, 2, 2, 2);
               RescheduleArrivalDate.MinimumSize = new Size(4, 29);
               RescheduleArrivalDate.Name = "RescheduleArrivalDate";
               RescheduleArrivalDate.Size = new Size(98, 29);
               RescheduleArrivalDate.TabIndex = 17;
               // 
               // RescheduleStatus
               // 
               RescheduleStatus.BackColor = Color.White;
               RescheduleStatus.BorderStyle = BorderStyle.FixedSingle;
               RescheduleStatus.ColorA = Color.FromArgb(31, 31, 31);
               RescheduleStatus.ColorB = Color.FromArgb(41, 41, 41);
               RescheduleStatus.ColorC = Color.FromArgb(51, 51, 51);
               RescheduleStatus.ColorD = Color.FromArgb(0, 0, 0, 0);
               RescheduleStatus.ColorE = Color.FromArgb(25, 255, 255, 255);
               RescheduleStatus.ColorF = Color.Black;
               RescheduleStatus.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               RescheduleStatus.ForeColor = Color.Black;
               RescheduleStatus.Location = new Point(11, 157);
               RescheduleStatus.Margin = new Padding(1, 1, 1, 1);
               RescheduleStatus.Name = "RescheduleStatus";
               RescheduleStatus.PlaceholderText = " Status";
               RescheduleStatus.Size = new Size(281, 25);
               RescheduleStatus.TabIndex = 15;
               // 
               // rescheduleDeptDate
               // 
               rescheduleDeptDate.CustomFormat = "MM/dd/yyyy";
               rescheduleDeptDate.Format = DateTimePickerFormat.Short;
               rescheduleDeptDate.Location = new Point(127, 80);
               rescheduleDeptDate.Margin = new Padding(2, 2, 2, 2);
               rescheduleDeptDate.MinimumSize = new Size(4, 29);
               rescheduleDeptDate.Name = "rescheduleDeptDate";
               rescheduleDeptDate.Size = new Size(98, 29);
               rescheduleDeptDate.TabIndex = 13;
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               label1.Location = new Point(11, 110);
               label1.Margin = new Padding(2, 0, 2, 0);
               label1.Name = "label1";
               label1.Size = new Size(81, 21);
               label1.TabIndex = 12;
               label1.Text = "Arrival Time:";
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               label2.Location = new Point(11, 82);
               label2.Margin = new Padding(2, 0, 2, 0);
               label2.Name = "label2";
               label2.Size = new Size(102, 21);
               label2.TabIndex = 11;
               label2.Text = "Departure Time:";
               // 
               // button1
               // 
               button1.BackColor = Color.FromArgb(92, 7, 49);
               button1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
               button1.ForeColor = Color.White;
               button1.Location = new Point(77, 202);
               button1.Margin = new Padding(1, 1, 1, 1);
               button1.Name = "button1";
               button1.Size = new Size(153, 27);
               button1.TabIndex = 10;
               button1.Text = "Reschedule";
               button1.UseVisualStyleBackColor = false;
               button1.Click += button1_Click_1;
               // 
               // label3
               // 
               label3.AutoSize = true;
               label3.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
               label3.ForeColor = Color.FromArgb(92, 7, 49);
               label3.Location = new Point(55, 9);
               label3.Margin = new Padding(1, 0, 1, 0);
               label3.Name = "label3";
               label3.Size = new Size(198, 35);
               label3.TabIndex = 0;
               label3.Text = "Reschedule Flight";
               // 
               // create_user
               // 
               create_user.BackColor = Color.FromArgb(247, 246, 246);
               create_user.Controls.Add(Aircrafts);
               create_user.Controls.Add(panel4);
               create_user.Font = new Font("Poppins", 10F);
               create_user.Location = new Point(4, 28);
               create_user.Margin = new Padding(1, 1, 1, 1);
               create_user.Name = "create_user";
               create_user.Padding = new Padding(1, 1, 1, 1);
               create_user.Size = new Size(791, 276);
               create_user.TabIndex = 0;
               create_user.Text = "Create";
               // 
               // Aircrafts
               // 
               Aircrafts.Dock = DockStyle.Right;
               Aircrafts.FormattingEnabled = true;
               Aircrafts.ItemHeight = 23;
               Aircrafts.Location = new Point(663, 1);
               Aircrafts.Margin = new Padding(2, 2, 2, 2);
               Aircrafts.Name = "Aircrafts";
               Aircrafts.Size = new Size(127, 274);
               Aircrafts.TabIndex = 4;
               Aircrafts.SelectedIndexChanged += Aircrafts_SelectedIndexChanged;
               // 
               // panel4
               // 
               panel4.BorderStyle = BorderStyle.FixedSingle;
               panel4.Controls.Add(f_arrival_time);
               panel4.Controls.Add(f_dept_time);
               panel4.Controls.Add(f_arrivalTime);
               panel4.Controls.Add(AircraftModel);
               panel4.Controls.Add(f_status);
               panel4.Controls.Add(f_deptTime);
               panel4.Controls.Add(label13);
               panel4.Controls.Add(label12);
               panel4.Controls.Add(create_fm_button);
               panel4.Controls.Add(f_ArrivalAirport);
               panel4.Controls.Add(f_deptAirport);
               panel4.Controls.Add(label8);
               panel4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 5);
               panel4.Location = new Point(259, 8);
               panel4.Margin = new Padding(1, 1, 1, 1);
               panel4.Name = "panel4";
               panel4.Size = new Size(302, 259);
               panel4.TabIndex = 3;
               // 
               // f_arrival_time
               // 
               f_arrival_time.Format = DateTimePickerFormat.Time;
               f_arrival_time.Location = new Point(228, 130);
               f_arrival_time.Margin = new Padding(2, 2, 2, 2);
               f_arrival_time.Name = "f_arrival_time";
               f_arrival_time.ShowUpDown = true;
               f_arrival_time.Size = new Size(68, 23);
               f_arrival_time.TabIndex = 19;
               // 
               // f_dept_time
               // 
               f_dept_time.Format = DateTimePickerFormat.Time;
               f_dept_time.Location = new Point(228, 103);
               f_dept_time.Margin = new Padding(2, 2, 2, 2);
               f_dept_time.Name = "f_dept_time";
               f_dept_time.ShowUpDown = true;
               f_dept_time.Size = new Size(68, 23);
               f_dept_time.TabIndex = 18;
               // 
               // f_arrivalTime
               // 
               f_arrivalTime.CustomFormat = "MM/dd/yyyy";
               f_arrivalTime.Format = DateTimePickerFormat.Short;
               f_arrivalTime.Location = new Point(127, 130);
               f_arrivalTime.Margin = new Padding(2, 2, 2, 2);
               f_arrivalTime.MinimumSize = new Size(0, 29);
               f_arrivalTime.Name = "f_arrivalTime";
               f_arrivalTime.Size = new Size(98, 29);
               f_arrivalTime.TabIndex = 17;
               f_arrivalTime.ValueChanged += f_arrivalTime_ValueChanged_1;
               // 
               // AircraftModel
               // 
               AircraftModel.BackColor = Color.White;
               AircraftModel.BorderStyle = BorderStyle.FixedSingle;
               AircraftModel.ColorA = Color.FromArgb(31, 31, 31);
               AircraftModel.ColorB = Color.FromArgb(41, 41, 41);
               AircraftModel.ColorC = Color.FromArgb(51, 51, 51);
               AircraftModel.ColorD = Color.FromArgb(0, 0, 0, 0);
               AircraftModel.ColorE = Color.FromArgb(25, 255, 255, 255);
               AircraftModel.ColorF = Color.Black;
               AircraftModel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               AircraftModel.ForeColor = Color.Black;
               AircraftModel.Location = new Point(11, 160);
               AircraftModel.Margin = new Padding(1, 1, 1, 1);
               AircraftModel.Name = "AircraftModel";
               AircraftModel.PlaceholderText = " Aircraft Model";
               AircraftModel.Size = new Size(281, 25);
               AircraftModel.TabIndex = 16;
               AircraftModel.TextChanged += AircraftModel_TextChanged;
               // 
               // f_status
               // 
               f_status.BackColor = Color.White;
               f_status.BorderStyle = BorderStyle.FixedSingle;
               f_status.ColorA = Color.FromArgb(31, 31, 31);
               f_status.ColorB = Color.FromArgb(41, 41, 41);
               f_status.ColorC = Color.FromArgb(51, 51, 51);
               f_status.ColorD = Color.FromArgb(0, 0, 0, 0);
               f_status.ColorE = Color.FromArgb(25, 255, 255, 255);
               f_status.ColorF = Color.Black;
               f_status.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               f_status.ForeColor = Color.Black;
               f_status.Location = new Point(11, 192);
               f_status.Margin = new Padding(1, 1, 1, 1);
               f_status.Name = "f_status";
               f_status.PlaceholderText = " Status";
               f_status.Size = new Size(281, 25);
               f_status.TabIndex = 15;
               f_status.TextChanged += f_status_TextChanged;
               // 
               // f_deptTime
               // 
               f_deptTime.CustomFormat = "MM/dd/yyyy";
               f_deptTime.Format = DateTimePickerFormat.Short;
               f_deptTime.Location = new Point(127, 103);
               f_deptTime.Margin = new Padding(2, 2, 2, 2);
               f_deptTime.MinimumSize = new Size(0, 29);
               f_deptTime.Name = "f_deptTime";
               f_deptTime.Size = new Size(98, 29);
               f_deptTime.TabIndex = 13;
               f_deptTime.ValueChanged += f_deptTime_ValueChanged;
               // 
               // label13
               // 
               label13.AutoSize = true;
               label13.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               label13.Location = new Point(11, 133);
               label13.Margin = new Padding(2, 0, 2, 0);
               label13.Name = "label13";
               label13.Size = new Size(81, 21);
               label13.TabIndex = 12;
               label13.Text = "Arrival Time:";
               // 
               // label12
               // 
               label12.AutoSize = true;
               label12.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               label12.Location = new Point(11, 105);
               label12.Margin = new Padding(2, 0, 2, 0);
               label12.Name = "label12";
               label12.Size = new Size(102, 21);
               label12.TabIndex = 11;
               label12.Text = "Departure Time:";
               // 
               // create_fm_button
               // 
               create_fm_button.BackColor = Color.FromArgb(92, 7, 49);
               create_fm_button.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
               create_fm_button.ForeColor = Color.White;
               create_fm_button.Location = new Point(74, 223);
               create_fm_button.Margin = new Padding(1, 1, 1, 1);
               create_fm_button.Name = "create_fm_button";
               create_fm_button.Size = new Size(153, 27);
               create_fm_button.TabIndex = 10;
               create_fm_button.Text = "Create";
               create_fm_button.UseVisualStyleBackColor = false;
               create_fm_button.Click += create_fm_button_Click;
               // 
               // f_ArrivalAirport
               // 
               f_ArrivalAirport.BackColor = Color.White;
               f_ArrivalAirport.BorderStyle = BorderStyle.FixedSingle;
               f_ArrivalAirport.ColorA = Color.FromArgb(31, 31, 31);
               f_ArrivalAirport.ColorB = Color.FromArgb(41, 41, 41);
               f_ArrivalAirport.ColorC = Color.FromArgb(51, 51, 51);
               f_ArrivalAirport.ColorD = Color.FromArgb(0, 0, 0, 0);
               f_ArrivalAirport.ColorE = Color.FromArgb(25, 255, 255, 255);
               f_ArrivalAirport.ColorF = Color.Black;
               f_ArrivalAirport.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               f_ArrivalAirport.ForeColor = Color.Black;
               f_ArrivalAirport.Location = new Point(11, 72);
               f_ArrivalAirport.Margin = new Padding(1, 1, 1, 1);
               f_ArrivalAirport.Name = "f_ArrivalAirport";
               f_ArrivalAirport.PlaceholderText = " Arrival Airport";
               f_ArrivalAirport.Size = new Size(281, 25);
               f_ArrivalAirport.TabIndex = 6;
               f_ArrivalAirport.TextChanged += f_ArrivalAirport_TextChanged;
               // 
               // f_deptAirport
               // 
               f_deptAirport.BackColor = Color.White;
               f_deptAirport.BorderStyle = BorderStyle.FixedSingle;
               f_deptAirport.ColorA = Color.FromArgb(31, 31, 31);
               f_deptAirport.ColorB = Color.FromArgb(41, 41, 41);
               f_deptAirport.ColorC = Color.FromArgb(51, 51, 51);
               f_deptAirport.ColorD = Color.FromArgb(0, 0, 0, 0);
               f_deptAirport.ColorE = Color.FromArgb(25, 255, 255, 255);
               f_deptAirport.ColorF = Color.Black;
               f_deptAirport.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               f_deptAirport.ForeColor = Color.Black;
               f_deptAirport.Location = new Point(11, 42);
               f_deptAirport.Margin = new Padding(1, 1, 1, 1);
               f_deptAirport.Name = "f_deptAirport";
               f_deptAirport.PlaceholderText = " Departure Airport";
               f_deptAirport.Size = new Size(281, 25);
               f_deptAirport.TabIndex = 4;
               f_deptAirport.TextChanged += f_deptAirport_TextChanged;
               // 
               // label8
               // 
               label8.AutoSize = true;
               label8.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
               label8.ForeColor = Color.FromArgb(92, 7, 49);
               label8.Location = new Point(74, 9);
               label8.Margin = new Padding(1, 0, 1, 0);
               label8.Name = "label8";
               label8.Size = new Size(149, 35);
               label8.TabIndex = 0;
               label8.Text = "Create Flight";
               // 
               // dungeonTabPage1
               // 
               dungeonTabPage1.ActivePageBackColor = Color.FromArgb(247, 246, 246);
               dungeonTabPage1.ActivePageBorderColor = Color.FromArgb(201, 198, 195);
               dungeonTabPage1.ActivePageTextColor = Color.FromArgb(80, 76, 76);
               dungeonTabPage1.BaseColor = Color.Transparent;
               dungeonTabPage1.Controls.Add(create_user);
               dungeonTabPage1.Controls.Add(tabPage2);
               dungeonTabPage1.Controls.Add(tabPage1);
               dungeonTabPage1.DeactivePageTextColor = Color.White;
               dungeonTabPage1.Font = new Font("Poppins", 9F);
               dungeonTabPage1.ItemSize = new Size(80, 24);
               dungeonTabPage1.Location = new Point(1, 120);
               dungeonTabPage1.Margin = new Padding(1, 1, 1, 1);
               dungeonTabPage1.Name = "dungeonTabPage1";
               dungeonTabPage1.PageBackColor = Color.FromArgb(247, 246, 246);
               dungeonTabPage1.PageEdgeBorderColor = Color.FromArgb(201, 198, 195);
               dungeonTabPage1.PageEdgeColor = Color.FromArgb(247, 246, 246);
               dungeonTabPage1.SelectedIndex = 0;
               dungeonTabPage1.Size = new Size(799, 308);
               dungeonTabPage1.TabIndex = 5;
               // 
               // ad_fm
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               AutoSizeMode = AutoSizeMode.GrowAndShrink;
               ClientSize = new Size(792, 409);
               Controls.Add(dungeonTabPage1);
               Controls.Add(panel1);
               FormBorderStyle = FormBorderStyle.Fixed3D;
               Icon = (Icon)resources.GetObject("$this.Icon");
               Margin = new Padding(1, 1, 1, 1);
               MaximizeBox = false;
               Name = "ad_fm";
               StartPosition = FormStartPosition.CenterScreen;
               Text = "Flight Managment";
               Load += ad_fm_Load;
               ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
               panel1.ResumeLayout(false);
               panel1.PerformLayout();
               f_reload.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
               tabPage1.ResumeLayout(false);
               panel8.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
               panel7.ResumeLayout(false);
               panel7.PerformLayout();
               tabPage2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)FlightsDataGrid).EndInit();
               panel2.ResumeLayout(false);
               panel2.PerformLayout();
               create_user.ResumeLayout(false);
               panel4.ResumeLayout(false);
               panel4.PerformLayout();
               dungeonTabPage1.ResumeLayout(false);
               ResumeLayout(false);
          }

          #endregion

          private PictureBox pictureBox1;
        private Button button2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Panel panel1;
          private ReaLTaiizor.Controls.PoisonTile reload;
          private ReaLTaiizor.Controls.PoisonTile f_reload;
          private TabPage tabPage1;
          private Panel panel8;
          private DataGridView dataGridView1;
          private Panel panel7;
          private Label label7;
          private Button search_fm_searchButton;
          private ReaLTaiizor.Controls.DreamTextBox search_fm_flightID;
          private Label label15;
          private TabPage tabPage2;
          private TabPage create_user;
          private Panel panel4;
          private ReaLTaiizor.Controls.DreamTextBox f_status;
          private ReaLTaiizor.Controls.PoisonDateTime date;
          private Label label13;
          private Label label12;
          private Button create_fm_button;
          private ReaLTaiizor.Controls.DreamTextBox f_ArrivalAirport;
          private ReaLTaiizor.Controls.DreamTextBox f_deptAirport;
          private Label label8;
          private ReaLTaiizor.Controls.DungeonTabPage dungeonTabPage1;
          private ReaLTaiizor.Controls.DreamTextBox AircraftModel;
          private ListBox Aircrafts;
          private PictureBox pictureBox2;
          private ReaLTaiizor.Controls.PoisonDateTime f_arrivalTime;
          private ReaLTaiizor.Controls.PoisonDateTime f_deptTime;
          private DateTimePicker f_arrival_time;
          private DateTimePicker f_dept_time;
          private Panel panel2;
          private DateTimePicker RescheduleArrivalTime;
          private DateTimePicker RescheduleDeptTime;
          private ReaLTaiizor.Controls.PoisonDateTime RescheduleArrivalDate;
          private ReaLTaiizor.Controls.DreamTextBox RescheduleStatus;
          private ReaLTaiizor.Controls.PoisonDateTime rescheduleDeptDate;
          private Label label1;
          private Label label2;
          private Button button1;
          private Label label3;
          private DataGridView FlightsDataGrid;
     }
}