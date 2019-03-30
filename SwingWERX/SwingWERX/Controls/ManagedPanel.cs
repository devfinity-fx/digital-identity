using System;
using System.Design;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Drawing.Design;
using System.Globalization;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SwingWERX.Controls
{
    [Designer(typeof(ManagedPanelDesigner)), ToolboxItem(false)]
    public class ManagedPanel : System.Windows.Forms.ScrollableControl
    {

        public ManagedPanel()
        {
            base.Dock = DockStyle.Fill;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            if (Parent != null) base.OnLayout(levent);
        }


        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DefaultValue(typeof(DockStyle), "Fill")]
        public override System.Windows.Forms.DockStyle Dock
        {
            get { return base.Dock; }
            set { base.Dock = DockStyle.Fill; }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DefaultValue(typeof(AnchorStyles), "None")]
        public override AnchorStyles Anchor
        {
            get { return AnchorStyles.None; }
            set { base.Anchor = AnchorStyles.None; }
        }

        protected override void OnLocationChanged(System.EventArgs e)
        {
            base.OnLocationChanged(e);
            base.Location = System.Drawing.Point.Empty;
        }

        protected override void OnSizeChanged(System.EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.Parent == null)
            {
                this.Size = System.Drawing.Size.Empty;
            }
            else
            {
                this.Size = this.Parent.ClientSize;
            }
        }

        protected override void OnParentChanged(System.EventArgs e)
        {
            if (!(this.Parent is Controls.PanelManager) && (this.Parent != null))
            {
                throw new ArgumentException("Managed Panels may only be added to a Panel Manager.");
            }
            base.OnParentChanged(e);
        }

    }
}
