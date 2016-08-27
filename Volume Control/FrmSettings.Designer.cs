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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboUpChar = new System.Windows.Forms.ComboBox();
            this.chkUpShift = new System.Windows.Forms.CheckBox();
            this.chkUpWin = new System.Windows.Forms.CheckBox();
            this.chkUpAlt = new System.Windows.Forms.CheckBox();
            this.chkUpCtrl = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboDownChar = new System.Windows.Forms.ComboBox();
            this.chkDownShift = new System.Windows.Forms.CheckBox();
            this.chkDownWin = new System.Windows.Forms.CheckBox();
            this.chkDownAlt = new System.Windows.Forms.CheckBox();
            this.chkDownCtrl = new System.Windows.Forms.CheckBox();
            this.chkStartAtLogin = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboUpChar);
            this.groupBox1.Controls.Add(this.chkUpShift);
            this.groupBox1.Controls.Add(this.chkUpWin);
            this.groupBox1.Controls.Add(this.chkUpAlt);
            this.groupBox1.Controls.Add(this.chkUpCtrl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Volume Up";
            // 
            // cboUpChar
            // 
            this.cboUpChar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpChar.FormattingEnabled = true;
            this.cboUpChar.Location = new System.Drawing.Point(194, 17);
            this.cboUpChar.Name = "cboUpChar";
            this.cboUpChar.Size = new System.Drawing.Size(69, 21);
            this.cboUpChar.TabIndex = 4;
            // 
            // chkUpShift
            // 
            this.chkUpShift.AutoSize = true;
            this.chkUpShift.Location = new System.Drawing.Point(143, 19);
            this.chkUpShift.Name = "chkUpShift";
            this.chkUpShift.Size = new System.Drawing.Size(45, 17);
            this.chkUpShift.TabIndex = 3;
            this.chkUpShift.Text = "shift";
            this.chkUpShift.UseVisualStyleBackColor = true;
            // 
            // chkUpWin
            // 
            this.chkUpWin.AutoSize = true;
            this.chkUpWin.Location = new System.Drawing.Point(95, 19);
            this.chkUpWin.Name = "chkUpWin";
            this.chkUpWin.Size = new System.Drawing.Size(42, 17);
            this.chkUpWin.TabIndex = 2;
            this.chkUpWin.Text = "win";
            this.chkUpWin.UseVisualStyleBackColor = true;
            // 
            // chkUpAlt
            // 
            this.chkUpAlt.AutoSize = true;
            this.chkUpAlt.Location = new System.Drawing.Point(52, 19);
            this.chkUpAlt.Name = "chkUpAlt";
            this.chkUpAlt.Size = new System.Drawing.Size(37, 17);
            this.chkUpAlt.TabIndex = 1;
            this.chkUpAlt.Text = "alt";
            this.chkUpAlt.UseVisualStyleBackColor = true;
            // 
            // chkUpCtrl
            // 
            this.chkUpCtrl.AutoSize = true;
            this.chkUpCtrl.Location = new System.Drawing.Point(6, 19);
            this.chkUpCtrl.Name = "chkUpCtrl";
            this.chkUpCtrl.Size = new System.Drawing.Size(40, 17);
            this.chkUpCtrl.TabIndex = 0;
            this.chkUpCtrl.Text = "ctrl";
            this.chkUpCtrl.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(208, 122);
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
            this.btnSave.Location = new System.Drawing.Point(128, 122);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboDownChar);
            this.groupBox2.Controls.Add(this.chkDownShift);
            this.groupBox2.Controls.Add(this.chkDownWin);
            this.groupBox2.Controls.Add(this.chkDownAlt);
            this.groupBox2.Controls.Add(this.chkDownCtrl);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 45);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volume Down";
            // 
            // cboDownChar
            // 
            this.cboDownChar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDownChar.FormattingEnabled = true;
            this.cboDownChar.Location = new System.Drawing.Point(194, 17);
            this.cboDownChar.Name = "cboDownChar";
            this.cboDownChar.Size = new System.Drawing.Size(69, 21);
            this.cboDownChar.TabIndex = 4;
            // 
            // chkDownShift
            // 
            this.chkDownShift.AutoSize = true;
            this.chkDownShift.Location = new System.Drawing.Point(143, 19);
            this.chkDownShift.Name = "chkDownShift";
            this.chkDownShift.Size = new System.Drawing.Size(45, 17);
            this.chkDownShift.TabIndex = 3;
            this.chkDownShift.Text = "shift";
            this.chkDownShift.UseVisualStyleBackColor = true;
            // 
            // chkDownWin
            // 
            this.chkDownWin.AutoSize = true;
            this.chkDownWin.Location = new System.Drawing.Point(95, 19);
            this.chkDownWin.Name = "chkDownWin";
            this.chkDownWin.Size = new System.Drawing.Size(42, 17);
            this.chkDownWin.TabIndex = 2;
            this.chkDownWin.Text = "win";
            this.chkDownWin.UseVisualStyleBackColor = true;
            // 
            // chkDownAlt
            // 
            this.chkDownAlt.AutoSize = true;
            this.chkDownAlt.Location = new System.Drawing.Point(52, 19);
            this.chkDownAlt.Name = "chkDownAlt";
            this.chkDownAlt.Size = new System.Drawing.Size(37, 17);
            this.chkDownAlt.TabIndex = 1;
            this.chkDownAlt.Text = "alt";
            this.chkDownAlt.UseVisualStyleBackColor = true;
            // 
            // chkDownCtrl
            // 
            this.chkDownCtrl.AutoSize = true;
            this.chkDownCtrl.Location = new System.Drawing.Point(6, 19);
            this.chkDownCtrl.Name = "chkDownCtrl";
            this.chkDownCtrl.Size = new System.Drawing.Size(40, 17);
            this.chkDownCtrl.TabIndex = 0;
            this.chkDownCtrl.Text = "ctrl";
            this.chkDownCtrl.UseVisualStyleBackColor = true;
            // 
            // chkStartAtLogin
            // 
            this.chkStartAtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkStartAtLogin.AutoSize = true;
            this.chkStartAtLogin.Location = new System.Drawing.Point(18, 126);
            this.chkStartAtLogin.Name = "chkStartAtLogin";
            this.chkStartAtLogin.Size = new System.Drawing.Size(85, 17);
            this.chkStartAtLogin.TabIndex = 5;
            this.chkStartAtLogin.Text = "Start at login";
            this.chkStartAtLogin.UseVisualStyleBackColor = true;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 157);
            this.Controls.Add(this.chkStartAtLogin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboUpChar;
        private System.Windows.Forms.CheckBox chkUpShift;
        private System.Windows.Forms.CheckBox chkUpWin;
        private System.Windows.Forms.CheckBox chkUpAlt;
        private System.Windows.Forms.CheckBox chkUpCtrl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboDownChar;
        private System.Windows.Forms.CheckBox chkDownShift;
        private System.Windows.Forms.CheckBox chkDownWin;
        private System.Windows.Forms.CheckBox chkDownAlt;
        private System.Windows.Forms.CheckBox chkDownCtrl;
        private System.Windows.Forms.CheckBox chkStartAtLogin;
    }
}