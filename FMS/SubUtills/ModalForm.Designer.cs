namespace FMS.SubUtills
{
     partial class ModalForm
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
               profilePicture = new PictureBox();
               separator = new Panel();
               usernameLabel = new Label();
               profilePicturePicker = new Button();
               SabeButton = new Button();
               usernameTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
               ModalEffect_Timer = new System.Windows.Forms.Timer(components);
               pictureBox2 = new PictureBox();
               EditButton = new Button();
               NameTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
               NameLabel = new Label();
               PhoneNoTextbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
               PhoneNoLabel = new Label();
               ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
               ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
               SuspendLayout();
               // 
               // profilePicture
               // 
               profilePicture.Image = Properties.Resources.noUser;
               profilePicture.Location = new Point(36, 73);
               profilePicture.Name = "profilePicture";
               profilePicture.Size = new Size(280, 280);
               profilePicture.SizeMode = PictureBoxSizeMode.Zoom;
               profilePicture.TabIndex = 0;
               profilePicture.TabStop = false;
               
               // 
               // separator
               // 
               separator.BackColor = Color.FromArgb(92, 7, 49);
               separator.Location = new Point(373, 12);
               separator.Name = "separator";
               separator.Size = new Size(10, 494);
               separator.TabIndex = 1;
               // 
               // usernameLabel
               // 
               usernameLabel.AutoSize = true;
               usernameLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
               usernameLabel.ForeColor = Color.FromArgb(92, 7, 49);
               usernameLabel.Location = new Point(416, 143);
               usernameLabel.Name = "usernameLabel";
               usernameLabel.Size = new Size(145, 42);
               usernameLabel.TabIndex = 4;
               usernameLabel.Text = "Username";
               // 
               // profilePicturePicker
               // 
               profilePicturePicker.BackColor = Color.White;
               profilePicturePicker.Cursor = Cursors.Hand;
               profilePicturePicker.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
               profilePicturePicker.ForeColor = Color.FromArgb(92, 7, 49);
               profilePicturePicker.Location = new Point(120, 377);
               profilePicturePicker.Name = "profilePicturePicker";
               profilePicturePicker.Size = new Size(112, 42);
               profilePicturePicker.TabIndex = 7;
               profilePicturePicker.Text = "Upload";
               profilePicturePicker.UseVisualStyleBackColor = false;
               profilePicturePicker.Click += profilePicturePicker_Click;
               // 
               // SabeButton
               // 
               SabeButton.BackColor = Color.FromArgb(92, 7, 49);
               SabeButton.Cursor = Cursors.Hand;
               SabeButton.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               SabeButton.ForeColor = SystemColors.ButtonHighlight;
               SabeButton.Location = new Point(319, 529);
               SabeButton.Name = "SabeButton";
               SabeButton.Size = new Size(112, 50);
               SabeButton.TabIndex = 8;
               SabeButton.Text = "Save";
               SabeButton.UseVisualStyleBackColor = false;
               SabeButton.Click += SabeButton_Click;
               // 
               // usernameTextBox
               // 
               usernameTextBox.AnimateReadOnly = false;
               usernameTextBox.AutoCompleteMode = AutoCompleteMode.None;
               usernameTextBox.AutoCompleteSource = AutoCompleteSource.None;
               usernameTextBox.BackgroundImageLayout = ImageLayout.None;
               usernameTextBox.CharacterCasing = CharacterCasing.Normal;
               usernameTextBox.Depth = 0;
               usernameTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
               usernameTextBox.HideSelection = true;
               usernameTextBox.LeadingIcon = null;
               usernameTextBox.Location = new Point(416, 176);
               usernameTextBox.MaxLength = 32767;
               usernameTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
               usernameTextBox.Name = "usernameTextBox";
               usernameTextBox.PasswordChar = '\0';
               usernameTextBox.PrefixSuffixText = null;
               usernameTextBox.ReadOnly = false;
               usernameTextBox.RightToLeft = RightToLeft.No;
               usernameTextBox.SelectedText = "";
               usernameTextBox.SelectionLength = 0;
               usernameTextBox.SelectionStart = 0;
               usernameTextBox.ShortcutsEnabled = true;
               usernameTextBox.Size = new Size(200, 48);
               usernameTextBox.TabIndex = 9;
               usernameTextBox.TabStop = false;
               usernameTextBox.Text = "materialTextBoxEdit1";
               usernameTextBox.TextAlign = HorizontalAlignment.Left;
               usernameTextBox.TrailingIcon = null;
               usernameTextBox.UseSystemPasswordChar = false;
               
               // 
               // ModalEffect_Timer
               // 
               ModalEffect_Timer.Enabled = true;
               ModalEffect_Timer.Interval = 1;
               ModalEffect_Timer.Tick += ModalEffect_Timer_Tick;
               // 
               // pictureBox2
               // 
               pictureBox2.Cursor = Cursors.Hand;
               pictureBox2.Image = Properties.Resources.cross;
               pictureBox2.Location = new Point(646, 12);
               pictureBox2.Name = "pictureBox2";
               pictureBox2.Size = new Size(50, 38);
               pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
               pictureBox2.TabIndex = 12;
               pictureBox2.TabStop = false;
               pictureBox2.Click += pictureBox2_Click;
               // 
               // EditButton
               // 
               EditButton.BackColor = Color.White;
               EditButton.Cursor = Cursors.Hand;
               EditButton.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
               EditButton.ForeColor = Color.FromArgb(92, 7, 49);
               EditButton.Location = new Point(449, 363);
               EditButton.Name = "EditButton";
               EditButton.Size = new Size(112, 42);
               EditButton.TabIndex = 13;
               EditButton.Text = "Edit";
               EditButton.UseVisualStyleBackColor = false;
               EditButton.Click += EditButton_Click;
               // 
               // NameTextBox
               // 
               NameTextBox.AnimateReadOnly = false;
               NameTextBox.AutoCompleteMode = AutoCompleteMode.None;
               NameTextBox.AutoCompleteSource = AutoCompleteSource.None;
               NameTextBox.BackgroundImageLayout = ImageLayout.None;
               NameTextBox.CharacterCasing = CharacterCasing.Normal;
               NameTextBox.Depth = 0;
               NameTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
               NameTextBox.HideSelection = true;
               NameTextBox.LeadingIcon = null;
               NameTextBox.Location = new Point(416, 73);
               NameTextBox.MaxLength = 32767;
               NameTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
               NameTextBox.Name = "NameTextBox";
               NameTextBox.PasswordChar = '\0';
               NameTextBox.PrefixSuffixText = null;
               NameTextBox.ReadOnly = false;
               NameTextBox.RightToLeft = RightToLeft.No;
               NameTextBox.SelectedText = "";
               NameTextBox.SelectionLength = 0;
               NameTextBox.SelectionStart = 0;
               NameTextBox.ShortcutsEnabled = true;
               NameTextBox.Size = new Size(200, 48);
               NameTextBox.TabIndex = 15;
               NameTextBox.TabStop = false;
               NameTextBox.Text = "materialTextBoxEdit2";
               NameTextBox.TextAlign = HorizontalAlignment.Left;
               NameTextBox.TrailingIcon = null;
               NameTextBox.UseSystemPasswordChar = false;
               // 
               // NameLabel
               // 
               NameLabel.AutoSize = true;
               NameLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
               NameLabel.ForeColor = Color.FromArgb(92, 7, 49);
               NameLabel.Location = new Point(416, 40);
               NameLabel.Name = "NameLabel";
               NameLabel.Size = new Size(92, 42);
               NameLabel.TabIndex = 14;
               NameLabel.Text = "Name";
               // 
               // PhoneNoTextbox
               // 
               PhoneNoTextbox.AnimateReadOnly = false;
               PhoneNoTextbox.AutoCompleteMode = AutoCompleteMode.None;
               PhoneNoTextbox.AutoCompleteSource = AutoCompleteSource.None;
               PhoneNoTextbox.BackgroundImageLayout = ImageLayout.None;
               PhoneNoTextbox.CharacterCasing = CharacterCasing.Normal;
               PhoneNoTextbox.Depth = 0;
               PhoneNoTextbox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
               PhoneNoTextbox.HideSelection = true;
               PhoneNoTextbox.LeadingIcon = null;
               PhoneNoTextbox.Location = new Point(416, 283);
               PhoneNoTextbox.MaxLength = 32767;
               PhoneNoTextbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
               PhoneNoTextbox.Name = "PhoneNoTextbox";
               PhoneNoTextbox.PasswordChar = '\0';
               PhoneNoTextbox.PrefixSuffixText = null;
               PhoneNoTextbox.ReadOnly = false;
               PhoneNoTextbox.RightToLeft = RightToLeft.No;
               PhoneNoTextbox.SelectedText = "";
               PhoneNoTextbox.SelectionLength = 0;
               PhoneNoTextbox.SelectionStart = 0;
               PhoneNoTextbox.ShortcutsEnabled = true;
               PhoneNoTextbox.Size = new Size(200, 48);
               PhoneNoTextbox.TabIndex = 17;
               PhoneNoTextbox.TabStop = false;
               PhoneNoTextbox.Text = "materialTextBoxEdit3";
               PhoneNoTextbox.TextAlign = HorizontalAlignment.Left;
               PhoneNoTextbox.TrailingIcon = null;
               PhoneNoTextbox.UseSystemPasswordChar = false;
               // 
               // PhoneNoLabel
               // 
               PhoneNoLabel.AutoSize = true;
               PhoneNoLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
               PhoneNoLabel.ForeColor = Color.FromArgb(92, 7, 49);
               PhoneNoLabel.Location = new Point(416, 250);
               PhoneNoLabel.Name = "PhoneNoLabel";
               PhoneNoLabel.Size = new Size(149, 42);
               PhoneNoLabel.TabIndex = 16;
               PhoneNoLabel.Text = "PhoneNo#";
               // 
               // ModalForm
               // 
               AutoScaleDimensions = new SizeF(10F, 25F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(712, 603);
               Controls.Add(PhoneNoTextbox);
               Controls.Add(PhoneNoLabel);
               Controls.Add(NameTextBox);
               Controls.Add(NameLabel);
               Controls.Add(EditButton);
               Controls.Add(pictureBox2);
               Controls.Add(usernameTextBox);
               Controls.Add(SabeButton);
               Controls.Add(profilePicturePicker);
               Controls.Add(usernameLabel);
               Controls.Add(separator);
               Controls.Add(profilePicture);
               FormBorderStyle = FormBorderStyle.None;
               Name = "ModalForm";
               Opacity = 0D;
               StartPosition = FormStartPosition.CenterScreen;
               Text = "ModalForm";
               TransparencyKey = Color.Fuchsia;
               Load += ModalForm_Load;
               ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
               ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private PictureBox profilePicture;
          private Panel separator;
          private ReaLTaiizor.Controls.PoisonContextMenuStrip poisonContextMenuStrip1;
          private ReaLTaiizor.Controls.PoisonContextMenuStrip poisonContextMenuStrip2;
          private Label usernameLabel;
          private Button profilePicturePicker;
          private Button SabeButton;
          private ReaLTaiizor.Controls.MaterialTextBoxEdit usernameTextBox;
          private System.Windows.Forms.Timer ModalEffect_Timer;
          private PictureBox pictureBox2;
          private Button EditButton;
          private ReaLTaiizor.Controls.MaterialTextBoxEdit NameTextBox;
          private Label NameLabel;
          private ReaLTaiizor.Controls.MaterialTextBoxEdit PhoneNoTextbox;
          private Label PhoneNoLabel;
     }
}