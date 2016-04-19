namespace WindowsFormsApplication2
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.Date = new MetroFramework.Controls.MetroTile();
            this.DatePick = new MetroFramework.Controls.MetroDateTime();
            this.okBtn = new MetroFramework.Controls.MetroTile();
            this.doctorPhoneIcon = new MetroFramework.Controls.MetroTile();
            this.docNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.ActiveControl = null;
            this.Date.Enabled = false;
            this.Date.Location = new System.Drawing.Point(136, 261);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(64, 64);
            this.Date.Style = MetroFramework.MetroColorStyle.White;
            this.Date.TabIndex = 3;
            this.Date.TileImage = ((System.Drawing.Image)(resources.GetObject("Date.TileImage")));
            this.Date.UseSelectable = true;
            this.Date.UseTileImage = true;
            // 
            // DatePick
            // 
            this.DatePick.Location = new System.Drawing.Point(220, 280);
            this.DatePick.MinimumSize = new System.Drawing.Size(0, 29);
            this.DatePick.Name = "DatePick";
            this.DatePick.Size = new System.Drawing.Size(264, 29);
            this.DatePick.TabIndex = 4;
            // 
            // okBtn
            // 
            this.okBtn.ActiveControl = null;
            this.okBtn.Location = new System.Drawing.Point(266, 361);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(128, 128);
            this.okBtn.Style = MetroFramework.MetroColorStyle.White;
            this.okBtn.TabIndex = 5;
            this.okBtn.TileImage = ((System.Drawing.Image)(resources.GetObject("okBtn.TileImage")));
            this.okBtn.UseSelectable = true;
            this.okBtn.UseTileImage = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // doctorPhoneIcon
            // 
            this.doctorPhoneIcon.ActiveControl = null;
            this.doctorPhoneIcon.Location = new System.Drawing.Point(143, 18);
            this.doctorPhoneIcon.Name = "doctorPhoneIcon";
            this.doctorPhoneIcon.Size = new System.Drawing.Size(132, 132);
            this.doctorPhoneIcon.Style = MetroFramework.MetroColorStyle.Black;
            this.doctorPhoneIcon.TabIndex = 1;
            this.doctorPhoneIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.doctorPhoneIcon.TileImage = ((System.Drawing.Image)(resources.GetObject("doctorPhoneIcon.TileImage")));
            this.doctorPhoneIcon.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.doctorPhoneIcon.UseSelectable = true;
            this.doctorPhoneIcon.UseTileImage = true;
            this.doctorPhoneIcon.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // docNumber
            // 
            // 
            // 
            // 
            this.docNumber.CustomButton.Image = null;
            this.docNumber.CustomButton.Location = new System.Drawing.Point(47, 1);
            this.docNumber.CustomButton.Name = "";
            this.docNumber.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.docNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.docNumber.CustomButton.TabIndex = 1;
            this.docNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.docNumber.CustomButton.UseSelectable = true;
            this.docNumber.CustomButton.Visible = false;
            this.docNumber.Enabled = false;
            this.docNumber.Lines = new string[0];
            this.docNumber.Location = new System.Drawing.Point(97, 166);
            this.docNumber.MaxLength = 32767;
            this.docNumber.Name = "docNumber";
            this.docNumber.PasswordChar = '\0';
            this.docNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.docNumber.SelectedText = "";
            this.docNumber.SelectionLength = 0;
            this.docNumber.SelectionStart = 0;
            this.docNumber.ShortcutsEnabled = true;
            this.docNumber.Size = new System.Drawing.Size(75, 29);
            this.docNumber.TabIndex = 6;
            this.docNumber.UseSelectable = true;
            this.docNumber.Visible = false;
            this.docNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.docNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 64);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(48, 48);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile1.TabIndex = 7;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.docNumber);
            this.groupBox1.Controls.Add(this.doctorPhoneIcon);
            this.groupBox1.Location = new System.Drawing.Point(123, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 436);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
           // this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(576, 64);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(64, 64);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile2.TabIndex = 9;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Visible = false;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 512);
            this.ControlBox = false;
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.DatePick);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(674, 512);
            this.MinimumSize = new System.Drawing.Size(674, 512);
            this.Name = "Appointment";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile Date;
        private MetroFramework.Controls.MetroDateTime DatePick;
        private MetroFramework.Controls.MetroTile okBtn;
        private MetroFramework.Controls.MetroTile doctorPhoneIcon;
        private MetroFramework.Controls.MetroTextBox docNumber;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}