using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace SwingWERX.Controls
{
    public partial class SlidePanel : Panel
    {
        public SlidePanel()
        {
            InitializeComponent();
        }

        public SlidePanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private bool _IsOpen = true;
        [PropertyTab("IsOpen")]
        [DisplayName("IsOpen")]
        [Browsable(true)]
        [Description("Determines whether the SlidePanel would be open or closed.")]
        [Category("Behavior")]
        [DefaultValue(true)]
        public bool IsOpen
        {
            get
            {
                return _IsOpen;
            }

            set
            {
                if (!this.Visible) Visible = true;
                if(_IsOpen!=value)
                    AnimatePanel();
                _IsOpen = value;
            }
        }

        private void AnimatePanel()
        {
            var x = this.Handle;

            BeginInvoke(new Action(() =>
            {
                try
                {
                    if (!IsOpen)
                    {
                        for (int i = 0; i > -(this.Width+1); i--)
                        {
                            this.Location = new Point(i, this.Location.Y);
                            Thread.Sleep(1);
                            Refresh();
                        }
                    }
                    else
                    {
                        for (int i = -(this.Width); i < 0; i++)
                        {
                            this.Location = new Point(i, this.Location.Y);
                            Thread.Sleep(1);
                            Refresh();
                        }
                    }
                }
                catch
                {
                    // form could be disposed
                }
            }));
        }

        private void SlidePanel_Layout(object sender, LayoutEventArgs e)
        {
            //this.Visible = IsOpen;
        }
    }

    public enum SlidePanelConstants
    {
        OPEN = 1,
        CLOSED = 0
    }
}
