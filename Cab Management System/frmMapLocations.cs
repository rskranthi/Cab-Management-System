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
    public partial class frmMapLocations : Form
    {
        DataBase db = new DataBase();  
        public frmMapLocations()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbFrom.SelectedIndex == -1)
            {
                MessageBox.Show("From Location should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbFrom.Focus();
                return;
            }
            if (cmbTo.SelectedIndex == -1)
            {
                MessageBox.Show("To Location should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbTo.Focus();
                return;
            }
            if (cmbTo.SelectedIndex == cmbFrom.SelectedIndex)
            {
                MessageBox.Show("From and To Location should not be same", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbTo.Focus();
                return;
            }
            if (txtDistance.Text.Trim()=="")
            {
                MessageBox.Show("Distance should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDistance.Focus();
                return;
            }
            try
            {
                if (btnSave.Text == "&Save")
                {
                    if (db.SUD("Insert into Tbl_MAPLocations(FromLocation_ID,ToLocation_ID,Distance,Company_ID) Values (" + cmbFrom.SelectedValue.ToString() + "," + cmbTo.SelectedValue.ToString() + "," + txtDistance.Text.Trim() + "," + Program.CompanyID.ToString() + ")" )!= 0)
                    {
                        MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        object  i = cmbTo.SelectedValue;  
                        ClearFields();
                        db.FillGrid("Select (Select Location_Name from Tbl_Locations where Location_ID=FromLocation_ID and Company_ID=" + Program.CompanyID + ") as  [From],(Select Location_Name from Tbl_Locations where Location_ID=ToLocation_ID and Company_ID=" + Program.CompanyID + ") as  [To],FromLocation_ID,ToLocation_ID, Distance from Tbl_MAPLocations where Company_ID=" + Program.CompanyID, "Tbl_MAPLocations", grdMAPLocations); 
                    }
                }
                else
                {
                    if (db.SUD("Delete from Tbl_MAPLocations Where FromLocation_ID=" + grdMAPLocations.Rows[grdMAPLocations.CurrentCell.RowIndex].Cells["FromLocation_ID"].Value.ToString() + " and ToLocation_ID=" + grdMAPLocations.Rows[grdMAPLocations.CurrentCell.RowIndex].Cells["ToLocation_ID"].Value.ToString() + " and Company_ID=" + Program.CompanyID.ToString()) != 0 && (db.SUD("Insert into Tbl_MAPLocations(FromLocation_ID,ToLocation_ID,Distance,Company_ID) Values (" + cmbFrom.SelectedValue.ToString() + "," + cmbTo.SelectedValue.ToString() + "," + txtDistance.Text.Trim() + "," + Program.CompanyID.ToString() + ")") != 0))
                    {
                        MessageBox.Show("Record Updated Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        db.FillGrid("Select (Select Location_Name from Tbl_Locations where Location_ID=FromLocation_ID and Company_ID=" + Program.CompanyID + ") as  [From],(Select Location_Name from Tbl_Locations where Location_ID=ToLocation_ID and Company_ID=" + Program.CompanyID + ") as  [To],FromLocation_ID,ToLocation_ID, Distance from Tbl_MAPLocations where Company_ID=" + Program.CompanyID, "Tbl_MAPLocations", grdMAPLocations); 
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
            cmbFrom.SelectedIndex = -1;
            cmbTo.SelectedIndex = -1;
            txtDistance.Text = "";
            cmbFrom.Focus();  
        }

        private void frmMapLocations_Load(object sender, EventArgs e)
        {
            db.FillCombo("Select * from Tbl_Locations where Company_ID=" + Program.CompanyID  + " order by Location_Name", "Tbl_Locations", cmbFrom);
            db.FillCombo("Select * from Tbl_Locations where Company_ID=" + Program.CompanyID  + " order by Location_Name", "Tbl_Locations", cmbTo);
            db.FillGrid("Select (Select Location_Name from Tbl_Locations where Location_ID=FromLocation_ID and Company_ID=" + Program.CompanyID + ") as  [From],(Select Location_Name from Tbl_Locations where Location_ID=ToLocation_ID and Company_ID=" + Program.CompanyID + ") as  [To],FromLocation_ID,ToLocation_ID, Distance from Tbl_MAPLocations where Company_ID=" + Program.CompanyID, "Tbl_MAPLocations", grdMAPLocations); 
            SetGridStyles();
            //ClearFields();  
        }

        private void SetGridStyles()
        {
            grdMAPLocations.Columns["From"].Width = 240 ;
            grdMAPLocations.Columns["FromLocation_ID"].Visible = false;  
            grdMAPLocations.Columns["To"].Width = 240;
            grdMAPLocations.Columns["ToLocation_ID"].Visible = false;  
            grdMAPLocations.Columns["Distance"].Width = 110;
            //grdMAPLocations.Columns["Company_ID"].Visible = false;
        }

        private void frmMapLocations_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}"); 
        }

        private void cmbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFrom.SelectedIndex == -1) return;
            db.FillGrid("Select (Select Location_Name from Tbl_Locations where Location_ID=FromLocation_ID and Company_ID=" + Program.CompanyID  + ") as  [From],(Select Location_Name from Tbl_Locations where Location_ID=ToLocation_ID and Company_ID=" + Program.CompanyID + ") as  [To],FromLocation_ID,ToLocation_ID, Distance from Tbl_MAPLocations where FromLocation_ID=" + cmbFrom.SelectedValue.ToString() + " and Company_ID=" + Program.CompanyID , "Tbl_MAPLocations", grdMAPLocations); 
        }

        private void grdMAPLocations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdMAPLocations.Rows.Count  <= 1) return;
            txtDistance.Text = grdMAPLocations.Rows[e.RowIndex].Cells["Distance"].Value.ToString();
            cmbTo.Text = grdMAPLocations.Rows[e.RowIndex].Cells["To"].Value.ToString();
            cmbFrom.Text  = grdMAPLocations.Rows[e.RowIndex].Cells["From"].Value.ToString();
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
            if (db.SUD("Delete from Tbl_MAPLocations where FromLocation_ID=" + grdMAPLocations.Rows[grdMAPLocations.CurrentCell.RowIndex].Cells["FromLocation_ID"].Value.ToString() + " and ToLocation_ID=" + grdMAPLocations.Rows[grdMAPLocations.CurrentCell.RowIndex].Cells["ToLocation_ID"].Value.ToString() + " and Company_ID=" + Program.CompanyID.ToString()) != 0)
            {
                MessageBox.Show("Record Deleted Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                db.FillGrid("Select (Select Location_Name from Tbl_Locations where Location_ID=FromLocation_ID and Company_ID=" + Program.CompanyID + ") as  [From],(Select Location_Name from Tbl_Locations where Location_ID=ToLocation_ID and Company_ID=" + Program.CompanyID + ") as  [To],FromLocation_ID,ToLocation_ID, Distance from Tbl_MAPLocations where Company_ID=" + Program.CompanyID, "Tbl_MAPLocations", grdMAPLocations); 
            }
        }

        
    }
}
