using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SwingWERX.Controls;

namespace test
{
    public partial class Form1 : Form
    {
        private ColorChooser colorChooser;
        public Form1()
        {
            InitializeComponent();

            colorChooser = new ColorChooser();
            colorChooser.SelectedColorChanged += ColorChooser_SelectedColorChanged;
            Color c = Color.FromName("ActiveBorder");
            Console.WriteLine(c.IsKnownColor);
            Console.WriteLine(c.IsNamedColor);
            Console.WriteLine(c.IsSystemColor);
        }

        private void ColorChooser_SelectedColorChanged(object sender, EventArgs e)
        {
            ColorChooser chooser = (ColorChooser)sender;
            dropDownControl1.CloseDropDown();
            panel1.BackColor = chooser.SelectedColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dropDownControl1.InitializeDropDown(colorChooser);
        }

    }
}
