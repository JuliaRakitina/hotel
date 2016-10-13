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

        private double nightCount = 1;

        public wndNewRsrv()
        {
            InitializeComponent();
            FillDropDownList("Select id,sortname,name from HotelCountries", cmbCountry, "id", "Name");
            dtpCheckOut.Value = dtpCheckIn.Value.Date.AddDays(1);
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


        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            nightCount = Convert.ToDouble(txtNightCount.Text);
            if (nightCount == 0)
            {
                dtpCheckOut.Value = dtpCheckIn.Value.Date.AddDays(1);
                txtNightCount.Text = "1";
            }
            else {
                dtpCheckOut.Value = dtpCheckIn.Value.Date.AddDays(nightCount);
            }
            
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            nightCount = Convert.ToDouble(txtNightCount.Text);
            if (nightCount == 0)
            {
                dtpCheckIn.Value = dtpCheckOut.Value.Date.AddDays(-1);
                txtNightCount.Text = "1";
            }
            else {
              //  dtpCheckIn.Value = dtpCheckOut.Value.Date.AddDays(Convert.ToDouble(-nightCount));
                nightCount = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).TotalDays;
                txtNightCount.Text = nightCount.ToString();
            }

        }

        private void txtNightCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtNightCount_TextChanged(object sender, EventArgs e)
        {
            if (txtNightCount.Text.Length > 0)
            {
                nightCount = Convert.ToDouble(txtNightCount.Text);
                if (nightCount == 0)
                {
                    dtpCheckOut.Value = dtpCheckIn.Value.Date.AddDays(1);
                    txtNightCount.Text = "1";
                }
                else {
                    dtpCheckOut.Value = dtpCheckIn.Value.Date.AddDays(nightCount);
                }
            }

        }

        private void txtNightCount_Leave(object sender, EventArgs e)
        {
            if (txtNightCount.Text.Length == 0)
            {
                nightCount = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).TotalDays;
                txtNightCount.Text = nightCount.ToString();
            }
        }
    }
}
