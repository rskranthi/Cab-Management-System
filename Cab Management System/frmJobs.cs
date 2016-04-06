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
    public partial class frmJobs : Form
    {
        DataTable dt;
        DataRow row;
        string[] Times = { "12:00 AM", "12:30 AM", "01:00 AM", "01:30 AM", "02:00 AM", "02:30 AM", "03:00 AM", "03:30 AM", "04:00 AM", "04:30 AM", "05:00 AM", "05:30 AM", "06:00 AM", "06:30 AM", "07:00 AM", "07:30 AM", "08:00 AM", "08:30 AM", "09:00 AM", "09:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "12:00 PM", "12:30 PM", "01:00 PM", "01:30 PM", "02:00 PM", "02:30 PM", "03:00 PM", "03:30 PM", "03:30 PM", "04:00 PM", "04:30 PM", "05:00 PM", "05:30 PM", "06:00 PM", "06:30 PM", "07:00 PM", "07:30 PM", "08:00 PM", "08:30 PM", "09:00 PM", "09:30 PM", "10:00 PM", "10:30 PM", "11:00 PM", "11:30 PM"};
        DataBase db = new DataBase();

        public frmJobs()
        {
            InitializeComponent();
        }

        private void frmJobs_Load(object sender, EventArgs e)
        {
            db.FillCombo("Select * from Tbl_Drivers where Company_ID=" + Program.CompanyID + " order by Driver_Name", "Tbl_Drivers", cmbDrivers);
            db.FillCombo("Select * from Tbl_Bookings where Company_ID=" + Program.CompanyID + " order by Job_ID", "Tbl_Bookings", cmbJobID);
            db.FillList("Select * from  Tbl_Bookings where format(PickUp_DateTime,'dd-mmm-yyyy')='" + dtpDate.Text + "' and Company_ID=" + Program.CompanyID + " order by Job_ID", "Tbl_Bookings", lstJobs);

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FillJobs();
            FillGrid(); 
        }
        private void FillGrid()
        {
            DataTable dt1 = db.ExecuteTable("Select * from Tbl_Bookings B, Tbl_Drivers D where B.Driver_ID=D.Driver_ID and B.Company_ID=D.Company_ID and format(B.PickUp_DateTime,'dd-mmm-yyyy')='" + dtpDate.Text + "' and B.Company_ID=" + Program.CompanyID, "Tbl_Bookings");
            for (int i = 0; i < dt1.Rows.Count; i++)
                OccupyGrid(Convert.ToDateTime(dt1.Rows[i]["PickUp_DateTime"]).ToShortTimeString(), Convert.ToDateTime(dt1.Rows[i]["Drop_DateTime"]).ToShortTimeString(), dt1.Rows[i]["Driver_Name"].ToString(), dt1.Rows[i]["Job_ID"].ToString());
        }
        private void frmJobs_Resize(object sender, EventArgs e)
        {
            grdJobs.Width = this.Width - 150;
            grdJobs.Height = this.Height - 230;
            lstJobs.Height = this.Height - 250;
            pictureBox1.Width = this.Width;
            groupBox1.Width = this.Width - 20;
            lblJobs.Left = this.Width - 75;  
        }

        private void FillJobs()
        {
            int cnt = Convert.ToInt32(db.getRecord("Select count(*) from Tbl_Drivers where Company_ID=" + Program.CompanyID));
            dt = new DataTable("Tbl_Drivers");
            DataColumn c1 = new DataColumn("Time", System.Type.GetType("System.String"));
            dt.Columns.Add(c1);

            DataColumn[] d = new DataColumn[cnt];

            db.OpenConnection();
            db.Dcmd = new System.Data.OleDb.OleDbCommand("Select Driver_Name from Tbl_Drivers where Company_ID=" + Program.CompanyID, db.DCon);
            System.Data.OleDb.OleDbDataReader dr = db.Dcmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                d[i] = new DataColumn(dr["Driver_Name"].ToString() , System.Type.GetType("System.String"));
                dt.Columns.Add(d[i]);
                i++;
            }
            grdJobs.DataSource = dt;  
            dr.Close();
            db.Dcmd.Dispose();  
            db.CloseConnection();

            for (int j = 0; j < 49; j++)
            {
                row = dt.NewRow();
                row["Time"] = Times[j];
                dt.Rows.Add(row);
            }
        }

        private void frmJobs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbDrivers.SelectedIndex == -1)
            {
                MessageBox.Show("Driver Name should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbDrivers.Focus();
                return;
            }
            if(dtpDate.Text  == dtpPickUpDate.Text)   
                OccupyGrid(dtpPickUpTime.Text, dtpDropTime.Text, cmbDrivers.Text, cmbJobID.Text);          
          
            if (db.SUD("Update Tbl_Bookings Set PickUp_DateTime='" + dtpPickUpDate.Text + " " + dtpPickUpTime.Text + "',Drop_DateTime='" + dtpDropDate.Text + " " + dtpDropTime.Text + "',Vehicle_No='" + cmbVehicleNo.Text + "', Driver_ID=" + cmbDrivers.SelectedValue.ToString() + " Where Job_ID= " + cmbJobID.Text.Trim().Replace("'", "''") + " and Company_ID=" + Program.CompanyID.ToString()) != 0)
            {
                MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }
        private void OccupyGrid(string pt, string dtt, string driver, string jobID)
        {
            for (int i = 0; i < grdJobs.RowCount - 1; i++)
            {
                if (Convert.ToDateTime(grdJobs.Rows[i].Cells["Time"].Value.ToString()) >= Convert.ToDateTime(pt) && Convert.ToDateTime(grdJobs.Rows[i].Cells["Time"].Value.ToString()) <= Convert.ToDateTime(dtt))
                {
                    grdJobs.Rows[i].Cells[driver].Style.BackColor = Color.FromArgb(104, 134, 172);
                    grdJobs.Rows[i].Cells[driver].Value = jobID;
                }
            }
        }
        private void ClearFields()
        {
            cmbJobID.SelectedIndex = -1;
            txtCustomerName.Text = "";
            txtVehicleName.Text = "";
            chkAC.Checked = false;
            txtFrom.Text = "";
            txtTo.Text = "";
            dtpPickUpDate.Value = dtpPickUpTime.Value = dtpDropDate.Value = dtpDropTime.Value = DateTime.Today;
            cmbVehicleNo.SelectedIndex = -1;
            cmbDrivers.SelectedIndex = -1;  
            cmbJobID.Focus();  
        }
        private void cmbJobID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                ShowDetails(); 
        }
        private void ShowDetails()
        {
            DataTable dt = db.ExecuteTable("Select B.*,(Select FL.Location_Name from Tbl_Locations FL where FL.Location_ID= B.PickUp_LocationID and FL.Company_ID = " + Program.CompanyID + ") as FromLocation, (Select TL.Location_Name from Tbl_Locations TL where TL.Location_ID= B.Drop_LocationID and TL.Company_ID = " + Program.CompanyID + ") as ToLocation, VT.Vehicle_Name  from Tbl_Bookings B , Tbl_VehicleTypes VT where B.Vehicle_NameID=VT.Vehicle_TypeID and B.Job_ID=" + cmbJobID.Text.Trim().Replace("'", "''") + " and B.Company_ID=" + Program.CompanyID, "Tbl_Bookings");
            txtCustomerName.Text = dt.Rows[0]["Customer_Name"].ToString();
            txtFrom.Text = dt.Rows[0]["FromLocation"].ToString();
            txtTo.Text = dt.Rows[0]["ToLocation"].ToString();
            txtVehicleName.Text = dt.Rows[0]["Vehicle_Name"].ToString();
            chkAC.Checked = (dt.Rows[0]["isAC"].ToString() == "0" ? false : true);
            dtpDropDate.Text = dt.Rows[0]["Drop_DateTime"].ToString();
            dtpDropTime.Text = dt.Rows[0]["Drop_DateTime"].ToString();
            dtpPickUpDate.Text = dt.Rows[0]["PickUp_DateTime"].ToString();
            dtpPickUpTime.Text = dt.Rows[0]["PickUp_DateTime"].ToString();
            cmbDrivers.SelectedIndex = -1;
            db.FillCombo("Select * from Tbl_Vehicles where Vehicle_TypeID= " + dt.Rows[0]["Vehicle_NameID"].ToString() + " and Company_ID=" + Program.CompanyID + " order by Vehicle_No", "Tbl_Vehicles", cmbVehicleNo);  
        }
        private void cmbVehicleNo_Validated(object sender, EventArgs e)
        {
            if (cmbVehicleNo.SelectedIndex == -1) return;
            cmbDrivers.SelectedValue = cmbVehicleNo.SelectedValue;  
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            FillGrid();
            db.FillList("Select * from  Tbl_Bookings where format(PickUp_DateTime,'dd-mmm-yyyy')='" + dtpDate.Text + "' and Company_ID=" + Program.CompanyID + " order by Job_ID", "Tbl_Bookings", lstJobs);
        }
       
        private void lstJobs_Click(object sender, EventArgs e)
        {
            if (lstJobs.SelectedIndex == -1) return;
            cmbJobID.Text = lstJobs.Text; 
            ShowDetails(); 
        }
    }
}
