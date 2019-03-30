/* SwxPanel- [SwingWERX Panel]
 * Author name:           Aron Jhed Bautista Amiscosa
 * Current version:       1.0.0.4 (12b)
 * License information:   Microsoft Public License (Ms-PL) [http://www.opensource.org/licenses/ms-pl.html]
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using SwingWERX.Extensions;
using SwingWERX.Designers;

namespace SwingWERX.Controls
{
    [Designer(typeof(SwxPanelDesigner)), DefaultEvent("Paint")]
    public class SwxPanel : ContainerControl
    {
        public SwxPanel()
        {
            InitializeStyles();
            InitializePanel();
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultValue(typeof(Color),"255,255,255,255")]
        public override Color BackColor
        {
            get
            {
                return Color.Transparent;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (_borderWidth > 0)
            {
                using (Brush brush = new SolidBrush(_borderColor))
                {
                    using (Pen pen = new Pen(brush, _borderWidth))
                    {
                        Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
                        ControlPaint.DrawBorder(e.Graphics, rect,
                                          _borderColor, _borderWidth, PBS2BBS(_borderStyle),
                                          _borderColor, _borderWidth, PBS2BBS(_borderStyle),
                                          _borderColor, _borderWidth, PBS2BBS(_borderStyle),
                                          _borderColor, _borderWidth, PBS2BBS(_borderStyle));
                        
                    }
                }
            }
            else
            {
                base.OnPaint(e);
            }

            StringFormat cFormat = new StringFormat();
            Int32 lNum = (Int32)Math.Log((Double)this.TextAlign, 2);
            cFormat.LineAlignment = (StringAlignment)(lNum / 4);
            cFormat.Alignment = (StringAlignment)(lNum % 4);

            Brush wb = new SolidBrush(base.ForeColor);
            g.DrawString(this.Text, this.Font, wb, this.ClientRectangle, cFormat);
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Rectangle rect = this.ClientRectangle;
            using (Brush brush = new LinearGradientBrush(rect,
                this._gradientStart,
                this._gradientEnd,
                _gradientMode))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            if (BackgroundImage != null)
            {

            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Refresh();
            }
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
            components = new System.ComponentModel.Container();
            this.Resize += new EventHandler(Panel_Resize);
            this.Name = "CollapsablePanel";
            this.Size = new System.Drawing.Size(250, 200);

        }


        /// <summary>This method fires when the CollapsePanel resize event occurs.</summary>
        /// <param name="sender">The object the sent the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Panel_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private ContentAlignment _TextAlign = ContentAlignment.MiddleCenter;
        [PropertyTab("TextAlign")]
        [DisplayName("TextAlign")]
        [Description("The text alignment.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(ContentAlignment.MiddleCenter)]
        public ContentAlignment TextAlign
        {
            get { return _TextAlign; }
            set { _TextAlign = value; Refresh(); }
        }

        private int _borderWidth = 0;
        [PropertyTab("BorderWidth")]
        [DisplayName("BorderWidth")]
        [Description("The border width.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(0)]
        public int BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; Refresh(); }
        }

        private PanelBorderStyle _borderStyle = PanelBorderStyle.Solid;
        [PropertyTab("BorderStyle")]
        [DisplayName("BorderStyle")]
        [Description("The border style.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(PanelBorderStyle.Solid)]
        public PanelBorderStyle BorderStyle
        {
            get { return _borderStyle; }
            set { _borderStyle = value; Refresh(); }
        }


        private Color _borderColor = Color.Gray;
        [PropertyTab("BorderColor")]
        [DisplayName("BorderColor")]
        [Description("The border color.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(typeof(Color), "Gray")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        private Color _gradientStart = Color.White;
        [PropertyTab("GradientColor1")]
        [DisplayName("GradientColor1")]
        [Description("The starting color of the gradient.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(typeof(Color), "White")]
        public Color GradientColor1
        {
            get { return _gradientStart; }
            set { _gradientStart = value; Refresh(); }
        }

        private Color _gradientEnd = Color.FromArgb(255, 255, 250);
        [PropertyTab("GradientColor2")]
        [DisplayName("GradientColor2")]
        [Description("The ending color of the gradient.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(typeof(Color), "255, 255, 250")]
        public Color GradientColor2
        {
            get { return _gradientEnd; }
            set { _gradientEnd = value; Refresh(); }
        }

        private LinearGradientMode _gradientMode = LinearGradientMode.ForwardDiagonal;
        [PropertyTab("GradientMode")]
        [DisplayName("GradientMode")]
        [Description("The gradient mode.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(LinearGradientMode.ForwardDiagonal)]
        public LinearGradientMode GradientMode
        {
            get { return _gradientMode; }
            set { _gradientMode = value; Refresh(); }
        }

        private System.ComponentModel.IContainer components = null;
        
        public static ButtonBorderStyle PBS2BBS(PanelBorderStyle style)
        {
            switch (style)
            {
                case PanelBorderStyle.Dashed: return ButtonBorderStyle.Dashed;
                case PanelBorderStyle.Dotted: return ButtonBorderStyle.Dotted;
                case PanelBorderStyle.Inset: return ButtonBorderStyle.Inset;
                case PanelBorderStyle.None: return ButtonBorderStyle.None;
                case PanelBorderStyle.Outset: return ButtonBorderStyle.Outset;
                case PanelBorderStyle.Solid: return ButtonBorderStyle.Solid;
            }
            return ButtonBorderStyle.None;
        }

        public class Design
        {
            private ButtonBorderStyle _style;
            public ButtonBorderStyle Style
            {
                get
                {
                    return _style;
                }
                set { _style = value; }
            }
        }
    }

    public enum PanelBorderStyle
    {
        None = ButtonBorderStyle.None,
        Solid = ButtonBorderStyle.Solid,
        Dashed = ButtonBorderStyle.Dashed,
        Dotted = ButtonBorderStyle.Dotted,
        Inset = ButtonBorderStyle.Inset,
        Outset = ButtonBorderStyle.Outset
    }
}
