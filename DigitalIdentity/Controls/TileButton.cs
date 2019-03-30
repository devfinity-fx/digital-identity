using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DevFINITY.DigitalIdentity.Classes;
using System.Windows.Forms.Design;

namespace DevFINITY.DigitalIdentity.Controls
{
    [Designer(typeof(TileButtonDesigner))]
    public class TileButton : Button
    {

        private bool _isMouseOver;


        public TileButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.FillRectangle(new SolidBrush(this.BackColor), this.ClientRectangle);

            Rectangle imgRect = new Rectangle(5, 5, 74, 74);
            Rectangle txtRect = new Rectangle(5, 83, 74, 42);

            if (_isMouseOver)
            {
                Rectangle customClientRect = new Rectangle(
                    0,0,
                    this.ClientRectangle.Width-1,
                    this.ClientRectangle.Height-1
                );
                g.FillRoundedRectangle(new SolidBrush(Color.WhiteSmoke), this.ClientRectangle,3);
                g.DrawRoundedRectangle(new Pen(SystemBrushes.ControlLight), customClientRect, 3);
            }


            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            
            g.FillRoundedRectangle(new SolidBrush(this.BackColor), this.Bounds, 0);

            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            g.DrawString(Text, new Font("Segoe UI Semilight", 10, FontStyle.Bold), SystemBrushes.ActiveBorder, txtRect, format);


            if(Image!=null)
            {
                g.DrawImage(Image, imgRect);
            }

        }
        
        protected override Size DefaultSize
        {
            get
            {
                return new Size(85, 130);
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

    #region Designer
    internal class TileButtonDesigner : ParentControlDesigner
    {
        protected override void OnPaintAdornments(System.Windows.Forms.PaintEventArgs pe)
        {
            base.OnPaintAdornments(pe);
            System.Drawing.Color penColor = default(System.Drawing.Color);
            if (this.Control.BackColor.GetBrightness() >= 0.5)
            {
                penColor = ControlPaint.Dark(this.Control.BackColor);
            }
            else
            {
                penColor = SystemColors.ControlLightLight;
            }
            Pen dashedPen = new Pen(penColor);
            Rectangle borderRectangle = this.Control.ClientRectangle;
            borderRectangle.Width -= 1;
            borderRectangle.Height -= 1;
            dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pe.Graphics.DrawRectangle(dashedPen, borderRectangle);
            dashedPen.Dispose();
        }
    }
    #endregion

}
