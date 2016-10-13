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
            this.lblTest = new System.Windows.Forms.Label();
            this.txtNightCount = new System.Windows.Forms.TextBox();
            this.lblAdults = new System.Windows.Forms.Label();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lblRooms = new System.Windows.Forms.Label();
            this.cmbRooms = new System.Windows.Forms.ComboBox();
            this.cmbAdults = new System.Windows.Forms.ComboBox();
            this.cmbChildren = new System.Windows.Forms.ComboBox();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.clmChoose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaxCapacityAdults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaxCapacityChildren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPriceChild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBook = new System.Windows.Forms.Button();
            this.cmbRoomTypes = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.pnlGusetInfo.SuspendLayout();
            this.grpbxGuestInfo.SuspendLayout();
            this.grpRateInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGusetInfo
            // 
            this.pnlGusetInfo.Controls.Add(this.grpbxGuestInfo);
            this.pnlGusetInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGusetInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlGusetInfo.Name = "pnlGusetInfo";
            this.pnlGusetInfo.Size = new System.Drawing.Size(1698, 246);
            this.pnlGusetInfo.TabIndex = 0;
            // 
            // grpbxGuestInfo
            // 
            this.grpbxGuestInfo.Controls.Add(this.txtIdNumber);
            this.grpbxGuestInfo.Controls.Add(this.lblTest);
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
            this.grpbxGuestInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbxGuestInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbxGuestInfo.Name = "grpbxGuestInfo";
            this.grpbxGuestInfo.Size = new System.Drawing.Size(1698, 238);
            this.grpbxGuestInfo.TabIndex = 0;
            this.grpbxGuestInfo.TabStop = false;
            this.grpbxGuestInfo.Text = "Guest Information";
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(920, 113);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(540, 31);
            this.txtIdNumber.TabIndex = 11;
            // 
            // cmbIdType
            // 
            this.cmbIdType.FormattingEnabled = true;
            this.cmbIdType.Items.AddRange(new object[] {
            "Passport",
            "International Passport",
            "Driver License"});
            this.cmbIdType.Location = new System.Drawing.Point(920, 54);
            this.cmbIdType.Name = "cmbIdType";
            this.cmbIdType.Size = new System.Drawing.Size(540, 33);
            this.cmbIdType.TabIndex = 10;
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new System.Drawing.Point(791, 116);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(110, 25);
            this.lblIdNumber.TabIndex = 9;
            this.lblIdNumber.Text = "Id Number";
            // 
            // lblIdType
            // 
            this.lblIdType.AutoSize = true;
            this.lblIdType.Location = new System.Drawing.Point(791, 62);
            this.lblIdType.Name = "lblIdType";
            this.lblIdType.Size = new System.Drawing.Size(83, 25);
            this.lblIdType.TabIndex = 8;
            this.lblIdType.Text = "Id Type";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(173, 174);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(540, 33);
            this.cmbCountry.TabIndex = 5;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(33, 183);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(87, 25);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Country";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(920, 174);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(540, 31);
            this.txtAddress.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(780, 174);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(91, 25);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
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
            this.lblLastName.Location = new System.Drawing.Point(33, 116);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(115, 25);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(173, 113);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(540, 31);
            this.txtSurname.TabIndex = 3;
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(33, 56);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(116, 25);
            this.lblGuestName.TabIndex = 1;
            this.lblGuestName.Text = "First Name";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(300, 56);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(413, 31);
            this.txtGuestName.TabIndex = 2;
            // 
            // grpRateInfo
            // 
            this.grpRateInfo.Controls.Add(this.lblRoomType);
            this.grpRateInfo.Controls.Add(this.cmbRoomTypes);
            this.grpRateInfo.Controls.Add(this.cmbChildren);
            this.grpRateInfo.Controls.Add(this.cmbAdults);
            this.grpRateInfo.Controls.Add(this.cmbRooms);
            this.grpRateInfo.Controls.Add(this.lblRooms);
            this.grpRateInfo.Controls.Add(this.lblChildren);
            this.grpRateInfo.Controls.Add(this.lblAdults);
            this.grpRateInfo.Controls.Add(this.txtNightCount);
            this.grpRateInfo.Controls.Add(this.lblNigthStay);
            this.grpRateInfo.Controls.Add(this.dtpCheckOut);
            this.grpRateInfo.Controls.Add(this.dtpCheckIn);
            this.grpRateInfo.Controls.Add(this.lblCheckout);
            this.grpRateInfo.Controls.Add(this.lblCheckIn);
            this.grpRateInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRateInfo.Location = new System.Drawing.Point(0, 246);
            this.grpRateInfo.Name = "grpRateInfo";
            this.grpRateInfo.Size = new System.Drawing.Size(1698, 214);
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
            this.lblCheckout.Location = new System.Drawing.Point(791, 42);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(109, 25);
            this.lblCheckout.TabIndex = 1;
            this.lblCheckout.Text = "Check out";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(173, 42);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(540, 31);
            this.dtpCheckIn.TabIndex = 2;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(920, 42);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(540, 31);
            this.dtpCheckOut.TabIndex = 3;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // lblNigthStay
            // 
            this.lblNigthStay.AutoSize = true;
            this.lblNigthStay.Location = new System.Drawing.Point(33, 104);
            this.lblNigthStay.Name = "lblNigthStay";
            this.lblNigthStay.Size = new System.Drawing.Size(125, 25);
            this.lblNigthStay.TabIndex = 4;
            this.lblNigthStay.Text = "Nigth Count";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(1539, 54);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(70, 25);
            this.lblTest.TabIndex = 6;
            this.lblTest.Text = "label1";
            // 
            // txtNightCount
            // 
            this.txtNightCount.Location = new System.Drawing.Point(173, 104);
            this.txtNightCount.MaxLength = 4;
            this.txtNightCount.Name = "txtNightCount";
            this.txtNightCount.Size = new System.Drawing.Size(88, 31);
            this.txtNightCount.TabIndex = 7;
            this.txtNightCount.Text = "1";
            this.txtNightCount.TextChanged += new System.EventHandler(this.txtNightCount_TextChanged);
            this.txtNightCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNightCount_KeyPress);
            this.txtNightCount.Leave += new System.EventHandler(this.txtNightCount_Leave);
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Location = new System.Drawing.Point(1073, 149);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(72, 25);
            this.lblAdults.TabIndex = 8;
            this.lblAdults.Text = "Adults";
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Location = new System.Drawing.Point(1269, 149);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(92, 25);
            this.lblChildren.TabIndex = 9;
            this.lblChildren.Text = "Children";
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(797, 149);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(79, 25);
            this.lblRooms.TabIndex = 10;
            this.lblRooms.Text = "Rooms";
            // 
            // cmbRooms
            // 
            this.cmbRooms.FormattingEnabled = true;
            this.cmbRooms.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbRooms.Location = new System.Drawing.Point(922, 145);
            this.cmbRooms.Name = "cmbRooms";
            this.cmbRooms.Size = new System.Drawing.Size(95, 33);
            this.cmbRooms.TabIndex = 11;
            this.cmbRooms.Text = "1";
            // 
            // cmbAdults
            // 
            this.cmbAdults.FormattingEnabled = true;
            this.cmbAdults.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbAdults.Location = new System.Drawing.Point(1151, 145);
            this.cmbAdults.Name = "cmbAdults";
            this.cmbAdults.Size = new System.Drawing.Size(95, 33);
            this.cmbAdults.TabIndex = 12;
            this.cmbAdults.Text = "1";
            // 
            // cmbChildren
            // 
            this.cmbChildren.FormattingEnabled = true;
            this.cmbChildren.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbChildren.Location = new System.Drawing.Point(1367, 145);
            this.cmbChildren.Name = "cmbChildren";
            this.cmbChildren.Size = new System.Drawing.Size(95, 33);
            this.cmbChildren.TabIndex = 13;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmChoose,
            this.clmRoomType,
            this.clmAvailability,
            this.clmMaxCapacityAdults,
            this.clmMaxCapacityChildren,
            this.clmPrice,
            this.clmPriceChild});
            this.dgvRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRooms.Location = new System.Drawing.Point(0, 460);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowTemplate.Height = 33;
            this.dgvRooms.Size = new System.Drawing.Size(1698, 318);
            this.dgvRooms.TabIndex = 2;
            // 
            // clmChoose
            // 
            this.clmChoose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmChoose.HeaderText = "";
            this.clmChoose.Name = "clmChoose";
            this.clmChoose.ReadOnly = true;
            this.clmChoose.Width = 50;
            // 
            // clmRoomType
            // 
            this.clmRoomType.HeaderText = "Room Type";
            this.clmRoomType.Name = "clmRoomType";
            this.clmRoomType.ReadOnly = true;
            // 
            // clmAvailability
            // 
            this.clmAvailability.HeaderText = "Availability";
            this.clmAvailability.Name = "clmAvailability";
            this.clmAvailability.ReadOnly = true;
            // 
            // clmMaxCapacityAdults
            // 
            this.clmMaxCapacityAdults.HeaderText = "Max Capacity Adults";
            this.clmMaxCapacityAdults.Name = "clmMaxCapacityAdults";
            this.clmMaxCapacityAdults.ReadOnly = true;
            // 
            // clmMaxCapacityChildren
            // 
            this.clmMaxCapacityChildren.HeaderText = "Max Capacity Children";
            this.clmMaxCapacityChildren.Name = "clmMaxCapacityChildren";
            this.clmMaxCapacityChildren.ReadOnly = true;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Price per Adult per nigth";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            // 
            // clmPriceChild
            // 
            this.clmPriceChild.HeaderText = "Price per child per night";
            this.clmPriceChild.Name = "clmPriceChild";
            this.clmPriceChild.ReadOnly = true;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(1384, 891);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(276, 62);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // cmbRoomTypes
            // 
            this.cmbRoomTypes.FormattingEnabled = true;
            this.cmbRoomTypes.Location = new System.Drawing.Point(173, 159);
            this.cmbRoomTypes.Name = "cmbRoomTypes";
            this.cmbRoomTypes.Size = new System.Drawing.Size(540, 33);
            this.cmbRoomTypes.TabIndex = 14;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(36, 159);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(122, 25);
            this.lblRoomType.TabIndex = 15;
            this.lblRoomType.Text = "Room Type";
            // 
            // wndNewRsrv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1698, 961);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.dgvRooms);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
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
        private System.Windows.Forms.Label lblNigthStay;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox txtNightCount;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.ComboBox cmbRooms;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.ComboBox cmbChildren;
        private System.Windows.Forms.ComboBox cmbAdults;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvailability;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaxCapacityAdults;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaxCapacityChildren;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPriceChild;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbRoomTypes;
    }
}