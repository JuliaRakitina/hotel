namespace Resto.Plugin.Hotel
{
    partial class HotelPluginAgeGroups
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
            this.grvCtrlAgeGroups = new DevExpress.XtraGrid.GridControl();
            this.grvAgeGroups = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.restoDataSet1 = new Resto.Plugin.Hotel.RestoDataSet();
            this.hotelAgeGroupsTableAdapter1 = new Resto.Plugin.Hotel.RestoDataSetTableAdapters.HotelAgeGroupsTableAdapter();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCtrlAgeGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAgeGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDataSet1)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1540, 134);
            this.tableLayoutPanel1.TabIndex = 1;
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
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(83, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 29);
            this.txtSearch.TabIndex = 1;
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
            // 
            // ddbView
            // 
            this.ddbView.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.ddbView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddbView.Location = new System.Drawing.Point(1047, 72);
            this.ddbView.Margin = new System.Windows.Forms.Padding(5);
            this.ddbView.Name = "ddbView";
            this.ddbView.Size = new System.Drawing.Size(179, 57);
            this.ddbView.TabIndex = 5;
            this.ddbView.Text = "Вид";
            // 
            // grvCtrlAgeGroups
            // 
            this.grvCtrlAgeGroups.DataMember = "HotelAgeGroups";
            this.grvCtrlAgeGroups.DataSource = this.restoDataSet1;
            this.grvCtrlAgeGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvCtrlAgeGroups.Location = new System.Drawing.Point(0, 134);
            this.grvCtrlAgeGroups.MainView = this.grvAgeGroups;
            this.grvCtrlAgeGroups.Name = "grvCtrlAgeGroups";
            this.grvCtrlAgeGroups.Size = new System.Drawing.Size(1540, 512);
            this.grvCtrlAgeGroups.TabIndex = 2;
            this.grvCtrlAgeGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvAgeGroups});
            // 
            // grvAgeGroups
            // 
            this.grvAgeGroups.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfrom,
            this.colto,
            this.colcode,
            this.colname});
            this.grvAgeGroups.GridControl = this.grvCtrlAgeGroups;
            this.grvAgeGroups.Name = "grvAgeGroups";
            // 
            // restoDataSet1
            // 
            this.restoDataSet1.DataSetName = "RestoDataSet";
            this.restoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelAgeGroupsTableAdapter1
            // 
            this.hotelAgeGroupsTableAdapter1.ClearBeforeFill = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colfrom
            // 
            this.colfrom.Caption = "C";
            this.colfrom.FieldName = "from";
            this.colfrom.Name = "colfrom";
            this.colfrom.Visible = true;
            this.colfrom.VisibleIndex = 0;
            // 
            // colto
            // 
            this.colto.Caption = "По";
            this.colto.FieldName = "to";
            this.colto.Name = "colto";
            this.colto.Visible = true;
            this.colto.VisibleIndex = 1;
            // 
            // colcode
            // 
            this.colcode.Caption = "Код";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 2;
            // 
            // colname
            // 
            this.colname.Caption = "Название";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 3;
            // 
            // HotelPluginAgeGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grvCtrlAgeGroups);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HotelPluginAgeGroups";
            this.Size = new System.Drawing.Size(1540, 646);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCtrlAgeGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAgeGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.Button btnSearchForward;
        private System.Windows.Forms.Button btnSearchBack;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private DevExpress.XtraEditors.DropDownButton ddbView;
        private DevExpress.XtraGrid.GridControl grvCtrlAgeGroups;
        private DevExpress.XtraGrid.Views.Grid.GridView grvAgeGroups;
        private RestoDataSet restoDataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfrom;
        private DevExpress.XtraGrid.Columns.GridColumn colto;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private RestoDataSetTableAdapters.HotelAgeGroupsTableAdapter hotelAgeGroupsTableAdapter1;
    }
}
