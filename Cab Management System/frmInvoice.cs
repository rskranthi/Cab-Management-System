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
    public partial class frmInvoice : Form
    {
        DataBase db = new DataBase();
        DataTable dtMain;
        DataRow row;
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            chkPrintAfterSave.Checked = (System.Configuration.ConfigurationManager.AppSettings["PrintAfterSave"].ToString() == "1" ? true : false); 
            db.FillCombo("Select * from Tbl_Bookings where Company_ID=" + Program.CompanyID + " order by Job_ID", "Tbl_Bookings", cmbJobID);
            dtMain = new DataTable("TestTable");
            DataColumn col0 = new DataColumn("Description", System.Type.GetType("System.String"));
            DataColumn col1 = new DataColumn("temp", System.Type.GetType("System.String"));
            DataColumn col2 = new DataColumn("Value", System.Type.GetType("System.String"));
            DataColumn col3 = new DataColumn("Amount", System.Type.GetType("System.String"));
            dtMain.Columns.Add(col0);
            dtMain.Columns.Add(col1);
            dtMain.Columns.Add(col2);
            dtMain.Columns.Add(col3);

            grdInvoice.DataSource = dtMain;
            grdInvoice.Columns[0].Width = 260;
            grdInvoice.Columns[0].ReadOnly = true;
            grdInvoice.Columns[1].Visible = false; 
            grdInvoice.Columns[2].Width = 100;
            grdInvoice.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdInvoice.Columns[3].Width = 102;
            grdInvoice.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            row = dtMain.NewRow();
            row["Description"] = "";
            //row["Amount"] = "";
            dtMain.Rows.Add(row);
            row = dtMain.NewRow();
            row["Description"] = "Extra Hours";
            dtMain.Rows.Add(row);
            row = dtMain.NewRow();
            row["Description"] = "Extra Kms";
            dtMain.Rows.Add(row);
            row = dtMain.NewRow();
            row["Description"] = "Driver Expenses";
            dtMain.Rows.Add(row);
            row = dtMain.NewRow();
            row["Description"] = "Others";
            dtMain.Rows.Add(row);
            row = dtMain.NewRow();
            row["Description"] = "";
            dtMain.Rows.Add(row);
            row = dtMain.NewRow();
            row["Description"] = "Total";
            dtMain.Rows.Add(row);
        }
        private void frmInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");  
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grdInvoice.Rows[0].Cells["Description"].Value.ToString() == "") return; 
            if (cmbJobID.Text.Trim() == "")
            {
                MessageBox.Show("Job ID should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbJobID.Focus();
                return;
            }
            try
            {
                db.SUD("Update Tbl_Bookings set Invoice_Date='" + dtpDate.Text + "', X_Hours=" + (grdInvoice.Rows[1].Cells["Value"].Value.ToString().Trim() == "" ? "0" : grdInvoice.Rows[1].Cells["Value"].Value.ToString().Trim()) + ",X_Kms=" + (grdInvoice.Rows[2].Cells["Value"].Value.ToString().Trim() == "" ? "0" : grdInvoice.Rows[2].Cells["Value"].Value.ToString().Trim()) + ",Driver_Expenses=" + (grdInvoice.Rows[3].Cells["Amount"].Value.ToString().Trim() == "" ? 0 : Convert.ToDouble(grdInvoice.Rows[3].Cells["Amount"].Value)) + ",Others=" + (grdInvoice.Rows[4].Cells["Amount"].Value.ToString().Trim() == "" ? 0 : Convert.ToDouble(grdInvoice.Rows[4].Cells["Amount"].Value)) + ", where Job_ID=" + cmbJobID.Text.Trim());
                MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (chkPrintAfterSave.Checked)
                    Print(); 
                ClearFields(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }
        private void Print()
        {
            frmReport frm = new frmReport();
            frm.MdiParent = frmMain.ActiveForm;
            //frm.crv.ReportSource = ConfigurationManager.AppSettings["ReportPath"].ToString() + "\\rptInvoice.rpt";
            //ParameterFields parameterFields = frm.crv.ParameterFieldInfo;
            //ParameterValues currentParameterValues = new ParameterValues();
            //ParameterDiscreteValue parameterDiscreteValue;

            //parameterDiscreteValue = new ParameterDiscreteValue();
            //parameterDiscreteValue.Value = ConfigurationManager.AppSettings["CName"].ToString();
            //currentParameterValues.Add(parameterDiscreteValue);
            //ParameterField parameterField = parameterFields["CName"];
            //parameterField.CurrentValues = currentParameterValues;

            //parameterDiscreteValue = new ParameterDiscreteValue();
            //parameterDiscreteValue.Value = ConfigurationManager.AppSettings["CAddress"].ToString();
            //currentParameterValues.Add(parameterDiscreteValue);
            //ParameterField p2 = parameterFields["CAddress"];
            //p2.CurrentValues = currentParameterValues;

            //parameterDiscreteValue = new ParameterDiscreteValue();
            //parameterDiscreteValue.Value = ConfigurationManager.AppSettings["VATNo"].ToString();
            //currentParameterValues.Add(parameterDiscreteValue);
            //ParameterField p3 = parameterFields["VATNo"];
            //p3.CurrentValues = currentParameterValues;

            //frm.crv.SelectionFormula = "{V_Invoice.InvoiceNo}='" + txtInvoieNo.Text.Trim() + "'";
            //frm.Show();
        }

        private void ClearFields()
        {
            chkPrintAfterSave.Checked = (System.Configuration.ConfigurationManager.AppSettings["PrintAfterSave"].ToString() == "1" ? true : false); 
            cmbJobID.Text = "";
            dtpDate.Text = dtpDropDate.Text = dtpDropTime.Text = dtpPickUpDate.Text = dtpPickUpTime.Text = DateTime.Now.ToString();
            txtCustomerName.Text = "";
            txtFrom.Text = "";
            txtTo.Text = "";
            txtVehicleType.Text = "";
            txtVehicleName.Text = "";
            chkAC.Checked = false;
            txtVehicleNo.Text = "";
            txtDriver.Text = "";
            
  
            grdInvoice.Rows[0].Cells["Description"].Value = "";
            grdInvoice.Rows[1].Cells["temp"].Value = "";
            grdInvoice.Rows[2].Cells["temp"].Value = "";
            grdInvoice.Rows[1].Cells["Value"].Value = "";
            grdInvoice.Rows[2].Cells["Value"].Value = "";
            //grdInvoice.Rows[3].Cells["Value"].Value = "";
            grdInvoice.Rows[0].Cells["Amount"].Value = "";
            grdInvoice.Rows[1].Cells["Amount"].Value = "";
            grdInvoice.Rows[2].Cells["Amount"].Value = "";
            grdInvoice.Rows[3].Cells["Amount"].Value = "";
            grdInvoice.Rows[4].Cells["Amount"].Value = "";
            grdInvoice.Rows[6].Cells["Amount"].Value = "";
            cmbJobID.Focus();  
        }
        private void cmbJobID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && cmbJobID.Text.Trim() != "")
            {
                double d = Convert.ToDouble( cmbJobID.Text.Trim());
                ClearFields();
                cmbJobID.Text = d.ToString();  
                ShowDetails();
            }
        }
        private void ShowDetails()
        {
            try
            {
                DataTable dt = db.ExecuteTable("Select B.*,(Select FL.Location_Name from Tbl_Locations FL where FL.Location_ID= B.PickUp_LocationID and FL.Company_ID = " + Program.CompanyID + ") as FromLocation, (Select TL.Location_Name from Tbl_Locations TL where TL.Location_ID= B.Drop_LocationID and TL.Company_ID = " + Program.CompanyID + ") as ToLocation, VT.Vehicle_Name, D.Driver_Name,F.*  from Tbl_Bookings B , Tbl_VehicleTypes VT, Tbl_Drivers D, Tbl_Fares F where F.Vehicle_TypeID=B.Vehicle_NameID and B.Company_ID=F.Company_ID and B.Driver_ID=D.Driver_ID and B.Company_ID=D.Company_ID and B.Vehicle_NameID=VT.Vehicle_TypeID and B.Job_ID=" + cmbJobID.Text.Trim().Replace("'", "''") + " and B.Company_ID=" + Program.CompanyID, "Tbl_Bookings");
                txtCustomerName.Text = dt.Rows[0]["Customer_Name"].ToString();
                txtFrom.Text = dt.Rows[0]["FromLocation"].ToString();
                txtTo.Text = dt.Rows[0]["ToLocation"].ToString();
                txtVehicleName.Text = dt.Rows[0]["Vehicle_Name"].ToString();
                chkAC.Checked = (dt.Rows[0]["isAC"].ToString() == "0" ? false : true);
                dtpDropDate.Text = dtpDropTime.Text = dt.Rows[0]["Drop_DateTime"].ToString();
                dtpPickUpDate.Text = dtpPickUpTime.Text = dt.Rows[0]["PickUp_DateTime"].ToString();
                txtVehicleNo.Text = dt.Rows[0]["Vehicle_No"].ToString();
                txtDriver.Text = dt.Rows[0]["Driver_Name"].ToString();

                switch (Convert.ToInt32(dt.Rows[0]["B.Vehicle_TypeID"].ToString()))
                {
                    case 0:
                        txtVehicleType.Text = "Economy";
                        break;
                    case 1:
                        txtVehicleType.Text = "Standard";
                        break;
                    case 2:
                        txtVehicleType.Text = "Luxury";
                        break;
                    case 3:
                        txtVehicleType.Text = "SUV";
                        break;
                }

                if (chkAC.Checked)
                {
                    grdInvoice.Rows[1].Cells["temp"].Value = dt.Rows[0]["ACXHrs"].ToString();
                    grdInvoice.Rows[2].Cells["temp"].Value = dt.Rows[0]["ACXKms"].ToString();
                }
                else
                {
                    grdInvoice.Rows[1].Cells["temp"].Value = dt.Rows[0]["NonXHrs"].ToString();
                    grdInvoice.Rows[2].Cells["temp"].Value = dt.Rows[0]["NonXKms"].ToString();
                }

                switch (Convert.ToInt32(dt.Rows[0]["Booking_Type"].ToString()))
                {
                    case 0:
                        grdInvoice.Rows[0].Cells["Description"].Value = @"4Hrs\40Kms";
                        if (chkAC.Checked)
                            grdInvoice.Rows[0].Cells["Amount"].Value = dt.Rows[0]["AC4"].ToString();
                        else
                            grdInvoice.Rows[0].Cells["Amount"].Value = dt.Rows[0]["Non4"].ToString();
                        break;
                    case 1:
                        grdInvoice.Rows[0].Cells["Description"].Value = @"8Hrs\80Kms";
                        if (chkAC.Checked)
                            grdInvoice.Rows[0].Cells["Amount"].Value = dt.Rows[0]["AC8"].ToString();
                        else
                            grdInvoice.Rows[0].Cells["Amount"].Value = dt.Rows[0]["Non8"].ToString();
                        break;
                    case 2:
                        grdInvoice.Rows[0].Cells["Description"].Value = "General";
                        if (chkAC.Checked)
                            grdInvoice.Rows[0].Cells["Amount"].Value = dt.Rows[0]["ACGeneral"].ToString();
                        else
                            grdInvoice.Rows[0].Cells["Amount"].Value = dt.Rows[0]["NonGeneral"].ToString();
                        break;
                }
                // If Invoice generated ......

                if(dt.Rows[0]["Invoice_Date"].ToString()!="")
                {
                    dtpDate.Text = dt.Rows[0]["Invoice_Date"].ToString(); 
                    grdInvoice.Rows[1].Cells["Value"].Value = dt.Rows[0]["X_Hours"].ToString();
                    grdInvoice.Rows[2].Cells["Value"].Value = dt.Rows[0]["X_Kms"].ToString();

                    if (grdInvoice.Rows[1].Cells["Value"].Value.ToString().Trim() != "" && grdInvoice.Rows[1].Cells["temp"].Value.ToString().Trim() != "")
                        grdInvoice.Rows[1].Cells["Amount"].Value = Convert.ToDouble(grdInvoice.Rows[1].Cells["temp"].Value) * Convert.ToDouble(grdInvoice.Rows[1].Cells["Value"].Value);
                    if (grdInvoice.Rows[2].Cells["Value"].Value.ToString().Trim() != "" && grdInvoice.Rows[2].Cells["temp"].Value.ToString().Trim() != "")
                        grdInvoice.Rows[2].Cells["Amount"].Value = Convert.ToDouble(grdInvoice.Rows[2].Cells["temp"].Value) * Convert.ToDouble(grdInvoice.Rows[2].Cells["Value"].Value);

                    grdInvoice.Rows[3].Cells["Amount"].Value = dt.Rows[0]["Driver_Expenses"].ToString();
                    grdInvoice.Rows[4].Cells["Amount"].Value = dt.Rows[0]["Others"].ToString();
                }
                CalculatePrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }
        private void CalculatePrice()
        {
            try
            {
                if (grdInvoice.Rows[0].Cells["Amount"].Value.ToString().Trim() == "")
                    return;
                double Amt, ExtraHours, ExtraKms, DriverExpenses, Others, Total;
                Amt = (grdInvoice.Rows[0].Cells["Amount"].Value.ToString().Trim() == "" ? 0 : Convert.ToDouble(grdInvoice.Rows[0].Cells["Amount"].Value));
                ExtraHours = (grdInvoice.Rows[1].Cells["Amount"].Value.ToString().Trim() == "" ? 0 : Convert.ToDouble(grdInvoice.Rows[1].Cells["Amount"].Value));
                ExtraKms = (grdInvoice.Rows[2].Cells["Amount"].Value.ToString().Trim() == "" ? 0 : Convert.ToDouble(grdInvoice.Rows[2].Cells["Amount"].Value));
                DriverExpenses = (grdInvoice.Rows[3].Cells["Amount"].Value.ToString().Trim() == "" ? 0 : Convert.ToDouble(grdInvoice.Rows[3].Cells["Amount"].Value));
                Others = (grdInvoice.Rows[4].Cells["Amount"].Value.ToString().Trim() == "" ? 0 : Convert.ToDouble(grdInvoice.Rows[4].Cells["Amount"].Value));
                Total = Amt + ExtraHours + ExtraKms + DriverExpenses + Others;
                if (Total == 0) return;
                grdInvoice.Rows[6].Cells["Amount"].Value = Total;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }

        private void grdInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grdInvoice.Rows[1].Cells["Value"].Value.ToString().Trim() != "" && grdInvoice.Rows[1].Cells["temp"].Value.ToString().Trim() != "")
                {
                    grdInvoice.Rows[1].Cells["Amount"].Value = Convert.ToDouble(grdInvoice.Rows[1].Cells["temp"].Value) * Convert.ToDouble(grdInvoice.Rows[1].Cells["Value"].Value);
                    CalculatePrice();
                }
                if (grdInvoice.Rows[2].Cells["Value"].Value.ToString().Trim() != "" && grdInvoice.Rows[2].Cells["temp"].Value.ToString().Trim() != "")
                {
                    grdInvoice.Rows[2].Cells["Amount"].Value = Convert.ToDouble(grdInvoice.Rows[2].Cells["temp"].Value) * Convert.ToDouble(grdInvoice.Rows[2].Cells["Value"].Value);
                    CalculatePrice();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
