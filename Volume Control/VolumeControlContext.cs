using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_Control
{
    class VolumeControlContext : ApplicationContext
    {
        private readonly string DefaultToolTip = Assembly.GetExecutingAssembly().GetName().Name;

        private System.ComponentModel.Container components;
        private NotifyIcon notifyIcon;
        private VolumeManager volumeManager;

        private FrmSettings frmSettings;
        private FrmHotkeyHandler frmHotkeyHandler;

        public VolumeControlContext()
        {
            components = new System.ComponentModel.Container();
            Icon volumeControlIcon = new Icon(Properties.Resources.VolumeControl, SystemInformation.SmallIconSize);
            notifyIcon = new NotifyIcon(components)
            {
                ContextMenuStrip = new ContextMenuStrip(),
                Icon = volumeControlIcon,
                Text = DefaultToolTip,
                Visible = true
            };

            notifyIcon.ContextMenuStrip.Items.Add(ToolStripMenuItemWithHandler("Settings", notifyIcon_SettingsClick));
            notifyIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            notifyIcon.ContextMenuStrip.Items.Add(ToolStripMenuItemWithHandler("Exit", notifyIcon_ExitClick));

            volumeManager = new VolumeManager();
            RefreshHotkeys();
        }

        #region event handlers

        private void notifyIcon_SettingsClick(object sender, EventArgs e)
        {
            if(frmSettings == null || frmSettings.IsDisposed)
            {
                frmSettings = new FrmSettings();
                frmSettings.Show();
                frmSettings.FormClosed += frmSettings_FormClosed;
            }
        }

        private void notifyIcon_ExitClick(object sender, EventArgs e)
        {
            ExitThread();
        }

        private void frmSettings_FormClosed(object sender, EventArgs e)
        {
            RefreshHotkeys();
            frmSettings.FormClosed -= frmSettings_FormClosed;
        }

        #endregion

        #region support methods

        private void RefreshHotkeys()
        {
            if (frmHotkeyHandler != null)
                frmHotkeyHandler.Close();

            int upModifier = Properties.Settings.Default.HotkeyUPModifier;
            int upChar = Properties.Settings.Default.HotkeyUPChar;

            int downModifier = Properties.Settings.Default.HotkeyDOWNModifier;
            int downChar = Properties.Settings.Default.HotkeyDOWNChar;

            int muteModifier = Properties.Settings.Default.HotkeyMUTEModifier;
            int muteChar = Properties.Settings.Default.HotkeyMUTEChar;

            frmHotkeyHandler = new FrmHotkeyHandler(volumeManager, (uint)upModifier, (uint)upChar, (uint)downModifier, (uint)downChar, (uint)muteModifier, (uint)muteChar);
        }

        private ToolStripMenuItem ToolStripMenuItemWithHandler(string displayText, EventHandler eventHandler)
        {
            var item = new ToolStripMenuItem(displayText);
            if (eventHandler != null) { item.Click += eventHandler; }
            return item;
        }

        # endregion support methods
    }
}
