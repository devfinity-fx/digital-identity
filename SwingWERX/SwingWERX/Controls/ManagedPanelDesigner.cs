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
    public class ManagedPanelDesigner : System.Windows.Forms.Design.ScrollableControlDesigner
    {

        private DesignerVerbCollection m_verbs = new DesignerVerbCollection();

        private ISelectionService m_SelectionService;
        private ManagedPanel HostControl
        {
            get { return (ManagedPanel)this.Control; }
        }

        public ISelectionService SelectionService
        {
            get
            {
                if (m_SelectionService == null)
                {
                    m_SelectionService = (ISelectionService)GetService(typeof(ISelectionService));
                }
                return m_SelectionService;
            }
        }

        public ManagedPanelDesigner()
            : base()
        {

            DesignerVerb verb1 = new DesignerVerb("Select PanelManager", OnSelectManager);
            m_verbs.Add(verb1);

        }

        private void OnSelectManager(object sender, EventArgs e)
        {
            if ((this.HostControl.Parent != null))
            {
                this.SelectionService.SetSelectedComponents(new Component[] { this.HostControl.Parent });
            }
        }

        public override System.Windows.Forms.Design.SelectionRules SelectionRules
        {
            get { return System.Windows.Forms.Design.SelectionRules.Visible; }
        }

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
                penColor = System.Drawing.Color.White;
            }
            Pen dashedPen = new Pen(penColor);
            Rectangle borderRectangle = this.Control.ClientRectangle;
            borderRectangle.Width -= 1;
            borderRectangle.Height -= 1;
            dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pe.Graphics.DrawRectangle(dashedPen, borderRectangle);
            dashedPen.Dispose();
        }

        public override System.ComponentModel.Design.DesignerVerbCollection Verbs
        {
            get { return m_verbs; }
        }

        protected override void PostFilterProperties(System.Collections.IDictionary properties)
        {
            properties.Remove("Anchor");
            properties.Remove("TabStop");
            properties.Remove("TabIndex");
            base.PostFilterProperties(properties);
        }

        #pragma warning disable
        public override void OnSetComponentDefaults()
        {
            base.OnSetComponentDefaults();
            this.Control.Visible = true;
        }

    }
}
