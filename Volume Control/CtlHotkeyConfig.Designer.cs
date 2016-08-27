namespace Volume_Control
{
    partial class CtlHotkeyConfig
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
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.cboChar = new System.Windows.Forms.ComboBox();
            this.chkShift = new System.Windows.Forms.CheckBox();
            this.chkWin = new System.Windows.Forms.CheckBox();
            this.chkAlt = new System.Windows.Forms.CheckBox();
            this.chkCtrl = new System.Windows.Forms.CheckBox();
            this.grpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.cboChar);
            this.grpControl.Controls.Add(this.chkShift);
            this.grpControl.Controls.Add(this.chkWin);
            this.grpControl.Controls.Add(this.chkAlt);
            this.grpControl.Controls.Add(this.chkCtrl);
            this.grpControl.Location = new System.Drawing.Point(3, 3);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(306, 45);
            this.grpControl.TabIndex = 1;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "HOTKEY_FUNCTION";
            // 
            // cboChar
            // 
            this.cboChar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChar.FormattingEnabled = true;
            this.cboChar.Location = new System.Drawing.Point(194, 17);
            this.cboChar.Name = "cboChar";
            this.cboChar.Size = new System.Drawing.Size(106, 21);
            this.cboChar.TabIndex = 4;
            // 
            // chkShift
            // 
            this.chkShift.AutoSize = true;
            this.chkShift.Location = new System.Drawing.Point(143, 19);
            this.chkShift.Name = "chkShift";
            this.chkShift.Size = new System.Drawing.Size(45, 17);
            this.chkShift.TabIndex = 3;
            this.chkShift.Text = "shift";
            this.chkShift.UseVisualStyleBackColor = true;
            // 
            // chkWin
            // 
            this.chkWin.AutoSize = true;
            this.chkWin.Location = new System.Drawing.Point(95, 19);
            this.chkWin.Name = "chkWin";
            this.chkWin.Size = new System.Drawing.Size(42, 17);
            this.chkWin.TabIndex = 2;
            this.chkWin.Text = "win";
            this.chkWin.UseVisualStyleBackColor = true;
            // 
            // chkAlt
            // 
            this.chkAlt.AutoSize = true;
            this.chkAlt.Location = new System.Drawing.Point(52, 19);
            this.chkAlt.Name = "chkAlt";
            this.chkAlt.Size = new System.Drawing.Size(37, 17);
            this.chkAlt.TabIndex = 1;
            this.chkAlt.Text = "alt";
            this.chkAlt.UseVisualStyleBackColor = true;
            // 
            // chkCtrl
            // 
            this.chkCtrl.AutoSize = true;
            this.chkCtrl.Location = new System.Drawing.Point(6, 19);
            this.chkCtrl.Name = "chkCtrl";
            this.chkCtrl.Size = new System.Drawing.Size(40, 17);
            this.chkCtrl.TabIndex = 0;
            this.chkCtrl.Text = "ctrl";
            this.chkCtrl.UseVisualStyleBackColor = true;
            // 
            // CtlHotkeyConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpControl);
            this.Name = "CtlHotkeyConfig";
            this.Size = new System.Drawing.Size(312, 51);
            this.grpControl.ResumeLayout(false);
            this.grpControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.ComboBox cboChar;
        private System.Windows.Forms.CheckBox chkShift;
        private System.Windows.Forms.CheckBox chkWin;
        private System.Windows.Forms.CheckBox chkAlt;
        private System.Windows.Forms.CheckBox chkCtrl;
    }
}
