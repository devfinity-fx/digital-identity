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
    [DefaultProperty("SelectedPanel"), DefaultEvent("SelectedIndexChanged"), Designer(typeof(PanelManagerDesigner))]
    public class PanelManager : System.Windows.Forms.Control
    {

        #region " Windows Form Designer generated code "

        public PanelManager()
            : base()
        {

            //This call is required by the Windows Form Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call

        }

        //UserControl1 overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if ((components != null))
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        //Required by the Windows Form Designer

        private System.ComponentModel.IContainer components;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        #endregion


        private ManagedPanel m_SelectedPanel;
        public event EventHandler SelectedIndexChanged;

        //ManagedPanels
        [Editor(typeof(ManagedPanelCollectionEditor), typeof(UITypeEditor))]
        public ControlCollection ManagedPanels
        {
            get { return base.Controls; }
        }

        //SelectedPanel
        [TypeConverter(typeof(TypeConverters.SelectedPanelConverter))]
        public ManagedPanel SelectedPanel
        {
            get { return m_SelectedPanel; }
            set
            {
                if (object.ReferenceEquals(m_SelectedPanel, value))
                    return;
                m_SelectedPanel = value;
                OnSelectedPanelChanged(EventArgs.Empty);
            }
        }

        //SelectedIndex
        [Browsable(false)]
        public Int32 SelectedIndex
        {
            get { return this.ManagedPanels.IndexOf((ManagedPanel)this.SelectedPanel); }
            set
            {
                if (value == -1)
                {
                    this.SelectedPanel = null;
                }
                else
                {
                    this.SelectedPanel = (ManagedPanel)this.ManagedPanels[value];
                }
            }
        }

        //DefaultSize
        protected override System.Drawing.Size DefaultSize
        {
            get { return new System.Drawing.Size(200, 100); }
        }
        readonly Microsoft.VisualBasic.CompilerServices.StaticLocalInitFlag static_OnSelectedPanelChanged_oldSelection_Init = new Microsoft.VisualBasic.CompilerServices.StaticLocalInitFlag();

        ManagedPanel static_OnSelectedPanelChanged_oldSelection;
        protected virtual void OnSelectedPanelChanged(EventArgs e)
        {
            lock (static_OnSelectedPanelChanged_oldSelection_Init)
            {
                try
                {
                    if (InitStaticVariableHelper(static_OnSelectedPanelChanged_oldSelection_Init))
                    {
                        static_OnSelectedPanelChanged_oldSelection = null;
                    }
                }
                finally
                {
                    static_OnSelectedPanelChanged_oldSelection_Init.State = 1;
                }
            }
            if ((static_OnSelectedPanelChanged_oldSelection != null))
            {
                static_OnSelectedPanelChanged_oldSelection.Visible = false;
            }
            if ((m_SelectedPanel != null))
            {
                ((ManagedPanel)m_SelectedPanel).Visible = true;
            }
            bool tabChanged = false;
            if (m_SelectedPanel == null)
            {
                tabChanged = (static_OnSelectedPanelChanged_oldSelection != null);
            }
            else
            {
                tabChanged = !(m_SelectedPanel.Equals(static_OnSelectedPanelChanged_oldSelection));
            }
            if (tabChanged & this.Created)
            {
                if (SelectedIndexChanged != null)
                {
                    SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
            static_OnSelectedPanelChanged_oldSelection = (ManagedPanel)m_SelectedPanel;
        }

        protected override void OnControlAdded(System.Windows.Forms.ControlEventArgs e)
        {
            if (!(e.Control is ManagedPanel))
            {
                throw new ArgumentException("Only Mangel.ManagedPanels can be added to a Mangel.PanelManger.");
            }
            if ((this.SelectedPanel != null))
            {
                ((ManagedPanel)this.SelectedPanel).Visible = false;
            }
            this.SelectedPanel = (ManagedPanel)e.Control;
            e.Control.Visible = true;
            base.OnControlAdded(e);
        }

        protected override void OnControlRemoved(System.Windows.Forms.ControlEventArgs e)
        {
            if (!(e.Control is ManagedPanel))
                return;
            if (this.ManagedPanels.Count > 0)
            {
                this.SelectedIndex = 0;
            }
            else
            {
                this.SelectedPanel = null;
            }
            base.OnControlRemoved(e);
        }
        static bool InitStaticVariableHelper(Microsoft.VisualBasic.CompilerServices.StaticLocalInitFlag flag)
        {
            if (flag.State == 0)
            {
                flag.State = 2;
                return true;
            }
            else if (flag.State == 2)
            {
                throw new Microsoft.VisualBasic.CompilerServices.IncompleteInitialization();
            }
            else
            {
                return false;
            }
        }

    }
}
