using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace SwingWERX.Controls
{
    public class DockButton : Label
    {
        public DockButton()
        {
            this.Size = new Size(42, 54);
            //this.MinimumSize = new Size(42, 54);
            //this.MaximumSize = new Size(42, 54);
            this.ImageAlign = ContentAlignment.TopCenter;
            this.TextAlign = ContentAlignment.BottomCenter;
            this.BackColor = Color.FromKnownColor(KnownColor.Transparent);

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Size szImgRect = new Size(Width, Height);

            Rectangle imgRect = new Rectangle(new Point(0, 0), szImgRect);

            Graphics g = e.Graphics;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (Image != null)
            {
                g.DrawImage(Image, (Width / 2 - ImageSize.Width / 2), (szImgRect.Height / 2 - ImageSize.Height / 2), ImageSize.Width, ImageSize.Height);
            }
                
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            BackColor = HoverColor;
            ForeColor = HoverForeColor;
            Image = PressedImage;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            BackColor = Color.FromKnownColor(KnownColor.Transparent);
            ForeColor = DefaultFontColor;
            Image = DefaultImage;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            BackColor = PressedColor;
            Image = PressedImage;
            ForeColor = PressedFontColor;
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            BackColor = Color.FromKnownColor(KnownColor.Transparent);
            Image = DefaultImage;
            ForeColor = DefaultFontColor;
            base.OnMouseUp(e);
        }

        protected override Size DefaultSize
        {
            get
            {
                return new Size(42, 54);
            }
        }
        

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Font Font
        {
            get
            {
                return new Font("Segoe UI Semilight", 10, FontStyle.Regular, GraphicsUnit.Point);
            }
            set
            {
                base.Font = value;
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new virtual ContentAlignment TextAlign
        {
            get
            {
                return ContentAlignment.BottomCenter;
            }
            set
            {
                base.TextAlign = ContentAlignment.BottomCenter;
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new virtual Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new virtual ContentAlignment ImageAlign
        {
            get
            {
                return ContentAlignment.TopCenter;
            }
            set
            {
                base.ImageAlign = ContentAlignment.TopCenter;
            }
        }


        private Image _DefaultImage;
        [PropertyTab("DefaultImage")]
        [DisplayName("DefaultImage")]
        [Browsable(true)]
        [Description("Image to display.")]
        [Category("Appearance")]
        public Image DefaultImage
        {
            get
            {

                return _DefaultImage == null ? Image : _DefaultImage;
            }
            set
            {
                Image = _DefaultImage = value;

            }
        }

        private Image _PressedImage;
        [PropertyTab("PressedImage")]
        [DisplayName("PressedImage")]
        [Browsable(true)]
        [Description("Image to display when pressed.")]
        [Category("Appearance")]
        public Image PressedImage
        {
            get
            {

                return _PressedImage == null ? Image : _PressedImage;
            }
            set
            {
                _PressedImage = value;
            }
        }

        private Color _HoverColor = Color.FromKnownColor(KnownColor.LightSlateGray);
        [PropertyTab("HoverColor")]
        [DisplayName("HoverColor")]
        [Browsable(true)]
        [Description("Color when hovered.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "LightSlateGray")]
        public Color HoverColor
        {
            get
            {
                return _HoverColor;
            }
            set
            {
                _HoverColor = value;
            }
        }

        private Color _PressedColor = Color.FromKnownColor(KnownColor.Snow);
        [PropertyTab("PressedColor")]
        [DisplayName("PressedColor")]
        [Browsable(true)]
        [Description("Color when pressed.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "Snow")]
        public Color PressedColor
        {
            get
            {
                return _PressedColor;
            }
            set
            {
                _PressedColor = value;
            }
        }
        private Color _HoverForeColor = Color.FromKnownColor(KnownColor.LightSlateGray);
        [PropertyTab("HoverForeColor")]
        [DisplayName("HoverForeColor")]
        [Browsable(true)]
        [Description("ForeColor when hovered.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "LightSlateGray")]
        public Color HoverForeColor
        {
            get
            {
                return _HoverForeColor;
            }
            set
            {
                _HoverForeColor = value;
            }
        }

        private Color _PressedFontColor = Color.FromKnownColor(KnownColor.Snow);
        [PropertyTab("PressedFontColor")]
        [DisplayName("PressedFontColor")]
        [Browsable(true)]
        [Description("ForeColor when pressed.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "Snow")]
        public Color PressedFontColor
        {
            get
            {
                return _PressedFontColor;
            }
            set
            {
                _PressedFontColor = value;
            }
        }

        private Color _DefaultFontColor = Color.FromKnownColor(KnownColor.ControlText);
        [PropertyTab("DefaultFontColor")]
        [DisplayName("DefaultFontColor")]
        [Browsable(true)]
        [Description("ForeColor default.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "ControlText")]
        public Color DefaultFontColor
        {
            get
            {
                return _DefaultFontColor;
            }
            set
            {
                ForeColor = _DefaultFontColor = value;
            }
        }


        private Size _ImageSize = new Size(32, 32);
        [PropertyTab("ImageSize")]
        [DisplayName("ImageSize")]
        [Browsable(true)]
        [Description("Size of the Image.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Size), "32,32")]
        public Size ImageSize
        {
            get
            {
                return _ImageSize;
            }
            set
            {
                _ImageSize = value;
                Refresh();
            }
        }

    }
}
