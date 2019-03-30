using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SwingWERX.Controls
{
    public class FlatListView : ListView
    {
        public FlatListView()
        {
            this.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            if (this.View == View.Details)
            {
                IntPtr hHeader = SendMessage(this.Handle, LVM_GETHEADER, IntPtr.Zero, IntPtr.Zero);
                SetWindowTheme(hHeader, "", "");
            }
            base.OnHandleCreated(e);
        }

        private const int LVM_GETHEADER = 0x1000 + 31;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        [DllImport("uxtheme.dll")]
        private static extern int SetWindowTheme(IntPtr hWnd, string appname, string idlist);
    }
}
