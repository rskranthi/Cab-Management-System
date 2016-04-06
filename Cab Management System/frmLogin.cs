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
    public partial class frmLogin : Form
    {
        DataBase db = new DataBase(); 
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
            if (cmbCompany.SelectedIndex==-1 )
            {
                MessageBox.Show("Select a company", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCompany.Focus();
                return;
            }
            if (!db.isAuthenticate("Select * from Tbl_Users where Company_ID=" + cmbCompany.SelectedValue.ToString() + " and User_Name='" + txtUserName.Text.Trim().Replace("'", "''") + "' and Pwd='" + txtPassword.Text.Trim().Replace("'", "''") + "'"))
            {
                MessageBox.Show("Invalid UserName and Password", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
                return; 
            }
            
            DataTable dt = db.ExecuteTable("Select * from  Tbl_Users where Company_ID=" + cmbCompany.SelectedValue.ToString() + " and User_Name='" + txtUserName.Text.Trim().Replace("'", "''") + "'", "Tbl_Users");
            if (dt.Rows[0]["isAdmin"].ToString() == "1")
                Program.isAdmin = true;
            Program.userID = Convert.ToInt32(dt.Rows[0]["User_ID"].ToString());    
            byte cType = 0;
            if (db.getRecord("Select CType from Tbl_Company where Company_ID=" + cmbCompany.SelectedValue.ToString()) == "1")
                cType = 1;
            Program.CompanyID = (int) cmbCompany.SelectedValue;
            Program.CName = cmbCompany.Text;   
            Program.enableMenus(cmbCompany.Text,txtUserName.Text,Program.isAdmin,cType); 
            this.Close(); 
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}"); 
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            db.FillCombo("Select * from Tbl_Company order by Company_Name", "Tbl_Company", cmbCompany);   
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin; 
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
