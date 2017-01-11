namespace Resto.Plugin.Hotel
{
    partial class NewFloor
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpBoxFloor = new System.Windows.Forms.GroupBox();
            this.cmbFloorDynamic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            this.grpBoxFloor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grpBoxFloor);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1048, 206);
            this.pnlMain.TabIndex = 0;
            // 
            // grpBoxFloor
            // 
            this.grpBoxFloor.AutoSize = true;
            this.grpBoxFloor.Controls.Add(this.cmbFloorDynamic);
            this.grpBoxFloor.Controls.Add(this.label1);
            this.grpBoxFloor.Controls.Add(this.textBox1);
            this.grpBoxFloor.Controls.Add(this.cmbRoomType);
            this.grpBoxFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxFloor.Location = new System.Drawing.Point(0, 0);
            this.grpBoxFloor.Name = "grpBoxFloor";
            this.grpBoxFloor.Size = new System.Drawing.Size(1048, 206);
            this.grpBoxFloor.TabIndex = 6;
            this.grpBoxFloor.TabStop = false;
            this.grpBoxFloor.Text = "Room Definition";
            // 
            // cmbFloorDynamic
            // 
            this.cmbFloorDynamic.FormattingEnabled = true;
            this.cmbFloorDynamic.Location = new System.Drawing.Point(6, 53);
            this.cmbFloorDynamic.Name = "cmbFloorDynamic";
            this.cmbFloorDynamic.Size = new System.Drawing.Size(121, 33);
            this.cmbFloorDynamic.TabIndex = 6;
            this.cmbFloorDynamic.SelectedIndexChanged += new System.EventHandler(this.cmbFloorDynamic_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "You can enter room numbers :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(476, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(526, 31);
            this.textBox1.TabIndex = 4;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(156, 53);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(285, 33);
            this.cmbRoomType.TabIndex = 2;
            // 
            // NewFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "NewFloor";
            this.Size = new System.Drawing.Size(1048, 206);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.grpBoxFloor.ResumeLayout(false);
            this.grpBoxFloor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpBoxFloor;
        private System.Windows.Forms.ComboBox cmbFloorDynamic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbRoomType;
    }
}
