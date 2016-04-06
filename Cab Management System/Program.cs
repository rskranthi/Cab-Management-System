using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;   

namespace CabMan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static frmMain f;
        public static int CompanyID, userID=0;
        public static string CName="";
        public static bool isAdmin = false;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());
            //CompanyID = 1;
            f = new frmMain(); 
            Application.Run(f);
        }

        public static void enableMenus(string cName, string uName, bool isAdmin,byte cType)
        {
            disableMenus(); // Make all menus as disabled  

            DataBase db = new DataBase();

            f.lblCName.Text = cName;
            f.lblUserName.Text = uName;
            f.mnuLogin.Enabled = false;
            f.mnuCompany.Enabled = false;
            f.mnuLogout.Enabled = true;

            
            if (cType == 0)   // Rental ....
            {
                if (isAdmin)
                    RentalAdmin(true);
                else
                {
                    db.OpenConnection(); 
                    db.Dcmd = new OleDbCommand ("Select * from Tbl_Access where Company_ID=" + Program.CompanyID + " and User_ID=" + Program.userID  + " and (A_Save=1 or A_Update=1 or A_Delete=1 or A_Print=1)",db.DCon);
                    OleDbDataReader dr = db.Dcmd.ExecuteReader();
                    while (dr.Read())
                    {
                        switch (Convert.ToInt32(dr["Form_ID"].ToString()))
                        {
                            case 1:
                            {
                                f.mnuBooking.Visible = true;
                                f.mnuTransactions.Visible = true;  
                                break; 
                            }
                            case 2:
                            {
                                f.mnuDriverDetails.Visible = true;
                                f.mnuDrivers.Visible = true;
                                break;
                            }
                            case 3:
                            {
                                f.mnuFares.Visible = true;
                                f.mnuMaster.Visible = true;
                                break;
                            }
                            case 4:
                            {
                                f.mnuInvoice.Visible = true;
                                f.mnuTransactions.Visible = true;
                                break;
                            }
                            case 5:
                            {
                                f.mnuJobs.Visible = true;
                                f.mnuTransactions.Visible = true;
                                break;
                            }
                            case 6:
                            {
                                f.mnuLocations.Visible = true;
                                f.mnuTransactions.Visible = true;
                                break;
                            }
                            case 7:
                            {
                                f.mnuMapAndDirections.Visible = true;
                                f.mnuTransactions.Visible = true;
                                break;
                            }
                            case 8:
                            {
                                f.mnuMapLocations.Visible = true;
                                f.mnuMaster.Visible = true;
                                break;
                            }
                            case 9:
                            {
                                f.mnuSettings.Visible = true;
                                break;
                            }
                            case 10:
                            {
                                f.mnuUsers.Visible = true;
                                f.mnuAdministration.Visible = true;
                                break;
                            }
                            case 11:
                            {
                                f.mnuVehicleTypes.Visible = true;
                                f.mnuMaster.Visible = true;
                                break;
                            }
                            case 12:
                            {
                                f.mnuVehicleDetails.Visible = true;
                                f.mnuMaster.Visible = true;
                                break;
                            }
                            case 13:
                            {
                                f.mnuAccess.Visible = true;
                                f.mnuAdministration.Visible = true;
                                break;
                            }
                            case 14:
                            {
                                f.mnuProjects.Visible = true;
                                f.mnuMaster.Visible = true;
                                break;
                            }
                        }
                    }
                    dr.Close();
                    db.Dcmd.Dispose();   
                    db.CloseConnection(); 
                }

            }
            else // Shuttle ......
            {
                if (isAdmin)
                    ShuttleAdmin(true);
                {

                }
            }
        }
        public static void disableMenus()
        {
            f.lblCName.Text = "";
            f.lblUserName.Text = "";
            f.mnuLogin.Enabled = true;
            f.mnuCompany.Enabled = true ;
            f.mnuLogout.Enabled = false;

            RentalAdmin(false);
            ShuttleAdmin(false);  
        }
        private static void RentalAdmin(bool flag)
        {
            f.mnuMaster.Visible = flag;
            f.mnuMapLocations.Visible = flag;
            f.mnuLocations.Visible = flag;
            f.mnuVehicleTypes.Visible = flag;
            f.mnuVehicleDetails.Visible = flag;
            f.mnuFares.Visible = flag;

            f.mnuTransactions.Visible = flag;
            f.mnuBooking.Visible = flag;
            f.mnuJobs.Visible = flag;
            f.mnuInvoice.Visible = flag;
            f.mnuMapAndDirections.Visible = flag;

            f.mnuDrivers.Visible = flag;
            f.mnuDriverDetails.Visible = flag;
            f.mnuDutyRooster.Visible = flag;

            f.mnuAdministration.Visible = flag;
            f.mnuUsers.Visible = flag;
            f.mnuAccess.Visible = flag;

            f.mnuSettings.Visible = flag;
            
            f.mnuReports.Visible = flag;
            f.mnuReportFares.Visible = flag;
            f.mnuReportLocations.Visible = flag;
            f.mnuReportVehicleTypes.Visible = flag;
            f.mnuReportVehicleDetails.Visible = flag; 
        }
        
        private static void ShuttleAdmin(bool flag)
        {
            f.mnuMaster.Visible = flag;
            f.mnuProjects.Visible = flag;
            f.mnuEmployees.Visible = flag;  
            f.mnuMapLocations.Visible = flag;
            f.mnuLocations.Visible = flag;
            f.mnuVehicleTypes.Visible = flag;
            f.mnuVehicleDetails.Visible = flag;

            f.mnuTransactions.Visible = flag;
            f.mnuShuttleBookings.Visible = flag;  
            f.mnuMapAndDirections.Visible = flag;

            f.mnuDrivers.Visible = flag;
            f.mnuDriverDetails.Visible = flag;
            f.mnuDutyRooster.Visible = flag;

            f.mnuAdministration.Visible = flag;
            f.mnuUsers.Visible = flag;
            f.mnuAccess.Visible = flag;

            f.mnuSettings.Visible = flag;
            f.mnuReports.Visible = flag;
            
            f.mnuReportLocations.Visible = flag;
            f.mnuReportVehicleTypes.Visible = flag;
            f.mnuReportVehicleDetails.Visible = flag; 
        }
    }
}
