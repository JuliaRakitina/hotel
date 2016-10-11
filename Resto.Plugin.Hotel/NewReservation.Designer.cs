namespace Resto.Plugin.Hotel
{
    partial class wndNewRsrv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wndNewRsrv));
            this.pnlGusetInfo = new System.Windows.Forms.Panel();
            this.grpbxGuestInfo = new System.Windows.Forms.GroupBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.cmbIdType = new System.Windows.Forms.ComboBox();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.lblIdType = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbPrefix = new System.Windows.Forms.ComboBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.grpRateInfo = new System.Windows.Forms.GroupBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblNigthStay = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pnlGusetInfo.SuspendLayout();
            this.grpbxGuestInfo.SuspendLayout();
            this.grpRateInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGusetInfo
            // 
            this.pnlGusetInfo.Controls.Add(this.grpbxGuestInfo);
            this.pnlGusetInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGusetInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlGusetInfo.Name = "pnlGusetInfo";
            this.pnlGusetInfo.Size = new System.Drawing.Size(1310, 310);
            this.pnlGusetInfo.TabIndex = 0;
            // 
            // grpbxGuestInfo
            // 
            this.grpbxGuestInfo.Controls.Add(this.txtIdNumber);
            this.grpbxGuestInfo.Controls.Add(this.cmbIdType);
            this.grpbxGuestInfo.Controls.Add(this.lblIdNumber);
            this.grpbxGuestInfo.Controls.Add(this.lblIdType);
            this.grpbxGuestInfo.Controls.Add(this.cmbCountry);
            this.grpbxGuestInfo.Controls.Add(this.lblCountry);
            this.grpbxGuestInfo.Controls.Add(this.txtAddress);
            this.grpbxGuestInfo.Controls.Add(this.lblAddress);
            this.grpbxGuestInfo.Controls.Add(this.cmbPrefix);
            this.grpbxGuestInfo.Controls.Add(this.lblLastName);
            this.grpbxGuestInfo.Controls.Add(this.txtSurname);
            this.grpbxGuestInfo.Controls.Add(this.lblGuestName);
            this.grpbxGuestInfo.Controls.Add(this.txtGuestName);
            this.grpbxGuestInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxGuestInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbxGuestInfo.Name = "grpbxGuestInfo";
            this.grpbxGuestInfo.Size = new System.Drawing.Size(1310, 310);
            this.grpbxGuestInfo.TabIndex = 0;
            this.grpbxGuestInfo.TabStop = false;
            this.grpbxGuestInfo.Text = "Guest Information";
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(758, 113);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(336, 31);
            this.txtIdNumber.TabIndex = 11;
            // 
            // cmbIdType
            // 
            this.cmbIdType.FormattingEnabled = true;
            this.cmbIdType.Items.AddRange(new object[] {
            "Passport",
            "International Passport",
            "Driver License"});
            this.cmbIdType.Location = new System.Drawing.Point(758, 56);
            this.cmbIdType.Name = "cmbIdType";
            this.cmbIdType.Size = new System.Drawing.Size(336, 33);
            this.cmbIdType.TabIndex = 10;
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new System.Drawing.Point(613, 113);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(110, 25);
            this.lblIdNumber.TabIndex = 9;
            this.lblIdNumber.Text = "Id Number";
            // 
            // lblIdType
            // 
            this.lblIdType.AutoSize = true;
            this.lblIdType.Location = new System.Drawing.Point(613, 56);
            this.lblIdType.Name = "lblIdType";
            this.lblIdType.Size = new System.Drawing.Size(83, 25);
            this.lblIdType.TabIndex = 8;
            this.lblIdType.Text = "Id Type";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(173, 217);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(331, 33);
            this.cmbCountry.TabIndex = 5;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(17, 226);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(87, 25);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Country";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(173, 170);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(331, 31);
            this.txtAddress.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 170);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(97, 25);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            // 
            // cmbPrefix
            // 
            this.cmbPrefix.FormattingEnabled = true;
            this.cmbPrefix.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss",
            "Dr."});
            this.cmbPrefix.Location = new System.Drawing.Point(173, 56);
            this.cmbPrefix.Name = "cmbPrefix";
            this.cmbPrefix.Size = new System.Drawing.Size(121, 33);
            this.cmbPrefix.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 116);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(127, 25);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name: ";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(173, 113);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(331, 31);
            this.txtSurname.TabIndex = 3;
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(12, 56);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(128, 25);
            this.lblGuestName.TabIndex = 1;
            this.lblGuestName.Text = "First Name: ";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(300, 56);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(204, 31);
            this.txtGuestName.TabIndex = 2;
            // 
            // grpRateInfo
            // 
            this.grpRateInfo.Controls.Add(this.numericUpDown1);
            this.grpRateInfo.Controls.Add(this.lblNigthStay);
            this.grpRateInfo.Controls.Add(this.dtpCheckOut);
            this.grpRateInfo.Controls.Add(this.dtpCheckIn);
            this.grpRateInfo.Controls.Add(this.lblCheckout);
            this.grpRateInfo.Controls.Add(this.lblCheckIn);
            this.grpRateInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRateInfo.Location = new System.Drawing.Point(0, 310);
            this.grpRateInfo.Name = "grpRateInfo";
            this.grpRateInfo.Size = new System.Drawing.Size(1310, 336);
            this.grpRateInfo.TabIndex = 1;
            this.grpRateInfo.TabStop = false;
            this.grpRateInfo.Text = "Rate Information";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(33, 42);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(96, 25);
            this.lblCheckIn.TabIndex = 0;
            this.lblCheckIn.Text = "Check in";
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Location = new System.Drawing.Point(613, 42);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(109, 25);
            this.lblCheckout.TabIndex = 1;
            this.lblCheckout.Text = "Check out";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(173, 42);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(331, 31);
            this.dtpCheckIn.TabIndex = 2;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(758, 36);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(331, 31);
            this.dtpCheckOut.TabIndex = 3;
            // 
            // lblNigthStay
            // 
            this.lblNigthStay.AutoSize = true;
            this.lblNigthStay.Location = new System.Drawing.Point(33, 108);
            this.lblNigthStay.Name = "lblNigthStay";
            this.lblNigthStay.Size = new System.Drawing.Size(125, 25);
            this.lblNigthStay.TabIndex = 4;
            this.lblNigthStay.Text = "Nigth Count";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(173, 101);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(331, 31);
            this.numericUpDown1.TabIndex = 5;
            // 
            // wndNewRsrv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 909);
            this.Controls.Add(this.grpRateInfo);
            this.Controls.Add(this.pnlGusetInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wndNewRsrv";
            this.Text = "New Reservation";
            this.pnlGusetInfo.ResumeLayout(false);
            this.grpbxGuestInfo.ResumeLayout(false);
            this.grpbxGuestInfo.PerformLayout();
            this.grpRateInfo.ResumeLayout(false);
            this.grpRateInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGusetInfo;
        private System.Windows.Forms.GroupBox grpbxGuestInfo;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ComboBox cmbPrefix;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblIdType;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.ComboBox cmbIdType;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.GroupBox grpRateInfo;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblNigthStay;
    }
}