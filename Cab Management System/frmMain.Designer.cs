namespace CabMan
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLocations = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMapLocations = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuVehicleTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehicleDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFares = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDriverDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDutyRooster = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShuttleBookings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDriversSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMapAndDirections = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccess = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportLocations = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportFares = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportVehicleTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportVehicleDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportDriverDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutCabMan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblCName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblUserName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.mnuReportVehicleFares = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuMaster,
            this.mnuDrivers,
            this.mnuTransactions,
            this.mnuAdministration,
            this.mnuReports,
            this.mnuSettings,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuLogout,
            this.toolStripMenuItem1,
            this.mnuCompany,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(152, 22);
            this.mnuLogin.Text = "Log&in";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Enabled = false;
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(152, 22);
            this.mnuLogout.Text = "Log&out";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuCompany
            // 
            this.mnuCompany.Name = "mnuCompany";
            this.mnuCompany.Size = new System.Drawing.Size(152, 22);
            this.mnuCompany.Text = "&Company";
            this.mnuCompany.Click += new System.EventHandler(this.mnuCompany_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = ((System.Drawing.Image)(resources.GetObject("mnuExit.Image")));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuMaster
            // 
            this.mnuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLocations,
            this.mnuProjects,
            this.mnuEmployees,
            this.mnuMapLocations,
            this.toolStripMenuItem2,
            this.mnuVehicleTypes,
            this.mnuVehicleDetails,
            this.toolStripMenuItem4,
            this.mnuFares});
            this.mnuMaster.Name = "mnuMaster";
            this.mnuMaster.Size = new System.Drawing.Size(52, 20);
            this.mnuMaster.Text = "&Master";
            this.mnuMaster.Visible = false;
            // 
            // mnuLocations
            // 
            this.mnuLocations.Name = "mnuLocations";
            this.mnuLocations.Size = new System.Drawing.Size(153, 22);
            this.mnuLocations.Text = "&Locations";
            this.mnuLocations.Click += new System.EventHandler(this.mnuLocations_Click);
            // 
            // mnuProjects
            // 
            this.mnuProjects.Name = "mnuProjects";
            this.mnuProjects.Size = new System.Drawing.Size(153, 22);
            this.mnuProjects.Text = "&Projects";
            this.mnuProjects.Click += new System.EventHandler(this.mnuProjects_Click);
            // 
            // mnuEmployees
            // 
            this.mnuEmployees.Name = "mnuEmployees";
            this.mnuEmployees.Size = new System.Drawing.Size(153, 22);
            this.mnuEmployees.Text = "&Employees";
            this.mnuEmployees.Click += new System.EventHandler(this.mnuEmployees_Click);
            // 
            // mnuMapLocations
            // 
            this.mnuMapLocations.Name = "mnuMapLocations";
            this.mnuMapLocations.Size = new System.Drawing.Size(153, 22);
            this.mnuMapLocations.Text = "&Map Locations";
            this.mnuMapLocations.Click += new System.EventHandler(this.mnuMapLocations_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
            // 
            // mnuVehicleTypes
            // 
            this.mnuVehicleTypes.Name = "mnuVehicleTypes";
            this.mnuVehicleTypes.Size = new System.Drawing.Size(153, 22);
            this.mnuVehicleTypes.Text = "Vehicle &Types";
            this.mnuVehicleTypes.Click += new System.EventHandler(this.mnuVehicleTypes_Click);
            // 
            // mnuVehicleDetails
            // 
            this.mnuVehicleDetails.Name = "mnuVehicleDetails";
            this.mnuVehicleDetails.Size = new System.Drawing.Size(153, 22);
            this.mnuVehicleDetails.Text = "&Vehicle Details";
            this.mnuVehicleDetails.Click += new System.EventHandler(this.mnuVehicleDetails_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(150, 6);
            // 
            // mnuFares
            // 
            this.mnuFares.Name = "mnuFares";
            this.mnuFares.Size = new System.Drawing.Size(153, 22);
            this.mnuFares.Text = "&Fares";
            this.mnuFares.Click += new System.EventHandler(this.mnuFares_Click);
            // 
            // mnuDrivers
            // 
            this.mnuDrivers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDriverDetails,
            this.mnuDutyRooster});
            this.mnuDrivers.Name = "mnuDrivers";
            this.mnuDrivers.Size = new System.Drawing.Size(53, 20);
            this.mnuDrivers.Text = "&Drivers";
            this.mnuDrivers.Visible = false;
            // 
            // mnuDriverDetails
            // 
            this.mnuDriverDetails.Name = "mnuDriverDetails";
            this.mnuDriverDetails.Size = new System.Drawing.Size(149, 22);
            this.mnuDriverDetails.Text = "Drive&r Details";
            this.mnuDriverDetails.Click += new System.EventHandler(this.mnuDriverDetails_Click);
            // 
            // mnuDutyRooster
            // 
            this.mnuDutyRooster.Name = "mnuDutyRooster";
            this.mnuDutyRooster.Size = new System.Drawing.Size(149, 22);
            this.mnuDutyRooster.Text = "Duty R&ooster";
            this.mnuDutyRooster.Click += new System.EventHandler(this.mnuDutyRooster_Click);
            // 
            // mnuTransactions
            // 
            this.mnuTransactions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBooking,
            this.mnuShuttleBookings,
            this.mnuDriversSchedule,
            this.mnuJobs,
            this.mnuInvoice,
            this.toolStripMenuItem5,
            this.mnuMapAndDirections});
            this.mnuTransactions.Name = "mnuTransactions";
            this.mnuTransactions.Size = new System.Drawing.Size(80, 20);
            this.mnuTransactions.Text = "&Transactions";
            this.mnuTransactions.Visible = false;
            // 
            // mnuBooking
            // 
            this.mnuBooking.Name = "mnuBooking";
            this.mnuBooking.Size = new System.Drawing.Size(165, 22);
            this.mnuBooking.Text = "&Bookings";
            this.mnuBooking.Click += new System.EventHandler(this.mnuBooking_Click);
            // 
            // mnuShuttleBookings
            // 
            this.mnuShuttleBookings.Name = "mnuShuttleBookings";
            this.mnuShuttleBookings.Size = new System.Drawing.Size(165, 22);
            this.mnuShuttleBookings.Text = "&Bookings";
            this.mnuShuttleBookings.Click += new System.EventHandler(this.mnuShuttleBookings_Click);
            // 
            // mnuDriversSchedule
            // 
            this.mnuDriversSchedule.Name = "mnuDriversSchedule";
            this.mnuDriversSchedule.Size = new System.Drawing.Size(165, 22);
            this.mnuDriversSchedule.Text = "&Drivers Schedule";
            this.mnuDriversSchedule.Click += new System.EventHandler(this.mnuDriversSchedule_Click);
            // 
            // mnuJobs
            // 
            this.mnuJobs.Name = "mnuJobs";
            this.mnuJobs.Size = new System.Drawing.Size(165, 22);
            this.mnuJobs.Text = "&Jobs";
            this.mnuJobs.Click += new System.EventHandler(this.mnuJobs_Click);
            // 
            // mnuInvoice
            // 
            this.mnuInvoice.Name = "mnuInvoice";
            this.mnuInvoice.Size = new System.Drawing.Size(165, 22);
            this.mnuInvoice.Text = "&Invoice";
            this.mnuInvoice.Click += new System.EventHandler(this.mnuInvoice_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(162, 6);
            // 
            // mnuMapAndDirections
            // 
            this.mnuMapAndDirections.Name = "mnuMapAndDirections";
            this.mnuMapAndDirections.Size = new System.Drawing.Size(165, 22);
            this.mnuMapAndDirections.Text = "&Map && Directions";
            this.mnuMapAndDirections.Click += new System.EventHandler(this.mnuMapAndDirections_Click);
            // 
            // mnuAdministration
            // 
            this.mnuAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsers,
            this.mnuAccess});
            this.mnuAdministration.Name = "mnuAdministration";
            this.mnuAdministration.Size = new System.Drawing.Size(87, 20);
            this.mnuAdministration.Text = "&Administration";
            this.mnuAdministration.Visible = false;
            // 
            // mnuUsers
            // 
            this.mnuUsers.Name = "mnuUsers";
            this.mnuUsers.Size = new System.Drawing.Size(118, 22);
            this.mnuUsers.Text = "&Users";
            this.mnuUsers.Click += new System.EventHandler(this.mnuUsers_Click);
            // 
            // mnuAccess
            // 
            this.mnuAccess.Name = "mnuAccess";
            this.mnuAccess.Size = new System.Drawing.Size(118, 22);
            this.mnuAccess.Text = "&Access";
            this.mnuAccess.Click += new System.EventHandler(this.mnuAccess_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportLocations,
            this.mnuReportFares,
            this.mnuReportVehicleTypes,
            this.mnuReportVehicleDetails,
            this.mnuReportDriverDetails,
            this.mnuReportVehicleFares});
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(57, 20);
            this.mnuReports.Text = "&Reports";
            this.mnuReports.Visible = false;
            // 
            // mnuReportLocations
            // 
            this.mnuReportLocations.Name = "mnuReportLocations";
            this.mnuReportLocations.Size = new System.Drawing.Size(153, 22);
            this.mnuReportLocations.Text = "&Locations";
            this.mnuReportLocations.Click += new System.EventHandler(this.mnuReportLocations_Click);
            // 
            // mnuReportFares
            // 
            this.mnuReportFares.Name = "mnuReportFares";
            this.mnuReportFares.Size = new System.Drawing.Size(153, 22);
            this.mnuReportFares.Text = "&Fares";
            this.mnuReportFares.Click += new System.EventHandler(this.mnuReportFares_Click);
            // 
            // mnuReportVehicleTypes
            // 
            this.mnuReportVehicleTypes.Name = "mnuReportVehicleTypes";
            this.mnuReportVehicleTypes.Size = new System.Drawing.Size(153, 22);
            this.mnuReportVehicleTypes.Text = "Vehicle &Types";
            this.mnuReportVehicleTypes.Click += new System.EventHandler(this.mnuReportVehicleTypes_Click);
            // 
            // mnuReportVehicleDetails
            // 
            this.mnuReportVehicleDetails.Name = "mnuReportVehicleDetails";
            this.mnuReportVehicleDetails.Size = new System.Drawing.Size(153, 22);
            this.mnuReportVehicleDetails.Text = "Vehicle &Details";
            this.mnuReportVehicleDetails.Click += new System.EventHandler(this.mnuReportVehicleDetails_Click);
            // 
            // mnuReportDriverDetails
            // 
            this.mnuReportDriverDetails.Name = "mnuReportDriverDetails";
            this.mnuReportDriverDetails.Size = new System.Drawing.Size(153, 22);
            this.mnuReportDriverDetails.Text = "&Driver Details";
            this.mnuReportDriverDetails.Click += new System.EventHandler(this.mnuReportDriverDetails_Click);
            // 
            // mnuSettings
            // 
            this.mnuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackUp,
            this.mnuOptions});
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(58, 20);
            this.mnuSettings.Text = "&Settings";
            this.mnuSettings.Visible = false;
            // 
            // mnuBackUp
            // 
            this.mnuBackUp.Name = "mnuBackUp";
            this.mnuBackUp.Size = new System.Drawing.Size(122, 22);
            this.mnuBackUp.Text = "&BackUp";
            this.mnuBackUp.Click += new System.EventHandler(this.mnuBackUp_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(122, 22);
            this.mnuOptions.Text = "&Options";
            this.mnuOptions.Click += new System.EventHandler(this.mnuOptions_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAboutCabMan});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(40, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAboutCabMan
            // 
            this.mnuAboutCabMan.Name = "mnuAboutCabMan";
            this.mnuAboutCabMan.Size = new System.Drawing.Size(156, 22);
            this.mnuAboutCabMan.Text = "&About CabMan";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCName,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.lblUserName,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblCName
            // 
            this.lblCName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(129, 22);
            this.lblCName.Text = "Cab Management System";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblUserName
            // 
            this.lblUserName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(30, 22);
            this.lblUserName.Text = "Sajid";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // mnuReportVehicleFares
            // 
            this.mnuReportVehicleFares.Name = "mnuReportVehicleFares";
            this.mnuReportVehicleFares.Size = new System.Drawing.Size(153, 22);
            this.mnuReportVehicleFares.Text = "Vehicle Fares";
            this.mnuReportVehicleFares.Click += new System.EventHandler(this.mnuReportVehicleFares_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 464);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "CabMan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem mnuFile;
        public System.Windows.Forms.ToolStripMenuItem mnuLogin;
        public System.Windows.Forms.ToolStripMenuItem mnuLogout;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem mnuExit;
        public System.Windows.Forms.ToolStripMenuItem mnuMaster;
        public System.Windows.Forms.ToolStripMenuItem mnuLocations;
        public System.Windows.Forms.ToolStripMenuItem mnuMapLocations;
        public System.Windows.Forms.ToolStripMenuItem mnuTransactions;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem mnuVehicleDetails;
        public System.Windows.Forms.ToolStripMenuItem mnuVehicleTypes;
        public System.Windows.Forms.ToolStripMenuItem mnuReports;
        public System.Windows.Forms.ToolStripMenuItem mnuHelp;
        public System.Windows.Forms.ToolStripMenuItem mnuAboutCabMan;
        public System.Windows.Forms.ToolStripMenuItem mnuBooking;
        public System.Windows.Forms.ToolStripMenuItem mnuSettings;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        public System.Windows.Forms.ToolStripMenuItem mnuMapAndDirections;
        public System.Windows.Forms.ToolStripMenuItem mnuFares;
        public System.Windows.Forms.ToolStripMenuItem mnuInvoice;
        public System.Windows.Forms.ToolStripMenuItem mnuCompany;
        public System.Windows.Forms.ToolStripLabel lblCName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripLabel lblUserName;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        public System.Windows.Forms.ToolStripMenuItem mnuDrivers;
        public System.Windows.Forms.ToolStripMenuItem mnuAdministration;
        public System.Windows.Forms.ToolStripMenuItem mnuDriverDetails;
        public System.Windows.Forms.ToolStripMenuItem mnuUsers;
        public System.Windows.Forms.ToolStripMenuItem mnuAccess;
        public System.Windows.Forms.ToolStripMenuItem mnuDutyRooster;
        public System.Windows.Forms.ToolStripMenuItem mnuJobs;
        public System.Windows.Forms.ToolStripMenuItem mnuProjects;
        public System.Windows.Forms.ToolStripMenuItem mnuEmployees;
        public System.Windows.Forms.ToolStripMenuItem mnuShuttleBookings;
        public System.Windows.Forms.ToolStripMenuItem mnuReportLocations;
        public System.Windows.Forms.ToolStripMenuItem mnuReportFares;
        public System.Windows.Forms.ToolStripMenuItem mnuReportVehicleTypes;
        public System.Windows.Forms.ToolStripMenuItem mnuReportVehicleDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuBackUp;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuDriversSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuReportDriverDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuReportVehicleFares;
    }
}

