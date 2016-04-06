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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            crv.Show();
            crv.Refresh();
        }

        private void frmReport_Resize(object sender, EventArgs e)
        {
            crv.Size = this.Size;  
        }

    }
}
