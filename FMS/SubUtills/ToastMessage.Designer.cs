namespace FMS.SubUtills
{
     partial class ToastMessage
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
               toastBorder = new Panel();
               typeLabel = new Label();
               messageLabel = new Label();
               toastImage = new PictureBox();
               toastAnimationTimer = new System.Windows.Forms.Timer(components);
               toastHideTimer = new System.Windows.Forms.Timer(components);
               ((System.ComponentModel.ISupportInitialize)toastImage).BeginInit();
               SuspendLayout();
               // 
               // toastBorder
               // 
               toastBorder.BackColor = Color.FromArgb(57, 155, 53);
               toastBorder.Location = new Point(-4, 0);
               toastBorder.Margin = new Padding(4, 5, 4, 5);
               toastBorder.Name = "toastBorder";
               toastBorder.Size = new Size(14, 117);
               toastBorder.TabIndex = 0;
               // 
               // typeLabel
               // 
               typeLabel.AutoSize = true;
               typeLabel.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
               typeLabel.Location = new Point(100, 9);
               typeLabel.Margin = new Padding(4, 0, 4, 0);
               typeLabel.Name = "typeLabel";
               typeLabel.Size = new Size(65, 35);
               typeLabel.TabIndex = 1;
               typeLabel.Text = "Type";
               
               // 
               // messageLabel
               // 
               messageLabel.AutoSize = true;
               messageLabel.Font = new Font("Poppins Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
               messageLabel.Location = new Point(100, 43);
               messageLabel.Margin = new Padding(4, 0, 4, 0);
               messageLabel.Name = "messageLabel";
               messageLabel.Size = new Size(77, 28);
               messageLabel.TabIndex = 2;
               messageLabel.Text = "Success";
               
               // 
               // toastImage
               // 
               toastImage.Image = Properties.Resources.system_regular_56_warning;
               toastImage.Location = new Point(38, 16);
               toastImage.Margin = new Padding(4, 5, 4, 5);
               toastImage.Name = "toastImage";
               toastImage.Size = new Size(54, 43);
               toastImage.SizeMode = PictureBoxSizeMode.Zoom;
               toastImage.TabIndex = 3;
               toastImage.TabStop = false;
               // 
               // toastAnimationTimer
               // 
               toastAnimationTimer.Enabled = true;
               toastAnimationTimer.Interval = 10;
               toastAnimationTimer.Tick += toastAnimationTimer_Tick;
               // 
               // toastHideTimer
               // 
               toastHideTimer.Enabled = true;
               toastHideTimer.Interval = 10;
               toastHideTimer.Tick += toastHideTimer_Tick;
               // 
               // ToastMessage
               // 
               AutoScaleDimensions = new SizeF(10F, 25F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(457, 80);
               Controls.Add(toastImage);
               Controls.Add(messageLabel);
               Controls.Add(typeLabel);
               Controls.Add(toastBorder);
               FormBorderStyle = FormBorderStyle.None;
               Margin = new Padding(4, 5, 4, 5);
               Name = "ToastMessage";
               Text = "ToastMessage";
               Load += ToastMessage_Load;
               ((System.ComponentModel.ISupportInitialize)toastImage).EndInit();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Panel toastBorder;
          private Label typeLabel;
          private Label messageLabel;
          private PictureBox toastImage;
          private System.Windows.Forms.Timer toastAnimationTimer;
          private System.Windows.Forms.Timer toastHideTimer;
     }
}