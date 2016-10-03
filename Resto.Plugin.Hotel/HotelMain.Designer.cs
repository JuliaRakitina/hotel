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
            this.hotelMainPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsStrpLbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTest = new System.Windows.Forms.Label();
            this.cmbRoomStatuses = new System.Windows.Forms.ComboBox();
            this.hotelRoomStatusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoDataSet = new Resto.Plugin.Hotel.RestoDataSet();
            this.btnCreate = new System.Windows.Forms.Button();
            this.hotelRoomStatusesTableAdapter = new Resto.Plugin.Hotel.RestoDataSetTableAdapters.HotelRoomStatusesTableAdapter();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rsrv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.info = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMain)).BeginInit();
            this.hotelMainPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomStatusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvMain
            // 
            this.dtvMain.AllowUserToOrderColumns = true;
            this.dtvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rsrv_id,
            this.guestId,
            this.date_from,
            this.date_to,
            this.room_type,
            this.room_number,
            this.status,
            this.edit,
            this.info,
            this.cancel});
            this.dtvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtvMain.Location = new System.Drawing.Point(0, 118);
            this.dtvMain.Name = "dtvMain";
            this.dtvMain.RowTemplate.Height = 31;
            this.dtvMain.Size = new System.Drawing.Size(1606, 816);
            this.dtvMain.TabIndex = 0;
            this.dtvMain.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtvMain_CellPainting);
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
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(681, 40);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(47, 25);
            this.lblTest.TabIndex = 4;
            this.lblTest.Text = "test";
            // 
            // cmbRoomStatuses
            // 
            this.cmbRoomStatuses.DataSource = this.hotelRoomStatusesBindingSource;
            this.cmbRoomStatuses.DisplayMember = "room_status";
            this.cmbRoomStatuses.FormattingEnabled = true;
            this.cmbRoomStatuses.Location = new System.Drawing.Point(1081, 53);
            this.cmbRoomStatuses.Name = "cmbRoomStatuses";
            this.cmbRoomStatuses.Size = new System.Drawing.Size(275, 33);
            this.cmbRoomStatuses.TabIndex = 3;
            this.cmbRoomStatuses.ValueMember = "room_status_id";
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
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(107, 32);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(341, 41);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTest);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.cmbRoomStatuses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1606, 118);
            this.panel1.TabIndex = 6;
            // 
            // rsrv_id
            // 
            this.rsrv_id.HeaderText = "Reservation";
            this.rsrv_id.Name = "rsrv_id";
            // 
            // guestId
            // 
            this.guestId.HeaderText = "Guest";
            this.guestId.Name = "guestId";
            // 
            // date_from
            // 
            this.date_from.HeaderText = "From";
            this.date_from.Name = "date_from";
            // 
            // date_to
            // 
            this.date_to.HeaderText = "To";
            this.date_to.Name = "date_to";
            // 
            // room_type
            // 
            this.room_type.HeaderText = "Room Type";
            this.room_type.Name = "room_type";
            // 
            // room_number
            // 
            this.room_number.HeaderText = "Room";
            this.room_number.Name = "room_number";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // edit
            // 
            this.edit.HeaderText = "Edit";
            this.edit.Name = "edit";
            // 
            // info
            // 
            this.info.HeaderText = "Info";
            this.info.Name = "info";
            // 
            // cancel
            // 
            this.cancel.HeaderText = "Cancel";
            this.cancel.Name = "cancel";
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomStatusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvMain;
        private System.Windows.Forms.Panel hotelMainPanel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbRoomStatuses;
        private System.Windows.Forms.BindingSource hotelRoomStatusesBindingSource;
        private RestoDataSet restoDataSet;
        private RestoDataSetTableAdapters.HotelRoomStatusesTableAdapter hotelRoomStatusesTableAdapter;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsStrpLbl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rsrv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn info;
        private System.Windows.Forms.DataGridViewButtonColumn cancel;
    }
}
