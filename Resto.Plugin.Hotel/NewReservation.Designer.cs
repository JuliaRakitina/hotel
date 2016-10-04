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
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbPrefix = new System.Windows.Forms.ComboBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.pnlGusetInfo.SuspendLayout();
            this.grpbxGuestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGusetInfo
            // 
            this.pnlGusetInfo.Controls.Add(this.grpbxGuestInfo);
            this.pnlGusetInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGusetInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlGusetInfo.Name = "pnlGusetInfo";
            this.pnlGusetInfo.Size = new System.Drawing.Size(1380, 310);
            this.pnlGusetInfo.TabIndex = 0;
            // 
            // grpbxGuestInfo
            // 
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
            this.grpbxGuestInfo.Size = new System.Drawing.Size(1380, 310);
            this.grpbxGuestInfo.TabIndex = 0;
            this.grpbxGuestInfo.TabStop = false;
            this.grpbxGuestInfo.Text = "Guest Information";
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
            this.lblCountry.Location = new System.Drawing.Point(40, 226);
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
            this.lblAddress.Location = new System.Drawing.Point(35, 170);
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
            this.lblLastName.Location = new System.Drawing.Point(35, 116);
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
            this.lblGuestName.Location = new System.Drawing.Point(35, 56);
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
            // wndNewRsrv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 963);
            this.Controls.Add(this.pnlGusetInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wndNewRsrv";
            this.Text = "New Reservation";
            this.pnlGusetInfo.ResumeLayout(false);
            this.grpbxGuestInfo.ResumeLayout(false);
            this.grpbxGuestInfo.PerformLayout();
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
    }
}