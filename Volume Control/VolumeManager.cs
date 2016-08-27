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
            keybd_event((byte)Keys.VolumeUp, 0, 0, 0);
        }

        public void VolumeDown()
        {
            keybd_event((byte)Keys.VolumeDown, 0, 0, 0);
        }
    }
}
