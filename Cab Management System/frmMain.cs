using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CabMan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }

        private void mnuLocations_Click(object sender, EventArgs e)
        {
            frmLocations f = new frmLocations();
            f.MdiParent = this;
            f.Show(); 
        }

        private void mnuMapLocations_Click(object sender, EventArgs e)
        {
            frmMapLocations f = new frmMapLocations();
            f.MdiParent = this;
            f.Show(); 
        }

        private void mnuVehicleTypes_Click(object sender, EventArgs e)
        {
            frmVehicleTypes f = new frmVehicleTypes();
            f.MdiParent = this;
            f.Show(); 
        }

        private void mnuUsers_Click(object sender, EventArgs e)
        {
            frmUsers f = new frmUsers();
            f.MdiParent = this;
            f.Show(); 
        }

       
        private void mnuDriverDetails_Click(object sender, EventArgs e)
        {
            frmDriverDetails f = new frmDriverDetails();
            f.MdiParent = this;
            f.Show(); 
        }

        private void mnuVehicleDetails_Click(object sender, EventArgs e)
        {
            frmVehicleDetails f = new frmVehicleDetails();
            f.MdiParent = this;
            f.Show(); 
        }

        private void mnuMapAndDirections_Click(object sender, EventArgs e)
        {
            frmMapAndDirection f = new frmMapAndDirection();
            f.MdiParent = this;
            f.Show(); 
        }

        private void mnuInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice f = new frmInvoice();
            f.MdiParent = this;
            //f.Anchor = AnchorStyles.Top;
            //f.Width = this.Width-10; 
            f.Show();
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.MdiParent = this;
            f.Show(); 
        }

        private void mnuCompany_Click(object sender, EventArgs e)
        {
            frmCompany f = new frmCompany();
            f.MdiParent = this;
            f.Show(); 
        }

        private void mnuFares_Click(object sender, EventArgs e)
        {
            frmFares f = new frmFares();
            f.MdiParent = this;
            f.Show(); 
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuBooking_Click(object sender, EventArgs e)
        {
            frmBooking f = new frmBooking();
            f.MdiParent = this;
            f.Show(); 
        }

        private void mnuJobs_Click(object sender, EventArgs e)
        {
            frmJobs f = new frmJobs();
            f.MdiParent = this;
            f.Show(); 
        }

        private void mnuAccess_Click(object sender, EventArgs e)
        {
            frmAccess f = new frmAccess();
            f.MdiParent = this;
            f.Show(); 
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Program.disableMenus();  
        }

        private void mnuProjects_Click(object sender, EventArgs e)
        {
            frmProjects f = new frmProjects();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuEmployees_Click(object sender, EventArgs e)
        {
            frmEmployees f = new frmEmployees();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuShuttleBookings_Click(object sender, EventArgs e)
        {
            frmShuttleBooking f = new frmShuttleBooking();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuReportLocations_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.MdiParent = frmMain.ActiveForm;
            
            
            

            frm.crv.ReportSource =  ConfigurationManager.AppSettings["ReportPath"].ToString() + "\\rptLocations.rpt";

            ParameterFields parameterFields = frm.crv.ParameterFieldInfo;
            ParameterValues currentParameterValues = new ParameterValues();
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();

            parameterDiscreteValue.Value = Program.CName;
            currentParameterValues.Add(parameterDiscreteValue);
            ParameterField parameterField = parameterFields["CName"];
            parameterField.CurrentValues = currentParameterValues;

            frm.crv.SelectionFormula = "{Tbl_Locations.Company_ID}=" + Program.CompanyID;  
            frm.Show();
        }

        private void mnuReportFares_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.MdiParent = frmMain.ActiveForm;
            frm.crv.ReportSource = ConfigurationManager.AppSettings["ReportPath"].ToString() + "\\rptFares.rpt";

            ParameterFields parameterFields = frm.crv.ParameterFieldInfo;
            ParameterValues currentParameterValues = new ParameterValues();
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();

            parameterDiscreteValue.Value = Program.CName;
            currentParameterValues.Add(parameterDiscreteValue);
            ParameterField parameterField = parameterFields["CName"];
            parameterField.CurrentValues = currentParameterValues;

            frm.crv.SelectionFormula = "{Tbl_Fares.Company_ID}=" + Program.CompanyID;  
            frm.Show();
        }

        private void mnuReportVehicleTypes_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.MdiParent = frmMain.ActiveForm;
            frm.crv.ReportSource = ConfigurationManager.AppSettings["ReportPath"].ToString() + "\\rptVehicleTypes.rpt";

            ParameterFields parameterFields = frm.crv.ParameterFieldInfo;
            ParameterValues currentParameterValues = new ParameterValues();
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();

            parameterDiscreteValue.Value = Program.CName;
            currentParameterValues.Add(parameterDiscreteValue);
            ParameterField parameterField = parameterFields["CName"];
            parameterField.CurrentValues = currentParameterValues;

            //frm.crv.SelectionFormula = "{Tbl_VehicleTypes.Company_ID}='" + txtInvoieNo.Text.Trim() + "'";
            frm.crv.SelectionFormula = "{Tbl_VehicleTypes.Company_ID}=" + Program.CompanyID;  
            frm.Show();
        }

        private void mnuReportVehicleDetails_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.MdiParent = frmMain.ActiveForm;
            frm.crv.ReportSource = ConfigurationManager.AppSettings["ReportPath"].ToString() + "\\rptVehicleDetails.rpt";

            ParameterFields parameterFields = frm.crv.ParameterFieldInfo;
            ParameterValues currentParameterValues = new ParameterValues();
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();

            parameterDiscreteValue.Value = Program.CName;
            currentParameterValues.Add(parameterDiscreteValue);
            ParameterField parameterField = parameterFields["CName"];
            parameterField.CurrentValues = currentParameterValues;

            frm.crv.SelectionFormula = "{Tbl_Vehicles.Company_ID}=" + Program.CompanyID;
            frm.Show();
        }

        private void mnuBackUp_Click(object sender, EventArgs e)
        {
            frmBackUp f = new frmBackUp();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuDutyRooster_Click(object sender, EventArgs e)
        {
            frmDutyRooster f = new frmDutyRooster();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuOptions_Click(object sender, EventArgs e)
        {
            frmOptions f = new frmOptions();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuDriversSchedule_Click(object sender, EventArgs e)
        {
            frmDriverSchedule f = new frmDriverSchedule();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuReportDriverDetails_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.MdiParent = frmMain.ActiveForm;

            //ParameterFields parameterFields = frm.crv.ParameterFieldInfo;
            //ParameterValues currentParameterValues = new ParameterValues();
            //ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();

            //parameterDiscreteValue.Value = Program.CName;
            //currentParameterValues.Add(parameterDiscreteValue);
            //ParameterField parameterField = parameterFields["CName"];
            //parameterField.CurrentValues = currentParameterValues;

            frm.crv.ReportSource = ConfigurationManager.AppSettings["ReportPath"].ToString() + "\\rptDriverDetails.rpt";
            frm.Show();
        }

        private void mnuReportVehicleFares_Click(object sender, EventArgs e)
        {
            frmReportFares f = new frmReportFares();
            f.MdiParent = this;
            f.Show();
        }
    }
}
