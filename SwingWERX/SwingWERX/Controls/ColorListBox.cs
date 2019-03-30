using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace SwingWERX.Controls
{
    class ColorListBox : ListBox
    {
        public ColorListBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if(this.Items.Count>0)
            {
                ColorListBoxItem item = (ColorListBoxItem)this.Items[e.Index];
                item.DrawItem(e, Font, ForeColor, ItemHeight);
            }
        }
    }

    class ColorListBoxItem
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Color _color;
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public void DrawItem(DrawItemEventArgs e, Font font, Color foreColor, int itemHeight)
        {
            Rectangle colorRect = new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, 22, itemHeight-4);

            RectangleF textRect = new RectangleF(e.Bounds.X + 26, e.Bounds.Y, e.Bounds.Width - 22, e.Bounds.Height);
            
            // if selected, mark the background differently
            Rectangle highlightRect = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height + 1);
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, highlightRect);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, highlightRect);
            }

            e.Graphics.FillRectangle(new SolidBrush(_color), colorRect);
            e.Graphics.DrawRectangle(Pens.Black, colorRect);

            StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };

            e.Graphics.DrawString(
                _color.ToString(),
                font,
                new SolidBrush(foreColor),
                textRect,
                sf
            );

        }
    }

    class ColorLabel
        : Label
    {
        public ColorLabel()
        {
            this.Size = new Size(20, 20);
            this.Text = "";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;


            Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
            Rectangle rect1 = new Rectangle(1, 1, base.Width-2, base.Height-2);

            ControlPaint.DrawBorder(e.Graphics, rect,
                              Color.FromArgb(105, 105, 105), 1, ButtonBorderStyle.Solid,
                              Color.FromArgb(105, 105, 105), 1, ButtonBorderStyle.Solid,
                              Color.White, 1, ButtonBorderStyle.Solid,
                              Color.White, 1, ButtonBorderStyle.Solid);


            ControlPaint.DrawBorder(e.Graphics, rect1,
                              Color.FromArgb(160, 160, 160), 1, ButtonBorderStyle.Solid,
                              Color.FromArgb(160, 160, 160), 1, ButtonBorderStyle.Solid,
                              Color.FromArgb(227, 227, 227), 1, ButtonBorderStyle.Solid,
                              Color.FromArgb(227, 227, 227), 1, ButtonBorderStyle.Solid);
        }

        public override bool AutoSize
        {
            get
            {
                return false;
            }
        }

        public override int PreferredHeight
        {
            get
            {
                return 20;
            }
        }

        public override int PreferredWidth
        {
            get
            {
                return 20;
            }
        }

        public override string Text
        {
            get
            {
                return "";
            }
            
        }

        protected override bool ShowFocusCues
        {
            get
            {
                return true;
            }
        }

        
    }
    
}
