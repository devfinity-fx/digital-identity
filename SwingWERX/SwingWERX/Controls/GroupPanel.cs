using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Linq;
using System.Text;
using System.Windows.Forms;

using SwingWERX.Utils;
using SwingWERX.Extensions;

namespace SwingWERX.Controls
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public class GroupPanel : ContainerControl
    {
        public GroupPanel()
        {
            InitializeStyles();
            InitializePanel();
        }

        /// <summary>This method will initialize the controls custom styles.</summary>
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
            this.Name = "GroupPanel";
            this.Size = new System.Drawing.Size(250, 200);

        }

        /// <summary>This method fires when the CollapsePanel resize event occurs.</summary>
        /// <param name="sender">The object the sent the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Panel_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            PaintHeader(e.Graphics);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {

            base.OnPaintBackground(e);

            int tmpShadowOffSet = Math.Min(Math.Min(_shadowOffSet, this.Width - 2), this.Height - 2);
            int tmpSoundCornerRadius = Math.Min(Math.Min(_roundCornerRadius, this.Width - 2), this.Height - 2);
            if (this.Width > 1 && this.Height > 1)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(0, HeaderHeight - 5, this.Width - tmpShadowOffSet - 1, this.Height - HeaderHeight + 5 - tmpShadowOffSet - 1);
                Rectangle rectShadow = new Rectangle(tmpShadowOffSet, tmpShadowOffSet, this.Width - tmpShadowOffSet - 1, this.Height - tmpShadowOffSet - 1);

                GraphicsPath graphPathShadow = GraphicsExtension.GetRoundPath(rectShadow, tmpSoundCornerRadius);
                GraphicsPath graphPath = GraphicsExtension.GetRoundPath(rect, tmpSoundCornerRadius);

                if (tmpSoundCornerRadius > 0)
                {
                    using (PathGradientBrush gBrush = new PathGradientBrush(graphPathShadow))
                    {
                        gBrush.WrapMode = WrapMode.Clamp;
                        ColorBlend colorBlend = new ColorBlend(3);
                        colorBlend.Colors = new Color[]{Color.Transparent, 
                                                   Color.FromArgb(180, Color.DimGray), 
                                                   Color.FromArgb(180, Color.DimGray)};

                        colorBlend.Positions = new float[] { 0f, .1f, 1f };

                        gBrush.InterpolationColors = colorBlend;
                        e.Graphics.FillPath(gBrush, graphPathShadow);
                    }
                }

                // Draw backgroup
                Brush brush = new LinearGradientBrush(rect,
                    this._gradientStartColor,
                    this._gradientEndColor,
                    LinearGradientMode.BackwardDiagonal);
                e.Graphics.FillPath(brush, graphPath);
                e.Graphics.DrawPath(new Pen(Color.FromArgb(180, this._borderColor), _borderWidth), graphPath);
            }
        }
        private void PaintHeader(Graphics g)
        {
            if (graphics == null) graphics = g;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            StringFormat sFormat = new StringFormat()
            {
                Alignment = Utils.Utils.TA2SA(_TextAlignment),
                LineAlignment = StringAlignment.Center
            };

            Rectangle strRect = new Rectangle();

            int FontPx = Utils.Utils.GetFontPixels(HeaderFont);

            int tmpShadowOffSet = Math.Min(Math.Min(_shadowOffSet, this.Width - 2), this.Height - 2);
            int tmpSoundCornerRadius = Math.Min(Math.Min(_roundCornerRadius, this.Width - 2), this.Height - 2);

            //Rectangle rect = headerRect = new Rectangle(0, 0, this.Width, HeaderHeight = HeaderHeight < FontPx ? FontPx : HeaderHeight);
            Rectangle rect = headerRect = new Rectangle(0, 0, this.Width - tmpShadowOffSet - 1, HeaderHeight = HeaderHeight < FontPx ? FontPx : HeaderHeight);
            
            
            switch(_TextAlignment)
            {
                case TextAlignment.Right:strRect = new Rectangle(0, 0, this.Width - tmpShadowOffSet - 1 - 10, HeaderHeight = HeaderHeight < FontPx ? FontPx : HeaderHeight); break;
                case TextAlignment.Center: strRect = rect; break;
                case TextAlignment.Left: strRect = new Rectangle(10, 0, this.Width - tmpShadowOffSet - 1, HeaderHeight = HeaderHeight < FontPx ? FontPx : HeaderHeight); break;
            }


            Brush brush = new SolidBrush(_HeaderColor);
            g.FillRoundedRectangle(brush, rect, HeaderCornerRadius > (HeaderHeight / 2) - 1 ? (HeaderHeight / 2) - 1 : HeaderCornerRadius, RectangleEdgeFilter.TopLeft | RectangleEdgeFilter.TopRight);

            g.DrawString(this.Text, HeaderFont, new SolidBrush(Color.White), strRect, sFormat);
            Point imgLoc = imagePt = new Point(this.Width - 16 - 10, (((HeaderHeight / 2) - (16 / 2))) + 1);
            Rectangle imgRect = imageRect = new Rectangle(imgLoc, new Size(16, 16));

            //g.DrawLine(new Pen(new SolidBrush(SystemColors.ActiveBorder)), 0, HeaderHeight, 0, this.Height);
            //g.DrawLine(new Pen(new SolidBrush(SystemColors.ActiveBorder)), 0, this.Height - 1, this.Width, this.Height - 1);
            //g.DrawLine(new Pen(new SolidBrush(SystemColors.ActiveBorder)), this.Width - 1, this.Height - 1, this.Width - 1, HeaderHeight);

            if (region == null) region = new Region(rect);
        }


        #region Public Fields / Properties
        private TextAlignment _TextAlignment = TextAlignment.Center;
        [PropertyTab("TextAlignment")]
        [DisplayName("TextAlignment")]
        [Description("The alignment of the header text.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(TextAlignment.Center)]
        public TextAlignment TextAlignment
        {
            get { return _TextAlignment; }
            set { _TextAlignment = value; }
        }

        private Font _HeaderFont = new Font("Segoe UI", 9.75f, FontStyle.Regular);
        [PropertyTab("HeaderFont")]
        [DisplayName("HeaderFont")]
        [Description("The font to be used on the header text.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(typeof(Font), "Segoe UI, 9.75pt, style=Regular")]
        public Font HeaderFont
        {
            get { return _HeaderFont; }
            set { _HeaderFont = value; }
        }

        private int _HeaderHeight = 27;
        [PropertyTab("HeaderHeight")]
        [DisplayName("HeaderHeight")]
        [Description("The height of the header panel.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(27)]
        public int HeaderHeight
        {
            get { return _HeaderHeight; }
            set { _HeaderHeight = value; }
        }

        private int _HeaderCornerRadius = 10;
        [PropertyTab("HeaderCornerRadius")]
        [DisplayName("HeaderCornerRadius")]
        [Description("The radius of the curve on the panel's corner.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(10)]
        public int HeaderCornerRadius
        {
            get { return _HeaderCornerRadius; }
            set { _HeaderCornerRadius = value; }
        }

        private Color _HeaderColor = Color.DarkSlateGray;
        [PropertyTab("HeaderColor")]
        [DisplayName("HeaderColor")]
        [Description("The header panel's color.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue("Color.DarkSlateGray")]
        public Color HeaderColor
        {
            get { return _HeaderColor; }
            set { _HeaderColor = value; }
        }

        private int _borderWidth = 1;
        [PropertyTab("BorderWidth")]
        [DisplayName("BorderWidth")]
        [Description("The border width.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(1)]
        public int BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; Invalidate(); }
        }

        private int _shadowOffSet = 5;
        [PropertyTab("ShadowOffSet")]
        [DisplayName("ShadowOffSet")]
        [Description("The offset of the shadow from the form border.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(5)]
        public int ShadowOffSet
        {
            get
            {
                return _shadowOffSet;
            }
            set { _shadowOffSet = Math.Abs(value); Invalidate(); }
        }

        private int _roundCornerRadius = 4;
        [PropertyTab("RoundCornerRadius")]
        [DisplayName("RoundCornerRadius")]
        [Description("The radius of rounded corners.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(4)]
        public int RoundCornerRadius
        {
            get { return _roundCornerRadius; }
            set { _roundCornerRadius = Math.Abs(value); Invalidate(); }
        }

        private Color _borderColor = Color.Gray;
        [PropertyTab("BorderColor")]
        [DisplayName("BorderColor")]
        [Description("The color of the border.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue("Color.Gray")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        private Color _gradientStartColor = Color.White;
        [PropertyTab("GradientStartColor")]
        [DisplayName("GradientStartColor")]
        [Description("The gradient offset color of the panel's background color.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue("Color.White")]
        public Color GradientStartColor
        {
            get { return _gradientStartColor; }
            set { _gradientStartColor = value; Invalidate(); }
        }

        private Color _gradientEndColor = Color.Gray;
        [PropertyTab("GradientEndColor")]
        [DisplayName("GradientEndColor")]
        [Description("The gradient end color of the panel's background color.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue("Color.Gray")]
        public Color GradientEndColor
        {
            get { return _gradientEndColor; }
            set { _gradientEndColor = value; Invalidate(); }
        }

        #endregion

        #region Private Fields
        private System.ComponentModel.IContainer components = null;
        private System.Drawing.Region region;
        private System.Drawing.Graphics graphics;
        private System.Drawing.Rectangle headerRect, imageRect;
        private System.Drawing.Point imagePt;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        
        #endregion

    }
}
