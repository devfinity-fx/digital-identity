using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;

namespace SwingWERX.Editors
{
    [ToolboxItem(false)]
    public partial class ToolTipEditorForm : Form 
    {
        public String HeaderText { get; set; }
        public String ContentText { get; set; }

        public ToolTipEditorForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.HeaderText = txtHeader.Text;
            this.ContentText = txtMessage.Text;
        }
    }
}
