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
    public partial class frmShuttleBooking : Form
    {
        DataBase db = new DataBase(); 
        public frmShuttleBooking()
        {
            InitializeComponent();
        }

        private void frmShuttleBooking_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");  
        }

        private void frmShuttleBooking_Load(object sender, EventArgs e)
        {
            db.FillCombo("Select * from Tbl_Locations where Company_ID=" + Program.CompanyID + " order by Location_Name", "Tbl_Locations", cmbPickUpLocation);
            db.FillCombo("Select * from Tbl_Locations where Company_ID=" + Program.CompanyID + " order by Location_Name", "Tbl_Locations", cmbDropLocation);
            db.FillCombo("Select * from Tbl_Employees where Company_ID=" + Program.CompanyID + " order by Employee_Name", "Tbl_Employees", cmbEmployees);
            db.FillCombo("Select * from Tbl_Projects where Company_ID=" + Program.CompanyID + " order by Project_Name", "Tbl_Projects", cmbProjects);
            db.FillGrid("SELECT * FROM Tbl_ShuttleBookings B , Tbl_Projects P ,Tbl_Employees E Where B.Company_ID=P.Company_ID and B.Project_ID=P.Project_ID and B.Company_ID=E.Company_ID  and B.Employee_ID=E.Employee_ID and B.Company_ID=" + Program.CompanyID + " and Month(SBDate)=" + dtpDate.Value.Month.ToString() + " and Year(SBDate)=" + dtpDate.Value.Year.ToString(), "Tbl_ShuttleBookings", grdBookings);
            SetGridStyles(); 
        }

        private void SetGridStyles()
        {
            grdBookings.Columns["Booking_ID"].Visible = false;
            grdBookings.Columns["SBDate"].Visible = false;
            grdBookings.Columns["B.Employee_ID"].Visible = false;
            grdBookings.Columns["B.Project_ID"].Visible = false;
            grdBookings.Columns["isPickUp"].Visible = false;
            grdBookings.Columns["PickUpDateTime"].Width = 110;
            grdBookings.Columns["PickUp_LocationID"].Visible = false;
            grdBookings.Columns["PickUp_Address"].Visible = false;
            grdBookings.Columns["isDrop"].Visible = false;
            grdBookings.Columns["DropDateTime"].Visible = false;
            grdBookings.Columns["Drop_LocationID"].Visible = false;
            grdBookings.Columns["Drop_Address"].Visible = false;
            grdBookings.Columns["B.Company_ID"].Visible = false;
            grdBookings.Columns["P.Project_ID"].Visible = false;
            grdBookings.Columns["Project_Name"].Visible = false;
            grdBookings.Columns["P.Company_ID"].Visible = false;
            grdBookings.Columns["E.Employee_ID"].Width = 60;
            grdBookings.Columns["E.Employee_ID"].HeaderText = "EmpID"; 
            grdBookings.Columns["Employee_Name"].Width = 100;
            grdBookings.Columns["Enterprise_ID"].Visible = false;
            grdBookings.Columns["Location_ID"].Visible = false;
            grdBookings.Columns["Address"].Visible = false;
            grdBookings.Columns["E.Company_ID"].Visible = false;
        }

        private void chkPickUp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPickUp.Checked)
            {
                grpPickUp.Enabled = true;
                dtpPickUpDate.Focus();  
            }
            else
            {
                dtpPickUpDate.Text = dtpPickUpTime.Text = DateTime.Now.ToString();
                cmbPickUpLocation.SelectedIndex = -1;
                txtPickUpAddress.Text = "";
                grpPickUp.Enabled = false;
            }
        }

        private void chkDrop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDrop.Checked)
            {
                grpDrop.Enabled = true;
                dtpDropDate.Focus();
                if (chkPickUp.Checked)
                {
                    cmbDropLocation.SelectedValue = cmbPickUpLocation.SelectedValue;
                    txtDropAddress.Text = txtPickUpAddress.Text;   
                }
            }
            else
            {
                dtpDropDate.Text = dtpDropTime.Text = DateTime.Now.ToString();
                cmbDropLocation.SelectedIndex = -1;
                txtDropAddress.Text = "";
                grpDrop.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Employee Name should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbEmployees.Focus();
                return;
            }
            if (cmbProjects.SelectedIndex == -1)
            {
                MessageBox.Show("Project Name should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbProjects.Focus();
                return;
            }
            if (!chkPickUp.Checked && !chkDrop.Checked)
            {
                MessageBox.Show("PickUp or Drop have to be selected", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chkPickUp.Focus();
                return;
            }
            if (chkPickUp.Checked)
            {
                if (cmbPickUpLocation.SelectedIndex == -1)
                {
                    MessageBox.Show("PickUp Location should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbPickUpLocation.Focus();
                    return;
                }
                if (txtPickUpAddress.Text.Trim().Replace("'", "''") == "")
                {
                    MessageBox.Show("PickUp Address should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPickUpAddress.Focus();
                    return;
                }
            }
            if (chkDrop.Checked)
            {
                if (cmbDropLocation.SelectedIndex == -1)
                {
                    MessageBox.Show("Drop Location should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDropLocation.Focus();
                    return;
                }
                if (txtDropAddress.Text.Trim().Replace("'", "''") == "")
                {
                    MessageBox.Show("Drop Address should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDropAddress.Focus();
                    return;
                }
            }
            try
            {
                if (btnSave.Text == "&Save")
                {
                    if (dtpMonthDate.Checked)
                    {
                        db.SUD("Delete from Tbl_ShuttleBookings where Company_ID="+ Program.CompanyID.ToString() + "  and Month(SBDate)=" + dtpDate.Value.Month.ToString() + " and Year(SBDate)=" + dtpDate.Value.Year.ToString());
                        for (int i = 0; i < lstDates.Items.Count ; i++)
                        {
                            if (lstDates.GetItemChecked(i))
                            db.SUD("Insert into Tbl_ShuttleBookings(SBDate,Employee_ID,Project_ID,isPickUp,PickUpDateTime,PickUp_LocationID,PickUp_Address,isDrop,DropDateTime,Drop_LocationID,Drop_Address,Company_ID) Values ('" + dtpDate.Text + "'," + cmbEmployees.SelectedValue.ToString() + "," + cmbProjects.SelectedValue.ToString() + "," + (chkPickUp.Checked ? "1" : "0") + ",'" + lstDates.Items[i].ToString() + " " + dtpPickUpTime.Text + "'," + cmbPickUpLocation.SelectedValue.ToString() + ",'" + txtPickUpAddress.Text.Trim().Replace("'", "''") + "'," + (chkDrop.Checked ? "1" : "0") + ",'" + Convert.ToDateTime(lstDates.Items[i].ToString()).AddDays(DateTime.Compare(dtpPickUpDate.Value, dtpDropDate.Value)).ToString("dd-MMM-yyyy") + " " + dtpDropTime.Text + "'," + cmbDropLocation.SelectedValue.ToString() + ",'" + txtDropAddress.Text.Trim().Replace("'", "''") + "'," + Program.CompanyID.ToString() + ")");
                        }
                        MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("SELECT * FROM Tbl_ShuttleBookings B , Tbl_Projects P ,Tbl_Employees E Where B.Company_ID=P.Company_ID and B.Project_ID=P.Project_ID and B.Company_ID=E.Company_ID  and B.Employee_ID=E.Employee_ID and B.Company_ID=" + Program.CompanyID + " and Month(SBDate)=" + dtpDate.Value.Month.ToString() + " and Year(SBDate)=" + dtpDate.Value.Year.ToString(), "Tbl_ShuttleBookings", grdBookings);
                        ClearFields();
                    }
                    else
                    {
                        if (db.SUD("Insert into Tbl_ShuttleBookings(SBDate,Employee_ID,Project_ID,isPickUp,PickUpDateTime,PickUp_LocationID,PickUp_Address,isDrop,DropDateTime,Drop_LocationID,Drop_Address,Company_ID) Values ('" + dtpDate.Text + "'," + cmbEmployees.SelectedValue.ToString() + "," + cmbProjects.SelectedValue.ToString() + "," + (chkPickUp.Checked ? "1" : "0") + ",'" + dtpPickUpDate.Text + " " + dtpPickUpTime.Text + "'," + cmbPickUpLocation.SelectedValue.ToString() + ",'" + txtPickUpAddress.Text.Trim().Replace("'", "''") + "'," + (chkDrop.Checked ? "1" : "0") + ",'" + dtpDropDate.Text + " " + dtpDropTime.Text + "'," + cmbDropLocation.SelectedValue.ToString() + ",'" + txtDropAddress.Text.Trim().Replace("'", "''") + "'," + Program.CompanyID.ToString() + ")") != 0)
                        {
                            MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            db.FillGrid("SELECT * FROM Tbl_ShuttleBookings B , Tbl_Projects P ,Tbl_Employees E Where B.Company_ID=P.Company_ID and B.Project_ID=P.Project_ID and B.Company_ID=E.Company_ID  and B.Employee_ID=E.Employee_ID and B.Company_ID=" + Program.CompanyID + " and Month(SBDate)=" + dtpDate.Value.Month.ToString() + " and Year(SBDate)=" + dtpDate.Value.Year.ToString(), "Tbl_ShuttleBookings", grdBookings);
                            ClearFields();
                        }
                    }
                }
                else
                {
                    //if (db.SUD("Update Tbl_ShuttleBookings Set  and Company_ID=" + Program.CompanyID.ToString()) != 0)
                    //{
                        MessageBox.Show("Record Updated Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("SELECT * FROM Tbl_ShuttleBookings B , Tbl_Projects P ,Tbl_Employees E Where B.Company_ID=P.Company_ID and B.Project_ID=P.Project_ID and B.Company_ID=E.Company_ID  and B.Employee_ID=E.Employee_ID and B.Company_ID=" + Program.CompanyID + " and Month(SBDate)=" + dtpDate.Value.Month.ToString() + " and Year(SBDate)=" + dtpDate.Value.Year.ToString(), "Tbl_ShuttleBookings", grdBookings);
                        ClearFields();
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void ClearFields()
        {
            dtpMonthDate.Text = dtpDate.Text = dtpDropDate.Text = dtpDropTime.Text = dtpPickUpDate.Text = dtpPickUpTime.Text = DateTime.Now.ToString();
            cmbEmployees.SelectedIndex = -1;
            cmbProjects.SelectedIndex = -1;
            chkDrop.Checked = false;
            chkPickUp.Checked = false;
            dtpMonthDate.Checked = false;
            lstDates.Items.Clear();
            dtpDate.Focus();  
            btnSave.Text = "&Save";
        }
        private void dtpMonthDate_ValueChanged(object sender, EventArgs e)
        {
            lstDates.Items.Clear();
            if (dtpMonthDate.Checked)
            {
                DateTime dt = Convert.ToDateTime(dtpMonthDate.Value.Month.ToString() + "-01-" + dtpMonthDate.Value.Year.ToString());
                for (int i = 0; i < DateTime.DaysInMonth(dtpMonthDate.Value.Year, dtpMonthDate.Value.Month); i++)
                    lstDates.Items.Add(dt.AddDays(i).ToString("dd-MMM-yyyy"),true);
            }
        }

        private void cmbPickUpLocation_Validated(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedIndex == -1 || cmbPickUpLocation.SelectedIndex == -1) return;
            txtPickUpAddress.Text = db.getRecord("Select Address from Tbl_Employees where Company_ID=" + Program.CompanyID + " and Location_ID=" + cmbPickUpLocation.SelectedValue.ToString());
        }

        private void cmbDropLocation_Validated(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedIndex == -1 || cmbDropLocation.SelectedIndex == -1) return;
            txtDropAddress.Text = db.getRecord("Select Address from Tbl_Employees where Company_ID=" + Program.CompanyID + " and Location_ID=" + cmbPickUpLocation.SelectedValue.ToString());
        }
        private void dtpDate_Validated(object sender, EventArgs e)
        {
            db.FillGrid("SELECT * FROM Tbl_ShuttleBookings B , Tbl_Projects P ,Tbl_Employees E Where B.Company_ID=P.Company_ID and B.Project_ID=P.Project_ID and B.Company_ID=E.Company_ID  and B.Employee_ID=E.Employee_ID and B.Company_ID=" + Program.CompanyID + " and Month(SBDate)=" + dtpDate.Value.Month.ToString() + " and Year(SBDate)=" + dtpDate.Value.Year.ToString(), "Tbl_ShuttleBookings", grdBookings);
        }
    }
}
