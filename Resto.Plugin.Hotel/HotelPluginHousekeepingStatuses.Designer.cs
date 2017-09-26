namespace Resto.Plugin.Hotel
{
    partial class HotelPluginHousekeepingStatuses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.btnSearchForward = new System.Windows.Forms.Button();
            this.btnSearchBack = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ddbView = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grCntrlHousekeepingStatuses = new DevExpress.XtraGrid.GridControl();
            this.hotelHouseKeepingStatusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoDataSet = new Resto.Plugin.Hotel.RestoDataSet();
            this.grvHousekeepigStatuses = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.hotelHouseKeepingStatusesTableAdapter = new Resto.Plugin.Hotel.RestoDataSetTableAdapters.HotelHouseKeepingStatusesTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTools.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCntrlHousekeepingStatuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelHouseKeepingStatusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHousekeepigStatuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.tableLayoutPanel1);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(1516, 134);
            this.pnlTools.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pnlSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.ddbView, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1516, 134);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearchClear);
            this.pnlSearch.Controls.Add(this.btnSearchForward);
            this.pnlSearch.Controls.Add(this.btnSearchBack);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(434, 61);
            this.pnlSearch.TabIndex = 0;
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchClear.FlatAppearance.BorderSize = 0;
            this.btnSearchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClear.Image = global::Resto.Plugin.Hotel.Properties.Resources.cross_20;
            this.btnSearchClear.Location = new System.Drawing.Point(393, 14);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(30, 30);
            this.btnSearchClear.TabIndex = 4;
            this.btnSearchClear.UseVisualStyleBackColor = false;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // btnSearchForward
            // 
            this.btnSearchForward.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchForward.FlatAppearance.BorderSize = 0;
            this.btnSearchForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchForward.Image = global::Resto.Plugin.Hotel.Properties.Resources.arrow_right_20;
            this.btnSearchForward.Location = new System.Drawing.Point(353, 15);
            this.btnSearchForward.Name = "btnSearchForward";
            this.btnSearchForward.Size = new System.Drawing.Size(30, 30);
            this.btnSearchForward.TabIndex = 3;
            this.btnSearchForward.UseVisualStyleBackColor = false;
            this.btnSearchForward.Click += new System.EventHandler(this.btnSearchForward_Click);
            // 
            // btnSearchBack
            // 
            this.btnSearchBack.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchBack.FlatAppearance.BorderSize = 0;
            this.btnSearchBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBack.Image = global::Resto.Plugin.Hotel.Properties.Resources.arrow_left_20;
            this.btnSearchBack.Location = new System.Drawing.Point(313, 15);
            this.btnSearchBack.Name = "btnSearchBack";
            this.btnSearchBack.Size = new System.Drawing.Size(30, 30);
            this.btnSearchBack.TabIndex = 2;
            this.btnSearchBack.UseVisualStyleBackColor = false;
            this.btnSearchBack.Click += new System.EventHandler(this.btnSearchBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(83, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 29);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск";
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(445, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 57);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(630, 5);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(222, 57);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редактировать...";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(862, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 57);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(1047, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(179, 57);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ddbView
            // 
            this.ddbView.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.ddbView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddbView.DropDownControl = this.popupMenu1;
            this.ddbView.Location = new System.Drawing.Point(1047, 72);
            this.ddbView.Margin = new System.Windows.Forms.Padding(5);
            this.ddbView.Name = "ddbView";
            this.ddbView.Size = new System.Drawing.Size(179, 57);
            this.ddbView.TabIndex = 5;
            this.ddbView.Text = "Вид";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem1)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "Показывать удаленные";
            this.barCheckItem1.Id = 0;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barCheckItem1});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1516, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 894);
            this.barDockControlBottom.Size = new System.Drawing.Size(1516, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 894);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1516, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 894);
            // 
            // grCntrlHousekeepingStatuses
            // 
            this.grCntrlHousekeepingStatuses.DataSource = this.hotelHouseKeepingStatusesBindingSource;
            this.grCntrlHousekeepingStatuses.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.grCntrlHousekeepingStatuses.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grCntrlHousekeepingStatuses.Location = new System.Drawing.Point(0, 0);
            this.grCntrlHousekeepingStatuses.MainView = this.grvHousekeepigStatuses;
            this.grCntrlHousekeepingStatuses.Margin = new System.Windows.Forms.Padding(5);
            this.grCntrlHousekeepingStatuses.Name = "grCntrlHousekeepingStatuses";
            this.grCntrlHousekeepingStatuses.Size = new System.Drawing.Size(1516, 760);
            this.grCntrlHousekeepingStatuses.TabIndex = 1;
            this.grCntrlHousekeepingStatuses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvHousekeepigStatuses});
            // 
            // hotelHouseKeepingStatusesBindingSource
            // 
            this.hotelHouseKeepingStatusesBindingSource.DataMember = "HotelHouseKeepingStatuses";
            this.hotelHouseKeepingStatusesBindingSource.DataSource = this.restoDataSet;
            // 
            // restoDataSet
            // 
            this.restoDataSet.DataSetName = "RestoDataSet";
            this.restoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grvHousekeepigStatuses
            // 
            this.grvHousekeepigStatuses.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcode,
            this.colName,
            this.coldescription,
            this.coldeleted});
            this.grvHousekeepigStatuses.GridControl = this.grCntrlHousekeepingStatuses;
            this.grvHousekeepigStatuses.Name = "grvHousekeepigStatuses";
            this.grvHousekeepigStatuses.OptionsSelection.MultiSelect = true;
            this.grvHousekeepigStatuses.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.grvHousekeepigStatuses_CustomColumnDisplayText);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.AllowShowHide = false;
            // 
            // colcode
            // 
            this.colcode.Caption = "Код";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.AllowEdit = false;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Название";
            this.colName.FieldName = "status_name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Описание";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.OptionsColumn.AllowEdit = false;
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 2;
            // 
            // coldeleted
            // 
            this.coldeleted.Caption = "Удалено";
            this.coldeleted.FieldName = "deleted";
            this.coldeleted.Name = "coldeleted";
            this.coldeleted.OptionsColumn.AllowEdit = false;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.grCntrlHousekeepingStatuses;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 134);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.grCntrlHousekeepingStatuses);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1516, 760);
            this.gridSplitContainer1.TabIndex = 1;
            // 
            // hotelHouseKeepingStatusesTableAdapter
            // 
            this.hotelHouseKeepingStatusesTableAdapter.ClearBeforeFill = true;
            // 
            // HotelPluginHousekeepingStatuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "HotelPluginHousekeepingStatuses";
            this.Size = new System.Drawing.Size(1516, 894);
            this.pnlTools.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCntrlHousekeepingStatuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelHouseKeepingStatusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHousekeepigStatuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTools;
        private DevExpress.XtraGrid.GridControl grCntrlHousekeepingStatuses;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private System.Windows.Forms.BindingSource hotelHouseKeepingStatusesBindingSource;
        private RestoDataSet restoDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private RestoDataSetTableAdapters.HotelHouseKeepingStatusesTableAdapter hotelHouseKeepingStatusesTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchBack;
        private System.Windows.Forms.Button btnSearchForward;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        protected internal DevExpress.XtraGrid.Views.Grid.GridView grvHousekeepigStatuses;
        private DevExpress.XtraEditors.DropDownButton ddbView;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn coldeleted;
    }
}
