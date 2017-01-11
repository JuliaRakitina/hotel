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
            this.btnAddFloor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmbFloorCount)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(18, 36);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(120, 25);
            this.lblFloor.TabIndex = 0;
            this.lblFloor.Text = "Floor count";
            // 
            // nmbFloorCount
            // 
            this.nmbFloorCount.Location = new System.Drawing.Point(183, 34);
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
            this.nmbFloorCount.Size = new System.Drawing.Size(120, 31);
            this.nmbFloorCount.TabIndex = 1;
            this.nmbFloorCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbFloorCount.ValueChanged += new System.EventHandler(this.nmbFloorCount_ValueChanged);
            // 
            // btnAddFloor
            // 
            this.btnAddFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFloor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddFloor.Location = new System.Drawing.Point(958, 0);
            this.btnAddFloor.Name = "btnAddFloor";
            this.btnAddFloor.Size = new System.Drawing.Size(156, 100);
            this.btnAddFloor.TabIndex = 6;
            this.btnAddFloor.Text = "Add prorety";
            this.btnAddFloor.UseVisualStyleBackColor = true;
            this.btnAddFloor.Click += new System.EventHandler(this.btnAddFloor_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(958, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 94);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblFloor);
            this.pnlTop.Controls.Add(this.nmbFloorCount);
            this.pnlTop.Controls.Add(this.btnAddFloor);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1114, 100);
            this.pnlTop.TabIndex = 9;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 714);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1114, 94);
            this.pnlBottom.TabIndex = 10;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 100);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1114, 614);
            this.pnlMain.TabIndex = 11;
            // 
            // HotelStructureMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "HotelStructureMain";
            this.Size = new System.Drawing.Size(1114, 808);
            ((System.ComponentModel.ISupportInitialize)(this.nmbFloorCount)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.NumericUpDown nmbFloorCount;
        private System.Windows.Forms.Button btnAddFloor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlMain;
    }
}
