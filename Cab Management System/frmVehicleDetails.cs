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
    public partial class frmVehicleDetails : Form
    {
        DataBase db = new DataBase(); 
        public frmVehicleDetails()
        {
            InitializeComponent();
        }

        private void frmVehicleDetails_Load(object sender, EventArgs e)
        {
            nudModel.Value = DateTime.Today.Year;     
            BusinessLogic.FillVehicleTypes(cmbVehicleType);
            db.FillCombo("Select * from Tbl_Drivers where Company_ID=" + Program.CompanyID.ToString() + " order by Driver_Name", "Tbl_Drivers", cmbDriver);
            db.FillGrid("Select * from V_Vehicles where Company_ID=" + Program.CompanyID.ToString(), "V_Vehicles", grdVehicleDetails);
            SetGridStyles(); 
        }
        private void SetGridStyles()
        {
            grdVehicleDetails.Columns["Vehicle_ID"].Visible = false;
            grdVehicleDetails.Columns["Vehicle_No"].Width = 150;
            grdVehicleDetails.Columns["Vehicle_TypeID"].Visible = false;
            grdVehicleDetails.Columns["isAC"].Visible = false;
            grdVehicleDetails.Columns["Vehicle_Type"].Visible = false;
            grdVehicleDetails.Columns["Seating_Capacity"].Visible = false;
            grdVehicleDetails.Columns["Luggage_Capacity"].Visible = false;
            grdVehicleDetails.Columns["Color"].Visible = false;
            grdVehicleDetails.Columns["Make"].Visible = false;
            grdVehicleDetails.Columns["Model"].Visible = false;
            grdVehicleDetails.Columns["Registration_No"].Visible = false;
            grdVehicleDetails.Columns["Insurance_No"].Visible = false;
            grdVehicleDetails.Columns["Insurance_Expired"].Visible = false;
            grdVehicleDetails.Columns["Insurance_Premium"].Visible = false;
            grdVehicleDetails.Columns["Driver_ID"].Visible = false;
            grdVehicleDetails.Columns["Vehicle_Owner"].Visible = false;
            grdVehicleDetails.Columns["Comments"].Visible = false;
            grdVehicleDetails.Columns["Company_ID"].Visible = false;
            grdVehicleDetails.Columns["Vehicle_Name"].Width = 150;
            grdVehicleDetails.Columns["Driver_Name"].Width = 280;

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    txtVehicleNo.Focus();  
                    break; 
                case 1:
                    txtColor.Focus();  
                    break; 
                case 2:
                    txtRegistrationNo.Focus();  
                    break; 
                case 3:
                    cmbDriver.Focus();  
                    break; 
            }
        }

        private void frmVehicleDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");  
        }

        private void cmbVehicleType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillVehicleNames(); 
        }

        private void FillVehicleNames()
        {
            if (cmbVehicleType.SelectedIndex == -1)
            {
                cmbVehicleName.Items.Clear();
                return;
            }
            db.FillCombo("Select * from Tbl_VehicleTypes where Vehicle_Type=" + cmbVehicleType.SelectedIndex.ToString() + " and Company_ID=" + Program.CompanyID.ToString(), "Tbl_VehicleTypes", cmbVehicleName);
        }

        private void ClearFields()
        {
            txtVehicleNo.Text = "";
            cmbVehicleType.SelectedIndex = -1;
            cmbVehicleName.SelectedIndex = -1;
            chkAC.Checked = false;  
            nudSeatingCapacity.Value = 2;
            nudLuggageCapacity.Value = 0;
            txtColor.Text = "";
            txtMake.Text = "";
            nudModel.Value = DateTime.Today.Year;
            txtRegistrationNo.Text = "";
            txtInsuranceNo.Text = "";
            dtpInsuranceExpired.Text = DateTime.Today.ToShortDateString();
            txtInsurancePremium.Text = "";
            
            cmbDriver.SelectedIndex = -1;
            txtVehicleOwner.Text = "";
            txtComments.Text = "";  
            btnSave.Text = "&Save";  
            txtVehicleNo.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtVehicleNo.Text.Trim()=="")
            {
                MessageBox.Show("Vehicle No should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVehicleNo.Focus();
                return;
            }
            if (cmbVehicleType.SelectedIndex==-1 )
            {
                MessageBox.Show("Vehicle Type should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbVehicleType.Focus();
                return;
            }
            if (cmbVehicleName.SelectedIndex==-1 )
            {
                MessageBox.Show("Vehicle Name should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbVehicleName.Focus();
                return;
            }
            try
            {
                if (btnSave.Text == "&Save")
                {
                    if (db.SUD("Insert into Tbl_Vehicles(Vehicle_No,Vehicle_TypeID,isAC,Seating_Capacity,Luggage_Capacity,Color,Make,Model,Registration_No,Insurance_No,Insurance_Expired,Insurance_Premium,Driver_ID,Vehicle_Owner,Comments,Company_ID) Values ('" + txtVehicleNo.Text.Trim().Replace("'", "''") + "'," + cmbVehicleName.SelectedValue.ToString() + "," + (chkAC.Checked ? "1" : "0") + "," + nudSeatingCapacity.Value.ToString() + "," + nudLuggageCapacity.Value.ToString() + ",'" + txtColor.Text.Trim().Replace("'", "''") + "','" + txtMake.Text.Trim().Replace("'", "''") + "'," + nudModel.Value.ToString() + ",'" + txtRegistrationNo.Text.Trim().Replace("'", "''") + "','" + txtInsuranceNo.Text.Trim().Replace("'", "''") + "','" + dtpInsuranceExpired.Text + "'," + (txtInsurancePremium.Text.Trim() == "" ? "0" : txtInsurancePremium.Text.Trim().Replace("'", "''")) + "," + (cmbDriver.SelectedIndex == -1 ? "-1" : cmbDriver.SelectedValue.ToString()) + ",'" + txtVehicleOwner.Text.Trim().Replace("'", "''") + "','" + txtComments.Text.Trim().Replace("'", "''") + "'," + Program.CompanyID.ToString() + ")") != 0)
                    {
                        MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select * from V_Vehicles where Company_ID=" + Program.CompanyID.ToString(), "V_Vehicles", grdVehicleDetails);
                        ClearFields();
                    }
                }
                else
                {
                    string s = "Update Tbl_Vehicles Set Vehicle_No='" + txtVehicleNo.Text.Trim().Replace("'", "''") + "',Vehicle_TypeID=" + cmbVehicleName.SelectedValue.ToString() + ",isAC=" + (chkAC.Checked ? "1" : "0") + ",Seating_Capacity=" + nudSeatingCapacity.Value.ToString() + ",Luggage_Capacity=" + nudLuggageCapacity.Value.ToString() + ",Color='" + txtColor.Text.Trim().Replace("'", "''") + "',Make='" + txtMake.Text.Trim().Replace("'", "''") + "',Model=" + nudModel.Value.ToString() + ",Registration_No='" + txtRegistrationNo.Text.Trim().Replace("'", "''") + "',Insurance_No='" + txtInsuranceNo.Text.Trim().Replace("'", "''") + "',Insurance_Expired='" + dtpInsuranceExpired.Text + "',Insurance_Premium=" + (txtInsurancePremium.Text.Trim() == "" ? "0" : txtInsurancePremium.Text.Trim().Replace("'", "''")) + ",Driver_ID=" + (cmbDriver.SelectedIndex == -1 ? "-1" : cmbDriver.SelectedValue.ToString()) + ",Vehicle_Owner='" + txtVehicleOwner.Text.Trim().Replace("'", "''") + "',Comments='" + txtComments.Text.Trim().Replace("'", "''") + "' Where Vehicle_ID=" + grdVehicleDetails.Rows[grdVehicleDetails.CurrentCell.RowIndex].Cells["Vehicle_ID"].Value.ToString() + " and Company_ID=" + Program.CompanyID.ToString();
                    if (db.SUD(s)!=0)
                    {
                        MessageBox.Show("Record Updated Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select * from V_Vehicles where Company_ID=" + Program.CompanyID.ToString(), "V_Vehicles", grdVehicleDetails);
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "&Save") return;
            if (MessageBox.Show(this, "Are you sure to delete this record ?", "CabMan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                ClearFields();
                return;
            }
            if (db.SUD("Delete from Tbl_Vehicles where Vehicle_ID=" + grdVehicleDetails.Rows[grdVehicleDetails.CurrentCell.RowIndex].Cells["Vehicle_ID"].Value.ToString() + " and Company_ID=" + Program.CompanyID.ToString()) != 0)
            {
                MessageBox.Show("Record Deleted Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.FillGrid("Select * from V_Vehicles where Company_ID=" + Program.CompanyID.ToString(), "V_Vehicles", grdVehicleDetails);
                ClearFields();
            }
        }

        private void grdVehicleDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtVehicleNo.Text = grdVehicleDetails.Rows[e.RowIndex].Cells["Vehicle_No"].Value.ToString();
            cmbVehicleType.SelectedIndex = Convert.ToInt32(grdVehicleDetails.Rows[e.RowIndex].Cells["Vehicle_Type"].Value.ToString());
            FillVehicleNames();             
            cmbVehicleName.SelectedValue = grdVehicleDetails.Rows[e.RowIndex].Cells["Vehicle_TypeID"].Value.ToString();
            chkAC.Checked = (grdVehicleDetails.Rows[e.RowIndex].Cells["isAC"].Value.ToString() == "0" ? false : true);
            nudSeatingCapacity.Value = Convert.ToInt32((grdVehicleDetails.Rows[e.RowIndex].Cells["Seating_Capacity"].Value.ToString() == "" ? "0" : grdVehicleDetails.Rows[e.RowIndex].Cells["Seating_Capacity"].Value.ToString()));
            nudLuggageCapacity.Value = Convert.ToInt32(grdVehicleDetails.Rows[e.RowIndex].Cells["Luggage_Capacity"].Value.ToString() == "" ? "0" : grdVehicleDetails.Rows[e.RowIndex].Cells["Luggage_Capacity"].Value.ToString());
            txtColor.Text = grdVehicleDetails.Rows[e.RowIndex].Cells["Color"].Value.ToString();
            txtMake.Text = grdVehicleDetails.Rows[e.RowIndex].Cells["Make"].Value.ToString();
            nudModel.Value = Convert.ToInt32(grdVehicleDetails.Rows[e.RowIndex].Cells["Model"].Value.ToString() == "" ? "0" : grdVehicleDetails.Rows[e.RowIndex].Cells["Model"].Value.ToString());
            txtRegistrationNo.Text = grdVehicleDetails.Rows[e.RowIndex].Cells["Registration_No"].Value.ToString();
            txtInsuranceNo.Text = grdVehicleDetails.Rows[e.RowIndex].Cells["Insurance_No"].Value.ToString();
            dtpInsuranceExpired.Text = grdVehicleDetails.Rows[e.RowIndex].Cells["Insurance_Expired"].Value.ToString();
            txtInsurancePremium.Text = grdVehicleDetails.Rows[e.RowIndex].Cells["Insurance_Premium"].Value.ToString();
            
            cmbDriver.SelectedValue = grdVehicleDetails.Rows[e.RowIndex].Cells["Driver_ID"].Value.ToString();
            txtVehicleOwner.Text = grdVehicleDetails.Rows[e.RowIndex].Cells["Vehicle_Owner"].Value.ToString();
            txtComments.Text = grdVehicleDetails.Rows[e.RowIndex].Cells["Comments"].Value.ToString(); 
            btnSave.Text = "&Update";
            txtVehicleNo.Focus();  
        }

        private void txtInsurancePremium_KeyPress(object sender, KeyPressEventArgs e)
        {
            BusinessLogic.NumbersWithDecimals(sender, e);   
        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
