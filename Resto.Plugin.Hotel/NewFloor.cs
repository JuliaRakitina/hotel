using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Resto.Plugin.Hotel
{
    public partial class NewFloor : UserControl
    {
        public String Name { get; set; }
        public int Floor { get; set; }
        public String RoomType { get; set; }

        public NewFloor()
        {
            InitializeComponent();
            onLoad();
        }

        public void onLoad() {
            Floor = 0;
        }

        public void FillFloorCombo(List<Int32> ds) {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            cmbFloorDynamic.DataSource = bs;
        }

        private void cmbFloorDynamic_SelectedIndexChanged(object sender, EventArgs e)
        {
            Floor = (Int32)cmbFloorDynamic.SelectedItem;
        }

        public void FillRoomTypeCombo(List<HotelRoomType> rt) {

        }
    }
}
