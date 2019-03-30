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
    public class ManagedPanelCollectionEditor : System.ComponentModel.Design.CollectionEditor
    {

        public ManagedPanelCollectionEditor(Type type)
            : base(type)
        {
        }

        protected override System.Type CreateCollectionItemType()
        {
            return typeof(ManagedPanel);
        }

    }
}
