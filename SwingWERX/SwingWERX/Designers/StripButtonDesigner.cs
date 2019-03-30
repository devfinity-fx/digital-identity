using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SwingWERX.Designers
{
    public class StripButtonDesigner : System.Windows.Forms.Design.ParentControlDesigner
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
            pe.Graphics.DrawLine(dashedPen, new Point(10, 0), new Point(10, 42));
            pe.Graphics.DrawLine(dashedPen, new Point(58, 0), new Point(58, 42));
            dashedPen.Dispose();
        }
    }
}
