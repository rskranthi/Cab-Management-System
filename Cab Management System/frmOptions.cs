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
    public partial class frmOptions : Form
    {
        DataBase db = new DataBase(); 
        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmOptions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");  
        }

        private void chkInternet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInternet.Checked)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                txtCityMapPath.Focus();
            }
            else
            {
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
                txtCityMapImage.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkInternet.Checked && txtCityMapPath.Text.Trim() == "")
            {
                MessageBox.Show("City Map Path should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCityMapPath.Focus();  
            }
            if (chkInternet.Checked ==false && txtCityMapImage.Text.Trim() == "")
            {
                MessageBox.Show("City Map Image should not be blank", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLoad.Focus();  
            }
            db.SUD("Delete from Tbl_Options where Company_ID=" + Program.CompanyID);
            db.SUD("Insert into Tbl_Options(isInternet,CityMapPath,CityMapImage,Company_ID) Values(" + (chkInternet.Checked ? "1" : "0") + ",'" + txtCityMapPath.Text.Trim() + "','" + txtCityMapImage.Text.Trim() + "'," + Program.CompanyID + ")");
            MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            DataTable dt= db.ExecuteTable("Select * from Tbl_Options where Company_ID=" + Program.CompanyID,"Tbl_Options" );
            if (dt.Rows.Count > 0)
            {
                chkInternet.Checked = (dt.Rows[0]["isInternet"].ToString() == "1" ? true : false);
                if (dt.Rows[0]["isInternet"].ToString() == "1")
                {
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = false;  
                    txtCityMapPath.Text = dt.Rows[0]["CityMapPath"].ToString();
                }
                else
                {
                    groupBox2.Enabled = true;
                    groupBox1.Enabled = false;  
                    txtCityMapImage.Text = dt.Rows[0]["CityMapImage"].ToString();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Select the City Image Path";
                openFileDialog1.AddExtension = true;
                openFileDialog1.Filter = "JPEG|*.jpeg|All Files|*.*";
                openFileDialog1.ShowDialog();
                txtCityMapImage.Text = openFileDialog1.FileName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
