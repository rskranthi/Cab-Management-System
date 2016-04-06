namespace CabMan
{
    partial class frmDriverSchedule
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
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.grdBookings = new System.Windows.Forms.DataGridView();
            this.Booking_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From_LocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From_LocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To_LocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To_LocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle_No = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Driver_Name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(172)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(750, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Drivers Schedule";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CabMan.Properties.Resources.RCar_Header;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(926, 87);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(7, 62);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(92, 20);
            this.dtpDate.TabIndex = 0;
            // 
            // grdBookings
            // 
            this.grdBookings.AllowUserToAddRows = false;
            this.grdBookings.AllowUserToDeleteRows = false;
            this.grdBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Booking_ID,
            this.Employee_ID,
            this.Employee_Name,
            this.FromDateTime,
            this.ToDateTime,
            this.From_LocationID,
            this.From_LocationName,
            this.To_LocationID,
            this.To_LocationName,
            this.Vehicle_No,
            this.Driver_Name});
            this.grdBookings.Location = new System.Drawing.Point(7, 85);
            this.grdBookings.Name = "grdBookings";
            this.grdBookings.RowHeadersWidth = 20;
            this.grdBookings.Size = new System.Drawing.Size(905, 520);
            this.grdBookings.TabIndex = 1;
            // 
            // Booking_ID
            // 
            this.Booking_ID.HeaderText = "Booking_ID";
            this.Booking_ID.Name = "Booking_ID";
            this.Booking_ID.Visible = false;
            this.Booking_ID.Width = 69;
            // 
            // Employee_ID
            // 
            this.Employee_ID.HeaderText = "Employee_ID";
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.ReadOnly = true;
            this.Employee_ID.Visible = false;
            this.Employee_ID.Width = 76;
            // 
            // Employee_Name
            // 
            this.Employee_Name.HeaderText = "Employee_Name";
            this.Employee_Name.Name = "Employee_Name";
            this.Employee_Name.ReadOnly = true;
            this.Employee_Name.Width = 112;
            // 
            // FromDateTime
            // 
            this.FromDateTime.HeaderText = "FromDateTime";
            this.FromDateTime.Name = "FromDateTime";
            this.FromDateTime.ReadOnly = true;
            this.FromDateTime.Width = 101;
            // 
            // ToDateTime
            // 
            this.ToDateTime.HeaderText = "ToDateTime";
            this.ToDateTime.Name = "ToDateTime";
            this.ToDateTime.ReadOnly = true;
            this.ToDateTime.Width = 91;
            // 
            // From_LocationID
            // 
            this.From_LocationID.HeaderText = "From_LocationID";
            this.From_LocationID.Name = "From_LocationID";
            this.From_LocationID.ReadOnly = true;
            this.From_LocationID.Visible = false;
            this.From_LocationID.Width = 113;
            // 
            // From_LocationName
            // 
            this.From_LocationName.HeaderText = "From_LocationName";
            this.From_LocationName.Name = "From_LocationName";
            this.From_LocationName.ReadOnly = true;
            this.From_LocationName.Width = 130;
            // 
            // To_LocationID
            // 
            this.To_LocationID.HeaderText = "To_LocationID";
            this.To_LocationID.Name = "To_LocationID";
            this.To_LocationID.ReadOnly = true;
            this.To_LocationID.Visible = false;
            this.To_LocationID.Width = 103;
            // 
            // To_LocationName
            // 
            this.To_LocationName.HeaderText = "To_LocationName";
            this.To_LocationName.Name = "To_LocationName";
            this.To_LocationName.ReadOnly = true;
            this.To_LocationName.Width = 120;
            // 
            // Vehicle_No
            // 
            this.Vehicle_No.HeaderText = "Vehicle_No";
            this.Vehicle_No.Name = "Vehicle_No";
            this.Vehicle_No.Width = 68;
            // 
            // Driver_Name
            // 
            this.Driver_Name.HeaderText = "Driver_Name";
            this.Driver_Name.Name = "Driver_Name";
            this.Driver_Name.Width = 75;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(837, 611);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(759, 611);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmDriverSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(917, 640);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdBookings);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDriverSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drivers Schedule";
            this.Load += new System.EventHandler(this.frmDriverSchedule_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDriverSchedule_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView grdBookings;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Booking_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn From_LocationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn From_LocationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_LocationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_LocationName;
        public System.Windows.Forms.DataGridViewComboBoxColumn Vehicle_No;
        public  System.Windows.Forms.DataGridViewComboBoxColumn Driver_Name;
    }
}