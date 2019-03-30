using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwingWERX.Designers
{
    public class FormButtonDesigner : System.Windows.Forms.Design.ParentControlDesigner
    {
        public override System.Windows.Forms.Design.SelectionRules SelectionRules
        {
            get
            {
                return System.Windows.Forms.Design.SelectionRules.Moveable | System.Windows.Forms.Design.SelectionRules.None;
            }
        }
    }
}
