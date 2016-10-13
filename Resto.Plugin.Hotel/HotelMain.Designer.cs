namespace Resto.Plugin.Hotel
{
    partial class HotelMain
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtvMain = new System.Windows.Forms.DataGridView();
            this.info_reservation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editReservation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cancel_reservation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rsrv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelMainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hotelRoomStatusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoDataSet = new Resto.Plugin.Hotel.RestoDataSet();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsStrpLbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.hotelRoomStatusesTableAdapter = new Resto.Plugin.Hotel.RestoDataSetTableAdapters.HotelRoomStatusesTableAdapter();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTimeFilter = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMain)).BeginInit();
            this.hotelMainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomStatusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvMain
            // 
            this.dtvMain.AllowUserToOrderColumns = true;
            this.dtvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.info_reservation,
            this.editReservation,
            this.cancel_reservation,
            this.rsrv_id,
            this.guestId,
            this.date_from,
            this.date_to,
            this.room_type,
            this.room_number,
            this.status});
            this.dtvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtvMain.Location = new System.Drawing.Point(0, 118);
            this.dtvMain.Name = "dtvMain";
            this.dtvMain.RowTemplate.Height = 31;
            this.dtvMain.Size = new System.Drawing.Size(1606, 816);
            this.dtvMain.TabIndex = 0;
            this.dtvMain.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtvMain_CellPainting);
            // 
            // info_reservation
            // 
            this.info_reservation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.info_reservation.FillWeight = 99.20385F;
            this.info_reservation.HeaderText = "";
            this.info_reservation.Name = "info_reservation";
            this.info_reservation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.info_reservation.Width = 40;
            // 
            // editReservation
            // 
            this.editReservation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editReservation.FillWeight = 101.7849F;
            this.editReservation.HeaderText = "";
            this.editReservation.Name = "editReservation";
            this.editReservation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editReservation.Width = 40;
            // 
            // cancel_reservation
            // 
            this.cancel_reservation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cancel_reservation.FillWeight = 99.07878F;
            this.cancel_reservation.HeaderText = "";
            this.cancel_reservation.Name = "cancel_reservation";
            this.cancel_reservation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cancel_reservation.Width = 40;
            // 
            // rsrv_id
            // 
            this.rsrv_id.FillWeight = 99.99036F;
            this.rsrv_id.HeaderText = "Reservation";
            this.rsrv_id.Name = "rsrv_id";
            // 
            // guestId
            // 
            this.guestId.FillWeight = 99.99036F;
            this.guestId.HeaderText = "Guest";
            this.guestId.Name = "guestId";
            // 
            // date_from
            // 
            this.date_from.FillWeight = 99.99036F;
            this.date_from.HeaderText = "From";
            this.date_from.Name = "date_from";
            // 
            // date_to
            // 
            this.date_to.FillWeight = 99.99036F;
            this.date_to.HeaderText = "To";
            this.date_to.Name = "date_to";
            // 
            // room_type
            // 
            this.room_type.FillWeight = 99.99036F;
            this.room_type.HeaderText = "Room Type";
            this.room_type.Name = "room_type";
            // 
            // room_number
            // 
            this.room_number.FillWeight = 99.99036F;
            this.room_number.HeaderText = "Room";
            this.room_number.Name = "room_number";
            // 
            // status
            // 
            this.status.FillWeight = 99.99036F;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // hotelMainPanel
            // 
            this.hotelMainPanel.Controls.Add(this.dtvMain);
            this.hotelMainPanel.Controls.Add(this.panel1);
            this.hotelMainPanel.Controls.Add(this.statusStrip1);
            this.hotelMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotelMainPanel.Location = new System.Drawing.Point(0, 0);
            this.hotelMainPanel.Name = "hotelMainPanel";
            this.hotelMainPanel.Size = new System.Drawing.Size(1606, 971);
            this.hotelMainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblTimeFilter);
            this.panel1.Controls.Add(this.btnClearSearch);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1606, 118);
            this.panel1.TabIndex = 6;
            // 
            // hotelRoomStatusesBindingSource
            // 
            this.hotelRoomStatusesBindingSource.DataMember = "HotelRoomStatuses";
            this.hotelRoomStatusesBindingSource.DataSource = this.restoDataSet;
            // 
            // restoDataSet
            // 
            this.restoDataSet.DataSetName = "RestoDataSet";
            this.restoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsStrpLbl1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 934);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1606, 37);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "stsStrp";
            // 
            // stsStrpLbl1
            // 
            this.stsStrpLbl1.Name = "stsStrpLbl1";
            this.stsStrpLbl1.Size = new System.Drawing.Size(159, 32);
            this.stsStrpLbl1.Text = "Current user: ";
            // 
            // hotelRoomStatusesTableAdapter
            // 
            this.hotelRoomStatusesTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(402, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(238, 31);
            this.txtSearch.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(316, 21);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(80, 25);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search";
            // 
            // lblTimeFilter
            // 
            this.lblTimeFilter.AutoSize = true;
            this.lblTimeFilter.Location = new System.Drawing.Point(281, 64);
            this.lblTimeFilter.Name = "lblTimeFilter";
            this.lblTimeFilter.Size = new System.Drawing.Size(115, 25);
            this.lblTimeFilter.TabIndex = 8;
            this.lblTimeFilter.Text = "Time Span";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Open Period",
            "Today",
            "Current week",
            "Current month",
            "Current year",
            "Yesterday",
            "Last week",
            "Last month",
            "Last year",
            "Other..."});
            this.comboBox1.Location = new System.Drawing.Point(403, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 33);
            this.comboBox1.TabIndex = 9;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(740, 64);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 31);
            this.dtpFrom.TabIndex = 10;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(1020, 64);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 31);
            this.dtpTo.TabIndex = 11;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(661, 67);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(54, 25);
            this.lblFrom.TabIndex = 12;
            this.lblFrom.Text = "from";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(965, 67);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(30, 25);
            this.lblTo.TabIndex = 13;
            this.lblTo.Text = "to";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackgroundImage = global::Resto.Plugin.Hotel.Properties.Resources.repeat32x32;
            this.btnClearSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearSearch.FlatAppearance.BorderSize = 0;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.Location = new System.Drawing.Point(748, 11);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(32, 32);
            this.btnClearSearch.TabIndex = 7;
            this.btnClearSearch.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::Resto.Plugin.Hotel.Properties.Resources.fast_forward32x32;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(707, 11);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 32);
            this.btnNext.TabIndex = 6;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImage = global::Resto.Plugin.Hotel.Properties.Resources.rewind32x32;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(666, 11);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(32, 32);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Image = global::Resto.Plugin.Hotel.Properties.Resources.plus_32x32;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(17, 15);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(249, 87);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "New Reservation";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // HotelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hotelMainPanel);
            this.Name = "HotelMain";
            this.Size = new System.Drawing.Size(1606, 971);
            ((System.ComponentModel.ISupportInitialize)(this.dtvMain)).EndInit();
            this.hotelMainPanel.ResumeLayout(false);
            this.hotelMainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomStatusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvMain;
        private System.Windows.Forms.Panel hotelMainPanel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.BindingSource hotelRoomStatusesBindingSource;
        private RestoDataSet restoDataSet;
        private RestoDataSetTableAdapters.HotelRoomStatusesTableAdapter hotelRoomStatusesTableAdapter;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsStrpLbl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewButtonColumn info_reservation;
        private System.Windows.Forms.DataGridViewButtonColumn editReservation;
        private System.Windows.Forms.DataGridViewButtonColumn cancel_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn rsrv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTimeFilter;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
    }
}
