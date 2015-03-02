namespace IPSettingsTool
{
    partial class Form1
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
            this.grpNIC = new System.Windows.Forms.GroupBox();
            this.txtDNS = new System.Windows.Forms.TextBox();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.txtSubnet = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblDNS = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblSubnet = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNIC = new System.Windows.Forms.ComboBox();
            this.btnSET = new System.Windows.Forms.Button();
            this.btnCIDR = new System.Windows.Forms.Button();
            this.grpNIC.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNIC
            // 
            this.grpNIC.Controls.Add(this.txtDNS);
            this.grpNIC.Controls.Add(this.txtGateway);
            this.grpNIC.Controls.Add(this.txtSubnet);
            this.grpNIC.Controls.Add(this.txtIP);
            this.grpNIC.Controls.Add(this.lblDNS);
            this.grpNIC.Controls.Add(this.lblGateway);
            this.grpNIC.Controls.Add(this.lblSubnet);
            this.grpNIC.Controls.Add(this.lblIP);
            this.grpNIC.Controls.Add(this.label1);
            this.grpNIC.Controls.Add(this.cboNIC);
            this.grpNIC.Enabled = false;
            this.grpNIC.Location = new System.Drawing.Point(85, 34);
            this.grpNIC.Name = "grpNIC";
            this.grpNIC.Size = new System.Drawing.Size(496, 168);
            this.grpNIC.TabIndex = 4;
            this.grpNIC.TabStop = false;
            this.grpNIC.Text = "IPv4 Configuration";
            // 
            // txtDNS
            // 
            this.txtDNS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNS.Location = new System.Drawing.Point(64, 136);
            this.txtDNS.Name = "txtDNS";
            this.txtDNS.Size = new System.Drawing.Size(424, 20);
            this.txtDNS.TabIndex = 13;
            // 
            // txtGateway
            // 
            this.txtGateway.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGateway.Location = new System.Drawing.Point(64, 112);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(424, 20);
            this.txtGateway.TabIndex = 11;
            // 
            // txtSubnet
            // 
            this.txtSubnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubnet.Location = new System.Drawing.Point(64, 88);
            this.txtSubnet.Name = "txtSubnet";
            this.txtSubnet.Size = new System.Drawing.Size(424, 20);
            this.txtSubnet.TabIndex = 9;
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Location = new System.Drawing.Point(64, 64);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(424, 20);
            this.txtIP.TabIndex = 7;
            // 
            // lblDNS
            // 
            this.lblDNS.AutoSize = true;
            this.lblDNS.Location = new System.Drawing.Point(8, 136);
            this.lblDNS.Name = "lblDNS";
            this.lblDNS.Size = new System.Drawing.Size(33, 13);
            this.lblDNS.TabIndex = 12;
            this.lblDNS.Text = "DNS:";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Location = new System.Drawing.Point(8, 112);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(52, 13);
            this.lblGateway.TabIndex = 10;
            this.lblGateway.Text = "Gateway:";
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.Location = new System.Drawing.Point(8, 88);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(44, 13);
            this.lblSubnet.TabIndex = 8;
            this.lblSubnet.Text = "Subnet:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(8, 64);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 13);
            this.lblIP.TabIndex = 6;
            this.lblIP.Text = "IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NIC:";
            // 
            // cboNIC
            // 
            this.cboNIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNIC.Location = new System.Drawing.Point(64, 16);
            this.cboNIC.Name = "cboNIC";
            this.cboNIC.Size = new System.Drawing.Size(424, 21);
            this.cboNIC.TabIndex = 5;
            this.cboNIC.SelectedIndexChanged += new System.EventHandler(this.cboNIC_SelectedIndexChanged);
            // 
            // btnSET
            // 
            this.btnSET.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSET.Location = new System.Drawing.Point(149, 225);
            this.btnSET.Name = "btnSET";
            this.btnSET.Size = new System.Drawing.Size(147, 50);
            this.btnSET.TabIndex = 5;
            this.btnSET.Text = "Set new IPv4 NIC configuration";
            this.btnSET.UseVisualStyleBackColor = true;
            this.btnSET.Click += new System.EventHandler(this.btnSET_Click);
            // 
            // btnCIDR
            // 
            this.btnCIDR.Location = new System.Drawing.Point(587, 122);
            this.btnCIDR.Name = "btnCIDR";
            this.btnCIDR.Size = new System.Drawing.Size(75, 23);
            this.btnCIDR.TabIndex = 7;
            this.btnCIDR.Text = "CIDR";
            this.btnCIDR.UseVisualStyleBackColor = true;
            this.btnCIDR.Click += new System.EventHandler(this.btnCIDR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 287);
            this.Controls.Add(this.btnCIDR);
            this.Controls.Add(this.btnSET);
            this.Controls.Add(this.grpNIC);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(679, 326);
            this.MinimumSize = new System.Drawing.Size(679, 326);
            this.Name = "Form1";
            this.Text = "IPv4 NIC Settings Tool";
            this.grpNIC.ResumeLayout(false);
            this.grpNIC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNIC;
        private System.Windows.Forms.TextBox txtDNS;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.TextBox txtSubnet;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblDNS;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNIC;
        private System.Windows.Forms.Button btnSET;
        private System.Windows.Forms.Button btnCIDR;


    }
}

