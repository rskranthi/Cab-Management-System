using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;

namespace CabMan
{
    class DataBase
    {
        string ConStr = ConfigurationManager.AppSettings["Con"].ToString();
        
        public OleDbConnection DCon;
        public OleDbDataAdapter Dda;
        public OleDbCommand Dcmd;
        public DataSet Dds;

        public void OpenConnection()
        {
            try
            {
                DCon = new OleDbConnection(ConStr);
                DCon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }

        public void CloseConnection()
        {
            try
            {
                DCon.Close();
                DCon.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }
        public void FillCombo(string Qry, string TableName, ComboBox cmb)
        {
            try
            {
                OpenConnection();
                Dds = new DataSet();
                using (Dda = new OleDbDataAdapter(Qry, DCon))
                {
                    Dda.Fill(Dds, TableName);
                    cmb.DataSource = Dds.Tables[0];
                }
                cmb.SelectedIndex = -1;
                Dds.Dispose();
                CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }
        public void FillList(string Qry, string TableName, ListBox cmb)
        {
            try
            {
                OpenConnection();
                Dds = new DataSet();
                using (Dda = new OleDbDataAdapter(Qry, DCon))
                {
                    Dda.Fill(Dds, TableName);
                    cmb.DataSource = Dds.Tables[0];
                }
                cmb.SelectedIndex = -1;
                Dds.Dispose();
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FillGrid(string Qry, string TableName, DataGridView grd)
        {
            try
            {
                OpenConnection();
                Dds = new DataSet();
                Dda = new OleDbDataAdapter(Qry, DCon);
                Dda.Fill(Dds, TableName);
                grd.DataSource = Dds.Tables[0];

                Dda.Dispose();
                Dds.Dispose();
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }
        public int SUD(string Qry)
        {
            try
            {
                OpenConnection();
                Dcmd = new OleDbCommand(Qry, DCon);
                int result = Dcmd.ExecuteNonQuery();
                Dcmd.Dispose();
                CloseConnection();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public string getRecord(string Qry)
        {
            string cid = "";
            try
            {
                OpenConnection();
                Dcmd = new OleDbCommand(Qry, DCon);
                OleDbDataReader dr = Dcmd.ExecuteReader();
                if (dr.Read())
                    cid = dr[0].ToString();
                dr.Close();
                Dcmd.Dispose();
                CloseConnection();
                return cid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool isAuthenticate(string Qry)
        {
            bool flag = false;
            try
            {
                OpenConnection();
                Dcmd = new OleDbCommand(Qry, DCon);
                OleDbDataReader dr = Dcmd.ExecuteReader();
                if (dr.Read())
                    flag = true;
                dr.Close();
                Dcmd.Dispose();
                CloseConnection();
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false; 
            }
        }
        public DataTable ExecuteTable(string Qry, string tableName)
        {
            Dds = new DataSet();
            try
            {
                OpenConnection(); 
                Dda = new OleDbDataAdapter(Qry, DCon);
                Dda.Fill(Dds, tableName);
                CloseConnection(); 
                return Dds.Tables[tableName];   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void SaveFares(DataGridView grd)
        {
            try
            {
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    SUD("Delete from Tbl_Fares where Vehicle_TypeID=" + grd.Rows[i].Cells["CarID"].Value.ToString() + " and Company_ID=" + Program.CompanyID);
                    SUD("INSERT INTO Tbl_Fares(Vehicle_TypeID,Non4,Non8,NonXHrs,NonXKms,NonGeneral,AC4,AC8,ACXHrs,ACXKms,ACGeneral,Company_ID) values(" + grd.Rows[i].Cells["CarID"].Value.ToString() + "," + (grd.Rows[i].Cells["Non4"].Value.ToString() == "" ? "0" : grd.Rows[i].Cells["Non4"].Value.ToString()) + "," + (grd.Rows[i].Cells["Non8"].Value.ToString() == "" ? "0" : grd.Rows[i].Cells["Non8"].Value.ToString()) + "," + (grd.Rows[i].Cells["NonXHrs"].Value.ToString() == "" ? "0" : grd.Rows[i].Cells["NonXHrs"].Value.ToString()) + "," + (grd.Rows[i].Cells["NonXKms"].Value.ToString() == "" ? "0" : grd.Rows[i].Cells["NonXKms"].Value.ToString()) + "," + (grd.Rows[i].Cells["NonGeneral"].Value.ToString() == "" ? "0" : grd.Rows[i].Cells["NonGeneral"].Value.ToString()) + "," + (grd.Rows[i].Cells["AC4"].Value.ToString() == "" ? "0" : grd.Rows[i].Cells["AC4"].Value.ToString()) + "," + (grd.Rows[i].Cells["AC8"].Value.ToString() == "" ? "0" : grd.Rows[i].Cells["AC8"].Value.ToString()) + "," + (grd.Rows[i].Cells["ACXHrs"].Value.ToString() == "" ? "0" : grd.Rows[i].Cells["ACXHrs"].Value.ToString()) + "," + (grd.Rows[i].Cells["ACXKms"].Value.ToString() == "" ? "0" : grd.Rows[i].Cells["ACXKms"].Value.ToString()) + "," + (grd.Rows[i].Cells["ACGeneral"].Value.ToString() == "" ? "0" : grd.Rows[i].Cells["ACGeneral"].Value.ToString()) + "," + Program.CompanyID + ")");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayFares(DataGridView grd, DataTable dt)
        {
            OpenConnection();
            try
            {
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    Dcmd = new OleDbCommand("Select * from Tbl_Fares where Vehicle_TypeID=" + grd.Rows[i].Cells["CarID"].Value.ToString() + " and Company_ID=" + Program.CompanyID.ToString(), DCon);
                    OleDbDataReader dr = Dcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dt.Rows[i]["Non4"] = dr["Non4"].ToString();
                        dt.Rows[i]["Non8"] = dr["Non8"].ToString();
                        dt.Rows[i]["NonXHrs"] = dr["NonXHrs"].ToString();
                        dt.Rows[i]["NonXKms"] = dr["NonXKms"].ToString();
                        dt.Rows[i]["NonGeneral"] = dr["NonGeneral"].ToString();
                        dt.Rows[i]["AC4"] = dr["AC4"].ToString();
                        dt.Rows[i]["AC8"] = dr["AC8"].ToString();
                        dt.Rows[i]["ACXHrs"] = dr["ACXHrs"].ToString();
                        dt.Rows[i]["ACXKms"] = dr["ACXKms"].ToString();
                        dt.Rows[i]["ACGeneral"] = dr["ACGeneral"].ToString();
                    }
                    dr.Close();
                    Dcmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }
            CloseConnection();
        }

        public int getJobID(DateTime dt)
        {
            int i;
            OpenConnection();
            Dcmd = new OleDbCommand("Select Job_ID from Tbl_Bookings where Booking_Date=#" + dt.ToShortDateString() + "# and Company_ID=" + Program.CompanyID.ToString() + " order by Job_ID Desc", DCon);
            OleDbDataReader dr = Dcmd.ExecuteReader();
            if (dr.Read())
            {
                i = Convert.ToInt32(dr["Job_ID"]);
                i = Convert.ToInt32(Convert.ToInt32(Program.CompanyID + (dt.Day.ToString().Length == 1 ? "0" + dt.Day.ToString() : dt.Day.ToString()) + (dt.Month.ToString().Length == 1 ? "0" + dt.Month.ToString() : dt.Month.ToString()) + dt.Year) + i.ToString().Substring(i.ToString().IndexOf(dt.Year.ToString()) + 4)) + 1;
            }
            else
                i = Convert.ToInt32(Program.CompanyID + (dt.Day.ToString().Length == 1 ? "0" + dt.Day.ToString() : dt.Day.ToString()) + (dt.Month.ToString().Length == 1 ? "0" + dt.Month.ToString() : dt.Month.ToString()) + dt.Year + 1);
            dr.Close();
            Dcmd.Dispose();  
            CloseConnection();
            return i;
        }

        public void setAccess(DataGridView grd)
        {
            byte i = 1;
            string s;
            string ct = getRecord("Select CType from Tbl_Company where Company_ID=" + Program.CompanyID);
            if (ct == "0")
                ct = "1";
            else
                ct = "0";
            OpenConnection();
            Dcmd = new OleDbCommand("Select * from Tbl_Forms where CType <>" + ct,DCon);
            OleDbDataReader dr = Dcmd.ExecuteReader();
            while(dr.Read())
            {
                grd.Rows.Add(1);   
                s = dr["Form_Name"].ToString();
                grd.Rows[i].Cells["Form_ID"].Value =dr["Form_ID"].ToString();
                grd.Rows[i].Cells["Form_Name"].Value =dr["Form_Name"].ToString(); 
                grd.Rows[i].Cells["Display_Name"].Value =dr["Display_Name"].ToString();
                i++;
            }
            dr.Close();
            Dcmd.Dispose();
            grd.Rows.RemoveAt(0); 
            CloseConnection(); 
        }
        public void saveAccess(int userID, DataGridView grd)
        {
            for (int i = 0; i < grd.Rows.Count - 1; i++)
                SUD("INSERT INTO Tbl_Access(User_ID,Form_ID,A_Save,A_Update,A_Delete,A_Print,Company_ID) values(" + userID + "," + grd.Rows[i].Cells["Form_ID"].Value.ToString() + "," + grd.Rows[i].Cells["A_Save"].Value.ToString() + "," + grd.Rows[i].Cells["A_Update"].Value.ToString() + "," + grd.Rows[i].Cells["A_Delete"].Value.ToString() + "," + grd.Rows[i].Cells["A_Print"].Value.ToString() + "," + Program.CompanyID);
        }
        public void getAccess(out byte s, out byte u, out byte d, out byte p, int formID)
        {
            s = u = d = p = 0;
            DataTable dt = ExecuteTable("Select * from Tbl_Access where User_ID=" + Program.userID + " and Company_ID=" + Program.CompanyID + " and Form_ID=" + formID.ToString(),"Tbl_Forms");
            if (dt.Rows.Count == 0) return;
            s = Convert.ToByte(dt.Rows[0]["A_Save"].ToString());
            u = Convert.ToByte(dt.Rows[0]["A_Update"].ToString());
            d = Convert.ToByte(dt.Rows[0]["A_Delete"].ToString());
            p = Convert.ToByte(dt.Rows[0]["A_Print"].ToString());
            //OpenConnection();
            //Dcmd = new OleDbCommand("Select * from Tbl_Access where User_ID=" + Program.userID + " and Company_ID=" + Program.CompanyID + " and Form_ID=" + formID.ToString());
            //OleDbDataReader dr = Dcmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    //s=
            //}
            //CloseConnection(); 
        }
    }
}
