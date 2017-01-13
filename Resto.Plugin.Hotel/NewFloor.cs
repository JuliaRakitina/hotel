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

        public void onLoad()
        {
            Floor = 0;
        }

        public void FillFloorCombo(List<Int32> ds)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            cmbFloorDynamic.DataSource = bs;
            cmbFloorDynamic.SelectedItem = null;
        }

        private void cmbFloorDynamic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFloorDynamic.SelectedItem != null)
            {
                Floor = (Int32)cmbFloorDynamic.SelectedItem;
            }

        }

        public void FillRoomTypeCombo(List<HotelRoomType> rt)
        {
            cmbRoomType.DataSource = rt;
            cmbRoomType.ValueMember = "id";
            cmbRoomType.DisplayMember = "name";
            cmbRoomType.SelectedItem = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }



        private void txtPattern_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i;
            if (int.TryParse(e.KeyChar.ToString(), out i))
            {
                txtPattern.ForeColor = Color.Black;
            }
            else {
                if (e.KeyChar.ToString() != "," && e.KeyChar.ToString() != "-" && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
