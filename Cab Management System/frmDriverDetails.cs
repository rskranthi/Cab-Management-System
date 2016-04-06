using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
 
namespace CabMan
{
    public partial class frmDriverDetails : Form
    {
        DataBase db = new DataBase(); 
        public frmDriverDetails()
        {
            InitializeComponent();
        }
        private void frmDriverDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}"); 
        }
        private void frmDriverDetails_Load(object sender, EventArgs e)
        {
            db.FillGrid("Select * from Tbl_Drivers where Company_ID=" + Program.CompanyID.ToString() + " order by Driver_Name", "Tbl_Drivers", grdDriver);   
            SetGridStyles(); 
        }

        private void SetGridStyles()
        {
            grdDriver.Columns["Driver_ID"].Visible = false;
            grdDriver.Columns["Driver_Name"].Width = 300;
            grdDriver.Columns["Contact_No"].Width = 130;
            grdDriver.Columns["Adhoc"].Visible = false;
            grdDriver.Columns["Alternate_No"].Visible = false;
            grdDriver.Columns["DoB"].Visible = false;
            grdDriver.Columns["DJ"].Visible = false;
            grdDriver.Columns["DL"].Visible = false;
            grdDriver.Columns["Licence_No"].Visible = false;
            grdDriver.Columns["Licence_Class"].Visible = false;
            grdDriver.Columns["LE"].Width = 110;
            grdDriver.Columns["Pic_Attached"].Visible = false;  
            grdDriver.Columns["Company_ID"].Visible = false;
        }
        private void grdDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDriverName.Text = grdDriver.Rows[e.RowIndex].Cells["Driver_Name"].Value.ToString();
            txtContactNo.Text = grdDriver.Rows[e.RowIndex].Cells["Contact_No"].Value.ToString();
            chkAdhoc.Checked = (grdDriver.Rows[e.RowIndex].Cells["Adhoc"].Value.ToString() == "0" ? false : true);
            txtAlternateNo.Text = grdDriver.Rows[e.RowIndex].Cells["Alternate_No"].Value.ToString();
            dtpDOB.Text = grdDriver.Rows[e.RowIndex].Cells["DOB"].Value.ToString();
            dtpDJoined.Text = grdDriver.Rows[e.RowIndex].Cells["DJ"].Value.ToString();

            DateTime d = (DateTime) grdDriver.Rows[e.RowIndex].Cells["DL"].Value;
            if (d.Year == 1900)
            {
                dtpDLeft.Text = DateTime.Today.ToShortDateString();
                dtpDLeft.Checked = false;
            }
            else
            {
                dtpDLeft.Text = grdDriver.Rows[e.RowIndex].Cells["DL"].Value.ToString();
            }
            txtLicenceNo.Text = grdDriver.Rows[e.RowIndex].Cells["Licence_No"].Value.ToString();
            txtLicenceClass.Text = grdDriver.Rows[e.RowIndex].Cells["Licence_Class"].Value.ToString();
            dtpLicenceExpired.Text = grdDriver.Rows[e.RowIndex].Cells["LE"].Value.ToString();
            if (grdDriver.Rows[e.RowIndex].Cells["Pic_Attached"].Value.ToString() == "1")
                picDriver.Load(ConfigurationManager.AppSettings["PicPath"] + grdDriver.Rows[e.RowIndex].Cells["Driver_ID"].Value.ToString() + ".jpeg");
            else
                picDriver.Image = null;  
  
            btnSave.Text = "&Update";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDriverName.Text.Trim()=="")
            {
                MessageBox.Show("Driver Name should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDriverName.Focus();
                return;
            }
            if (txtContactNo.Text.Trim() == "")
            {
                MessageBox.Show("Contact No should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContactNo.Focus();
                return;
            }
            try
            {
                if (btnSave.Text == "&Save")
                {
                    if (db.SUD("Insert into Tbl_Drivers(Driver_Name,Contact_No,Adhoc,Alternate_No,DoB,DJ,DL,Licence_No,Licence_Class,LE,Pic_Attached,Company_ID) Values ('" + txtDriverName.Text.Trim().Replace("'", "''") + "','" + txtContactNo.Text.Trim().Replace("'", "''") + "'," + (chkAdhoc.Checked ? 1 : 0) + ",'" + txtAlternateNo.Text.Trim().Replace("'", "''") + "','" + dtpDOB.Text + "','" + dtpDJoined.Text + "','" + (dtpDLeft.Checked ? dtpDLeft.Text : "01/01/1900") + "','" + txtLicenceNo.Text.Trim().Replace("'", "''") + "','" + txtLicenceClass.Text.Trim().Replace("'", "''") + "','" + dtpLicenceExpired.Text + "'," + (picDriver.Image==null? 0:1) +"," + Program.CompanyID.ToString() + ")") != 0)
                    {
                        if (picDriver.Image != null)
                            System.IO.File.Copy(openFileDialog1.FileName, ConfigurationManager.AppSettings["PicPath"] + db.getRecord("Select Max(Driver_ID) from Tbl_Drivers") + ".jpeg", true);         
                        MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select * from Tbl_Drivers where Company_ID=" + Program.CompanyID.ToString() + " order by Driver_Name", "Tbl_Drivers", grdDriver);   
                        ClearFields();
                    }
                }
                else
                {
                    if (db.SUD("Update Tbl_Drivers Set Driver_Name='" + txtDriverName.Text.Trim().Replace("'", "''") + "',Contact_No='" + txtContactNo.Text.Trim().Replace("'", "''") + "',Adhoc=" + (chkAdhoc.Checked ? 1 : 0) + ",Alternate_No='" + txtAlternateNo.Text.Trim().Replace("'", "''") + "',DoB='" + dtpDOB.Text + "',DJ='" + dtpDJoined.Text + "',DL='" + dtpDJoined.Text + "',Licence_No='" + txtLicenceNo.Text.Trim().Replace("'", "''") + "',Licence_Class='" + txtLicenceClass.Text.Trim().Replace("'", "''") + "',LE='" + dtpLicenceExpired.Text + "',Pic_Attached=" + (picDriver.Image == null ? 0 : 1) + " where Driver_ID=" + grdDriver.Rows[grdDriver.CurrentCell.RowIndex].Cells["Driver_ID"].Value.ToString() + " and Company_ID=" + Program.CompanyID.ToString()) != 0)
                    {
                        if (picDriver.Image != null && openFileDialog1.FileName != "openFileDialog1")
                            System.IO.File.Copy(openFileDialog1.FileName, ConfigurationManager.AppSettings["PicPath"] + grdDriver.Rows[grdDriver.CurrentCell.RowIndex].Cells["Driver_ID"].Value.ToString() + ".jpeg", true);         
                        MessageBox.Show("Record Updated Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.FillGrid("Select * from Tbl_Drivers where Company_ID=" + Program.CompanyID.ToString() + " order by Driver_Name", "Tbl_Drivers", grdDriver);   
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
            txtDriverName.Text = "";  
            txtAddress.Text = "";
            txtContactNo.Text = "";
            txtAlternateNo.Text = "";
            chkAdhoc.Checked = false;
            dtpDOB.Text = dtpDLeft.Text = dtpDJoined.Text  = dtpLicenceExpired.Text = DateTime.Today.ToShortDateString() ;
            txtLicenceNo.Text = "";
            txtLicenceClass.Text = "";
            picDriver.Image = null;  
            btnSave.Text = "&Save";
            txtDriverName.Focus();
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Select Drivers Image";
                openFileDialog1.AddExtension = true;
                openFileDialog1.Filter = "JPG|*.jpg|GIF|*.gif|JPEG|*.jpeg|All Files|*.*";
                openFileDialog1.ShowDialog();
                picDriver.Load(openFileDialog1.FileName.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
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
            if (db.SUD("Delete from Tbl_Drivers where Company_ID=" + grdDriver.Rows[grdDriver.CurrentCell.RowIndex].Cells["Company_ID"].Value.ToString() + " and Driver_ID=" + grdDriver.Rows[grdDriver.CurrentCell.RowIndex].Cells["Driver_ID"].Value.ToString()) != 0)
            {
                if (grdDriver.Rows[grdDriver.CurrentCell.RowIndex].Cells["Pic_Attached"].Value.ToString() == "1")
                {
                    System.IO.File.Delete(ConfigurationManager.AppSettings["PicPath"] + grdDriver.Rows[grdDriver.CurrentCell.RowIndex].Cells["Driver_ID"].Value.ToString() + ".jpeg");   
                }
                MessageBox.Show("Record Deleted Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.FillGrid("Select * from Tbl_Drivers where Company_ID=" + Program.CompanyID.ToString() + " order by Driver_Name", "Tbl_Drivers", grdDriver);   
                ClearFields();
            }
        }
    }
}
