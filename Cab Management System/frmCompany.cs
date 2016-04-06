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
    public partial class frmCompany : Form
    {
        DataBase db = new DataBase(); 
        public frmCompany()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text.Trim() == "")
            {
                MessageBox.Show("Company Name should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCompanyName.Focus();
                return; 
            }
            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Address should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return;
            }
            if (txtFinancialYear.Text.Trim() == "")
            {
                MessageBox.Show("Financial Year should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFinancialYear.Focus();
                return;
            }
            try
            {
                if (btnSave.Text == "&Save")
                {
                    if (db.SUD("Insert into Tbl_Company(Company_Name,Company_Address,Contact_No,Registration_No,CType,Financial_Year) Values ('" + txtCompanyName.Text.Trim().Replace("'", "''") + "','" + txtAddress.Text.Trim().Replace("'", "''") + "','" + txtContactNo.Text.Trim().Replace("'", "''") + "','" + txtRegistrationNo.Text.Trim().Replace("'", "''") + "'," + (rdoRental.Checked ? 0 : 1) + ",'" + txtFinancialYear.Text.Trim().Replace("'", "''") + "')") != 0)
                    {
                        string cid = db.getRecord("Select Company_ID from Tbl_Company where Company_Name='" + txtCompanyName.Text.Trim().Replace("'", "''") + "'");
                        db.SUD("Insert into Tbl_Users(User_Name,Pwd,IsAdmin,Company_ID) Values ('admin','admin',1," + cid + ")");
                        MessageBox.Show("Company Created Successfully ... Login as admin\\admin", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select * from Tbl_Company", "Tbl_Company", grdCompany); 
                        ClearFields();
                    }
                }
                else
                {
                    if (db.SUD("Update Tbl_Company Set Company_Name='" + txtCompanyName.Text.Trim().Replace("'", "''") + "',Company_Address='" + txtAddress.Text.Trim().Replace("'", "''") + "',Contact_No='" + txtContactNo.Text.Trim().Replace("'", "''") + "',Registration_No='" + txtRegistrationNo.Text.Trim().Replace("'", "''") + "',CType=" + (rdoRental.Checked ? 0 : 1) + ",Financial_Year='" + txtRegistrationNo.Text.Trim().Replace("'", "''") + "' where Company_ID=" + grdCompany.Rows[grdCompany.CurrentCell.RowIndex].Cells["Company_ID"].Value.ToString()) != 0)
                    {
                        MessageBox.Show("Record Updated Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select * from Tbl_Company", "Tbl_Comp any", grdCompany); 
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
            txtCompanyName.Text = "";
            txtAddress.Text = "";
            txtContactNo.Text = "";
            txtRegistrationNo.Text = "";
            rdoRental.Checked = true;
            txtFinancialYear.Text = "";
            btnSave.Text = "&Save"; 
            txtCompanyName.Focus();  
        }

        private void frmCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");  
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            db.FillGrid("Select * from Tbl_Company", "Tbl_Company", grdCompany);
            SetGridStyles();
        }

        private void SetGridStyles()
        {
            grdCompany.Columns["Company_ID"].Visible = false;
            grdCompany.Columns["Company_Name"].Width = 380;
            grdCompany.Columns["Company_Address"].Visible = false;
            grdCompany.Columns["Contact_No"].Visible = false;
            grdCompany.Columns["Registration_No"].Visible = false;
            grdCompany.Columns["CType"].Visible = false;
            grdCompany.Columns["Financial_Year"].Width = 130;
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            this.KeyPreview = false; 
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            this.KeyPreview = true; 
        }

        private void txtFinancialYear_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSave;  
        }

        private void txtFinancialYear_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void grdCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCompanyName.Text = grdCompany.Rows[e.RowIndex].Cells["Company_Name"].Value.ToString();
            txtAddress.Text = grdCompany.Rows[e.RowIndex].Cells["Company_Address"].Value.ToString();
            txtContactNo.Text = grdCompany.Rows[e.RowIndex].Cells["Contact_No"].Value.ToString();
            txtRegistrationNo.Text = grdCompany.Rows[e.RowIndex].Cells["Registration_No"].Value.ToString();
            if (grdCompany.Rows[e.RowIndex].Cells["CType"].Value.ToString() == "0")
                rdoRental.Checked = true;
            else
                rdoShuttle.Checked = true;   
            txtFinancialYear.Text = grdCompany.Rows[e.RowIndex].Cells["Financial_Year"].Value.ToString();
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
            if (db.SUD("Delete from Tbl_Company where Company_ID=" + grdCompany.Rows[grdCompany.CurrentCell.RowIndex].Cells["Company_ID"].Value.ToString()) != 0)
            {
                db.SUD("Delete from Tbl_Users where Company_ID=" + grdCompany.Rows[grdCompany.CurrentCell.RowIndex].Cells["Company_ID"].Value.ToString()); 
                MessageBox.Show("Record Deleted Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.FillGrid("Select * from Tbl_Company", "Tbl_Company", grdCompany);
                ClearFields();
            }
        }
    }
}
