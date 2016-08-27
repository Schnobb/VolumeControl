namespace Volume_Control
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkStartAtLogin = new System.Windows.Forms.CheckBox();
            this.hotkeyMute = new Volume_Control.CtlHotkeyConfig();
            this.hotkeyVolumeDown = new Volume_Control.CtlHotkeyConfig();
            this.hotkeyVolumeUp = new Volume_Control.CtlHotkeyConfig();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(249, 221);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(169, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkStartAtLogin
            // 
            this.chkStartAtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkStartAtLogin.AutoSize = true;
            this.chkStartAtLogin.Location = new System.Drawing.Point(18, 225);
            this.chkStartAtLogin.Name = "chkStartAtLogin";
            this.chkStartAtLogin.Size = new System.Drawing.Size(85, 17);
            this.chkStartAtLogin.TabIndex = 5;
            this.chkStartAtLogin.Text = "Start at login";
            this.chkStartAtLogin.UseVisualStyleBackColor = true;
            // 
            // hotkeyMute
            // 
            this.hotkeyMute.KeyChar = 37;
            this.hotkeyMute.KeyModifier = 0;
            this.hotkeyMute.Location = new System.Drawing.Point(12, 126);
            this.hotkeyMute.Name = "hotkeyMute";
            this.hotkeyMute.Size = new System.Drawing.Size(312, 51);
            this.hotkeyMute.TabIndex = 8;
            this.hotkeyMute.Text = "Mute";
            // 
            // hotkeyVolumeDown
            // 
            this.hotkeyVolumeDown.KeyChar = 37;
            this.hotkeyVolumeDown.KeyModifier = 0;
            this.hotkeyVolumeDown.Location = new System.Drawing.Point(12, 69);
            this.hotkeyVolumeDown.Name = "hotkeyVolumeDown";
            this.hotkeyVolumeDown.Size = new System.Drawing.Size(312, 51);
            this.hotkeyVolumeDown.TabIndex = 7;
            this.hotkeyVolumeDown.Text = "Volume Down";
            // 
            // hotkeyVolumeUp
            // 
            this.hotkeyVolumeUp.KeyChar = 37;
            this.hotkeyVolumeUp.KeyModifier = 0;
            this.hotkeyVolumeUp.Location = new System.Drawing.Point(12, 12);
            this.hotkeyVolumeUp.Name = "hotkeyVolumeUp";
            this.hotkeyVolumeUp.Size = new System.Drawing.Size(312, 51);
            this.hotkeyVolumeUp.TabIndex = 6;
            this.hotkeyVolumeUp.Text = "Volume Up";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(336, 256);
            this.Controls.Add(this.hotkeyMute);
            this.Controls.Add(this.hotkeyVolumeDown);
            this.Controls.Add(this.hotkeyVolumeUp);
            this.Controls.Add(this.chkStartAtLogin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkStartAtLogin;
        private CtlHotkeyConfig hotkeyVolumeUp;
        private CtlHotkeyConfig hotkeyVolumeDown;
        private CtlHotkeyConfig hotkeyMute;
    }
}