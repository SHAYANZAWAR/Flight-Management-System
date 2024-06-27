namespace FMS.SubUtills
{
     partial class VerifyOTPForm
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
               materialTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
               VerifyOTPHeading = new Label();
               VerifyButton = new Button();
               pictureBox1 = new PictureBox();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
               SuspendLayout();
               // 
               // materialTextBoxEdit1
               // 
               materialTextBoxEdit1.AnimateReadOnly = false;
               materialTextBoxEdit1.AutoCompleteMode = AutoCompleteMode.None;
               materialTextBoxEdit1.AutoCompleteSource = AutoCompleteSource.None;
               materialTextBoxEdit1.BackgroundImageLayout = ImageLayout.None;
               materialTextBoxEdit1.CharacterCasing = CharacterCasing.Normal;
               materialTextBoxEdit1.Depth = 0;
               materialTextBoxEdit1.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
               materialTextBoxEdit1.HideSelection = true;
               materialTextBoxEdit1.LeadingIcon = null;
               materialTextBoxEdit1.Location = new Point(250, 89);
               materialTextBoxEdit1.Margin = new Padding(2, 2, 2, 2);
               materialTextBoxEdit1.MaxLength = 8;
               materialTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
               materialTextBoxEdit1.Name = "materialTextBoxEdit1";
               materialTextBoxEdit1.PasswordChar = '\0';
               materialTextBoxEdit1.PrefixSuffixText = null;
               materialTextBoxEdit1.ReadOnly = false;
               materialTextBoxEdit1.RightToLeft = RightToLeft.No;
               materialTextBoxEdit1.SelectedText = "";
               materialTextBoxEdit1.SelectionLength = 0;
               materialTextBoxEdit1.SelectionStart = 0;
               materialTextBoxEdit1.ShortcutsEnabled = true;
               materialTextBoxEdit1.Size = new Size(206, 48);
               materialTextBoxEdit1.TabIndex = 1;
               materialTextBoxEdit1.TabStop = false;
               materialTextBoxEdit1.Text = "Enter OTP here...";
               materialTextBoxEdit1.TextAlign = HorizontalAlignment.Left;
               materialTextBoxEdit1.TrailingIcon = null;
               materialTextBoxEdit1.UseSystemPasswordChar = false;
               // 
               // VerifyOTPHeading
               // 
               VerifyOTPHeading.AutoSize = true;
               VerifyOTPHeading.Font = new Font("Poppins ExtraBold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
               VerifyOTPHeading.ForeColor = Color.FromArgb(92, 7, 49);
               VerifyOTPHeading.Location = new Point(260, 28);
               VerifyOTPHeading.Margin = new Padding(2, 0, 2, 0);
               VerifyOTPHeading.Name = "VerifyOTPHeading";
               VerifyOTPHeading.Size = new Size(183, 53);
               VerifyOTPHeading.TabIndex = 1;
               VerifyOTPHeading.Text = "Verify OTP";
               // 
               // VerifyButton
               // 
               VerifyButton.BackColor = Color.FromArgb(92, 7, 49);
               VerifyButton.Cursor = Cursors.Hand;
               VerifyButton.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
               VerifyButton.ForeColor = SystemColors.ButtonHighlight;
               VerifyButton.Location = new Point(314, 141);
               VerifyButton.Margin = new Padding(2, 2, 2, 2);
               VerifyButton.Name = "VerifyButton";
               VerifyButton.Size = new Size(78, 30);
               VerifyButton.TabIndex = 9;
               VerifyButton.Text = "Verify";
               VerifyButton.UseVisualStyleBackColor = false;
               VerifyButton.Click += VerifyButton_Click;
               // 
               // pictureBox1
               // 
               pictureBox1.Image = Properties.Resources.verifyOTP;
               pictureBox1.Location = new Point(-1, 0);
               pictureBox1.Margin = new Padding(2, 2, 2, 2);
               pictureBox1.Name = "pictureBox1";
               pictureBox1.Size = new Size(228, 206);
               pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
               pictureBox1.TabIndex = 10;
               pictureBox1.TabStop = false;
               // 
               // VerifyOTPForm
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               BackColor = Color.White;
               ClientSize = new Size(475, 206);
               Controls.Add(pictureBox1);
               Controls.Add(VerifyButton);
               Controls.Add(VerifyOTPHeading);
               Controls.Add(materialTextBoxEdit1);
               Margin = new Padding(2, 2, 2, 2);
               Name = "VerifyOTPForm";
               Text = "VerifyOTPForm";
               ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
          private Label VerifyOTPHeading;
          private Button VerifyButton;
          private PictureBox pictureBox1;
     }
}