using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CabMan
{
    public partial class frmVehicleTypes : Form
    {
        DataBase db = new DataBase(); 
        public frmVehicleTypes()
        {
            InitializeComponent();
        }
        private void frmVehicleTypes_Load(object sender, EventArgs e)
        {
            BusinessLogic.FillVehicleTypes(cmbVehicleType);
            db.FillGrid("Select * from Tbl_VehicleTypes where Vehicle_Type=" + cmbVehicleType.SelectedIndex.ToString() + " and Company_ID=" + Program.CompanyID.ToString(), "Tbl_VehicleTypes", grdVehicleType);   
            SetGridStyles();
        }
        private void frmVehicleTypes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");  
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbVehicleType.SelectedIndex==-1 )
            {
                MessageBox.Show("Vehicle Type should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbVehicleType.Focus();
                return;
            }
            if (txtVehicleName.Text.Trim() == "")
            {
                MessageBox.Show("Vehicle Name should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVehicleName.Focus();
                return;
            }
            try
            {
                if (btnSave.Text == "&Save")
                {
                    if (db.SUD("Insert into Tbl_VehicleTypes(Vehicle_Type,Vehicle_Name,Company_ID) Values (" + cmbVehicleType.SelectedIndex.ToString() + ",'" + txtVehicleName.Text.Trim().Replace("'", "''") + "'," + Program.CompanyID.ToString()+ ")") != 0)
                    {
                        MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
                else
                {
                    if (db.SUD("Update Tbl_VehicleTypes Set Vehicle_Name='" + txtVehicleName.Text.Trim().Replace("'", "''") + "' where Vehicle_TypeID=" + grdVehicleType.Rows[grdVehicleType.CurrentCell.RowIndex].Cells["Vehicle_TypeID"].Value.ToString()) != 0)
                    {
                        MessageBox.Show("Record Updated Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            cmbVehicleType.SelectedIndex = -1;
            txtVehicleName.Text = "";
            grdVehicleType.DataSource = null;
            db.FillGrid("Select * from Tbl_VehicleTypes where Vehicle_Type=" + cmbVehicleType.SelectedIndex.ToString() + " and Company_ID=" + Program.CompanyID.ToString(), "Tbl_VehicleTypes", grdVehicleType);
            SetGridStyles(); 
            cmbVehicleType.Focus();
            btnSave.Text = "&Save";  
        }
        private void SetGridStyles()
        {
            grdVehicleType.Columns["Vehicle_TypeID"].Visible = false;
            grdVehicleType.Columns["Vehicle_Type"].Visible = false;
            grdVehicleType.Columns["Vehicle_Name"].Width = 310;
            grdVehicleType.Columns["Company_ID"].Visible = false;
        }
        private void txtVehicleName_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSave; 
        }

        private void txtVehicleName_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null; 
        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVehicleType.SelectedIndex == -1) return;
            db.FillGrid("Select * from Tbl_VehicleTypes where Vehicle_Type=" + cmbVehicleType.SelectedIndex.ToString() + " and Company_ID=" + Program.CompanyID.ToString(), "Tbl_VehicleTypes", grdVehicleType);
            //SetGridStyles(); 
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "&Save") return;
            if (MessageBox.Show(this, "Are you sure to delete this record ?", "CabMan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                ClearFields();
                return;
            }
            if (db.SUD("Delete from Tbl_VehicleTypes where Vehicle_TypeID=" + grdVehicleType.Rows[grdVehicleType.CurrentCell.RowIndex].Cells["Vehicle_TypeID"].Value.ToString()) != 0)
            {
                MessageBox.Show("Record Deleted Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }
        private void grdVehicleType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtVehicleName.Text = grdVehicleType.Rows[e.RowIndex].Cells["Vehicle_Name"].Value.ToString();
            btnSave.Text = "&Update";
        }
    }
}
