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
    public partial class frmMapAndDirection : Form
    {
        private Rectangle rect;
        private bool move = false;
        DataBase db = new DataBase();
        DataTable dt;
        DataRow row;        

        public frmMapAndDirection()
        {
            InitializeComponent();
        }

        private void frmMapAndDirection_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            db.FillCombo("Select * from Tbl_Locations order by Location_Name","Tbl_Locations",cmbFrom);
            db.FillCombo("Select * from Tbl_Locations order by Location_Name", "Tbl_Locations", cmbTo);
            setGrid();
            DataTable dtm= db.ExecuteTable("Select * from Tbl_Options where Company_ID=" + Program.CompanyID, "Tbl_Options");
            if (dtm.Rows.Count > 0)
            {
                if (dtm.Rows[0]["isInternet"].ToString() == "1")
                {
                    webBrowser1.Visible = true;
                    picMapAndDirection.Visible = false;
                    Uri u = new Uri(dtm.Rows[0]["CityMapPath"].ToString());  
                    webBrowser1.Url = u; 
                }
                else
                {
                    webBrowser1.Visible = false;
                    picMapAndDirection.Visible = true;
                    picMapAndDirection.Load(dtm.Rows[0]["CityMapImage"].ToString());  
                }
            }
            
        }

        private void setGrid()
        {
            dt = new DataTable("TestTable");
            DataColumn col0 = new DataColumn("From", System.Type.GetType("System.String"));
            DataColumn col1 = new DataColumn("FromLocation", System.Type.GetType("System.String"));
            DataColumn col2 = new DataColumn("To", System.Type.GetType("System.String"));
            DataColumn col3 = new DataColumn("ToLocation", System.Type.GetType("System.String"));
            DataColumn col4 = new DataColumn("Distance", System.Type.GetType("System.String"));
            dt.Columns.Add(col0);
            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            grdMapAndDirection.DataSource = dt;

            grdMapAndDirection.Columns["From"].Width = 200;
            grdMapAndDirection.Columns["FromLocation"].Width = 200;
            grdMapAndDirection.Columns["To"].Width = 200;
            grdMapAndDirection.Columns["ToLocation"].Width = 200;
            grdMapAndDirection.Columns["Distance"].Width = 150;

        }

        private void frmMapAndDirection_Resize(object sender, EventArgs e)
        {
            grdMapAndDirection.Width = this.Width - 28;
            picMapAndDirection.Width = this.Width - 28;
            webBrowser1.Width = this.Width - 28;
            groupBox1.Width = this.Width - 28; 
            picMapAndDirection.Height = this.Height - (this.grdMapAndDirection.Height + 170);
            webBrowser1.Height = this.Height - (this.grdMapAndDirection.Height + 170);
            panel1.Width = this.Width - 28;
            panel1.Height = this.Height - (this.grdMapAndDirection.Height + 170);
         }

        private void picMapAndDirection_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            rect.X = e.X;
            rect.Y = e.Y;
        }

        private void picMapAndDirection_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                picMapAndDirection.Left += e.X - rect.X;
                picMapAndDirection.Top += e.Y - rect.Y;
            } 
        }

        private void picMapAndDirection_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cmbFrom.SelectedIndex==-1  )
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
            try
            {
                db.OpenConnection();
                bool flag= true;
                int d=0;
                dt.Clear(); 
                string FROM = cmbFrom.SelectedValue.ToString();   
                while (flag)
                {
                    db.Dcmd = new System.Data.OleDb.OleDbCommand("Select FromLocation_ID,ToLocation_ID,Distance,(Select Location_Name from Tbl_Locations where Location_ID=FromLocation_ID and Company_ID=" + Program.CompanyID + ") as FromLocation, (Select Location_Name from Tbl_Locations where Location_ID=ToLocation_ID and Company_ID=" + Program.CompanyID + ") as ToLocation from Tbl_MAPLocations where Company_ID=" + Program.CompanyID + " and FromLocation_ID=" + FROM, db.DCon);
                    System.Data.OleDb.OleDbDataReader dr = db.Dcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        row = dt.NewRow();
                        row["From"] = dr["FromLocation_ID"].ToString();
                        row["FromLocation"] = dr["FromLocation"].ToString();
                        row["To"] = dr["ToLocation_ID"].ToString();
                        row["ToLocation"] = dr["FromLocation"].ToString();
                        row["Distance"] = dr["Distance"].ToString();
                        dt.Rows.Add(row);

                        d += Convert.ToInt32(dr["Distance"]);
                        FROM = dr["ToLocation_ID"].ToString(); 
                        if (dr["ToLocation_ID"].ToString()  == cmbTo.SelectedValue.ToString())
                            flag = false; 
                    }
                    dr.Close();
                    db.Dcmd.Dispose();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void frmMapAndDirection_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
            else if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");
        }
    }
}
