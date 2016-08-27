using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_Control
{
    public partial class CtlHotkeyConfig : UserControl
    {
        private Dictionary<int, string> comboboxDataSource;

        #region properties

        public int KeyModifier
        {
            get
            {
                int mod = 0;

                if (chkCtrl.Checked) mod |= (int)Utils.WM_ModifierKeys.MOD_CONTROL;
                if (chkAlt.Checked) mod |= (int)Utils.WM_ModifierKeys.MOD_ALT;
                if (chkWin.Checked) mod |= (int)Utils.WM_ModifierKeys.MOD_WIN;
                if (chkShift.Checked) mod |= (int)Utils.WM_ModifierKeys.MOD_SHIFT;

                return mod;
            }

            set
            {
                chkCtrl.Checked = (value & (int)Utils.WM_ModifierKeys.MOD_CONTROL) > 0;
                chkAlt.Checked = (value & (int)Utils.WM_ModifierKeys.MOD_ALT) > 0;
                chkWin.Checked = (value & (int)Utils.WM_ModifierKeys.MOD_WIN) > 0;
                chkShift.Checked = (value & (int)Utils.WM_ModifierKeys.MOD_SHIFT) > 0;
            }
        }

        public int KeyChar
        {
            get { return (int)cboChar.SelectedValue; }

            set
            {
                if (comboboxDataSource.Keys.Contains(value))
                    cboChar.SelectedValue = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get { return grpControl.Text; }
            set { grpControl.Text = value; }
        }

        #endregion

        public CtlHotkeyConfig()
        {
            InitializeComponent();

            // Populate combobox
            comboboxDataSource = GetKeyDictionnary();
            cboChar.DataSource = new BindingSource(comboboxDataSource, null);
            cboChar.DisplayMember = "Value";
            cboChar.ValueMember = "Key";
        }

        private Dictionary<int, string> GetKeyDictionnary()
        {
            Dictionary<int, string> keyDict = new Dictionary<int, string>();

            // Arrow keys
            keyDict.Add(0x25, "LEFT");
            keyDict.Add(0x26, "UP");
            keyDict.Add(0x27, "RIGHT");
            keyDict.Add(0x28, "DOWN");

            // Number keys
            for (int i = 0x30; i < 0x3A; i++)
                keyDict.Add(i, String.Format("{0}", (char)i));

            // Letter keys
            for (int i = 0x41; i < 0x5A; i++)
                keyDict.Add(i, String.Format("{0}", (char)i));

            // Insert / Home / etc. key island
            keyDict.Add(0x21, "PAGE UP");
            keyDict.Add(0x22, "PAGE DOWN");
            keyDict.Add(0x23, "END");
            keyDict.Add(0x24, "HOME");

            keyDict.Add(0x2D, "INSERT");
            keyDict.Add(0x2E, "DELETE");

            // Numpad keys
            for (int i = 0; i < 10; i++)
                keyDict.Add(0x60 + i, String.Format("NUM {0}", i));

            keyDict.Add(0x6A, "MULTIPLY");
            keyDict.Add(0x6B, "ADD");
            keyDict.Add(0x6D, "SUBTRACT");
            keyDict.Add(0x6E, "DECIMAL");
            keyDict.Add(0x6F, "DIVIDE");

            // F keys
            for (int i = 0; i < 12; i++)
                keyDict.Add(0x70 + i, String.Format("F{0}", i + 1));

            // Spacebar
            keyDict.Add(0x20, "SPACEBAR");

            return keyDict;
        }
    }
}
