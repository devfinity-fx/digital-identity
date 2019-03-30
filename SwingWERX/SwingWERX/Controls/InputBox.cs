/* InputBox - [Custom Textbox]
 * Author name:           Aron Jhed Bautista Amiscosa
 * Current version:       1.0.0.4
 * License information:   Microsoft Public License (Ms-PL) [http://www.opensource.org/licenses/ms-pl.html]
 * 
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;

namespace SwingWERX.Controls
{
    public partial class InputBox : TextBox
    {
        public InputBox()
        {
            InitializeComponent();
            ResetNullText();
        }

        public InputBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            ResetNullText();
            
        }

        private void ResetNullText()
        {
            if (!String.IsNullOrEmpty(NullText))
            {
                SendMessage(this.Handle, EM_SETCUEBANNER, 0, NullText);
            }
        }

        [PropertyTab("NullText")]
        [DisplayName("NullText")]
        [Browsable(true)]
        [Description("Text to be displayed when empty and out of focus.")]
        [Category("Appearance")]
        public String NullText
        {
            get
            {
                return _NullText;
            }
            set
            {
                _NullText = value;
                ResetNullText();
            }
        }
        private String _NullText;


        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar == ((char)Keys.Enter)) || (e.KeyChar == ((char) Keys.Escape)))
            {
                e.Handled = true;
            }
            
            base.OnKeyPress(e);
        }

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
    }
}
