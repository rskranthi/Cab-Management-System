namespace CabMan
{
    partial class frmShuttleBooking
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpDrop = new System.Windows.Forms.GroupBox();
            this.txtDropAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDropLocation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDropDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDropTime = new System.Windows.Forms.DateTimePicker();
            this.grpPickUp = new System.Windows.Forms.GroupBox();
            this.txtPickUpAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPickUpLocation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPickUpDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpPickUpTime = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpMonthDate = new System.Windows.Forms.DateTimePicker();
            this.grdBookings = new System.Windows.Forms.DataGridView();
            this.chkPickUp = new System.Windows.Forms.CheckBox();
            this.chkDrop = new System.Windows.Forms.CheckBox();
            this.lstDates = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpDrop.SuspendLayout();
            this.grpPickUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CabMan.Properties.Resources.RCar_Header;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 87);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(172)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(689, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bookings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.cmbProjects);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbEmployees);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(118, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(89, 10);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(92, 20);
            this.dtpDate.TabIndex = 2;
            
            this.dtpDate.Validated += new System.EventHandler(this.dtpDate_Validated);
            // 
            // cmbProjects
            // 
            this.cmbProjects.DisplayMember = "Project_Name";
            this.cmbProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(89, 55);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(247, 21);
            this.cmbProjects.TabIndex = 4;
            this.cmbProjects.ValueMember = "Project_ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Project Name";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.DisplayMember = "Employee_Name";
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(89, 32);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(247, 21);
            this.cmbEmployees.TabIndex = 3;
            this.cmbEmployees.ValueMember = "Employee_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(388, 472);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(307, 472);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpDrop
            // 
            this.grpDrop.Controls.Add(this.txtDropAddress);
            this.grpDrop.Controls.Add(this.label3);
            this.grpDrop.Controls.Add(this.cmbDropLocation);
            this.grpDrop.Controls.Add(this.label4);
            this.grpDrop.Controls.Add(this.dtpDropDate);
            this.grpDrop.Controls.Add(this.label7);
            this.grpDrop.Controls.Add(this.label9);
            this.grpDrop.Controls.Add(this.dtpDropTime);
            this.grpDrop.Enabled = false;
            this.grpDrop.Location = new System.Drawing.Point(119, 318);
            this.grpDrop.Name = "grpDrop";
            this.grpDrop.Size = new System.Drawing.Size(345, 154);
            this.grpDrop.TabIndex = 11;
            this.grpDrop.TabStop = false;
            this.grpDrop.Text = "   Drop";
            // 
            // txtDropAddress
            // 
            this.txtDropAddress.Location = new System.Drawing.Point(62, 65);
            this.txtDropAddress.Multiline = true;
            this.txtDropAddress.Name = "txtDropAddress";
            this.txtDropAddress.Size = new System.Drawing.Size(273, 82);
            this.txtDropAddress.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Address";
            // 
            // cmbDropLocation
            // 
            this.cmbDropLocation.DisplayMember = "Location_Name";
            this.cmbDropLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDropLocation.FormattingEnabled = true;
            this.cmbDropLocation.Location = new System.Drawing.Point(62, 42);
            this.cmbDropLocation.Name = "cmbDropLocation";
            this.cmbDropLocation.Size = new System.Drawing.Size(273, 21);
            this.cmbDropLocation.TabIndex = 13;
            this.cmbDropLocation.ValueMember = "Location_ID";
            this.cmbDropLocation.Validated += new System.EventHandler(this.cmbDropLocation_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date";
            // 
            // dtpDropDate
            // 
            this.dtpDropDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDropDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDropDate.Location = new System.Drawing.Point(62, 19);
            this.dtpDropDate.Name = "dtpDropDate";
            this.dtpDropDate.Size = new System.Drawing.Size(92, 20);
            this.dtpDropDate.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Time";
            // 
            // dtpDropTime
            // 
            this.dtpDropTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDropTime.Location = new System.Drawing.Point(235, 19);
            this.dtpDropTime.Name = "dtpDropTime";
            this.dtpDropTime.ShowUpDown = true;
            this.dtpDropTime.Size = new System.Drawing.Size(100, 20);
            this.dtpDropTime.TabIndex = 12;
            // 
            // grpPickUp
            // 
            this.grpPickUp.Controls.Add(this.txtPickUpAddress);
            this.grpPickUp.Controls.Add(this.label8);
            this.grpPickUp.Controls.Add(this.cmbPickUpLocation);
            this.grpPickUp.Controls.Add(this.label2);
            this.grpPickUp.Controls.Add(this.dtpPickUpDate);
            this.grpPickUp.Controls.Add(this.label6);
            this.grpPickUp.Controls.Add(this.label10);
            this.grpPickUp.Controls.Add(this.dtpPickUpTime);
            this.grpPickUp.Enabled = false;
            this.grpPickUp.Location = new System.Drawing.Point(118, 163);
            this.grpPickUp.Name = "grpPickUp";
            this.grpPickUp.Size = new System.Drawing.Size(345, 154);
            this.grpPickUp.TabIndex = 5;
            this.grpPickUp.TabStop = false;
            this.grpPickUp.Text = "   Pick-up";
            // 
            // txtPickUpAddress
            // 
            this.txtPickUpAddress.Location = new System.Drawing.Point(62, 65);
            this.txtPickUpAddress.Multiline = true;
            this.txtPickUpAddress.Name = "txtPickUpAddress";
            this.txtPickUpAddress.Size = new System.Drawing.Size(273, 82);
            this.txtPickUpAddress.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Address";
            // 
            // cmbPickUpLocation
            // 
            this.cmbPickUpLocation.DisplayMember = "Location_Name";
            this.cmbPickUpLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPickUpLocation.FormattingEnabled = true;
            this.cmbPickUpLocation.Location = new System.Drawing.Point(62, 42);
            this.cmbPickUpLocation.Name = "cmbPickUpLocation";
            this.cmbPickUpLocation.Size = new System.Drawing.Size(273, 21);
            this.cmbPickUpLocation.TabIndex = 8;
            this.cmbPickUpLocation.ValueMember = "Location_ID";
            this.cmbPickUpLocation.Validated += new System.EventHandler(this.cmbPickUpLocation_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date";
            // 
            // dtpPickUpDate
            // 
            this.dtpPickUpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpPickUpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPickUpDate.Location = new System.Drawing.Point(62, 19);
            this.dtpPickUpDate.Name = "dtpPickUpDate";
            this.dtpPickUpDate.Size = new System.Drawing.Size(92, 20);
            this.dtpPickUpDate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Location";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Time";
            // 
            // dtpPickUpTime
            // 
            this.dtpPickUpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPickUpTime.Location = new System.Drawing.Point(235, 19);
            this.dtpPickUpTime.Name = "dtpPickUpTime";
            this.dtpPickUpTime.ShowUpDown = true;
            this.dtpPickUpTime.Size = new System.Drawing.Size(100, 20);
            this.dtpPickUpTime.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(172)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(5, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 23);
            this.label12.TabIndex = 25;
            this.label12.Text = "Month Wise";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpMonthDate
            // 
            this.dtpMonthDate.Checked = false;
            this.dtpMonthDate.CustomFormat = "MMM-yyyy";
            this.dtpMonthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonthDate.Location = new System.Drawing.Point(5, 108);
            this.dtpMonthDate.Name = "dtpMonthDate";
            this.dtpMonthDate.ShowCheckBox = true;
            this.dtpMonthDate.Size = new System.Drawing.Size(107, 20);
            this.dtpMonthDate.TabIndex = 0;
            this.dtpMonthDate.ValueChanged += new System.EventHandler(this.dtpMonthDate_ValueChanged);
            // 
            // grdBookings
            // 
            this.grdBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBookings.Location = new System.Drawing.Point(469, 84);
            this.grdBookings.Name = "grdBookings";
            this.grdBookings.ReadOnly = true;
            this.grdBookings.RowHeadersWidth = 20;
            this.grdBookings.Size = new System.Drawing.Size(308, 411);
            this.grdBookings.TabIndex = 17;
            // 
            // chkPickUp
            // 
            this.chkPickUp.AutoSize = true;
            this.chkPickUp.Location = new System.Drawing.Point(123, 163);
            this.chkPickUp.Name = "chkPickUp";
            this.chkPickUp.Size = new System.Drawing.Size(15, 14);
            this.chkPickUp.TabIndex = 5;
            this.chkPickUp.UseVisualStyleBackColor = true;
            this.chkPickUp.CheckedChanged += new System.EventHandler(this.chkPickUp_CheckedChanged);
            // 
            // chkDrop
            // 
            this.chkDrop.AutoSize = true;
            this.chkDrop.Location = new System.Drawing.Point(123, 318);
            this.chkDrop.Name = "chkDrop";
            this.chkDrop.Size = new System.Drawing.Size(15, 14);
            this.chkDrop.TabIndex = 10;
            this.chkDrop.UseVisualStyleBackColor = true;
            this.chkDrop.CheckedChanged += new System.EventHandler(this.chkDrop_CheckedChanged);
            // 
            // lstDates
            // 
            this.lstDates.CheckOnClick = true;
            this.lstDates.FormattingEnabled = true;
            this.lstDates.Location = new System.Drawing.Point(5, 131);
            this.lstDates.Name = "lstDates";
            this.lstDates.Size = new System.Drawing.Size(107, 364);
            this.lstDates.TabIndex = 1;
            // 
            // frmShuttleBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(782, 501);
            this.Controls.Add(this.lstDates);
            this.Controls.Add(this.chkDrop);
            this.Controls.Add(this.grdBookings);
            this.Controls.Add(this.chkPickUp);
            this.Controls.Add(this.dtpMonthDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grpDrop);
            this.Controls.Add(this.grpPickUp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmShuttleBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.frmShuttleBooking_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmShuttleBooking_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDrop.ResumeLayout(false);
            this.grpDrop.PerformLayout();
            this.grpPickUp.ResumeLayout(false);
            this.grpPickUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpDrop;
        private System.Windows.Forms.TextBox txtDropAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDropLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDropDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDropTime;
        private System.Windows.Forms.GroupBox grpPickUp;
        private System.Windows.Forms.TextBox txtPickUpAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPickUpLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPickUpDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpPickUpTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpMonthDate;
        private System.Windows.Forms.DataGridView grdBookings;
        private System.Windows.Forms.CheckBox chkPickUp;
        private System.Windows.Forms.CheckBox chkDrop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckedListBox lstDates;
    }
}