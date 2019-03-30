using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

using SwingWERX.Extensions;

namespace SwingWERX.Controls
{
    public class Separator : Label
    {
        public Separator()
        {

        }

        #region Overrides
        [Browsable(false)]
        [DefaultValue(false)]
        public override bool AutoSize
        {
            get
            {
                return false;
            }
        }

        public new string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value; Refresh();
            }
        }

        private Orientation _Orientation = Orientation.Horizontal;
        [PropertyTab("Orientation")]
        [DisplayName("Orientation")]
        [Description("The orientation of the separator.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(Orientation.Horizontal)]
        public Orientation Orientation
        {
            get { return _Orientation; }
            set { _Orientation = value; Refresh(); }
        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            label = new Label()
            {
                Font = base.Font,
                Text = base.Text,
                AutoEllipsis = false,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };

            if (!String.IsNullOrEmpty(Text))
            {

                StringFormat sFormat = new StringFormat()
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center
                };

                if (Orientation == System.Windows.Forms.Orientation.Horizontal)
                {
                    sFormat.Trimming = StringTrimming.EllipsisPath;
                    rect = new Rectangle(20, 0, label.PreferredWidth + 2, base.Height);

                    SizeF x = g.MeasureString(base.Text, base.Font);

                    g.DrawString(base.Text, base.Font, new SolidBrush(Color.FromKnownColor(KnownColor.ControlDarkDark)), rect, sFormat);
                    g.DrawLine(new Pen(new SolidBrush(Color.FromArgb(215, 215, 215))), 0, base.Height / 2, 16, base.Height / 2);
                    g.DrawLine(new Pen(new SolidBrush(Color.FromArgb(215, 215, 215))), 16 + x.Width + 6, base.Height / 2, base.Width, base.Height / 2);
                }
                else
                {
                    this.Width = label.Height;

                    sFormat.FormatFlags = StringFormatFlags.DirectionVertical | StringFormatFlags.LineLimit;

                    SizeF x = g.MeasureString(base.Text, base.Font, label.PreferredWidth, sFormat);
                    
                    rect = new Rectangle(0, 20, this.Width, (int)x.Height);

                    g.DrawString(base.Text, base.Font, new SolidBrush(Color.FromKnownColor(KnownColor.ControlDarkDark)), rect, sFormat);
                    g.DrawLine(new Pen(new SolidBrush(Color.FromArgb(215, 215, 215))), this.Width / 2, 0, this.Width / 2, 16);
                    g.DrawLine(new Pen(new SolidBrush(Color.FromArgb(215, 215, 215))), this.Width / 2, 16 + x.Height + 6, this.Width / 2, base.Height);
                }
            }
            else
            {
                if (Orientation == System.Windows.Forms.Orientation.Horizontal)
                {
                    g.DrawLine(new Pen(new SolidBrush(Color.FromArgb(215, 215, 215))), 0, base.Height / 2, base.Width, base.Height / 2);
                }
                else
                {
                    this.Width = label.Height;

                    g.DrawLine(new Pen(new SolidBrush(Color.FromArgb(215, 215, 215))), this.Width / 2, 0, this.Width / 2, base.Height);
                }
            }
            //base.OnPaint(e);
        }

        private Rectangle rect;

        private void InitializeSeparator()
        {
            this.AutoSize = false;
        }

        private System.Windows.Forms.Label label;
    }
}
