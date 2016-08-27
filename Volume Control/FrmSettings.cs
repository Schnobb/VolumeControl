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
        private readonly RegistryKey RkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        private readonly string AppName = Assembly.GetExecutingAssembly().GetName().Name;

        public FrmSettings()
        {
            InitializeComponent();

            // Init hotkey controls
            hotkeyVolumeUp.KeyModifier = Properties.Settings.Default.HotkeyUPModifier;
            hotkeyVolumeUp.KeyChar = Properties.Settings.Default.HotkeyUPChar;

            hotkeyVolumeDown.KeyModifier = Properties.Settings.Default.HotkeyDOWNModifier;
            hotkeyVolumeDown.KeyChar = Properties.Settings.Default.HotkeyDOWNChar;

            hotkeyMute.KeyModifier = Properties.Settings.Default.HotkeyMUTEModifier;
            hotkeyMute.KeyChar = Properties.Settings.Default.HotkeyMUTEChar;

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
            int upModifier = hotkeyVolumeUp.KeyModifier;
            int downModifier = hotkeyVolumeDown.KeyModifier;
            int muteModifier = hotkeyMute.KeyModifier;

            //// Hotkey char
            int upChar = hotkeyVolumeUp.KeyChar;
            int downChar = hotkeyVolumeDown.KeyChar;
            int muteChat = hotkeyMute.KeyChar;

            // Save settings
            Properties.Settings.Default.HotkeyUPModifier = upModifier;
            Properties.Settings.Default.HotkeyUPChar = upChar;

            Properties.Settings.Default.HotkeyDOWNModifier = downModifier;
            Properties.Settings.Default.HotkeyDOWNChar = downChar;

            Properties.Settings.Default.HotkeyMUTEModifier = muteModifier;
            Properties.Settings.Default.HotkeyMUTEChar = muteChat;

            Properties.Settings.Default.Save();

            // Start at login
            if (chkStartAtLogin.Checked)
                RkApp.SetValue(AppName, Application.ExecutablePath);
            else
                RkApp.DeleteValue(AppName, false);

            MessageBox.Show("Settings saved");
        }
    }
}
