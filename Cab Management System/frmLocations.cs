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
    public partial class frmLocations : Form
    {
        DataBase db = new DataBase();
        byte s , u , d , p ;
        public frmLocations()
        {
            InitializeComponent();
        }

        private void grdLocations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLocationName.Text = grdLocations.Rows[e.RowIndex].Cells["Location_Name"].Value.ToString();
            btnSave.Text = "&Update";
        }

        private void frmLocations_Load(object sender, EventArgs e)
        {
            db.FillGrid("Select * from Tbl_Locations where Company_ID=" + Program.CompanyID + " order by Location_Name" , "Tbl_Locations", grdLocations);
            SetGridStyles();
            db.getAccess(out s, out u, out d, out p, Convert.ToByte(db.getRecord("Select Form_ID from Tbl_Forms where Form_Name='" + this.Name.ToString() + "'")));
        }

        private void SetGridStyles()
        {
            grdLocations.Columns["Location_ID"].Visible = false;
            grdLocations.Columns["Location_Name"].Width = 375;
            grdLocations.Columns["Company_ID"].Visible = false;
        }

        private void frmLocations_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "&Save") return;
            if (d == 0 && !Program.isAdmin)
            {
                MessageBox.Show("You are NOT authorized to access this functionality \n Please contact your administrator", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show(this, "Are you sure to delete this record ?", "CabMan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                ClearFields();
                return;
            }
            if (db.SUD("Delete from Tbl_Locations where Location_ID=" + grdLocations.Rows[grdLocations.CurrentCell.RowIndex].Cells["Location_ID"].Value.ToString() + " and Company_ID=" + Program.CompanyID.ToString()) != 0)
            {
                MessageBox.Show("Record Deleted Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.FillGrid("Select * from Tbl_Locations where Company_ID=" + Program.CompanyID + " order by Location_Name", "Tbl_Locations", grdLocations);
                ClearFields();
            }
        }

        private void ClearFields()
        {
            txtLocationName.Text = "";
            txtLocationName.Focus();
            btnSave.Text = "&Save";  
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLocationName.Text.Trim() == "")
            {
                MessageBox.Show("Location should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLocationName.Focus();
                return;
            }
            try
            {
                if (btnSave.Text == "&Save")
                {
                    if (s == 0 && !Program.isAdmin)
                    {
                        MessageBox.Show("You are NOT authorized to access this functionality \n Please contact your administrator", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return; 
                    }
                    if (db.SUD("Insert into Tbl_Locations(Location_Name,Company_ID) Values ('" + txtLocationName.Text.Trim().Replace("'", "''") + "'," + Program.CompanyID.ToString() + ")") != 0)
                    {
                        MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select * from Tbl_Locations where Company_ID=" + Program.CompanyID + " order by Location_Name", "Tbl_Locations", grdLocations);
                        ClearFields();
                    }
                }
                else
                {
                    if (u == 0 && !Program.isAdmin)
                    {
                        MessageBox.Show("You are NOT authorized to access this functionality \n Please contact your administrator", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (db.SUD("Update Tbl_Locations Set Location_Name='" + txtLocationName.Text.Trim().Replace("'", "''") + "' where Location_ID=" + grdLocations.Rows[grdLocations.CurrentCell.RowIndex].Cells["Location_ID"].Value.ToString() + " and Company_ID=" + Program.CompanyID.ToString()) != 0)
                    {
                        MessageBox.Show("Record Updated Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select * from Tbl_Locations where Company_ID=" + Program.CompanyID + " order by Location_Name", "Tbl_Locations", grdLocations);
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
