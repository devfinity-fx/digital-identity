using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing;

namespace SwingWERX.Controls
{
    [DefaultEvent("Click")]
    public partial class MetroToggleButton 
        : Button
    {
        public MetroToggleButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            Brush br = new SolidBrush(_motif);
            Pen p = new Pen(br);

            Size StatusSize = new Size((Size.Width/4)*3, Size.Height);

            Rectangle ControlRect = new Rectangle(new Point(0, 0), Size);

            Rectangle StatusRect = new Rectangle(new Point(0, 0), StatusSize);
            g.DrawRectangle(p, ControlRect);


            g.FillRectangle(br, new Rectangle(new Point(0, 0), StatusSize));

        }


        private Color _motif = Color.DodgerBlue;
        [PropertyTab("ColorMotif")]
        [DisplayName("ColorMotif")]
        [Browsable(true)]
        [Description("The color motif for the SwingWERX Button.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "DodgerBlue")]
        public Color ColorMotif
        {
            get
            {
                return _motif;
            }
            set
            {
                _motif = value;
            }
        }

        protected override Size DefaultSize
        {
            get
            {
                return new Size(62, 27);
            }
        }


        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color BackColor
        {
            get
            {
                return Color.White;
            }
            set
            {
                base.BackColor = value;
            }
        }
    }
}
