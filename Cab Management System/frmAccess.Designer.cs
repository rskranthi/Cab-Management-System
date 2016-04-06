namespace CabMan
{
    partial class frmAccess
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.grdAccess = new System.Windows.Forms.DataGridView();
            this.Form_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Form_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Display_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccess)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(172)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(503, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Access";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CabMan.Properties.Resources.RCar_Header;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 87);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "User Name";
            // 
            // cmbUsers
            // 
            this.cmbUsers.DisplayMember = "User_Name";
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(346, 63);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(229, 21);
            this.cmbUsers.TabIndex = 0;
            this.cmbUsers.ValueMember = "User_ID";
            this.cmbUsers.Validated += new System.EventHandler(this.cmbUsers_Validated);
            // 
            // grdAccess
            // 
            this.grdAccess.AllowUserToAddRows = false;
            this.grdAccess.AllowUserToDeleteRows = false;
            this.grdAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAccess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Form_ID,
            this.Form_Name,
            this.Display_Name,
            this.Save,
            this.Update,
            this.Delete,
            this.Print});
            this.grdAccess.Location = new System.Drawing.Point(6, 90);
            this.grdAccess.Name = "grdAccess";
            this.grdAccess.RowHeadersWidth = 20;
            this.grdAccess.Size = new System.Drawing.Size(569, 372);
            this.grdAccess.TabIndex = 1;
            this.grdAccess.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccess_CellClick);
            // 
            // Form_ID
            // 
            this.Form_ID.HeaderText = "Form_ID";
            this.Form_ID.Name = "Form_ID";
            this.Form_ID.Visible = false;
            this.Form_ID.Width = 50;
            // 
            // Form_Name
            // 
            this.Form_Name.HeaderText = "Form Name";
            this.Form_Name.Name = "Form_Name";
            this.Form_Name.Width = 150;
            // 
            // Display_Name
            // 
            this.Display_Name.HeaderText = "Display Name";
            this.Display_Name.Name = "Display_Name";
            this.Display_Name.Width = 175;
            // 
            // Save
            // 
            this.Save.HeaderText = "Save";
            this.Save.Name = "Save";
            this.Save.Width = 50;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // Print
            // 
            this.Print.HeaderText = "Print";
            this.Print.Name = "Print";
            this.Print.Width = 50;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(500, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(419, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(580, 497);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdAccess);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "frmAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access";
            this.Load += new System.EventHandler(this.frmAccess_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAccess_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.DataGridView grdAccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Form_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Form_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Display_Name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Save;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Update;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Print;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}