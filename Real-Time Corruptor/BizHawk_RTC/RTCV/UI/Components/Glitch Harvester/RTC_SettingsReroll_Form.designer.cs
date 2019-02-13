﻿namespace RTCV.UI
{
    partial class RTC_SettingsReroll_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RTC_SettingsReroll_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRerollDomain = new System.Windows.Forms.CheckBox();
            this.cbRerollSourceDomain = new System.Windows.Forms.CheckBox();
            this.cbRerollAddress = new System.Windows.Forms.CheckBox();
            this.cbRerollSourceAddress = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbIgnoreUnitOrigin = new System.Windows.Forms.CheckBox();
            this.cbRerollFollowsCustom = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.cbRerollDomain);
            this.panel1.Controls.Add(this.cbRerollSourceDomain);
            this.panel1.Controls.Add(this.cbRerollAddress);
            this.panel1.Controls.Add(this.cbRerollSourceAddress);
            this.panel1.Location = new System.Drawing.Point(28, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 91);
            this.panel1.TabIndex = 140;
            this.panel1.Tag = "color:dark";
            // 
            // cbRerollDomain
            // 
            this.cbRerollDomain.AutoSize = true;
            this.cbRerollDomain.Enabled = false;
            this.cbRerollDomain.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbRerollDomain.ForeColor = System.Drawing.Color.White;
            this.cbRerollDomain.Location = new System.Drawing.Point(10, 64);
            this.cbRerollDomain.Name = "cbRerollDomain";
            this.cbRerollDomain.Size = new System.Drawing.Size(99, 17);
            this.cbRerollDomain.TabIndex = 3;
            this.cbRerollDomain.Text = "Reroll Domain";
            this.cbRerollDomain.UseVisualStyleBackColor = true;
            this.cbRerollDomain.CheckedChanged += new System.EventHandler(this.cbRerollDomain_CheckedChanged);
            // 
            // cbRerollSourceDomain
            // 
            this.cbRerollSourceDomain.AutoSize = true;
            this.cbRerollSourceDomain.Enabled = false;
            this.cbRerollSourceDomain.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbRerollSourceDomain.ForeColor = System.Drawing.Color.White;
            this.cbRerollSourceDomain.Location = new System.Drawing.Point(10, 24);
            this.cbRerollSourceDomain.Name = "cbRerollSourceDomain";
            this.cbRerollSourceDomain.Size = new System.Drawing.Size(137, 17);
            this.cbRerollSourceDomain.TabIndex = 2;
            this.cbRerollSourceDomain.Text = "Reroll Source Domain";
            this.cbRerollSourceDomain.UseVisualStyleBackColor = true;
            this.cbRerollSourceDomain.CheckedChanged += new System.EventHandler(this.cbRerollSourceDomain_CheckedChanged);
            // 
            // cbRerollAddress
            // 
            this.cbRerollAddress.AutoSize = true;
            this.cbRerollAddress.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbRerollAddress.ForeColor = System.Drawing.Color.White;
            this.cbRerollAddress.Location = new System.Drawing.Point(10, 48);
            this.cbRerollAddress.Name = "cbRerollAddress";
            this.cbRerollAddress.Size = new System.Drawing.Size(100, 17);
            this.cbRerollAddress.TabIndex = 1;
            this.cbRerollAddress.Text = "Reroll Address";
            this.cbRerollAddress.UseVisualStyleBackColor = true;
            this.cbRerollAddress.CheckedChanged += new System.EventHandler(this.cbRerollAddress_CheckedChanged);
            // 
            // cbRerollSourceAddress
            // 
            this.cbRerollSourceAddress.AutoSize = true;
            this.cbRerollSourceAddress.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbRerollSourceAddress.ForeColor = System.Drawing.Color.White;
            this.cbRerollSourceAddress.Location = new System.Drawing.Point(10, 8);
            this.cbRerollSourceAddress.Name = "cbRerollSourceAddress";
            this.cbRerollSourceAddress.Size = new System.Drawing.Size(138, 17);
            this.cbRerollSourceAddress.TabIndex = 0;
            this.cbRerollSourceAddress.Text = "Reroll Source Address";
            this.cbRerollSourceAddress.UseVisualStyleBackColor = true;
            this.cbRerollSourceAddress.CheckedChanged += new System.EventHandler(this.cbRerollSourceAddress_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 141;
            this.label4.Text = "Store Settings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.cbIgnoreUnitOrigin);
            this.panel2.Controls.Add(this.cbRerollFollowsCustom);
            this.panel2.Location = new System.Drawing.Point(27, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 52);
            this.panel2.TabIndex = 142;
            this.panel2.Tag = "color:dark";
            // 
            // cbIgnoreUnitOrigin
            // 
            this.cbIgnoreUnitOrigin.AutoSize = true;
            this.cbIgnoreUnitOrigin.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbIgnoreUnitOrigin.ForeColor = System.Drawing.Color.White;
            this.cbIgnoreUnitOrigin.Location = new System.Drawing.Point(11, 27);
            this.cbIgnoreUnitOrigin.Name = "cbIgnoreUnitOrigin";
            this.cbIgnoreUnitOrigin.Size = new System.Drawing.Size(154, 17);
            this.cbIgnoreUnitOrigin.TabIndex = 1;
            this.cbIgnoreUnitOrigin.Text = "Ignore Unit Origin Mode";
            this.cbIgnoreUnitOrigin.UseVisualStyleBackColor = true;
            this.cbIgnoreUnitOrigin.CheckedChanged += new System.EventHandler(this.CBRerollIgnoresOriginalSource);
            // 
            // cbRerollFollowsCustom
            // 
            this.cbRerollFollowsCustom.AutoSize = true;
            this.cbRerollFollowsCustom.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbRerollFollowsCustom.ForeColor = System.Drawing.Color.White;
            this.cbRerollFollowsCustom.Location = new System.Drawing.Point(11, 10);
            this.cbRerollFollowsCustom.Name = "cbRerollFollowsCustom";
            this.cbRerollFollowsCustom.Size = new System.Drawing.Size(180, 17);
            this.cbRerollFollowsCustom.TabIndex = 0;
            this.cbRerollFollowsCustom.Text = "Reroll Follows Custom Engine";
            this.cbRerollFollowsCustom.UseVisualStyleBackColor = true;
            this.cbRerollFollowsCustom.CheckedChanged += new System.EventHandler(this.CbRerollFollowsCustom_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 143;
            this.label1.Text = "Value Settings";
            // 
            // RTC_SettingsReroll_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(289, 228);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RTC_SettingsReroll_Form";
            this.ShowInTaskbar = false;
            this.Tag = "color:normal";
            this.Text = "General";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.CheckBox cbRerollAddress;
		public System.Windows.Forms.CheckBox cbRerollSourceAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.CheckBox cbIgnoreUnitOrigin;
		public System.Windows.Forms.CheckBox cbRerollFollowsCustom;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.CheckBox cbRerollSourceDomain;
		public System.Windows.Forms.CheckBox cbRerollDomain;
	}
}