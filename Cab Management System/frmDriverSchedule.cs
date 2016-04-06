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
    public partial class frmDriverSchedule : Form
    {
        DataBase db = new DataBase(); 
        public frmDriverSchedule()
        {
            InitializeComponent();
        }

        private void frmDriverSchedule_Load(object sender, EventArgs e)
        {
            //grdBookings.Rows.Add(1);
            FillGrid();
            FillVehicleNos();
            FillDrivers();
        }

        private void FillVehicleNos()
        {
            DataTable dtF = db.ExecuteTable("Select Vehicle_No from Tbl_Vehicles where Company_ID=" + Program.CompanyID, "Tbl_Vehicles");
            if (dtF.Rows.Count == 0) return;
            Vehicle_No.Items.Add("");
            for (int i = 0; i < dtF.Rows.Count; i++)
                Vehicle_No.Items.Add(dtF.Rows[i]["Vehicle_No"].ToString());      
        }
        private void FillDrivers()
        {
            DataTable dtD = db.ExecuteTable("Select * from Tbl_Drivers where Company_ID=" + Program.CompanyID, "Tbl_Drivers");
            if (dtD.Rows.Count == 0) return;
            Driver_Name.Items.Add("");
            Driver_Name.DisplayMember = "Driver_Name";
            Driver_Name.ValueMember = "Driver_ID"; 
            for (int i = 0; i < dtD.Rows.Count; i++)
                Driver_Name.Items.Add(dtD.Rows[i]["Driver_Name"].ToString());
        }
        private void FillGrid()
        {
            DataTable dt = db.ExecuteTable("SELECT *,(Select Location_Name from Tbl_Locations where Location_ID=B.PickUp_LocationID and Company_ID=" + Program.CompanyID + ") as FromLocation,(Select Location_Name from Tbl_Locations where Location_ID=B.Drop_LocationID  and Company_ID=" + Program.CompanyID + ") as ToLocation FROM Tbl_ShuttleBookings B, Tbl_Employees E where B.Company_ID=E.Company_ID and B.Company_ID=" + Program.CompanyID + " and Month(SBDate)=" + dtpDate.Value.Month.ToString() + " and Year(SBDate)=" + dtpDate.Value.Year.ToString() , "Tbl_ShuttleBookings");
            if (dt.Rows.Count == 0) return;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                grdBookings.Rows.Add(1);
                grdBookings.Rows[i].Cells["Booking_ID"].Value = dt.Rows[i]["Booking_ID"].ToString();
                grdBookings.Rows[i].Cells["Employee_ID"].Value = dt.Rows[i]["B.Employee_ID"].ToString();
                grdBookings.Rows[i].Cells["Employee_Name"].Value = dt.Rows[i]["Employee_Name"].ToString();
                grdBookings.Rows[i].Cells["FromDateTime"].Value = dt.Rows[i]["PickUpDateTime"].ToString();
                grdBookings.Rows[i].Cells["ToDateTime"].Value = dt.Rows[i]["DropDateTime"].ToString();
                
                grdBookings.Rows[i].Cells["From_LocationID"].Value = dt.Rows[i]["PickUp_LocationID"].ToString();
                grdBookings.Rows[i].Cells["From_LocationName"].Value = dt.Rows[i]["FromLocation"].ToString();
                grdBookings.Rows[i].Cells["To_LocationID"].Value = dt.Rows[i]["Drop_LocationID"].ToString();
                grdBookings.Rows[i].Cells["To_LocationName"].Value = dt.Rows[i]["ToLocation"].ToString();
            }   
        }

        private void frmDriverSchedule_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = false; 
            for (int i = 0; i < grdBookings.Rows.Count; i++)
            {
                if (grdBookings.Rows[i].Cells["Vehicle_No"].Value != null && grdBookings.Rows[i].Cells["Driver_Name"].Value !=  null)
                {
                    flag = true;
                    db.SUD("UPDATE Tbl_ShuttleBookings set Vehicle_No='" + grdBookings.Rows[i].Cells["Vehicle_No"].Value.ToString() + "' where Company_ID=" + Program.CompanyID + " and Booking_ID=" + grdBookings.Rows[i].Cells["Booking_ID"].Value.ToString());      
                }
            }
            if(flag) 
                MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
