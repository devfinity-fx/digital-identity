using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using SwingWERX.Controls;

namespace SwingWERX.Editors
{
    public class ToolTipEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(ITypeDescriptorContext context, System.IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService svc = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            SwxToolTip tip = value as SwxToolTip;
            if (svc != null && tip != null)
            {
                using (ToolTipEditorForm form = new ToolTipEditorForm())
                {
                    if (svc.ShowDialog(form) == DialogResult.OK)
                    {
                        MessageBox.Show(String.Format("tooltipeditor::{0}|{1}", form.HeaderText, form.ContentText));
                        tip.HeaderText = form.HeaderText; // update object
                        tip.ContentText = form.ContentText;
                    }
                }
            }
            return tip; // can also replace the wrapper object here
        }

    }
}
