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
    public partial class frmBooking : Form
    {
        DataBase db = new DataBase(); 
        public frmBooking()
        {
            InitializeComponent();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            BusinessLogic.FillVehicleTypes(cmbVehicleType);
            Via();
            BookingTypes();
            db.FillCombo("Select * from Tbl_Locations where Company_ID=" + Program.CompanyID + " order by Location_Name", "Tbl_Locations", cmbPickUpLocation);
            db.FillCombo("Select * from Tbl_Locations where Company_ID=" + Program.CompanyID + " order by Location_Name", "Tbl_Locations", cmbDropLocation);
            db.FillGrid("Select B.*,(Select L.Location_Name from Tbl_Locations L where L.Location_ID=B.Drop_LocationID and L.Company_ID=B.Company_ID) as DropLocation from Tbl_Bookings B where B.Company_ID=" + Program.CompanyID + " and Booking_Date=#" + dtpBookingDate.Text + "#", "Tbl_Bookings", grdBookings);
            txtJobID.Text=db.getJobID(dtpBookingDate.Value).ToString() ;
            SetGridStyles(); 
        }

        private void SetGridStyles()
        {
            grdBookings.Columns["Job_ID"].Width = 80;
            grdBookings.Columns["Booking_Date"].Width = 80;
            grdBookings.Columns["Booking_Type"].Visible = false;
            grdBookings.Columns["Booking_Via"].Visible = false;
            grdBookings.Columns["PickUp_DateTime"].Width = 110;
            grdBookings.Columns["PickUp_LocationID"].Visible = false;
            grdBookings.Columns["PickUp_Address"].Visible = false;
            grdBookings.Columns["Drop_DateTime"].Width = 110;
            grdBookings.Columns["Drop_LocationID"].Visible = false;
            grdBookings.Columns["Drop_Address"].Visible = false;
            grdBookings.Columns["Customer_Name"].Width = 170;
            grdBookings.Columns["Customer_Address"].Visible = false;
            grdBookings.Columns["Customer_ContactNo"].Visible = false;
            grdBookings.Columns["Total_Members"].Visible = false;
            grdBookings.Columns["Vehicle_TypeID"].Visible = false;
            grdBookings.Columns["Vehicle_NameID"].Visible = false;
            grdBookings.Columns["isAC"].Visible = false;
            grdBookings.Columns["Company_ID"].Visible = false;
            grdBookings.Columns["Vehicle_No"].Visible = false;
            grdBookings.Columns["Driver_ID"].Visible = false;
            grdBookings.Columns["Invoice_Date"].Visible = false;
            grdBookings.Columns["X_Hours"].Visible = false;
            grdBookings.Columns["X_Kms"].Visible = false;
            grdBookings.Columns["Driver_Expenses"].Visible = false;
            grdBookings.Columns["Others"].Visible = false;
            
            grdBookings.Columns["DropLocation"].Width = 120;
        }
        private void Via()
        {
            cmbBookingVia.Items.Add("Direct");
            cmbBookingVia.Items.Add("Phone");
            cmbBookingVia.Items.Add("SMS");
            cmbBookingVia.Items.Add("Email");
            cmbBookingVia.Items.Add("Agency");
            cmbBookingVia.Items.Add("Others");
        }

        private void BookingTypes()
        {
            cmbBookingType.Items.Add(@"4 Hrs\40 Kms");
            cmbBookingType.Items.Add(@"8 Hrs\80 Kms");
            cmbBookingType.Items.Add(@"General");
        }

        private void frmBooking_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");  
        }

        private void cmbVehicleType_Validated(object sender, EventArgs e)
        {
            if (cmbVehicleType.SelectedIndex == -1) return;   
            db.FillCombo("Select * from Tbl_VehicleTypes where Vehicle_Type=" + cmbVehicleType.SelectedIndex.ToString() + " and Company_ID=" + Program.CompanyID.ToString(), "Tbl_VehicleTypes", cmbVehicleName);
        }

        private void ClearFields()
        {
            dtpBookingDate.Text = dtpPickUpDate.Text = dtpDropDate.Text = dtpDropTime.Text = dtpPickUpTime.Text  = DateTime.Now.ToString() ;
            cmbVehicleName.SelectedIndex =  cmbVehicleType.SelectedIndex = cmbDropLocation.SelectedIndex = cmbBookingType.SelectedIndex = cmbBookingVia.SelectedIndex = cmbPickUpLocation.SelectedIndex = -1;
            lblEstimateDistance.Text = lblEstimateAmount.Text = txtContactNo.Text = txtCustomerAddress.Text = txtCustomerName.Text = txtDropAddress.Text = txtPickUpAddress.Text = "";  
            nudTotalMembers.Value = 1;
            chkAC.Checked = false;  
            btnSave.Text = "&Save";
            txtJobID.Text = db.getJobID(dtpBookingDate.Value).ToString();   
            cmbBookingType.Focus();  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbBookingType.SelectedIndex == -1)
            {
                MessageBox.Show("Booking Type should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbBookingType.Focus();
                return;
            }
            if (cmbBookingVia.SelectedIndex == -1)
            {
                MessageBox.Show("Booking Via should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbBookingVia.Focus();
                return;
            }
            if (dtpPickUpDate.Value > dtpDropDate.Value)
            {
                MessageBox.Show("PickUp Date should not be greater than Drop Date", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpDropDate.Focus();
                return;
            }
            if (cmbPickUpLocation.SelectedIndex == -1)
            {
                MessageBox.Show("Pickup Location should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbPickUpLocation.Focus();
                return;
            }
            if (cmbDropLocation.SelectedIndex == -1)
            {
                MessageBox.Show("Drop Location should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbDropLocation.Focus();
                return;
            }
            if (txtCustomerName.Text.Trim().Replace("'","''")=="")
            {
                MessageBox.Show("Customer Name should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerName.Focus();
                return;
            }
            if (txtContactNo.Text.Trim().Replace("'", "''") == "")
            {
                MessageBox.Show("Contact No should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContactNo.Focus();
                return;
            }
            if (cmbVehicleType.SelectedIndex == -1)
            {
                MessageBox.Show("Vehicle Type should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbVehicleType.Focus();
                return;
            }
            if (cmbVehicleName.SelectedIndex == -1)
            {
                MessageBox.Show("Vehicle Name should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbVehicleName.Focus();
                return;
            }
            try
            {
                if (btnSave.Text == "&Save")
                {
                    if (db.SUD("Insert into Tbl_Bookings(Job_ID,Booking_Date,Booking_Type,Booking_Via,PickUp_DateTime,PickUp_LocationID,PickUp_Address,Drop_DateTime,Drop_LocationID,Drop_Address,Customer_Name,Customer_Address,Customer_ContactNo,Total_Members,Vehicle_TypeID,Vehicle_NameID,isAC,Company_ID) Values ('" + txtJobID.Text   +"','" + dtpBookingDate.Text +  "'," + cmbBookingType.SelectedIndex.ToString() + "," + cmbBookingVia.SelectedIndex.ToString() + ",'" + dtpPickUpDate.Text + " " + dtpPickUpTime.Text + "'," + cmbPickUpLocation.SelectedValue.ToString() + ",'" + txtPickUpAddress.Text.Trim().Replace("'","''") + "','" + dtpDropDate.Text + " " + dtpDropTime.Text + "'," + cmbDropLocation.SelectedValue.ToString() + ",'" + txtDropAddress.Text.Trim().Replace("'","''") + "','" + txtCustomerName.Text.Trim().Replace("'","''") + "','" + txtCustomerAddress.Text.Trim().Replace("'","''") + "','" + txtContactNo.Text.Trim().Replace("'","''") + "'," + nudTotalMembers.Value.ToString() + "," + cmbVehicleType.SelectedIndex.ToString() + "," + cmbVehicleName.SelectedValue.ToString() + "," + (chkAC.Checked == true?1:0) + "," + Program.CompanyID.ToString() + ")") != 0)
                    {
                        MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select B.*,(Select L.Location_Name from Tbl_Locations L where L.Location_ID=B.Drop_LocationID and L.Company_ID=B.Company_ID) as DropLocation from Tbl_Bookings B where B.Company_ID=" + Program.CompanyID + " and Booking_Date=#" + dtpBookingDate.Text + "#", "Tbl_Bookings", grdBookings);
                        ClearFields();
                    }
                }
                else
                {
                    if (db.SUD("Update Tbl_Bookings Set Booking_Type=" + cmbBookingType.SelectedIndex.ToString() + ", Booking_Via=" + cmbBookingVia.SelectedIndex.ToString() + ",PickUp_DateTime='" + dtpPickUpDate.Text + " " + dtpPickUpTime.Text + "',PickUp_LocationID=" + cmbPickUpLocation.SelectedValue.ToString() + ",PickUp_Address='" + txtPickUpAddress.Text.Trim().Replace("'","''") + "',Drop_DateTime='" + dtpDropDate.Text + " " + dtpDropTime.Text + "',Drop_LocationID=" + cmbDropLocation.SelectedValue.ToString() + ",Drop_Address='" + txtDropAddress.Text.Trim().Replace("'","''") + "',Customer_Name='" + txtCustomerName.Text.Trim().Replace("'","''") + "',Customer_Address='" + txtCustomerAddress.Text.Trim().Replace("'","''") + "',Customer_ContactNo='" + txtContactNo.Text.Trim().Replace("'","''") + "',Total_Members=" + nudTotalMembers.Value.ToString() + ",Vehicle_TypeID=" + cmbVehicleType.SelectedIndex.ToString() + ",Vehicle_NameID=" +  cmbVehicleName.SelectedValue.ToString() + ",isAC=" + (chkAC.Checked == true?1:0) + " Where Job_ID=" + txtJobID.Text + " and Company_ID=" + Program.CompanyID.ToString())!=0)    
                    {
                        MessageBox.Show("Record Updated Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select B.*,(Select L.Location_Name from Tbl_Locations L where L.Location_ID=B.Drop_LocationID and L.Company_ID=B.Company_ID) as DropLocation from Tbl_Bookings B where B.Company_ID=" + Program.CompanyID + " and Booking_Date=#" + dtpBookingDate.Text + "#", "Tbl_Bookings", grdBookings);
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtJobID.Text = grdBookings.Rows[e.RowIndex].Cells["Job_ID"].Value.ToString();
            cmbBookingType.SelectedIndex = Convert.ToInt32(grdBookings.Rows[e.RowIndex].Cells["Booking_Type"].Value.ToString()); 
            cmbBookingVia.SelectedIndex  = Convert.ToInt32(grdBookings.Rows[e.RowIndex].Cells["Booking_Via"].Value.ToString());
            dtpPickUpDate.Text = grdBookings.Rows[e.RowIndex].Cells["PickUp_DateTime"].Value.ToString();
            dtpPickUpTime.Text = grdBookings.Rows[e.RowIndex].Cells["PickUp_DateTime"].Value.ToString();
            cmbPickUpLocation.SelectedValue = grdBookings.Rows[e.RowIndex].Cells["PickUp_LocationID"].Value.ToString();
            txtPickUpAddress.Text = grdBookings.Rows[e.RowIndex].Cells["PickUp_Address"].Value.ToString();
            dtpDropDate.Text = grdBookings.Rows[e.RowIndex].Cells["Drop_DateTime"].Value.ToString();
            dtpDropTime.Text = grdBookings.Rows[e.RowIndex].Cells["Drop_DateTime"].Value.ToString();
            cmbDropLocation.SelectedValue = grdBookings.Rows[e.RowIndex].Cells["Drop_LocationID"].Value.ToString();
            txtDropAddress.Text = grdBookings.Rows[e.RowIndex].Cells["Drop_Address"].Value.ToString();
            txtCustomerName.Text = grdBookings.Rows[e.RowIndex].Cells["Customer_Name"].Value.ToString();
            txtCustomerAddress.Text = grdBookings.Rows[e.RowIndex].Cells["Customer_Address"].Value.ToString();
            txtContactNo.Text = grdBookings.Rows[e.RowIndex].Cells["Customer_ContactNo"].Value.ToString();
            nudTotalMembers.Text = grdBookings.Rows[e.RowIndex].Cells["Total_Members"].Value.ToString();
            cmbVehicleType.SelectedIndex = Convert.ToByte(grdBookings.Rows[e.RowIndex].Cells["Vehicle_TypeID"].Value.ToString());
            db.FillCombo("Select * from Tbl_VehicleTypes where Vehicle_Type=" + cmbVehicleType.SelectedIndex.ToString() + " and Company_ID=" + Program.CompanyID.ToString(), "Tbl_VehicleTypes", cmbVehicleName);
            chkAC.Checked = (grdBookings.Rows[e.RowIndex].Cells["isAC"].Value.ToString() == "0" ? false : true);
            cmbVehicleName.SelectedValue= Convert.ToByte(grdBookings.Rows[e.RowIndex].Cells["Vehicle_NameID"].Value.ToString());
            //lblEstimateDistance.Text = grdBookings.Rows[e.RowIndex].Cells["Estimate_Distance"].Value.ToString();
            //lblEstimateAmount.Text = grdBookings.Rows[e.RowIndex].Cells["Estimate_Amount"].Value.ToString(); 
            btnSave.Text = "&Update";  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "&Save") return;
            if (MessageBox.Show(this, "Are you sure to delete this record ?", "CabMan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                ClearFields();
                return;
            }
            if (db.SUD("Delete from Tbl_Bookings where Job_ID=" + grdBookings.Rows[grdBookings.CurrentCell.RowIndex].Cells["Job_ID"].Value.ToString() + " and Company_ID=" + Program.CompanyID.ToString()) != 0)
            {
                MessageBox.Show("Record Deleted Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.FillGrid("Select B.*,(Select L.Location_Name from Tbl_Locations L where L.Location_ID=B.Drop_LocationID and L.Company_ID=B.Company_ID) as DropLocation from Tbl_Bookings B where B.Company_ID=" + Program.CompanyID + " and Booking_Date=#" + dtpBookingDate.Text + "#", "Tbl_Bookings", grdBookings);
                ClearFields();
            }
        }

        private void dtpBookingDate_ValueChanged(object sender, EventArgs e)
        {
            txtJobID.Text = db.getJobID(dtpBookingDate.Value).ToString() ;
            db.FillGrid("Select B.*,(Select L.Location_Name from Tbl_Locations L where L.Location_ID=B.Drop_LocationID and L.Company_ID=B.Company_ID) as DropLocation from Tbl_Bookings B where B.Company_ID=" + Program.CompanyID + " and Booking_Date=#" + dtpBookingDate.Text + "#", "Tbl_Bookings", grdBookings);
        }
        
        private void ShowEstimateAmount()
        {
            if (cmbBookingType.SelectedIndex == -1 || cmbVehicleName.SelectedIndex==-1 ) return;
            DataTable dt = db.ExecuteTable("Select * from Tbl_Fares where Vehicle_TypeID=" + cmbVehicleName.SelectedValue.ToString() + " and Company_ID=" + Program.CompanyID, "Tbl_Fares");
            if (chkAC.Checked)
            {
                switch(cmbBookingType.SelectedIndex)
                {
                    case 0:
                        lblEstimateAmount.Text = dt.Rows[0]["AC4"].ToString();  
                        break;
                    case 1:
                        lblEstimateAmount.Text = dt.Rows[0]["AC8"].ToString();  
                        break;
                    case 2:
                        lblEstimateAmount.Text = dt.Rows[0]["ACGeneral"].ToString();  
                        break;
                }
            }
            else
            {
                switch (cmbBookingType.SelectedIndex)
                {
                    case 0:
                        lblEstimateAmount.Text = dt.Rows[0]["Non4"].ToString();
                        break;
                    case 1:
                        lblEstimateAmount.Text = dt.Rows[0]["Non8"].ToString();
                        break;
                    case 2:
                        lblEstimateAmount.Text = dt.Rows[0]["NonGeneral"].ToString();
                        break;
                }
            }
        }

        private void cmbBookingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEstimateAmount(); 
        }

        private void cmbVehicleName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEstimateAmount(); 
        }

        private void chkAC_CheckedChanged(object sender, EventArgs e)
        {
            ShowEstimateAmount(); 
        }
    }
}
