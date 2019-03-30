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

}
namespace SwingWERX.Design
{

}

namespace SwingWERX.Editors
{

}

namespace SwingWERX.TypeConverters
{

    public class SelectedPanelConverter : ReferenceConverter
    {

        public SelectedPanelConverter()
            : base(typeof(Controls.ManagedPanel))
        {
        }

        protected override bool IsValueAllowed(System.ComponentModel.ITypeDescriptorContext context, object value)
        {
            if ((context != null))
            {
                Controls.PanelManager pm = (Controls.PanelManager)context.Instance;
                return pm.ManagedPanels.Contains((Controls.ManagedPanel)value);
            }
            return false;
        }

    }

}
