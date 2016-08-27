using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_Control
{
    public class VolumeManager
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public void VolumeUp()
        {
            PressKey(Keys.VolumeUp);
        }

        public void VolumeDown()
        {
            PressKey(Keys.VolumeDown);
        }

        public void Mute()
        {
            PressKey(Keys.VolumeMute);
        }

        private void PressKey(Keys key)
        {
            keybd_event((byte)key, 0, 0, 0);
        }
    }
}
