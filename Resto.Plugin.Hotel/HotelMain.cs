using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Resto.BackApi.Core.RestApi;

namespace Resto.Plugin.Hotel
{
    internal partial class HotelMain : UserControl
    {
        public HotelMain()
        {
            InitializeComponent();
            getCurrentUserName();
        }

        /// <summary>
        /// Контроллер.
        /// </summary>
        public HotelPluginController Controller { get; set; }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            wndNewRsrv frm = new wndNewRsrv();
            frm.Show();
        }

        private void getCurrentUserName()
        {
            var myUser = RestApiClient.CurrentSessionAuthData.Login;
            this.stsStrpLbl1.Text = this.stsStrpLbl1.Text + myUser;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtvMain_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)//this is Info button
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = 16;
                var h = 16;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                Image img = (Bitmap)(Properties.Resources.ResourceManager.GetObject("info_24x24"));
                e.Graphics.DrawImage(img, new Rectangle(x, y, w, h));
                e.Handled = true;
            }


            if (e.ColumnIndex==1)//this is Edit button
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = 16;
                var h = 16;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                Image img = (Bitmap)(Properties.Resources.ResourceManager.GetObject("edit_24x24"));
                e.Graphics.DrawImage(img, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 2)//this is Cancel button
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = 16;
                var h = 16;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                Image img = (Bitmap)(Properties.Resources.ResourceManager.GetObject("cancel_24x24"));
                e.Graphics.DrawImage(img, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

        }
    }
}
