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
    public partial class frmDutyRooster : Form
    {
        DataBase db = new DataBase();
        DataTable dt;
        DataRow row;
        public frmDutyRooster()
        {
            InitializeComponent();
        }

        private void frmDutyRooster_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");  
        }

        private void frmDutyRooster_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;  
            dt = new DataTable("Tbl_DutyRooster");
            DataColumn c0 = new DataColumn("Driver_ID", System.Type.GetType("System.String"));
            DataColumn c1 = new DataColumn("Driver_Name", System.Type.GetType("System.String"));
            dt.Columns.Add(c0);
            dt.Columns.Add(c1);

            DataColumn[] d = new DataColumn[DateTime.DaysInMonth(dtpMonthDate.Value.Year,dtpMonthDate.Value.Month)];
            for (int i = 0; i < DateTime.DaysInMonth(dtpMonthDate.Value.Year, dtpMonthDate.Value.Month); i++)
            {
                d[i] = new DataColumn((i+1).ToString(), System.Type.GetType("System.String"));
                dt.Columns.Add(d[i]);
            }
            grdDutyRooster.DataSource = dt;
            grdDutyRooster.Columns["Driver_ID"].Visible = false; 
            DataTable dtDriver = db.ExecuteTable("Select * from Tbl_Drivers where Company_ID=" + Program.CompanyID, "Tbl_Drivers");   
            for (int i = 0; i < dtDriver.Rows.Count ; i++)
            {
                row = dt.NewRow();
                row["Driver_ID"] = dtDriver.Rows[i]["Driver_ID"].ToString();   
                row["Driver_Name"] = dtDriver.Rows[i]["Driver_Name"].ToString();   
                dt.Rows.Add(row);
            }

            ShowPresent();  
        }
        private void ShowPresent()
        {
            int x;
            for (int i = 0; i < grdDutyRooster.Rows.Count-1 ; i++)
            {
                string s = "Select * from Tbl_DutyRooster where Company_ID=" + Program.CompanyID + " and Month(DDate)=" + dtpMonthDate.Value.Month.ToString() + " and Year(DDate)=" + dtpMonthDate.Value.Year.ToString() + " and Driver_ID=" + grdDutyRooster.Rows[i].Cells["Driver_ID"].Value.ToString();
                //MessageBox.Show(s);  
                DataTable dtPresent = db.ExecuteTable("Select * from Tbl_DutyRooster where Company_ID=" + Program.CompanyID + " and Month(DDate)=" + dtpMonthDate.Value.Month.ToString() + " and Year(DDate)=" + dtpMonthDate.Value.Year.ToString() + " and Driver_ID=" + grdDutyRooster.Rows[i].Cells["Driver_ID"].Value.ToString()  , "Tbl_DutyRooster");
                if (dtPresent.Rows.Count > 0)
                {
                    x = 0;
                    for (int j = 2; j < grdDutyRooster.Columns.Count; j++)
                    {
                        if (Convert.ToDateTime(dtPresent.Rows[x]["DDate"].ToString()).Day == j - 1)
                            grdDutyRooster.Rows[i].Cells[(j-1).ToString()].Value = dtPresent.Rows[x]["Hours"].ToString();
                        x++;
                        if (x >= dtPresent.Rows.Count) break; 
                    }
                    
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SUD("Delete from Tbl_DutyRooster where Company_ID=" + Program.CompanyID + " and Month(DDate)=" + dtpMonthDate.Value.Month.ToString() + " and Year(DDate)=" + dtpMonthDate.Value.Year.ToString());           
            for (int i = 0; i < grdDutyRooster.Rows.Count-1; i++)
            {
                for (int j = 2; j < grdDutyRooster.Columns.Count; j++)
                {
                    if(grdDutyRooster.Rows[i].Cells[(j - 1).ToString()].Value.ToString()!="")
                        db.SUD("INSERT into Tbl_DutyRooster(Driver_ID,DDate,Hours,Company_ID) values(" + grdDutyRooster.Rows[i].Cells["Driver_ID"].Value.ToString() + ",'" + (j - 1).ToString() + "-" + dtpMonthDate.Text + "'," + grdDutyRooster.Rows[i].Cells[(j - 1).ToString()].Value.ToString() + "," + Program.CompanyID + ")"); 
                }
            }
            MessageBox.Show("Record Stored Successfully", "CabMan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmDutyRooster_Resize(object sender, EventArgs e)
        {
            grdDutyRooster.Width = this.Width - 25;
            grdDutyRooster.Height = this.Height - 120;
            pictureBox2.Width = this.Width;
            lblHeader.Left = this.Width - 130;
            btnSave.Left = this.Width - 90;  
        }
    }
}
