using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Resto.Plugin.Hotel
{
    public partial class wndNewRsrv : Form
    {
        public wndNewRsrv()
        {
            InitializeComponent();
            FillDropDownList("Select id,sortname,name from HotelCountries", cmbCountry, "id", "Name");
        }

        public static void FillDropDownList(string Query, System.Windows.Forms.ComboBox cmb, String val, String disp)
        {

            using (var cn = new SqlConnection(Properties.Settings.Default.RestoConnectionString))
            {
                cn.Open();
                DataTable dt = new DataTable();
                try
                {
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    SqlDataReader myReader = cmd.ExecuteReader();
                    dt.Load(myReader);

                    cmb.DataSource = dt;
                    cmb.ValueMember = val;
                    cmb.DisplayMember = disp;
                    cmb.SelectedItem = null;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return;
                }
            }


        }
    }
}
