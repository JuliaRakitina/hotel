namespace Resto.Plugin.Hotel
{
    partial class HotelStructureMain
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
            this.lblFloor = new System.Windows.Forms.Label();
            this.nmbFloorCount = new System.Windows.Forms.NumericUpDown();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbRoomTypeFilter = new System.Windows.Forms.ComboBox();
            this.cmbFloorFilter = new System.Windows.Forms.ComboBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgwRooms = new System.Windows.Forms.DataGridView();
            this.cmbFloorAdd = new System.Windows.Forms.ComboBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmbFloorCount)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(3, 0);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(120, 25);
            this.lblFloor.TabIndex = 0;
            this.lblFloor.Text = "Floor count";
            // 
            // nmbFloorCount
            // 
            this.nmbFloorCount.Location = new System.Drawing.Point(153, 3);
            this.nmbFloorCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmbFloorCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbFloorCount.Name = "nmbFloorCount";
            this.nmbFloorCount.Size = new System.Drawing.Size(144, 31);
            this.nmbFloorCount.TabIndex = 1;
            this.nmbFloorCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbFloorCount.ValueChanged += new System.EventHandler(this.nmbFloorCount_ValueChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.tableLayoutPanel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1790, 172);
            this.pnlTop.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 606F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAdd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPattern, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbRoomType, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbFloorAdd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nmbFloorCount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFloor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFilter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbFloorFilter, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbRoomTypeFilter, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1442, 172);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(3, 118);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(60, 25);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter";
            // 
            // cmbRoomTypeFilter
            // 
            this.cmbRoomTypeFilter.FormattingEnabled = true;
            this.cmbRoomTypeFilter.Location = new System.Drawing.Point(303, 121);
            this.cmbRoomTypeFilter.Name = "cmbRoomTypeFilter";
            this.cmbRoomTypeFilter.Size = new System.Drawing.Size(394, 33);
            this.cmbRoomTypeFilter.TabIndex = 3;
            // 
            // cmbFloorFilter
            // 
            this.cmbFloorFilter.FormattingEnabled = true;
            this.cmbFloorFilter.Location = new System.Drawing.Point(153, 121);
            this.cmbFloorFilter.Name = "cmbFloorFilter";
            this.cmbFloorFilter.Size = new System.Drawing.Size(144, 33);
            this.cmbFloorFilter.TabIndex = 2;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(703, 121);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(600, 31);
            this.txt.TabIndex = 4;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Controls.Add(this.dgwRooms);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 172);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1790, 636);
            this.pnlMain.TabIndex = 11;
            // 
            // dgwRooms
            // 
            this.dgwRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRooms.Location = new System.Drawing.Point(109, 62);
            this.dgwRooms.Name = "dgwRooms";
            this.dgwRooms.RowTemplate.Height = 33;
            this.dgwRooms.Size = new System.Drawing.Size(876, 214);
            this.dgwRooms.TabIndex = 0;
            // 
            // cmbFloorAdd
            // 
            this.cmbFloorAdd.FormattingEnabled = true;
            this.cmbFloorAdd.Location = new System.Drawing.Point(153, 62);
            this.cmbFloorAdd.Name = "cmbFloorAdd";
            this.cmbFloorAdd.Size = new System.Drawing.Size(144, 33);
            this.cmbFloorAdd.TabIndex = 7;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(303, 62);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(394, 33);
            this.cmbRoomType.TabIndex = 3;
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(703, 62);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(594, 31);
            this.txtPattern.TabIndex = 5;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(3, 59);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(115, 25);
            this.lblAdd.TabIndex = 1;
            this.lblAdd.Text = "Add rooms";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Image = global::Resto.Plugin.Hotel.Properties.Resources.action_Cancel_16xLG;
            this.btnClear.Location = new System.Drawing.Point(1309, 62);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(30, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.TabStop = false;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Image = global::Resto.Plugin.Hotel.Properties.Resources.action_Cancel_16xLG;
            this.btnAdd.Location = new System.Drawing.Point(1377, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.TabStop = false;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // HotelStructureMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "HotelStructureMain";
            this.Size = new System.Drawing.Size(1790, 808);
            ((System.ComponentModel.ISupportInitialize)(this.nmbFloorCount)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.NumericUpDown nmbFloorCount;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbFloorFilter;
        private System.Windows.Forms.ComboBox cmbRoomTypeFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.DataGridView dgwRooms;
        private System.Windows.Forms.ComboBox cmbFloorAdd;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
    }
}
