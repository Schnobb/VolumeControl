using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_Control
{
    public partial class FrmSettings : Form
    {
        enum WM_ModifierKeys
        {
            MOD_ALT = 0x0001,
            MOD_CONTROL = 0x0002,
            MOD_SHIFT = 0x0004,
            MOD_WIN = 0x0008
        }

        private readonly RegistryKey RkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        private readonly string AppName = Assembly.GetExecutingAssembly().GetName().Name;

        public FrmSettings()
        {
            InitializeComponent();

            // Populate comboboxes
            Dictionary<int, string> comboboxDataSource = new Dictionary<int, string>();

            comboboxDataSource.Add(0x25, "LEFT");
            comboboxDataSource.Add(0x26, "UP");
            comboboxDataSource.Add(0x27, "RIGHT");
            comboboxDataSource.Add(0x28, "DOWN");

            for (int i = 0x30; i < 0x3A; i++)
            {
                comboboxDataSource.Add(i, String.Format("{0}", (char)i));
            }

            for (int i = 0x41; i < 0x5A; i++)
            {
                comboboxDataSource.Add(i, String.Format("{0}", (char)i));
            }

            cboUpChar.DataSource = new BindingSource(comboboxDataSource, null);
            cboUpChar.DisplayMember = "Value";
            cboUpChar.ValueMember = "Key";

            cboDownChar.DataSource = new BindingSource(comboboxDataSource, null);
            cboDownChar.DisplayMember = "Value";
            cboDownChar.ValueMember = "Key";

            // Check hotkey checkboxes
            int upModifier = Volume_Control.Properties.Settings.Default.HotkeyUPModifier;
            int upChar = Volume_Control.Properties.Settings.Default.HotkeyUPChar;

            int downModifier = Volume_Control.Properties.Settings.Default.HotkeyDOWNModifier;
            int downChar = Volume_Control.Properties.Settings.Default.HotkeyDOWNChar;

            chkUpCtrl.Checked = (upModifier & (int)WM_ModifierKeys.MOD_CONTROL) > 0;
            chkUpAlt.Checked = (upModifier & (int)WM_ModifierKeys.MOD_ALT) > 0;
            chkUpWin.Checked = (upModifier & (int)WM_ModifierKeys.MOD_WIN) > 0;
            chkUpShift.Checked = (upModifier & (int)WM_ModifierKeys.MOD_SHIFT) > 0;

            chkDownCtrl.Checked = (downModifier & (int)WM_ModifierKeys.MOD_CONTROL) > 0;
            chkDownAlt.Checked = (downModifier & (int)WM_ModifierKeys.MOD_ALT) > 0;
            chkDownWin.Checked = (downModifier & (int)WM_ModifierKeys.MOD_WIN) > 0;
            chkDownShift.Checked = (downModifier & (int)WM_ModifierKeys.MOD_SHIFT) > 0;

            // Select comboboxes values
            if(comboboxDataSource.Keys.Contains(upChar))
                cboUpChar.SelectedValue = upChar;

            if(comboboxDataSource.Keys.Contains(downChar))
                cboDownChar.SelectedValue = downChar;

            // Select 'Start at login' checkbox
            chkStartAtLogin.Checked = RkApp.GetValue(AppName) != null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Hotkey modifiers
            int upModifier = 0;
            int downModifier = 0;

            if (chkUpCtrl.Checked) upModifier |= (int)WM_ModifierKeys.MOD_CONTROL;
            if (chkUpAlt.Checked) upModifier |= (int)WM_ModifierKeys.MOD_ALT;
            if (chkUpWin.Checked) upModifier |= (int)WM_ModifierKeys.MOD_WIN;
            if (chkUpShift.Checked) upModifier |= (int)WM_ModifierKeys.MOD_SHIFT;

            if (chkDownCtrl.Checked) downModifier |= (int)WM_ModifierKeys.MOD_CONTROL;
            if (chkDownAlt.Checked) downModifier |= (int)WM_ModifierKeys.MOD_ALT;
            if (chkDownWin.Checked) downModifier |= (int)WM_ModifierKeys.MOD_WIN;
            if (chkDownShift.Checked) downModifier |= (int)WM_ModifierKeys.MOD_SHIFT;

            // Hotkey char
            int upChar = (int)cboUpChar.SelectedValue;
            int downChar = (int)cboDownChar.SelectedValue;

            // Save settings
            Volume_Control.Properties.Settings.Default.HotkeyUPModifier = upModifier;
            Volume_Control.Properties.Settings.Default.HotkeyUPChar = upChar;
            Volume_Control.Properties.Settings.Default.HotkeyDOWNModifier = downModifier;
            Volume_Control.Properties.Settings.Default.HotkeyDOWNChar = downChar;

            Volume_Control.Properties.Settings.Default.Save();

            // Start at login
            if (chkStartAtLogin.Checked)
                RkApp.SetValue(AppName, Application.ExecutablePath);
            else
                RkApp.DeleteValue(AppName, false);

            MessageBox.Show("Settings saved");
        }
    }
}
