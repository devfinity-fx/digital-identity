using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using SwingWERX.Extensions;

namespace SwingWERX.Controls
{
    public class FancyPanel : ContainerControl
    {
        public FancyPanel()
        {
            InitializeStyles();
            InitializePanel();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            int tmpShadowOffSet = Math.Min(Math.Min(_shadowOffSet, this.Width - 2), this.Height - 2);
            int tmpSoundCornerRadius = Math.Min(Math.Min(_roundCornerRadius, this.Width - 2), this.Height - 2);
            if (this.Width > 1 && this.Height > 1)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(0, 0, this.Width - tmpShadowOffSet - 1, this.Height - tmpShadowOffSet - 1);
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
                LinearGradientBrush brush = new LinearGradientBrush(rect,
                    this._gradientStartColor,
                    this._gradientEndColor,
                    _LinearGradientMode);
                e.Graphics.FillPath(brush, graphPath);
                e.Graphics.DrawPath(new Pen(Color.FromArgb(180, this._borderColor), _borderWidth), graphPath);
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

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override AnchorStyles Anchor
        {
            get
            {
                return AnchorStyles.Left;
            }
        }

        /// <summary>This method will initialize the CollapsePanel control.</summary>
        private void InitializePanel()
        {
            components = new System.ComponentModel.Container();
            this.Resize += new EventHandler(Panel_Resize);
            this.Name = "CollapsablePanel";
            this.Size = new System.Drawing.Size(250, 200);
            this.Anchor = AnchorStyles.Left;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            Controls.Add(e.Control);
            base.OnControlAdded(e);
        }
        

        /// <summary>This method fires when the CollapsePanel resize event occurs.</summary>
        /// <param name="sender">The object the sent the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Panel_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }


        #region Public Fields

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

        private LinearGradientMode _LinearGradientMode = LinearGradientMode.ForwardDiagonal;
        [PropertyTab("GradientMode")]
        [DisplayName("GradientMode")]
        [Description("The pattern of the gradient.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(LinearGradientMode.ForwardDiagonal)]
        public LinearGradientMode GradientMode
        {
            get { return _LinearGradientMode; }
            set { _LinearGradientMode = value; }
        }
        #endregion


        private System.ComponentModel.IContainer components = null;
    }
}
