using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SwingWERX.Controls
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip)]
    public partial class ToolStripBorderedButton : MyCustomToolStripControlHost
    {
        private static System.Drawing.Color borderColor;
        // Call the base constructor passing in a MaskedTextBox instance.
        public ToolStripBorderedButton() : base(CreateControlInstance()) { }

        public Button Button
        {
            get
            {
                return Control as Button;
            }
        }


        private static Control CreateControlInstance()
        {
            Button mtb = new Button();
            mtb.FlatStyle = FlatStyle.Flat;
            mtb.FlatAppearance.BorderColor = borderColor;
            mtb.FlatAppearance.BorderSize = 1;
            mtb.MinimumSize = new System.Drawing.Size(100, 16);
            return mtb;
        }

        public System.Drawing.Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }
    }

    public class MyCustomToolStripControlHost : ToolStripControlHost
    {
        public MyCustomToolStripControlHost()
            : base(new Control())
        {
        }
        public MyCustomToolStripControlHost(Control c)
            : base(c)
        {
        }
    }
}
