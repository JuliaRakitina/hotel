using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Resto.BackApi.Core.BackgroundTask;
using Resto.BackApi.Core.BackgroundTask.Extensions;
using Resto.BackApi.Core.RestApi;
using System.Data.SqlClient;
using System.Configuration;

namespace Resto.Plugin.Hotel
{
    public partial class HotelStructureMain : UserControl
    {

        private List<NewFloor> newFloorUserControllers;
        private NewFloor newFloorUserController;

        public HotelStructureMain()
        {
            InitializeComponent();
            OnLoadData();
        }
        
        /// <summary>
        /// Загружает данные для плагина.
        /// </summary>
        public void OnLoadData()
        {
            using (var cn = new SqlConnection(Properties.Settings.Default.RestoConnectionString))
            {
                cn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT floor_count FROM HotelProperties", cn);
                    Int32 floorsCount = (Int32)cmd.ExecuteScalar();
                    nmbFloorCount.Value = floorsCount;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return;
                }
            }
        }


        private void btnAddFloor_Click(object sender, EventArgs e)
        {
            newFloorUserController = new NewFloor();
            using (RestoEntities c = new RestoEntities())
            {
                newFloorUserController.FillRoomTypeCombo(c.HotelRoomType.ToList());
            }

            List<Int32> l = new List<int>();
            for (Int32 i = (Int32)nmbFloorCount.Value; i >= 1; i--)
            {
                l.Add(i);
            }
            if (pnlMain.Controls.OfType<NewFloor>().Count() > 0)
            {
                foreach (var nf in pnlMain.Controls.OfType<NewFloor>())
                {
                    l.RemoveAll(x => x == nf.Floor);
                }
            }
          
            newFloorUserController.Name = "new";
            newFloorUserController.Dock = DockStyle.Top;
            pnlMain.Controls.Add(newFloorUserController);
            newFloorUserController.FillFloorCombo(l);
            //  newFloorUserControllers.Add(newFloorUserController);

        }

        private void nmbFloorCount_ValueChanged(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(Properties.Settings.Default.RestoConnectionString))
            {
                cn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE HotelProperties SET floor_count = @count", cn);
                    cmd.Parameters.AddWithValue("@count", nmbFloorCount.Value);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                catch (SqlException err)
                {
                    Console.WriteLine(err.ToString());
                    return;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}
