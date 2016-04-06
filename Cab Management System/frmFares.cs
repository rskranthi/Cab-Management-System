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
    public partial class frmFares : Form
    {
        DataTable dt;
        DataRow row;
        DataBase db = new DataBase(); 
        public frmFares()
        {
            InitializeComponent();
        }

        private void frmFares_Load(object sender, EventArgs e)
        {
            BusinessLogic.FillVehicleTypes(cmbVehicleType);
            setGrid(); 
        }
        private void setGrid()
        {
            dt = new DataTable("TestTable");
            DataColumn col0 = new DataColumn("CarID", System.Type.GetType("System.String"));
            DataColumn col1 = new DataColumn("Car", System.Type.GetType("System.String"));
            DataColumn col2 = new DataColumn(@"Non4", System.Type.GetType("System.String"));
            DataColumn col3 = new DataColumn(@"Non8", System.Type.GetType("System.String"));
            DataColumn col4 = new DataColumn("NonXHrs", System.Type.GetType("System.String"));
            DataColumn col5 = new DataColumn("NonXKms", System.Type.GetType("System.String"));
            DataColumn col6 = new DataColumn("NonGeneral", System.Type.GetType("System.String"));
            DataColumn col7 = new DataColumn(@"AC4", System.Type.GetType("System.String"));
            DataColumn col8 = new DataColumn(@"AC8", System.Type.GetType("System.String"));
            DataColumn col9 = new DataColumn("ACXHrs", System.Type.GetType("System.String"));
            DataColumn col10 = new DataColumn("ACXKms", System.Type.GetType("System.String"));
            DataColumn col11 = new DataColumn("ACGeneral", System.Type.GetType("System.String"));

            dt.Columns.Add(col0);
            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            dt.Columns.Add(col5);
            dt.Columns.Add(col6);   
            dt.Columns.Add(col7);
            dt.Columns.Add(col8);
            dt.Columns.Add(col9);
            dt.Columns.Add(col10);
            dt.Columns.Add(col11);
            grdFareList.DataSource = dt;

            grdFareList.Columns["CarID"].Visible = false; 
            grdFareList.Columns["Non4"].HeaderText = @"4Hrs\40Kms";
            grdFareList.Columns["Non4"].Width = 70; 
            grdFareList.Columns["Non8"].HeaderText = @"8Hrs\80Kms";
            grdFareList.Columns["Non8"].Width = 70; 
            grdFareList.Columns["NonXHrs"].HeaderText = "Extra Hrs";
            grdFareList.Columns["NonXHrs"].Width = 55; 
            grdFareList.Columns["NonXKms"].HeaderText = "Extra Kms";
            grdFareList.Columns["NonXKms"].Width = 55; 
            grdFareList.Columns["NonGeneral"].HeaderText = "General";
            grdFareList.Columns["NonGeneral"].Width = 50; 
            grdFareList.Columns["AC4"].HeaderText = @"AC 4Hrs\40Kms";
            grdFareList.Columns["AC4"].Width = 70; 
            grdFareList.Columns["AC8"].HeaderText = @"8Hrs\80Kms";
            grdFareList.Columns["AC8"].Width = 70; 
            grdFareList.Columns["ACXHrs"].HeaderText = "Extra Hrs";
            grdFareList.Columns["ACXHrs"].Width = 60; 
            grdFareList.Columns["ACXKms"].HeaderText = "Extra Kms";
            grdFareList.Columns["ACXKms"].Width = 60; 
            grdFareList.Columns["ACGeneral"].HeaderText = "AC General";
            grdFareList.Columns["ACGeneral"].Width = 60; 
        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVehicleType.SelectedIndex == -1) return;
            dt.Rows.Clear();  

            db.OpenConnection();
            db.Dcmd = new System.Data.OleDb.OleDbCommand("Select * from Tbl_VehicleTypes where Vehicle_Type=" + cmbVehicleType.SelectedIndex.ToString() + " and Company_ID=" + Program.CompanyID.ToString(), db.DCon);
            System.Data.OleDb.OleDbDataReader dr = db.Dcmd.ExecuteReader();
            while (dr.Read())
            {
                row = dt.NewRow();
                row["CarID"] = dr["Vehicle_TypeID"].ToString(); 
                row["Car"] = dr["Vehicle_Name"].ToString(); 
                dt.Rows.Add(row);
            }
            dr.Close();
            db.Dcmd.Dispose();  
            db.CloseConnection();

            db.DisplayFares(grdFareList,dt);
        }
        private void frmFares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");  
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbVehicleType.SelectedIndex == -1)
            {
                MessageBox.Show("Vehicle Type should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbVehicleType.Focus();
                return;
            }
            db.SaveFares(grdFareList);
            MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);        
            dt.Rows.Clear();
            cmbVehicleType.SelectedIndex = -1;  
        }
    }
}
