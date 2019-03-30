using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using SwingWERX.Designers;

namespace SwingWERX.Controls
{
    [Designer(typeof(StripButtonDesigner))]
    public class StripButton : Label
    {
        public StripButton()
            : base()
        {
            Checked = false;
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
            Color bgColor = Checked ? PressedBackColor : BackColor;
            Brush br = new SolidBrush(bgColor);
            pevent.Graphics.FillRectangle(br, this.ClientRectangle);
        }

        private bool _UseCustomBackgroundColors = false;
        [PropertyTab("UseCustomBackgroundColors")]
        [DisplayName("UseCustomBackgroundColors")]
        [Browsable(true)]
        [Description("Whether to use custom background colors.")]
        [Category("Behavior")]
        [DefaultValue(typeof(bool), "false")]
        public bool UseCustomBackgroundColors
        {
            get
            {
                return _UseCustomBackgroundColors;
            }
            set
            {
                _UseCustomBackgroundColors = value;
                Refresh();
            }
        }



        private Color _HoverBackColor = Color.FromKnownColor(KnownColor.LightGray);
        [PropertyTab("HoverBackColor")]
        [DisplayName("HoverBackColor")]
        [Browsable(true)]
        [Description("BackColor when hovered.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "LightGray")]
        public Color HoverBackColor
        {
            get
            {
                return _HoverBackColor;
            }
            set
            {
                _HoverBackColor = value;
                Refresh();
            }
        }


        private Color _PressedBackColor = Color.FromArgb(60, 69, 79);
        [PropertyTab("PressedBackColor")]
        [DisplayName("PressedBackColor")]
        [Browsable(true)]
        [Description("BackColor when pressed.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "60, 69, 79")]
        public Color PressedBackColor
        {
            get
            {
                return _PressedBackColor;
            }
            set
            {
                _PressedBackColor = value;
                Refresh();
            }
        }

        private Color _HoverForeColor = Color.FromArgb(57,95,172);
        [PropertyTab("HoverForeColor")]
        [DisplayName("HoverForeColor")]
        [Browsable(true)]
        [Description("ForeColor when hovered.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "57,95,172")]
        public Color HoverForeColor
        {
            get
            {
                return _HoverForeColor;
            }
            set
            {
                _HoverForeColor = value;
                Refresh();
            }
        }

        private Color _PressedForeColor = Color.FromKnownColor(KnownColor.Snow);
        [PropertyTab("PressedForeColor")]
        [DisplayName("PressedForeColor")]
        [Browsable(true)]
        [Description("ForeColor when pressed.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "Snow")]
        public Color PressedForeColor
        {
            get
            {
                return _PressedForeColor;
            }
            set
            {
                _PressedForeColor = value;
                Refresh();
            }
        }

        private Color _DefaultForeColor = Color.FromKnownColor(KnownColor.ControlText);
        [PropertyTab("DefaultForeColor")]
        [DisplayName("DefaultForeColor")]
        [Browsable(true)]
        [Description("ForeColor default.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "ControlText")]
        public new Color DefaultForeColor
        {
            get
            {
                return _DefaultForeColor;
            }
            set
            {
                ForeColor = _DefaultForeColor = value;
                Refresh();
            }
        }


        private Color _DefaultBackColor = Color.FromKnownColor(KnownColor.Transparent);
        [PropertyTab("DefaultBackColor")]
        [DisplayName("DefaultBackColor")]
        [Browsable(true)]
        [Description("BackColor default.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "Transparent")]
        public new Color DefaultBackColor
        {
            get
            {
                return _DefaultBackColor;
            }
            set
            {
                ForeColor = _DefaultBackColor = value;
                Refresh();
            }
        }


        protected override void OnMouseEnter(EventArgs e)
        {
            if(!Checked)
            {
                ForeColor = HoverForeColor;
                BackColor = UseCustomBackgroundColors ? HoverBackColor : BackColor;
                Image = HoverImage;
            }
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (!Checked)
            {
                ForeColor = DefaultForeColor;
                BackColor = DefaultBackColor;
                Image = DefaultImage;
            }
            base.OnMouseLeave(e);
        }

        private bool _Checked = false;
        [PropertyTab("Checked")]
        [DisplayName("Checked")]
        [Browsable(true)]
        [Description("Whether the button state is checked.")]
        [Category("Behavior")]
        public bool Checked
        {
            get
            {
                return _Checked;
            }
            set
            {
                _Checked = value;
                UpdateUICheckState();
            }
        }

        private void UpdateUICheckState()
        {
            BackColor = UseCustomBackgroundColors ? (Checked ? PressedBackColor : DefaultBackColor) : DefaultBackColor;
            ForeColor = UseCustomBackgroundColors ? (Checked ? PressedForeColor : DefaultForeColor) : DefaultForeColor;
            Image = UseCustomBackgroundColors ? (Checked ? PressedImage : DefaultImage) : DefaultImage;
            Refresh();
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
                Refresh();
            }
        }

        private Image _HoverImage;
        [PropertyTab("HoverImage")]
        [DisplayName("HoverImage")]
        [Browsable(true)]
        [Description("Image to display when hovered.")]
        [Category("Appearance")]
        public Image HoverImage
        {
            get
            {

                return _HoverImage == null ? Image : _HoverImage;
            }
            set
            {
                _HoverImage = value;
                Refresh();
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
                Refresh();
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Size szImgRect = new Size(48, 42);
            Size szTxtRect = new Size(142, 42);

            Rectangle imgRect = new Rectangle(new Point(10, 0), szImgRect);
            Rectangle txtRect = new Rectangle(new Point(58, 0), szTxtRect);

            StringFormat sFormat = new StringFormat()
            {
                Alignment = _textAlignment == HorizontalAlignment.Center ? StringAlignment.Center : _textAlignment == HorizontalAlignment.Left ? StringAlignment.Near : StringAlignment.Far,
                LineAlignment = StringAlignment.Center
            };

            Graphics g = e.Graphics;
            g.DrawImage(_image, 10 + (48 / 2 - 26 / 2), (42 / 2 - 26 / 2), 26, 26);
            g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), txtRect, sFormat);

        }

        #region Overrides
        protected override Size DefaultSize
        {
            get
            {
                return new Size(200, 42);
            }
        }

        protected new Size Size
        {
            get
            {
                return new Size(200, 42);
            }
        }

        public override Size MaximumSize
        {
            get
            {
                return new Size(200, 42);
            }
        }

        public override Size MinimumSize
        {
            get
            {
                return new Size(200, 42);
            }
        }
        #endregion

        private Image _image = SwingWERX.Properties.Resources.blank;
        [PropertyTab("Image")]
        [DisplayName("Image")]
        [Description("The image of the button.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue("System.Drawing.Bitmap")]
        public new Image Image
        {
            get { return _image; }
            set { _image = value; Refresh(); }
        }

        private HorizontalAlignment _textAlignment = HorizontalAlignment.Left;
        [PropertyTab("TextAlignment")]
        [DisplayName("TextAlignment")]
        [Description("The alignment of text displayed by the control.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(HorizontalAlignment.Left)]
        public HorizontalAlignment TextAlignment
        {
            get { return _textAlignment; }
            set { _textAlignment = value; Refresh(); }
        }

        private String _toolTipHeader = "toolTipHeader";
        [PropertyTab("ToolTipHeader")]
        [DisplayName("ToolTipHeader")]
        [Description("The tooltip header text.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue("toolTipHeader")]
        public String ToolTipHeader
        {
            get
            {
                return _toolTipHeader;
            }
            set
            {
                _toolTipHeader = value;
                Refresh();
            }
        }

        private String _toolTipText = "toolTipText";
        [PropertyTab("ToolTipText")]
        [DisplayName("ToolTipText")]
        [Description("The tooltip content text.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue("toolTipText")]
        public String ToolTipText
        {
            get
            {
                return _toolTipText;
            }
            set
            {
                _toolTipText = value;
                Refresh();
            }
        }

        private Font _font = new Font("Segoe UI Light", 12, FontStyle.Regular);
        [DefaultValue(typeof(Font), "Segoe UI Light, 12pt, style=Regular")]
        public override Font Font
        {
            get
            {
                return _font;
            }
            set
            {
                _font = value;
                Refresh();
            }
        }

    }
    
}
