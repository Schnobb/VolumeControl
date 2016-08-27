﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_Control
{
    public partial class FrmHotkeyHandler : Form
    {
        private readonly int WM_HOTKEY = 0x0312;

        private readonly int UpHotkeyId = 0x01;
        private readonly int DownHotkeyId = 0x02;

        private VolumeManager volumeManager;

        private uint upModifier;
        private uint upChar;

        private uint downModifier;
        private uint downChar;

        public FrmHotkeyHandler(VolumeManager volumeManager, uint upModifier, uint upChar, uint downModifier, uint downChar)
        {
            InitializeComponent();

            this.volumeManager = volumeManager;

            this.upModifier = upModifier;
            this.upChar = upChar;

            this.downModifier = downModifier;
            this.downChar = downChar;

            SetHotkeys();
        }

        #region hotkey handling

        // Registers a hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        // Unregisters the hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private void SetHotkeys()
        {
            RegisterHotKey(this.Handle, UpHotkeyId, upModifier, upChar);
            RegisterHotKey(this.Handle, DownHotkeyId, downModifier, downChar);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                int key = ((int)m.LParam >> 16) & 0xFFFF;
                int modifier = (int)m.LParam & 0xFFFF;

                if (key == upChar && modifier == upModifier)
                    volumeManager.VolumeUp();
                else if (key == downChar && modifier == downModifier)
                    volumeManager.VolumeDown();
            }

            base.WndProc(ref m);
        }

        #endregion

        private void HotkeyHandler_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, UpHotkeyId);
            UnregisterHotKey(this.Handle, DownHotkeyId);
        }
    }
}
