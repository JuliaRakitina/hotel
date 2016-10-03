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
            var myUser = RestApiClient.CurrentSessionAuthData.Login;
            this.lblTest.Text = myUser;
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
            //if (e.RowIndex < 0)
            //    return;

            ////I supposed your button column is at index 0
            //if (e.ColumnIndex == 0)
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            //    var w = Properties.Resources.SomeImage.Width;
            //    var h = Properties.Resources.SomeImage.Height;
            //    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            //    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

            //    e.Graphics.DrawImage(Properties.Resources.SomeImage, new Rectangle(x, y, w, h));
            //    e.Handled = true;
            //}
        }
    }
}
