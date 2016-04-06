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
    public partial class frmAccess : Form
    {
        DataBase db = new DataBase();
        public frmAccess()
        {
            InitializeComponent();
        }

        private void frmAccess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");  
        }

        private void frmAccess_Load(object sender, EventArgs e)
        {
            db.FillCombo("Select * from Tbl_Users where Company_ID=" + Program.CompanyID + " order by User_Name", "Tbl_Users", cmbUsers);
            grdAccess.Rows.Add(1);
            db.setAccess(grdAccess);  
        }

        private void grdAccess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedIndex ==-1)
            {
                MessageBox.Show("User Name should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbUsers.Focus();
                return;
            }
            if (grdAccess.Rows.Count <= 1)
            {
                MessageBox.Show("No Forms to provide access", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grdAccess.Focus();
                return;
            }
            db.SUD("Delete from Tbl_Access where User_ID=" + cmbUsers.SelectedValue.ToString());
            byte s = 0, u = 0, d = 0, p = 0;
            for (int i = 0; i < grdAccess.Rows.Count; i++)
            {
                //MessageBox.Show(grdAccess.Rows[i].Cells["Save"].Value.ToString() );
                if (grdAccess.Rows[i].Cells["Save"].Value != null)
                    s = 1;
                else
                    s = 0;
                if (grdAccess.Rows[i].Cells["Update"].Value != null)
                    u = 1;
                else
                    u = 0;
                if (grdAccess.Rows[i].Cells["Delete"].Value != null)
                    d = 1;
                else
                    d = 0;
                if (grdAccess.Rows[i].Cells["Print"].Value != null)
                    p = 1;
                else
                    p = 0;
                db.SUD("INSERT INTO Tbl_Access(User_ID,Form_ID,A_Save,A_Update,A_Delete,A_Print,Company_ID) values(" + cmbUsers.SelectedValue.ToString() + "," + grdAccess.Rows[i].Cells["Form_ID"].Value.ToString() + "," + s.ToString() + "," + u.ToString() + "," + d.ToString() + "," + p.ToString()+ "," + Program.CompanyID + ")");
            }
                //db.SUD("INSERT INTO Tbl_Access(User_ID,Form_ID,A_Save,A_Update,A_Delete,A_Print,Company_ID) values(" + cmbUsers.SelectedValue.ToString() + "," + grdAccess.Rows[i].Cells["Form_ID"].Value.ToString() + "," + (grdAccess.Rows[i].Cells["Save"].Value == true ? "0" : "1") + "," + (grdAccess.Rows[i].Cells["Update"].Value == true ? "0" : "1") + "," + (grdAccess.Rows[i].Cells["Delete"].Value == true ? "0" : "1") + "," + (grdAccess.Rows[i].Cells["Print"].Value == true ? "0" : "1") + "," + Program.CompanyID + ")");
            MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure to delete this record ?", "CabMan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                ClearFields();
                return;
            }
            if (db.SUD("Delete from Tbl_Access where User_ID=" + cmbUsers.SelectedValue.ToString()) != 0)
            {
                MessageBox.Show("Record Deleted Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }
        private void ClearFields()
        {
            cmbUsers.SelectedIndex =-1; 
            for (int i = 0; i < grdAccess.Rows.Count ; i++)
            {
                grdAccess.Rows[i].Cells["Save"].Value = false;
                grdAccess.Rows[i].Cells["Update"].Value = false;
                grdAccess.Rows[i].Cells["Delete"].Value = false;
                grdAccess.Rows[i].Cells["Print"].Value = false;
            }
        }

        private void cmbUsers_Validated(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedIndex == -1) return;
            //DataTable dt = db.ExecuteTable("Select * from Tbl_Access where Company_ID=" + Program.CompanyID + " and User_ID=" + cmbUsers.SelectedValue.ToString() + " and (A_Save=1 or A_Update=1 or A_Delete=1 or A_Print=1)", "Tbl_Access");
            //if (dt.Rows.Count == 0) return;
            //for(int i=0;i<grdAccess.Rows.Count;i++)
            //{
            //    for (int j = 0; j < dt.Rows.Count; j++)
            //    {
            //        if (dt.Rows[j]["Form_ID"].ToString() == grdAccess.Rows[i].Cells["Form_ID"].ToString())
            //        {
            //            if (dt.Rows[j]["A_Save"].ToString() == "1")
            //                grdAccess.Rows[i].Cells["Save"].Value = 1;
            //            else
            //                grdAccess.Rows[i].Cells["Save"].Value = 0;
            //        }
            //    }
            //}
        }
    }
}
