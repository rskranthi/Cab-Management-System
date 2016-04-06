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
    public partial class frmReportFares : Form
    {
        public frmReportFares()
        {
            InitializeComponent();
        }

        private void frmReportFares_Load(object sender, EventArgs e)
        {
            BusinessLogic.FillVehicleTypes(cmbVT); 
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.MdiParent = frmMain.ActiveForm;
            frm.crv.ReportSource = System.Configuration.ConfigurationManager.AppSettings["ReportPath"].ToString() + "\\rptVehicleFares.rpt";

            frm.crv.SelectionFormula = "{V_Fares.Vehicle_Type}=" + cmbVT.SelectedIndex;  
            frm.Show();
        }
    }
}
