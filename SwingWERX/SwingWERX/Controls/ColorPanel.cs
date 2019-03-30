using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SwingWERX.Controls
{
    partial class ColorPanel : UserControl
    {

        private Color _selectedColor;
        public Color SelectedColor
        {
            get
            {
                return _selectedColor;
            }
            set
            {
                _selectedColor = value;
                OnSelectedColorChanged();
            }
        }


        public event System.EventHandler SelectedColorChanged;
        protected virtual void OnSelectedColorChanged()
        {
            if (SelectedColorChanged != null) SelectedColorChanged(this, EventArgs.Empty);
        }


        public ColorPanel()
        {
            InitializeComponent();

        }

        private void DoubleClick_Action(object sender, MouseEventArgs e)
        {
            ColorLabel label = (ColorLabel)sender;
            SelectedColor = label.BackColor;
        }
    }
}
