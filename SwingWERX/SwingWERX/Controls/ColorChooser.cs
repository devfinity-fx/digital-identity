using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace SwingWERX.Controls
{
    public partial class ColorChooser : UserControl
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


        [Description("Fired when SelectedColor is changed.")]
        public event System.EventHandler SelectedColorChanged;
        protected virtual void OnSelectedColorChanged()
        {
            if (SelectedColorChanged != null) SelectedColorChanged(this, EventArgs.Empty);
        }



        public ColorChooser()
        {
            InitializeComponent();

            foreach (PropertyInfo prop in typeof(SystemColors).GetProperties())
            {
                ColorListBoxItem item = new ColorListBoxItem();
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                {
                    item.Color = Color.FromName(prop.Name);
                    colorListBox1.Items.Add(item);
                }
            }

            var webColors =
              Enum.GetValues(typeof(KnownColor))
                .Cast<KnownColor>()
                .Where(k => k >= KnownColor.Transparent && k < KnownColor.ButtonFace) //Exclude system colors
                .Select(k => Color.FromKnownColor(k))
                .OrderBy(c => c.GetHue())
                    .ThenBy(c => c.GetSaturation())
                    .ThenBy(c => c.GetBrightness());


            List<Color> colors = webColors.ToList();

            colors.Remove(Color.Transparent);
            colors.Remove(Color.Black);
            colors.Remove(Color.White);

            colors.Insert(0, Color.Transparent);
            colors.Insert(1, Color.Black);
            colors.Insert(2, Color.White);

            foreach (Color c in colors)
            {
                ColorListBoxItem item = new ColorListBoxItem();
                item.Color = c;
                colorListBox2.Items.Add(item);
            }


            colorPanel1.SelectedColorChanged += ColorPanel1_SelectedColorChanged;
        }

        private void ColorPanel1_SelectedColorChanged(object sender, EventArgs e)
        {
            this.SelectedColor = colorPanel1.SelectedColor;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorListBox1.SelectedIndex = 0;
            colorListBox1.SelectedIndex = -1;
            colorListBox2.SelectedIndex = 0;
            colorListBox2.SelectedIndex = -1;
        }

        private void MouseDoubleClick_Action(object sender, MouseEventArgs e)
        {
            if (sender == colorListBox1)
            {
                ColorListBoxItem item = (ColorListBoxItem)colorListBox1.SelectedItem;
                SelectedColor = item.Color;
            }
            else if(sender == colorListBox2)
            {
                ColorListBoxItem item = (ColorListBoxItem)colorListBox2.SelectedItem;
                SelectedColor = item.Color;
            }
            else
            {
                SelectedColor = colorPanel1.SelectedColor;
            }
        }
    }
}
