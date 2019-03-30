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
    public class PanelManagerDesigner : System.Windows.Forms.Design.ParentControlDesigner
    {

        private DesignerVerbCollection m_verbs = new DesignerVerbCollection();
        private IDesignerHost m_DesignerHost;

        private ISelectionService m_SelectionService;
        private PanelManager HostControl
        {
            get { return (PanelManager)this.Control; }
        }

        public PanelManagerDesigner()
            : base()
        {

            DesignerVerb verb1 = new DesignerVerb("Add MangedPanel", OnAddPanel);
            DesignerVerb verb2 = new DesignerVerb("Remove ManagedPanel", OnRemovePanel);
            m_verbs.AddRange(new DesignerVerb[] {
                    verb1,
                    verb2
                });

        }

        protected override void OnPaintAdornments(System.Windows.Forms.PaintEventArgs pe)
        {
            //Don't want DrawGrid Dots.
        }

        public override System.ComponentModel.Design.DesignerVerbCollection Verbs
        {
            get
            {
                if (m_verbs.Count == 2)
                {
                    if (HostControl.ManagedPanels.Count > 0)
                    {
                        m_verbs[1].Enabled = true;
                    }
                    else
                    {
                        m_verbs[1].Enabled = false;
                    }
                }
                return m_verbs;
            }
        }

        public IDesignerHost DesignerHost
        {
            get
            {
                if (m_DesignerHost == null)
                {
                    m_DesignerHost = (IDesignerHost)GetService(typeof(IDesignerHost));
                }
                return m_DesignerHost;
            }
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


        private void OnAddPanel(object sender, EventArgs e)
        {
            Control.ControlCollection oldManagedPanels = HostControl.Controls;

            RaiseComponentChanging(TypeDescriptor.GetProperties(HostControl)["ManagedPanels"]);

            ManagedPanel P = (ManagedPanel)DesignerHost.CreateComponent(typeof(ManagedPanel));
            P.Text = P.Name;
            HostControl.ManagedPanels.Add(P);

            RaiseComponentChanged(TypeDescriptor.GetProperties(HostControl)["ManagedPanels"], oldManagedPanels, HostControl.ManagedPanels);
            HostControl.SelectedPanel = P;

            SetVerbs();

        }


        private void OnRemovePanel(object sender, EventArgs e)
        {
            Control.ControlCollection oldManagedPanels = HostControl.Controls;

            if (HostControl.SelectedIndex < 0)
                return;

            RaiseComponentChanging(TypeDescriptor.GetProperties(HostControl)["TabPages"]);

            DesignerHost.DestroyComponent((ManagedPanel)HostControl.ManagedPanels[HostControl.SelectedIndex]);

            RaiseComponentChanged(TypeDescriptor.GetProperties(HostControl)["ManagedPanels"], oldManagedPanels, HostControl.ManagedPanels);

            SelectionService.SetSelectedComponents(new IComponent[] { HostControl }, SelectionTypes.Normal);

            SetVerbs();
        }


        private void SetVerbs()
        {
            switch (HostControl.ManagedPanels.Count)
            {
                case 0:
                    Verbs[1].Enabled = false;
                    break;
                case 1:
                    Verbs[1].Enabled = true;
                    break;
            }

        }

        protected override void PostFilterProperties(System.Collections.IDictionary properties)
        {
            properties.Remove("AutoScroll");
            properties.Remove("AutoScrollMargin");
            properties.Remove("AutoScrollMinSize");
            properties.Remove("Text");
            base.PostFilterProperties(properties);
        }

        public override void OnSetComponentDefaults()
        {
            HostControl.ManagedPanels.Add((ManagedPanel)DesignerHost.CreateComponent(typeof(ManagedPanel)));
            HostControl.ManagedPanels.Add((ManagedPanel)DesignerHost.CreateComponent(typeof(ManagedPanel)));
            PanelManager pm = (PanelManager)this.Control;
            pm.ManagedPanels[0].Text = pm.ManagedPanels[0].Name;
            pm.ManagedPanels[1].Text = pm.ManagedPanels[1].Name;
            HostControl.SelectedIndex = 0;
        }

    }
}
