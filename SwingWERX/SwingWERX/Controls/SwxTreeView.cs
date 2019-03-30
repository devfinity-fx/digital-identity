using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;

namespace SwingWERX.Controls
{
    public class SwxTreeView : TreeView
    {
        public SwxTreeView()
            : base()
        {

        }

        protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {

            TreeNodeStates state = e.State;
            Font font = e.Node.NodeFont ?? e.Node.TreeView.Font;
            Color fore = e.Node.ForeColor;
            Rectangle rect = new Rectangle();
            if (fore == Color.Empty)
                fore = e.Node.TreeView.ForeColor;


            if (e.Node == e.Node.TreeView.SelectedNode)
            {
                fore = SystemColors.HighlightText;
                rect = new Rectangle(0, e.Bounds.Y, e.Node.TreeView.Width, e.Node.Bounds.Height);
                e.Graphics.FillRectangle(new SolidBrush(e.Node.BackColor), rect);
                //ControlPaint.DrawFocusRectangle(e.Graphics, rect, fore, Color.Red);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, fore, e.Node.BackColor, TextFormatFlags.GlyphOverhangPadding | TextFormatFlags.VerticalCenter);
            }
            else
            {
                rect = new Rectangle(0, e.Bounds.Y, e.Node.TreeView.Width, e.Node.Bounds.Height);
                e.Graphics.FillRectangle(new SolidBrush(Parent.BackColor), rect);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, fore, TextFormatFlags.GlyphOverhangPadding | TextFormatFlags.VerticalCenter);
            }
            base.OnDrawNode(e);
        }
    }
}
