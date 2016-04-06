namespace CabMan
{
    partial class frmBooking
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
            this.lblEstimateAmount = new System.Windows.Forms.Label();
            this.lblEstimateDistance = new System.Windows.Forms.Label();
            this.chkAC = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbBookingVia = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbBookingType = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbVehicleName = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nudTotalMembers = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDropAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDropLocation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDropDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDropTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPickUpAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPickUpLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPickUpDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPickUpTime = new System.Windows.Forms.DateTimePicker();
            this.grdBookings = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalMembers)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CabMan.Properties.Resources.RCar_Header;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 87);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(172)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(632, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Booking";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEstimateAmount);
            this.groupBox1.Controls.Add(this.lblEstimateDistance);
            this.groupBox1.Controls.Add(this.chkAC);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cmbVehicleName);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cmbVehicleType);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.nudTotalMembers);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtContactNo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCustomerAddress);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(7, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblEstimateAmount
            // 
            this.lblEstimateAmount.AutoSize = true;
            this.lblEstimateAmount.Location = new System.Drawing.Point(452, 305);
            this.lblEstimateAmount.Name = "lblEstimateAmount";
            this.lblEstimateAmount.Size = new System.Drawing.Size(0, 13);
            this.lblEstimateAmount.TabIndex = 37;
            // 
            // lblEstimateDistance
            // 
            this.lblEstimateDistance.AutoSize = true;
            this.lblEstimateDistance.Location = new System.Drawing.Point(452, 284);
            this.lblEstimateDistance.Name = "lblEstimateDistance";
            this.lblEstimateDistance.Size = new System.Drawing.Size(0, 13);
            this.lblEstimateDistance.TabIndex = 36;
            // 
            // chkAC
            // 
            this.chkAC.AutoSize = true;
            this.chkAC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAC.Location = new System.Drawing.Point(660, 282);
            this.chkAC.Name = "chkAC";
            this.chkAC.Size = new System.Drawing.Size(40, 17);
            this.chkAC.TabIndex = 16;
            this.chkAC.Text = "AC";
            this.chkAC.UseVisualStyleBackColor = true;
            this.chkAC.CheckedChanged += new System.EventHandler(this.chkAC_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbBookingVia);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.cmbBookingType);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.dtpBookingDate);
            this.groupBox4.Controls.Add(this.txtJobID);
            this.groupBox4.Location = new System.Drawing.Point(6, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(697, 36);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Booking";
            // 
            // cmbBookingVia
            // 
            this.cmbBookingVia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingVia.FormattingEnabled = true;
            this.cmbBookingVia.Location = new System.Drawing.Point(596, 10);
            this.cmbBookingVia.Name = "cmbBookingVia";
            this.cmbBookingVia.Size = new System.Drawing.Size(92, 21);
            this.cmbBookingVia.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(568, 15);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 13);
            this.label22.TabIndex = 37;
            this.label22.Text = "Via";
            // 
            // cmbBookingType
            // 
            this.cmbBookingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingType.FormattingEnabled = true;
            this.cmbBookingType.Location = new System.Drawing.Point(416, 10);
            this.cmbBookingType.Name = "cmbBookingType";
            this.cmbBookingType.Size = new System.Drawing.Size(92, 21);
            this.cmbBookingType.TabIndex = 0;
            this.cmbBookingType.SelectedIndexChanged += new System.EventHandler(this.cmbBookingType_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(378, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 35;
            this.label21.Text = "Type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(201, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Job ID";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingDate.Location = new System.Drawing.Point(237, 11);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(92, 20);
            this.dtpBookingDate.TabIndex = 0;
            this.dtpBookingDate.ValueChanged += new System.EventHandler(this.dtpBookingDate_ValueChanged);
            // 
            // txtJobID
            // 
            this.txtJobID.Enabled = false;
            this.txtJobID.Location = new System.Drawing.Point(64, 11);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(92, 20);
            this.txtJobID.TabIndex = 89;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(362, 305);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Estimate Amount";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(356, 283);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Estimate Distance";
            // 
            // cmbVehicleName
            // 
            this.cmbVehicleName.DisplayMember = "Vehicle_Name";
            this.cmbVehicleName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleName.FormattingEnabled = true;
            this.cmbVehicleName.Location = new System.Drawing.Point(452, 257);
            this.cmbVehicleName.Name = "cmbVehicleName";
            this.cmbVehicleName.Size = new System.Drawing.Size(248, 21);
            this.cmbVehicleName.TabIndex = 15;
            this.cmbVehicleName.ValueMember = "Vehicle_TypeID";
            this.cmbVehicleName.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleName_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(377, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Vehicle Name";
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Location = new System.Drawing.Point(452, 233);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(248, 21);
            this.cmbVehicleType.TabIndex = 14;
            this.cmbVehicleType.Validated += new System.EventHandler(this.cmbVehicleType_Validated);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(379, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Vehicle Type";
            // 
            // nudTotalMembers
            // 
            this.nudTotalMembers.Location = new System.Drawing.Point(452, 211);
            this.nudTotalMembers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTotalMembers.Name = "nudTotalMembers";
            this.nudTotalMembers.Size = new System.Drawing.Size(56, 20);
            this.nudTotalMembers.TabIndex = 13;
            this.nudTotalMembers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(371, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Total Members";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(104, 302);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(239, 20);
            this.txtContactNo.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Contact No";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(104, 233);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(239, 67);
            this.txtCustomerAddress.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(104, 211);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(239, 20);
            this.txtCustomerName.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Customer Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Customer Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDropAddress);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbDropLocation);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dtpDropDate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dtpDropTime);
            this.groupBox3.Location = new System.Drawing.Point(359, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 154);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drop";
            // 
            // txtDropAddress
            // 
            this.txtDropAddress.Location = new System.Drawing.Point(62, 65);
            this.txtDropAddress.Multiline = true;
            this.txtDropAddress.Name = "txtDropAddress";
            this.txtDropAddress.Size = new System.Drawing.Size(273, 82);
            this.txtDropAddress.TabIndex = 9;
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
            this.cmbDropLocation.TabIndex = 8;
            this.cmbDropLocation.ValueMember = "Location_ID";
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
            this.dtpDropDate.TabIndex = 6;
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
            this.dtpDropTime.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPickUpAddress);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbPickUpLocation);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpPickUpDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpPickUpTime);
            this.groupBox2.Location = new System.Drawing.Point(8, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 154);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pick-up";
            // 
            // txtPickUpAddress
            // 
            this.txtPickUpAddress.Location = new System.Drawing.Point(62, 65);
            this.txtPickUpAddress.Multiline = true;
            this.txtPickUpAddress.Name = "txtPickUpAddress";
            this.txtPickUpAddress.Size = new System.Drawing.Size(273, 82);
            this.txtPickUpAddress.TabIndex = 5;
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
            this.cmbPickUpLocation.TabIndex = 4;
            this.cmbPickUpLocation.ValueMember = "Location_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // dtpPickUpDate
            // 
            this.dtpPickUpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpPickUpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPickUpDate.Location = new System.Drawing.Point(62, 19);
            this.dtpPickUpDate.Name = "dtpPickUpDate";
            this.dtpPickUpDate.Size = new System.Drawing.Size(92, 20);
            this.dtpPickUpDate.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Time";
            // 
            // dtpPickUpTime
            // 
            this.dtpPickUpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPickUpTime.Location = new System.Drawing.Point(235, 19);
            this.dtpPickUpTime.Name = "dtpPickUpTime";
            this.dtpPickUpTime.ShowUpDown = true;
            this.dtpPickUpTime.Size = new System.Drawing.Size(100, 20);
            this.dtpPickUpTime.TabIndex = 3;
            // 
            // grdBookings
            // 
            this.grdBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBookings.Location = new System.Drawing.Point(7, 417);
            this.grdBookings.Name = "grdBookings";
            this.grdBookings.ReadOnly = true;
            this.grdBookings.RowHeadersWidth = 20;
            this.grdBookings.Size = new System.Drawing.Size(709, 227);
            this.grdBookings.TabIndex = 22;
            this.grdBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBookings_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(641, 650);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(560, 650);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(721, 676);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdBookings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmBooking_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalMembers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPickUpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPickUpTime;
        private System.Windows.Forms.ComboBox cmbPickUpLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPickUpAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDropAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDropLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDropDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDropTime;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudTotalMembers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.ComboBox cmbVehicleName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.DataGridView grdBookings;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbBookingType;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbBookingVia;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkAC;
        private System.Windows.Forms.Label lblEstimateAmount;
        private System.Windows.Forms.Label lblEstimateDistance;
    }
}