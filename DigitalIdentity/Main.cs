using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DevFINITY.DigitalIdentity
{
    public partial class Main : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public Main()
        {
            InitializeComponent();
        }



        #region Form Button Functions
        private void CloseAction(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void ToggleSizeAction(object sender, EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Maximized)
        //    {
        //        this.WindowState = FormWindowState.Normal;
        //        maximizeButton.SetButtonType(SwingWERX.Controls.ButtonType.MAXIMIZE);
        //    }
        //    else
        //    {
        //        this.WindowState = FormWindowState.Maximized;
        //        maximizeButton.SetButtonType(SwingWERX.Controls.ButtonType.RESTORE);
        //    }
        //}

        private void MinimizeAction(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MouseDownEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion


        private void LoadEvent(object sender, EventArgs e)
        {
            labelX1.ForeColor = Color.Silver;
        }

        private void LoginAction(object sender, EventArgs e)
        {
            new Login().ShowDialog();
        }

        private void AddRecordAction(object sender, EventArgs e)
        {
            panelManager.SelectedPanel = recordsManagedPanel;
        }
    }
}