using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_Control
{
    public static class Utils
    {
        public enum WM_ModifierKeys
        {
            MOD_ALT = 0x0001,
            MOD_CONTROL = 0x0002,
            MOD_SHIFT = 0x0004,
            MOD_WIN = 0x0008
        }

        public const int WM_HOTKEY = 0x0312;
    }
}
