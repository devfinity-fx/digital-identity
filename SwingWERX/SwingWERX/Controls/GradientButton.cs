using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;

namespace SwingWERX.Controls
{
    [DefaultEvent("Click")]
    public class GradientButton : Label
    {
        public GradientButton()
        {
            InitializeStyles();
            InitializePanel();
            _hover = new HoveredColors() { HoveredColorStart = Color.DarkGray, HoveredColorEnd = Color.LightGray };
            _pressed = new PressedColors() { PressedColorStart = Color.DarkGray, PressedColorEnd = Color.Gray };
        }


        private void InitializeStyles()
        {
            //Set the control styles----------------------------------
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //--------------------------------------------------------
        }


        /// <summary>This method will initialize the CollapsePanel control.</summary>
        private void InitializePanel()
        {
            this.Resize += new EventHandler(Resize_Event);
            this.Name = "GradientButton";
            this.Size = new System.Drawing.Size(100, 25);
        }


        /// <summary>This method fires when the CollapsePanel resize event occurs.</summary>
        /// <param name="sender">The object the sent the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Resize_Event(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private HoveredColors _hover;
        [PropertyTab("HoveredColors")]
        [DisplayName("HoveredColors")]
        [Browsable(true)]
        [Description("Hover Color")]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public HoveredColors Hover
        {
            get
            {
                return _hover;
            }
            set
            {
                _hover = value;
            }
        }

        private PressedColors _pressed;
        [PropertyTab("PressedColors")]
        [DisplayName("PressedColors")]
        [Browsable(true)]
        [Description("Pressed Color")]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PressedColors Pressed
        {
            get
            {
                return _pressed;
            }
            set
            {
                _pressed = value;
            }
        }
    }

    public class HoveredColors
    {
        public Color HoveredColorStart { get; set; }
        public Color HoveredColorEnd { get; set; }
    }

    public class PressedColors
    {
        public Color PressedColorStart { get; set; }
        public Color PressedColorEnd { get; set; }
    }


}
