namespace CabMan
{
    partial class frmDutyRooster
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtpMonthDate = new System.Windows.Forms.DateTimePicker();
            this.grdDutyRooster = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDutyRooster)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(172)))));
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(494, 33);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(117, 24);
            this.lblHeader.TabIndex = 18;
            this.lblHeader.Text = "Duty Rooster";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CabMan.Properties.Resources.Car_Header;
            this.pictureBox2.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1300, 87);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // dtpMonthDate
            // 
            this.dtpMonthDate.Checked = false;
            this.dtpMonthDate.CustomFormat = "MMM-yyyy";
            this.dtpMonthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonthDate.Location = new System.Drawing.Point(8, 63);
            this.dtpMonthDate.Name = "dtpMonthDate";
            this.dtpMonthDate.Size = new System.Drawing.Size(84, 20);
            this.dtpMonthDate.TabIndex = 19;
            // 
            // grdDutyRooster
            // 
            this.grdDutyRooster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDutyRooster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDutyRooster.Location = new System.Drawing.Point(8, 88);
            this.grdDutyRooster.Name = "grdDutyRooster";
            this.grdDutyRooster.RowHeadersWidth = 20;
            this.grdDutyRooster.Size = new System.Drawing.Size(1228, 391);
            this.grdDutyRooster.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(806, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmDutyRooster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(882, 512);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdDutyRooster);
            this.Controls.Add(this.dtpMonthDate);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox2);
            this.KeyPreview = true;
            this.Name = "frmDutyRooster";
            this.Text = "Duty Rooster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDutyRooster_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDutyRooster_KeyPress);
            this.Resize += new System.EventHandler(this.frmDutyRooster_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDutyRooster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dtpMonthDate;
        private System.Windows.Forms.DataGridView grdDutyRooster;
        private System.Windows.Forms.Button btnSave;
    }
}