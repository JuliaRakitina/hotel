using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Resto.Plugin.Hotel
{
    public partial class AddRoomStatus : Form
    {
        private HotelPluginHousekeepingStatuses _parent;
        private String _mode;
        private String id;
        public event EventHandler<EventArgs> RowAdded;
        public AddRoomStatus(HotelPluginHousekeepingStatuses parent)
        {
            InitializeComponent();
            this.CancelButton = btnCancel;
            _parent = parent;
            _mode = "edit";
            txtCode.Text = _parent.grvHousekeepigStatuses.GetFocusedDataRow()["code"].ToString();
            txtName.Text = _parent.grvHousekeepigStatuses.GetFocusedDataRow()["status_name"].ToString();
            txtDesc.Text = _parent.grvHousekeepigStatuses.GetFocusedDataRow()["description"].ToString();
            id = _parent.grvHousekeepigStatuses.GetFocusedDataRow()["id"].ToString();
            bool isDeleted = Int32.Parse(_parent.grvHousekeepigStatuses.GetFocusedDataRow()["deleted"].ToString())==1 ? true : false;
            chbDeleted.Checked = isDeleted;

        }
        public AddRoomStatus()
        {
            InitializeComponent();
            this.CancelButton = btnCancel;
            _mode = "add";
        }

        private void txtCode_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidRequired(txtCode.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtCode.Select(0, txtCode.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(txtCode, errorMsg);
            }
        }

        public bool ValidRequired(string emailAddress, out string errorMessage)
        {
            // Confirm that the field string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "field is required.";
                return false;
            }
            else {
                errorMessage = "";
                return true;
            }
        }

        private void txtCode_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(txtCode, "");
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidRequired(txtName.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtName.Select(0, txtName.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider2.SetError(txtName, errorMsg);
            }
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider2.SetError(txtName, "");
        }

        private void btnSavenClose_Click(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(Properties.Settings.Default.RestoConnectionString))
            {
                cn.Open();
                try
                {
                    if (_mode=="add") {
                        var q = "INSERT INTO HotelHouseKeepingStatuses(code,status_name,description,deleted) values(@code,@status_name,@description,@deleted)";
                        var cmd = new SqlCommand(q, cn);
                        cmd.Parameters.AddWithValue("@code", txtCode.Text);
                        cmd.Parameters.AddWithValue("@status_name", txtName.Text);
                        cmd.Parameters.AddWithValue("@description", txtDesc.Text);
                        var isDeleted = chbDeleted.Checked ? 1 : 0;
                        cmd.Parameters.AddWithValue("@deleted", isDeleted);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        OnRowAddedEvent();
                    }
                    if (_mode == "edit") {
                        var q = "UPDATE HotelHouseKeepingStatuses SET code=@code ,status_name=@status_name,description=@description,deleted=@deleted WHERE id=@id";
                        var cmd = new SqlCommand(q, cn);
                        cmd.Parameters.AddWithValue("@code", txtCode.Text);
                        cmd.Parameters.AddWithValue("@status_name", txtName.Text);
                        cmd.Parameters.AddWithValue("@description", txtDesc.Text);
                        cmd.Parameters.AddWithValue("@id", this.id);
                        var isDeleted = chbDeleted.Checked ? 1 : 0;
                        cmd.Parameters.AddWithValue("@deleted", isDeleted);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        _parent.refreshData();
                    }
                    this.Close();
                }
                catch (SqlException err)
                {
                    Console.WriteLine(err.ToString());
                    return;
                }
            }

        }

        private void OnRowAddedEvent()
        {
            var listener = RowAdded;
            if (listener != null)
                listener(this, EventArgs.Empty);
        }
    }
}
