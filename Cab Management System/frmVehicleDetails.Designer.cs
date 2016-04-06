namespace CabMan
{
    partial class frmVehicleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAC = new System.Windows.Forms.CheckBox();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nudLuggageCapacity = new System.Windows.Forms.NumericUpDown();
            this.nudSeatingCapacity = new System.Windows.Forms.NumericUpDown();
            this.cmbVehicleName = new System.Windows.Forms.ComboBox();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudModel = new System.Windows.Forms.NumericUpDown();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtInsurancePremium = new System.Windows.Forms.TextBox();
            this.dtpInsuranceExpired = new System.Windows.Forms.DateTimePicker();
            this.txtInsuranceNo = new System.Windows.Forms.TextBox();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtVehicleOwner = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grdVehicleDetails = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuggageCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatingCapacity)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModel)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(7, 86);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 173);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 147);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vehicle Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.groupBox2.Controls.Add(this.chkAC);
            this.groupBox2.Controls.Add(this.cmbVehicleType);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.nudLuggageCapacity);
            this.groupBox2.Controls.Add(this.nudSeatingCapacity);
            this.groupBox2.Controls.Add(this.cmbVehicleName);
            this.groupBox2.Controls.Add(this.txtVehicleNo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 137);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // chkAC
            // 
            this.chkAC.AutoSize = true;
            this.chkAC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAC.Location = new System.Drawing.Point(239, 83);
            this.chkAC.Name = "chkAC";
            this.chkAC.Size = new System.Drawing.Size(40, 17);
            this.chkAC.TabIndex = 4;
            this.chkAC.Text = "AC";
            this.chkAC.UseVisualStyleBackColor = true;
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Location = new System.Drawing.Point(115, 36);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(164, 21);
            this.cmbVehicleType.TabIndex = 1;
            this.cmbVehicleType.SelectionChangeCommitted += new System.EventHandler(this.cmbVehicleType_SelectionChangeCommitted);
            this.cmbVehicleType.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleType_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Vehicle Type";
            // 
            // nudLuggageCapacity
            // 
            this.nudLuggageCapacity.Location = new System.Drawing.Point(115, 105);
            this.nudLuggageCapacity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudLuggageCapacity.Name = "nudLuggageCapacity";
            this.nudLuggageCapacity.Size = new System.Drawing.Size(48, 20);
            this.nudLuggageCapacity.TabIndex = 5;
            // 
            // nudSeatingCapacity
            // 
            this.nudSeatingCapacity.Location = new System.Drawing.Point(115, 83);
            this.nudSeatingCapacity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSeatingCapacity.Name = "nudSeatingCapacity";
            this.nudSeatingCapacity.Size = new System.Drawing.Size(48, 20);
            this.nudSeatingCapacity.TabIndex = 3;
            this.nudSeatingCapacity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cmbVehicleName
            // 
            this.cmbVehicleName.DisplayMember = "Vehicle_Name";
            this.cmbVehicleName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleName.FormattingEnabled = true;
            this.cmbVehicleName.Location = new System.Drawing.Point(115, 60);
            this.cmbVehicleName.Name = "cmbVehicleName";
            this.cmbVehicleName.Size = new System.Drawing.Size(164, 21);
            this.cmbVehicleName.TabIndex = 2;
            this.cmbVehicleName.ValueMember = "Vehicle_TypeID";
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Location = new System.Drawing.Point(115, 13);
            this.txtVehicleNo.MaxLength = 20;
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(164, 20);
            this.txtVehicleNo.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Luggage Capacity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Seating Capacity";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 147);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vehicle Body";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.groupBox3.Controls.Add(this.nudModel);
            this.groupBox3.Controls.Add(this.txtMake);
            this.groupBox3.Controls.Add(this.txtColor);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(8, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 138);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // nudModel
            // 
            this.nudModel.Location = new System.Drawing.Point(55, 56);
            this.nudModel.Maximum = new decimal(new int[] {
            2009,
            0,
            0,
            0});
            this.nudModel.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudModel.Name = "nudModel";
            this.nudModel.Size = new System.Drawing.Size(52, 20);
            this.nudModel.TabIndex = 8;
            this.nudModel.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(55, 34);
            this.txtMake.MaxLength = 100;
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(239, 20);
            this.txtMake.TabIndex = 7;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(55, 13);
            this.txtColor.MaxLength = 50;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(127, 20);
            this.txtColor.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Make";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(618, 147);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vehicle Registration";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.groupBox4.Controls.Add(this.txtInsurancePremium);
            this.groupBox4.Controls.Add(this.dtpInsuranceExpired);
            this.groupBox4.Controls.Add(this.txtInsuranceNo);
            this.groupBox4.Controls.Add(this.txtRegistrationNo);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(603, 138);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // txtInsurancePremium
            // 
            this.txtInsurancePremium.Location = new System.Drawing.Point(110, 85);
            this.txtInsurancePremium.MaxLength = 10;
            this.txtInsurancePremium.Name = "txtInsurancePremium";
            this.txtInsurancePremium.Size = new System.Drawing.Size(100, 20);
            this.txtInsurancePremium.TabIndex = 13;
            this.txtInsurancePremium.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInsurancePremium.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsurancePremium_KeyPress);
            // 
            // dtpInsuranceExpired
            // 
            this.dtpInsuranceExpired.CustomFormat = "dd-MMM-yyyy";
            this.dtpInsuranceExpired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInsuranceExpired.Location = new System.Drawing.Point(110, 61);
            this.dtpInsuranceExpired.Name = "dtpInsuranceExpired";
            this.dtpInsuranceExpired.Size = new System.Drawing.Size(90, 20);
            this.dtpInsuranceExpired.TabIndex = 12;
            // 
            // txtInsuranceNo
            // 
            this.txtInsuranceNo.Location = new System.Drawing.Point(110, 37);
            this.txtInsuranceNo.MaxLength = 100;
            this.txtInsuranceNo.Name = "txtInsuranceNo";
            this.txtInsuranceNo.Size = new System.Drawing.Size(239, 20);
            this.txtInsuranceNo.TabIndex = 11;
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(110, 13);
            this.txtRegistrationNo.MaxLength = 100;
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(239, 20);
            this.txtRegistrationNo.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Insurance Premium";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Insurance  Expired";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Insurance No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Registration No";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(618, 147);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Driver";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.groupBox5.Controls.Add(this.txtComments);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtVehicleOwner);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.cmbDriver);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(8, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(603, 135);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(89, 56);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(316, 73);
            this.txtComments.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Comments";
            // 
            // txtVehicleOwner
            // 
            this.txtVehicleOwner.Location = new System.Drawing.Point(89, 34);
            this.txtVehicleOwner.Name = "txtVehicleOwner";
            this.txtVehicleOwner.Size = new System.Drawing.Size(316, 20);
            this.txtVehicleOwner.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Vehicle Owner";
            // 
            // cmbDriver
            // 
            this.cmbDriver.DisplayMember = "Driver_Name";
            this.cmbDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(89, 12);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(316, 21);
            this.cmbDriver.TabIndex = 16;
            this.cmbDriver.ValueMember = "Driver_ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Driver Name";
            // 
            // grdVehicleDetails
            // 
            this.grdVehicleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVehicleDetails.Location = new System.Drawing.Point(7, 265);
            this.grdVehicleDetails.Name = "grdVehicleDetails";
            this.grdVehicleDetails.ReadOnly = true;
            this.grdVehicleDetails.RowHeadersWidth = 20;
            this.grdVehicleDetails.Size = new System.Drawing.Size(626, 293);
            this.grdVehicleDetails.TabIndex = 18;
            this.grdVehicleDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVehicleDetails_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(558, 564);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(477, 564);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CabMan.Properties.Resources.RCar_Header;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 87);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(172)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(495, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Vehicle Details";
            // 
            // frmVehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(639, 593);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdVehicleDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVehicleDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Details";
            this.Load += new System.EventHandler(this.frmVehicleDetails_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmVehicleDetails_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuggageCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatingCapacity)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModel)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicleDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbVehicleName;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.NumericUpDown nudLuggageCapacity;
        private System.Windows.Forms.NumericUpDown nudSeatingCapacity;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.NumericUpDown nudModel;
        private System.Windows.Forms.TextBox txtInsuranceNo;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.DateTimePicker dtpInsuranceExpired;
        private System.Windows.Forms.TextBox txtInsurancePremium;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.DataGridView grdVehicleDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtVehicleOwner;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.CheckBox chkAC;
    }
}