using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SwingWERX.Controls
{
    public class PasswordBox : TextBox
    {
        private PeekButton btn = new PeekButton();
        public PasswordBox()
        {
            this.PasswordChar = '●';


            btn.Size = new Size(25, this.Height + 1);
            btn.Location = new Point(this.Width - btn.Width, -1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Properties.Resources.tap_256;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.MouseDown += Btn_MouseDown;
            btn.MouseUp += Btn_MouseUp;
            this.Controls.Add(btn);
            // Send EM_SETMARGINS to prevent text from disappearing underneath the button
            SendMessage(this.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn.Width << 16));
        }
        protected override void OnResize(EventArgs e)
        {
            btn.Size = new Size(25, this.Height + 1);
            btn.Location = new Point(this.Width - btn.Width, -1);
            base.OnResize(e);
        }
        private void Btn_MouseUp(object sender, MouseEventArgs e)
        {
            this.PasswordChar = this.PasswordChar == '\0' ? '●' : '\0';
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            this.PasswordChar = this.PasswordChar == '\0' ? '●' : '\0';
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);


    }


    class PeekButton : Button
    {
        public PeekButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.ImageList = new ImageList();
            this.ImageList.Images.Add(Properties.Resources.tap_256);
        }

    }
}
