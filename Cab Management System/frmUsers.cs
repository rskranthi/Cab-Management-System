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
    public partial class frmUsers : Form
    {
        DataBase db = new DataBase(); 
        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("User Name should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Password should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }
            try
            {
                if (btnSave.Text == "&Save")
                {
                    if (db.SUD("Insert into Tbl_Users(User_Name,Pwd,IsAdmin,Company_ID) Values ('" + txtUserName.Text.Trim().Replace("'", "''") + "','" + txtPassword.Text.Trim().Replace("'", "''") + "'," + (chkAdmin.Checked?"1":"0") + "," + Program.CompanyID.ToString() + ")") != 0)
                    {
                        MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select * from Tbl_Users where Company_ID=" + Program.CompanyID.ToString() + " order by User_Name", "Tbl_Users", grdUsers);
                        ClearFields();
                    }
                }
                else
                {
                    if (db.SUD("Update Tbl_Users Set User_Name='" + txtUserName.Text.Trim().Replace("'", "''") + "',Pwd='" + txtPassword.Text.Trim().Replace("'", "''") + "',isAdmin=" + (chkAdmin.Checked ? "1" : "0") + " where User_ID=" + grdUsers.Rows[grdUsers.CurrentCell.RowIndex].Cells["User_ID"].Value.ToString() + " and Company_ID=" + Program.CompanyID.ToString()) != 0)
                    {
                        MessageBox.Show("Record Updated Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select * from Tbl_Users where Company_ID=" + Program.CompanyID.ToString() + " order by User_Name", "Tbl_Users", grdUsers);
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            db.FillGrid("Select * from Tbl_Users where Company_ID=" + Program.CompanyID.ToString() + " order by User_Name", "Tbl_Users", grdUsers);
            SetGridStyles();
        }

        private void ClearFields()
        {
            txtUserName.Text = ""; 
            txtPassword.Text=""; 
            chkAdmin.Checked = false;  
            txtUserName.Focus();
            btnSave.Text = "&Save";
        }
        private void SetGridStyles()
        {
            grdUsers.Columns["User_ID"].Visible = false;
            grdUsers.Columns["User_Name"].Width = 155;
            grdUsers.Columns["Pwd"].Width = 155;
            grdUsers.Columns["IsAdmin"].Width = 60;
            grdUsers.Columns["Company_ID"].Visible = false;
        }

        private void frmUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}"); 
        }

        private void grdUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = grdUsers.Rows[e.RowIndex].Cells["User_Name"].Value.ToString();
            txtPassword.Text = grdUsers.Rows[e.RowIndex].Cells["Pwd"].Value.ToString();
            chkAdmin.Checked = (grdUsers.Rows[e.RowIndex].Cells["IsAdmin"].Value.ToString() == "1" ? false : true);   
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
            if (db.SUD("Delete from Tbl_Users where User_ID=" + grdUsers.Rows[grdUsers.CurrentCell.RowIndex].Cells["User_ID"].Value.ToString() + " and Company_ID=" + Program.CompanyID.ToString()) != 0)
            {
                MessageBox.Show("Record Deleted Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.FillGrid("Select * from Tbl_Users where Company_ID=" + Program.CompanyID.ToString() + " order by User_Name", "Tbl_Users", grdUsers);
                ClearFields();
            }
        }
    }
}
