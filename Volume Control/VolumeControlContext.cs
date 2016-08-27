using System;
using System.Collections.Generic;
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
            notifyIcon = new NotifyIcon(components)
            {
                ContextMenuStrip = new ContextMenuStrip(),
                Icon = Volume_Control.Properties.Resources.VolumeControl,
                Text = DefaultToolTip,
                Visible = true
            };

            notifyIcon.ContextMenuStrip.Items.Add(ToolStripMenuItemWithHandler("Settings", notifyIcon_SettingsClick));
            notifyIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            notifyIcon.ContextMenuStrip.Items.Add(ToolStripMenuItemWithHandler("Exit", notifyIcon_ExitClick));

            volumeManager = new VolumeManager();
            RefreshHotkeys();
        }

        private void RefreshHotkeys()
        {
            if (frmHotkeyHandler != null)
                frmHotkeyHandler.Close();

            int upModifier = Volume_Control.Properties.Settings.Default.HotkeyUPModifier;
            int upChar = Volume_Control.Properties.Settings.Default.HotkeyUPChar;
            int downModifier = Volume_Control.Properties.Settings.Default.HotkeyDOWNModifier;
            int downChar = Volume_Control.Properties.Settings.Default.HotkeyDOWNChar;

            frmHotkeyHandler = new FrmHotkeyHandler(volumeManager, (uint)upModifier, (uint)upChar, (uint)downModifier, (uint)downChar);
        }

        #region event handlers

        private void notifyIcon_SettingsClick(object sender, EventArgs e)
        {
            if(frmSettings == null || frmSettings.IsDisposed)
            {
                frmSettings = new FrmSettings();
                frmSettings.Show();
                RefreshHotkeys();
            }
        }

        private void notifyIcon_ExitClick(object sender, EventArgs e)
        {
            ExitThread();
        }

        #endregion

        #region support methods

        private ToolStripMenuItem ToolStripMenuItemWithHandler(string displayText, EventHandler eventHandler)
        {
            var item = new ToolStripMenuItem(displayText);
            if (eventHandler != null) { item.Click += eventHandler; }
            return item;
        }

        # endregion support methods
    }
}
