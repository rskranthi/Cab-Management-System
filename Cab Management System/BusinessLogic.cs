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
    class BusinessLogic
    {
        public static void FillVehicleTypes(System.Windows.Forms.ComboBox cmb)
        {
            cmb.Items.Add("Economy");
            cmb.Items.Add("Standard");
            cmb.Items.Add("Luxury");
            cmb.Items.Add("SUV");
                        
        }
        

        public static void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar))
                return;
            else
                e.Handled = true;
        }
        public static void NumbersWithDecimals(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt.Text.Trim().IndexOf(".", 0) >= 0)
                e.Handled = true;
            if (char.IsNumber(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.')
                return;
            else
                e.Handled = true;
        }
    }
}
