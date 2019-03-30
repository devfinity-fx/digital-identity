using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace SwingWERX.Controls
{
    [DefaultEvent("Click")]
    [DesignTimeVisible(true)]
    public partial class FlatButton
        : Button
    {
        public FlatButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }


        private Keys shorcutKey;
        [Bindable(true)]
        [Browsable(true)]
        [Category("Appearance")]
        [Description("Shortcut Key.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DisplayName("ShortcutKey")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public Keys ShortcutKey
        {
            get
            {
                return shorcutKey;
            }
            set
            {
                shorcutKey = value;
            }
        }


    }
    
}
