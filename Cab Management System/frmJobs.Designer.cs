namespace CabMan
{
    partial class frmJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobs));
            this.lblJobs = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVehicleName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbDrivers = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDropDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDropTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpPickUpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPickUpTime = new System.Windows.Forms.DateTimePicker();
            this.chkAC = new System.Windows.Forms.CheckBox();
            this.cmbVehicleNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbJobID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdJobs = new System.Windows.Forms.DataGridView();
            this.lstJobs = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJobs
            // 
            this.lblJobs.AutoSize = true;
            this.lblJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(172)))));
            this.lblJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobs.ForeColor = System.Drawing.Color.White;
            this.lblJobs.Location = new System.Drawing.Point(630, 34);
            this.lblJobs.Name = "lblJobs";
            this.lblJobs.Size = new System.Drawing.Size(50, 24);
            this.lblJobs.TabIndex = 20;
            this.lblJobs.Text = "Jobs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 87);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtVehicleName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cmbDrivers);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpDropDate);
            this.groupBox1.Controls.Add(this.dtpDropTime);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpPickUpDate);
            this.groupBox1.Controls.Add(this.dtpPickUpTime);
            this.groupBox1.Controls.Add(this.chkAC);
            this.groupBox1.Controls.Add(this.cmbVehicleNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbJobID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 113);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(588, 10);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(91, 20);
            this.dtpDate.TabIndex = 38;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Date";
            // 
            // txtVehicleName
            // 
            this.txtVehicleName.Enabled = false;
            this.txtVehicleName.Location = new System.Drawing.Point(95, 37);
            this.txtVehicleName.Name = "txtVehicleName";
            this.txtVehicleName.Size = new System.Drawing.Size(140, 20);
            this.txtVehicleName.TabIndex = 36;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(707, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbDrivers
            // 
            this.cmbDrivers.DisplayMember = "Driver_Name";
            this.cmbDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrivers.FormattingEnabled = true;
            this.cmbDrivers.Location = new System.Drawing.Point(367, 79);
            this.cmbDrivers.Name = "cmbDrivers";
            this.cmbDrivers.Size = new System.Drawing.Size(181, 21);
            this.cmbDrivers.TabIndex = 6;
            this.cmbDrivers.ValueMember = "Driver_ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(326, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Driver";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "To Date";
            // 
            // dtpDropDate
            // 
            this.dtpDropDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDropDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDropDate.Location = new System.Drawing.Point(368, 56);
            this.dtpDropDate.Name = "dtpDropDate";
            this.dtpDropDate.Size = new System.Drawing.Size(92, 20);
            this.dtpDropDate.TabIndex = 3;
            // 
            // dtpDropTime
            // 
            this.dtpDropTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDropTime.Location = new System.Drawing.Point(458, 56);
            this.dtpDropTime.Name = "dtpDropTime";
            this.dtpDropTime.ShowUpDown = true;
            this.dtpDropTime.Size = new System.Drawing.Size(90, 20);
            this.dtpDropTime.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "From Date";
            // 
            // dtpPickUpDate
            // 
            this.dtpPickUpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpPickUpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPickUpDate.Location = new System.Drawing.Point(95, 60);
            this.dtpPickUpDate.Name = "dtpPickUpDate";
            this.dtpPickUpDate.Size = new System.Drawing.Size(91, 20);
            this.dtpPickUpDate.TabIndex = 1;
            // 
            // dtpPickUpTime
            // 
            this.dtpPickUpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPickUpTime.Location = new System.Drawing.Point(186, 60);
            this.dtpPickUpTime.Name = "dtpPickUpTime";
            this.dtpPickUpTime.ShowUpDown = true;
            this.dtpPickUpTime.Size = new System.Drawing.Size(88, 20);
            this.dtpPickUpTime.TabIndex = 2;
            // 
            // chkAC
            // 
            this.chkAC.AutoSize = true;
            this.chkAC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAC.Enabled = false;
            this.chkAC.Location = new System.Drawing.Point(234, 39);
            this.chkAC.Name = "chkAC";
            this.chkAC.Size = new System.Drawing.Size(40, 17);
            this.chkAC.TabIndex = 22;
            this.chkAC.Text = "AC";
            this.chkAC.UseVisualStyleBackColor = true;
            // 
            // cmbVehicleNo
            // 
            this.cmbVehicleNo.DisplayMember = "Vehicle_No";
            this.cmbVehicleNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleNo.FormattingEnabled = true;
            this.cmbVehicleNo.Location = new System.Drawing.Point(94, 82);
            this.cmbVehicleNo.Name = "cmbVehicleNo";
            this.cmbVehicleNo.Size = new System.Drawing.Size(180, 21);
            this.cmbVehicleNo.TabIndex = 5;
            this.cmbVehicleNo.ValueMember = "Driver_ID";
            this.cmbVehicleNo.Validated += new System.EventHandler(this.cmbVehicleNo_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Vehicle No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Vehicle Name";
            // 
            // txtTo
            // 
            this.txtTo.Enabled = false;
            this.txtTo.Location = new System.Drawing.Point(588, 32);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(190, 20);
            this.txtTo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "To";
            // 
            // txtFrom
            // 
            this.txtFrom.Enabled = false;
            this.txtFrom.Location = new System.Drawing.Point(368, 33);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(178, 20);
            this.txtFrom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "From";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(367, 10);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(181, 20);
            this.txtCustomerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // cmbJobID
            // 
            this.cmbJobID.DisplayMember = "Job_ID";
            this.cmbJobID.FormattingEnabled = true;
            this.cmbJobID.Location = new System.Drawing.Point(95, 13);
            this.cmbJobID.Name = "cmbJobID";
            this.cmbJobID.Size = new System.Drawing.Size(179, 21);
            this.cmbJobID.TabIndex = 0;
            this.cmbJobID.ValueMember = "Job_ID";
            this.cmbJobID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbJobID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job ID";
            // 
            // grdJobs
            // 
            this.grdJobs.AllowUserToOrderColumns = true;
            this.grdJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdJobs.Location = new System.Drawing.Point(133, 199);
            this.grdJobs.Name = "grdJobs";
            this.grdJobs.ReadOnly = true;
            this.grdJobs.RowHeadersWidth = 20;
            this.grdJobs.Size = new System.Drawing.Size(916, 150);
            this.grdJobs.TabIndex = 22;
            // 
            // lstJobs
            // 
            this.lstJobs.DisplayMember = "Job_ID";
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.Location = new System.Drawing.Point(7, 225);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(120, 303);
            this.lstJobs.TabIndex = 23;
            this.lstJobs.ValueMember = "Job_ID";
            
            this.lstJobs.Click += new System.EventHandler(this.lstJobs_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(172)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Jobs";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1045, 538);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstJobs);
            this.Controls.Add(this.grdJobs);
            this.Controls.Add(this.lblJobs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmJobs";
            this.Text = "Jobs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJobs_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmJobs_KeyPress);
            this.Resize += new System.EventHandler(this.frmJobs_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbJobID;
        private System.Windows.Forms.DataGridView grdJobs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbVehicleNo;
        private System.Windows.Forms.CheckBox chkAC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDropDate;
        private System.Windows.Forms.DateTimePicker dtpDropTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpPickUpDate;
        private System.Windows.Forms.DateTimePicker dtpPickUpTime;
        private System.Windows.Forms.ComboBox cmbDrivers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtVehicleName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstJobs;
        private System.Windows.Forms.Label label6;
    }
}