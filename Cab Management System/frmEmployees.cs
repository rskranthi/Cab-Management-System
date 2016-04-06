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
    public partial class frmEmployees : Form
    {
        DataBase db = new DataBase(); 
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text.Trim() == "")
            {
                MessageBox.Show("Employee ID should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmployeeID.Focus();
                return;
            }
            if (txtEmployeeName.Text.Trim() == "")
            {
                MessageBox.Show("Employee Name should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmployeeName.Focus();
                return;
            }
            if (txtEnterpriseID.Text.Trim() == "")
            {
                MessageBox.Show("Enterprise ID should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEnterpriseID.Focus();
                return;
            }
            if (cmbLocation.SelectedIndex == -1)
            {
                MessageBox.Show("Location should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbLocation.Focus();
                return;
            }
            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Address should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return;
            }
            try
            {
                if (btnSave.Text == "&Save")
                {
                    if (db.SUD("Insert into Tbl_Employees(Employee_ID,Employee_Name,Enterprise_ID,Location_ID,Address,Company_ID) Values ('" + txtEmployeeID.Text.Trim().Replace("'", "''") + "','" + txtEmployeeName.Text.Trim().Replace("'", "''") + "','" + txtEnterpriseID.Text.Trim().Replace("'", "''") + "'," + cmbLocation.SelectedValue.ToString() + ",'" + txtAddress.Text.Trim().Replace("'", "''") + "'," + Program.CompanyID.ToString() + ")") != 0)
                    {
                        MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select * from Tbl_Employees where Company_ID=" + Program.CompanyID + " order by Employee_Name", "Tbl_Employees", grdEmployees);
                        ClearFields();
                    }
                }
                else
                {
                    if (db.SUD("Update Tbl_Employees Set Employee_ID='" + txtEmployeeID.Text.Trim().Replace("'", "''") + "', Employee_Name='" + txtEmployeeName.Text.Trim().Replace("'", "''") + "',Enterprise_ID='" + txtEnterpriseID.Text.Trim().Replace("'", "''") + "',Location_ID=" + cmbLocation.SelectedValue.ToString() + ",Address='" + txtAddress.Text.Trim().Replace("'", "''") + "' where Employee_ID='" + grdEmployees.Rows[grdEmployees.CurrentCell.RowIndex].Cells["Employee_ID"].Value.ToString() + "' and Company_ID=" + Program.CompanyID.ToString()) != 0)
                    {
                        MessageBox.Show("Record Updated Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select * from Tbl_Employees where Company_ID=" + Program.CompanyID + " order by Employee_Name", "Tbl_Employees", grdEmployees);
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
            if (db.SUD("Delete from Tbl_Employees where Employee_ID='" + grdEmployees.Rows[grdEmployees.CurrentCell.RowIndex].Cells["Employee_ID"].Value.ToString() + "' and Company_ID=" + Program.CompanyID.ToString()) != 0)
            {
                MessageBox.Show("Record Deleted Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.FillGrid("Select * from Tbl_Employees where Company_ID=" + Program.CompanyID + " order by Employee_Name", "Tbl_Employees", grdEmployees);
                ClearFields();
            }
        }
        private void ClearFields()
        {
            txtEmployeeID.Text = "";
            txtEmployeeName.Text = ""; 
            txtEnterpriseID.Text = "";
            cmbLocation.SelectedIndex = -1;
            txtAddress.Text = "";  
            txtEmployeeID.Focus();
            btnSave.Text = "&Save";
        }
        private void frmEmployees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}"); 
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            db.FillCombo("Select * from Tbl_Locations where Company_ID=" + Program.CompanyID + " order by Location_Name", "Tbl_Locations", cmbLocation);
            db.FillGrid("Select * from Tbl_Employees where Company_ID=" + Program.CompanyID + " order by Employee_Name", "Tbl_Employees", grdEmployees);
            SetGridStyles(); 
        }
        private void SetGridStyles()
        {
            grdEmployees.Columns["Employee_ID"].Width = 75;
            grdEmployees.Columns["Employee_Name"].Width = 165;
            grdEmployees.Columns["Enterprise_ID"].Width = 150;
            grdEmployees.Columns["Location_ID"].Visible = false;
            grdEmployees.Columns["Address"].Visible = false;
            grdEmployees.Columns["Company_ID"].Visible = false;
        }

        private void grdEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeID.Text = grdEmployees.Rows[e.RowIndex].Cells["Employee_ID"].Value.ToString();
            txtEmployeeName.Text = grdEmployees.Rows[e.RowIndex].Cells["Employee_Name"].Value.ToString();
            txtEnterpriseID.Text = grdEmployees.Rows[e.RowIndex].Cells["Enterprise_ID"].Value.ToString();
            cmbLocation.SelectedValue  = grdEmployees.Rows[e.RowIndex].Cells["Location_ID"].Value.ToString();
            txtAddress.Text = grdEmployees.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            btnSave.Text = "&Update";  
        }
    }
}
