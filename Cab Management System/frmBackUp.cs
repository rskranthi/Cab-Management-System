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
    public partial class frmBackUp : Form
    {
        public frmBackUp()
        {
            InitializeComponent();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            if (txtBackUpPath.Text.Trim()=="")
            {
                MessageBox.Show("Select a path to take backup", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOpen.Focus();  
                return;
            }
            System.IO.File.Copy(System.Configuration.ConfigurationManager.AppSettings["DatabasePath"].ToString() , txtBackUpPath.Text,true);
            MessageBox.Show("Backup completed successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBackUpPath.Text="";
            btnOpen.Focus();  
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
             try
            {
                saveFileDialog1.Title = "Select a path for Backup";
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.Filter = "MDB|*.mdb|All Files|*.*";
                saveFileDialog1.ShowDialog();
                txtBackUpPath.Text = saveFileDialog1.FileName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBackUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");
        }
    }
}
