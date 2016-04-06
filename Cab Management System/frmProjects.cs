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
    public partial class frmProjects : Form
    {
        DataBase db = new DataBase();     
        public frmProjects()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProjectName.Text.Trim() == "")
            {
                MessageBox.Show("Project should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProjectName.Focus();
                return;
            }
            try
            {
                if (btnSave.Text == "&Save")
                {
                    if (db.SUD("Insert into Tbl_Projects(Project_Name,Company_ID) Values ('" + txtProjectName.Text.Trim().Replace("'", "''") + "'," + Program.CompanyID.ToString() + ")") != 0)
                    {
                        MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select * from Tbl_Projects where Company_ID=" + Program.CompanyID + " order by Project_Name", "Tbl_Projects", grdProjects);
                        ClearFields();
                    }
                }
                else
                {
                    if (db.SUD("Update Tbl_Projects Set Project_Name='" + txtProjectName.Text.Trim().Replace("'", "''") + "' where Project_ID=" + grdProjects.Rows[grdProjects.CurrentCell.RowIndex].Cells["Project_ID"].Value.ToString() + " and Company_ID=" + Program.CompanyID.ToString()) != 0)
                    {
                        MessageBox.Show("Record Updated Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select * from Tbl_Projects where Company_ID=" + Program.CompanyID + " order by Project_Name", "Tbl_Projects", grdProjects);
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
            if (db.SUD("Delete from Tbl_Projects where Project_ID=" + grdProjects.Rows[grdProjects.CurrentCell.RowIndex].Cells["Project_ID"].Value.ToString() + " and Company_ID=" + Program.CompanyID.ToString()) != 0)
            {
                MessageBox.Show("Record Deleted Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.FillGrid("Select * from Tbl_Projects where Company_ID=" + Program.CompanyID + " order by Project_Name", "Tbl_Projects", grdProjects);
                ClearFields();
            }
        }
        private void ClearFields()
        {
            txtProjectName.Text = "";
            txtProjectName.Focus();
            btnSave.Text = "&Save";
        }
        private void frmProjects_Load(object sender, EventArgs e)
        {
            db.FillGrid("Select * from Tbl_Projects where Company_ID=" + Program.CompanyID + " order by Project_Name", "Tbl_Projects", grdProjects);
            SetGridStyles(); 
        }

        private void grdProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProjectName.Text = grdProjects.Rows[e.RowIndex].Cells["Project_Name"].Value.ToString();
            btnSave.Text = "&Update";  
        }
        private void SetGridStyles()
        {
            grdProjects.Columns["Project_ID"].Visible = false;
            grdProjects.Columns["Project_Name"].Width = 375;
            grdProjects.Columns["Company_ID"].Visible = false;
        }

        private void frmProjects_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");  
        }

    }
}
