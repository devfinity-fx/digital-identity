using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DevFINITY.DigitalIdentity.Classes;
using System.Windows.Forms.Design;

namespace DevFINITY.DigitalIdentity.Controls
{
    class BigTileButton : Button
    {

        private bool _isMouseOver;


        public BigTileButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {

            //base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            g.FillRectangle(new SolidBrush(this.BackColor), this.ClientRectangle);

            Rectangle imgRect = new Rectangle(
                (this.ClientRectangle.Width / 2) - 32, // 32x32
                (this.ClientRectangle.Width / 2) - ((64 / 4) * 3), // top lang. so whole size.
                64,
                64
            );
            Rectangle txtRect = new Rectangle(
                0,
                (this.ClientRectangle.Width / 2) + ((64 / 4)),
                this.ClientRectangle.Width,
                this.ClientRectangle.Height / 8
            );

            //using (Pen pen = new Pen(SystemBrushes.Control))
            //{
            //    pen.DashStyle = DashStyle.Solid;
            //    g.DrawRectangle(pen, imgRect);
            //}

            //using (Pen pen = new Pen(SystemBrushes.Control))
            //{
            //    pen.DashStyle = DashStyle.Solid;
            //    g.DrawRectangle(pen, txtRect);
            //}















            Rectangle customClientRect = new Rectangle(
                0, 0,
                this.ClientRectangle.Width - 1,
                this.ClientRectangle.Height - 1
            );
            
            using(Pen pen = new Pen(SystemBrushes.ActiveBorder))
            {
                pen.DashStyle = DashStyle.Dot;
                g.DrawRectangle(pen, customClientRect);
            }


            if (_isMouseOver)
            {
                customClientRect = new Rectangle(
                    0, 0,
                    this.ClientRectangle.Width - 1,
                    this.ClientRectangle.Height - 1
                );

                //using (Brush brush = new SolidBrush(Color.WhiteSmoke))
                //{
                //    g.FillRoundedRectangle(brush, this.ClientRectangle, 3);
                //}

                using (Pen pen = new Pen(SystemBrushes.Highlight))
                {
                    pen.DashStyle = DashStyle.Dot;
                    g.DrawRectangle(pen, customClientRect);
                }
            }




            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            //g.FillRoundedRectangle(new SolidBrush(this.BackColor), this.Bounds, 0);

            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            g.DrawString(Text, Font, new SolidBrush(ForeColor), txtRect, format);


            if (Image != null)
            {
                g.DrawImage(Image, imgRect);
            }

        }


        protected override Size DefaultSize
        {
            get
            {
                return new Size(128, 128);
            }
        }
        

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isMouseOver = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            _isMouseOver = false;
        }

    }
}
