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
            this.cmbFloorDynamic = new System.Windows.Forms.ComboBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.tblPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDesc = new System.Windows.Forms.Panel();
            this.lblDescStatic = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tblPanel.SuspendLayout();
            this.pnlDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFloorDynamic
            // 
            this.cmbFloorDynamic.FormattingEnabled = true;
            this.cmbFloorDynamic.Location = new System.Drawing.Point(3, 3);
            this.cmbFloorDynamic.Name = "cmbFloorDynamic";
            this.cmbFloorDynamic.Size = new System.Drawing.Size(294, 33);
            this.cmbFloorDynamic.TabIndex = 6;
            this.cmbFloorDynamic.SelectedIndexChanged += new System.EventHandler(this.cmbFloorDynamic_SelectedIndexChanged);
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(703, 3);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(594, 31);
            this.txtPattern.TabIndex = 4;
            this.txtPattern.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPattern_KeyPress);
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(303, 3);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(394, 33);
            this.cmbRoomType.TabIndex = 2;
            // 
            // tblPanel
            // 
            this.tblPanel.ColumnCount = 4;
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanel.Controls.Add(this.cmbFloorDynamic, 0, 0);
            this.tblPanel.Controls.Add(this.txtPattern, 2, 0);
            this.tblPanel.Controls.Add(this.cmbRoomType, 1, 0);
            this.tblPanel.Controls.Add(this.btnDelete, 3, 0);
            this.tblPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel.Location = new System.Drawing.Point(0, 0);
            this.tblPanel.Name = "tblPanel";
            this.tblPanel.RowCount = 1;
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.Size = new System.Drawing.Size(1790, 166);
            this.tblPanel.TabIndex = 1;
            // 
            // pnlDesc
            // 
            this.pnlDesc.Controls.Add(this.lblDescStatic);
            this.pnlDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDesc.Location = new System.Drawing.Point(0, 66);
            this.pnlDesc.Name = "pnlDesc";
            this.pnlDesc.Size = new System.Drawing.Size(1790, 100);
            this.pnlDesc.TabIndex = 2;
            // 
            // lblDescStatic
            // 
            this.lblDescStatic.AutoSize = true;
            this.lblDescStatic.Location = new System.Drawing.Point(4, 16);
            this.lblDescStatic.Name = "lblDescStatic";
            this.lblDescStatic.Size = new System.Drawing.Size(302, 25);
            this.lblDescStatic.TabIndex = 0;
            this.lblDescStatic.Text = "You can enter room numbers :";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Image = global::Resto.Plugin.Hotel.Properties.Resources.action_Cancel_16xLG;
            this.btnDelete.Location = new System.Drawing.Point(1303, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.TabStop = false;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // NewFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDesc);
            this.Controls.Add(this.tblPanel);
            this.Name = "NewFloor";
            this.Size = new System.Drawing.Size(1790, 166);
            this.tblPanel.ResumeLayout(false);
            this.tblPanel.PerformLayout();
            this.pnlDesc.ResumeLayout(false);
            this.pnlDesc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFloorDynamic;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.TableLayoutPanel tblPanel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlDesc;
        private System.Windows.Forms.Label lblDescStatic;
    }
}
