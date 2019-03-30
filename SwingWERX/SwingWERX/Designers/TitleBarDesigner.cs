using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Design;

namespace SwingWERX.Designers
{
    public class TitleBarDesigner : System.Windows.Forms.Design.ParentControlDesigner
    {
        public override System.Windows.Forms.Design.SelectionRules SelectionRules
        {
            get
            {
                return System.Windows.Forms.Design.SelectionRules.None;
            }
        }

        private DesignerVerbCollection m_verbs = new DesignerVerbCollection();
        public override System.ComponentModel.Design.DesignerVerbCollection Verbs
        {
            get { return m_verbs; }
        }

    }

}
