using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace Resto.Plugin.Hotel
{
    public partial class HotelPluginHousekeepingStatuses : UserControl
    {
        public HotelPluginHousekeepingStatuses()
        {
            InitializeComponent();
            if (barCheckItem1.Checked == false)
            {
                hotelHouseKeepingStatusesTableAdapter.FillByDel(restoDataSet.HotelHouseKeepingStatuses);
            }
            else
            {
                hotelHouseKeepingStatusesTableAdapter.Fill(restoDataSet.HotelHouseKeepingStatuses);
            }
            toolTip1.SetToolTip(btnSearchBack, "Предыдущий эелемент");
            toolTip2.SetToolTip(btnSearchForward, "Следующий эелемент");
            toolTip3.SetToolTip(btnSearchClear, "Очистить");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRoomStatus frm = new AddRoomStatus();
            // Define the border style of the form to a dialog box.
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the MaximizeBox to false to remove the maximize box.
            frm.MaximizeBox = false;

            // Set the MinimizeBox to false to remove the minimize box.
            frm.MinimizeBox = false;

            // Set the start position of the form to the center of the screen.
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.RowAdded += new EventHandler<EventArgs>(frm_RowAdded);

            // Display the form as a modal dialog box.
            frm.ShowDialog();
        }

        void frm_RowAdded(object sender, EventArgs e)
        {
            if (barCheckItem1.Checked == false)
            {
                hotelHouseKeepingStatusesTableAdapter.FillByDel(restoDataSet.HotelHouseKeepingStatuses);
            }
            else
            {
                hotelHouseKeepingStatusesTableAdapter.Fill(restoDataSet.HotelHouseKeepingStatuses);
            }
            grCntrlHousekeepingStatuses.Update();
            grCntrlHousekeepingStatuses.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (barCheckItem1.Checked == false)
            {
                hotelHouseKeepingStatusesTableAdapter.FillByDel(restoDataSet.HotelHouseKeepingStatuses);
            }
            else
            {
                hotelHouseKeepingStatusesTableAdapter.Fill(restoDataSet.HotelHouseKeepingStatuses);
            }
            grCntrlHousekeepingStatuses.Update();
            grCntrlHousekeepingStatuses.Refresh();
        }

        public void refreshData()
        {
            if (barCheckItem1.Checked == false)
            {
                hotelHouseKeepingStatusesTableAdapter.FillByDel(restoDataSet.HotelHouseKeepingStatuses);
            }
            else
            {
                hotelHouseKeepingStatusesTableAdapter.Fill(restoDataSet.HotelHouseKeepingStatuses);
            }
            grCntrlHousekeepingStatuses.Update();
            grCntrlHousekeepingStatuses.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddRoomStatus frm = new AddRoomStatus(this);
            // Define the border style of the form to a dialog box.
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the MaximizeBox to false to remove the maximize box.
            frm.MaximizeBox = false;

            // Set the MinimizeBox to false to remove the minimize box.
            frm.MinimizeBox = false;

            // Set the start position of the form to the center of the screen.
            frm.StartPosition = FormStartPosition.CenterScreen;
            
            // Display the form as a modal dialog box.
            frm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ((GridView)grCntrlHousekeepingStatuses.MainView).ActiveFilterString = "[code] like '%"+txtSearch.Text+ "%' OR [status_name] like '%" + txtSearch.Text + "%' OR [description] like '%" + txtSearch.Text + "%'";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var sel_count = ((GridView)grCntrlHousekeepingStatuses.MainView).SelectedRowsCount;
            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить выбранные данные ("+ sel_count + ")?",
                                      "Подтвердите удаление",
                                      MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Create an empty list.
                ArrayList rows = new ArrayList();
                for (int i = 0; i < sel_count; i++)
                {
                    if (((GridView)grCntrlHousekeepingStatuses.MainView).GetSelectedRows()[i] >= 0)
                        rows.Add(((GridView)grCntrlHousekeepingStatuses.MainView).GetDataRow(((GridView)grCntrlHousekeepingStatuses.MainView).GetSelectedRows()[i]));
                }

                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow r = rows[i] as DataRow;
                    using (var cn = new SqlConnection(Properties.Settings.Default.RestoConnectionString))
                    {
                        cn.Open();
                        try
                        {
                            var q = "UPDATE HotelHouseKeepingStatuses SET deleted=1 WHERE id=@id";
                            var cmd = new SqlCommand(q, cn);
                            cmd.Parameters.AddWithValue("@id", r["id"]);
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
                refreshData();
            }
        }

        private void grvHousekeepigStatuses_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "deleted") {
                if (Convert.ToDecimal(e.Value) == 0) e.DisplayText = "Нет";
                if (Convert.ToDecimal(e.Value) == 1) e.DisplayText = "Да";
            }
                
        }

        private void btnSearchForward_Click(object sender, EventArgs e)
        {
            (grCntrlHousekeepingStatuses.FocusedView as ColumnView).FocusedRowHandle++;
        }

        private void btnSearchBack_Click(object sender, EventArgs e)
        {
            (grCntrlHousekeepingStatuses.FocusedView as ColumnView).FocusedRowHandle--;
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          GridColumn column = ((GridView)grCntrlHousekeepingStatuses.MainView).Columns["deleted"];
            if (barCheckItem1.Checked == false)
            {
                hotelHouseKeepingStatusesTableAdapter.FillByDel(restoDataSet.HotelHouseKeepingStatuses);
                column.Visible = false;
            }
            else {
                hotelHouseKeepingStatusesTableAdapter.Fill(restoDataSet.HotelHouseKeepingStatuses);
                column.Visible = true;
            }
            grCntrlHousekeepingStatuses.Update();
            grCntrlHousekeepingStatuses.Refresh();
        }
    }
}
