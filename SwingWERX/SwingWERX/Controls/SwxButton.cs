using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SwingWERX.Controls
{
    [DefaultEvent("Click")]
    public partial class SwxButton 
        : Button
    {
        public SwxButton()
        {
            InitializeComponent();
            IsPainted = false;
            OriginalForeColor = ForeColor;
            OriginalImage = Image;
            Text = "swxButton";
            this.BackColor = Color.FromKnownColor(KnownColor.Control);
        }
        
        private bool _Checked = false;
        [PropertyTab("Checked")]
        [DisplayName("Checked")]
        [Description("Indicates whether the component is in the checked state.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(false)]
        public bool Checked
        {
            get { return _Checked; }
            set
            {
                if (value)
                {
                    this.ForeColor = ContrastColor(ColorMotif);
                    BackColor = ColorMotif;
                    this.FlatAppearance.BorderSize = 0;
                }
                else
                {
                    this.ForeColor = SelectedColor;
                    BackColor = DefaultBackgroundColor;
                    this.FlatAppearance.BorderSize = 1;
                }

                _Checked = value; 
            }
        }

        //[Browsable(false)]
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //public override String Text
        //{
        //    get { return ""; }
        //    set { base.Text = ""; }
        //}


        private String _text = "swxButton";
        [PropertyTab("DisplayText")]
        [DisplayName("DisplayText")]
        [Description("Text to be displayed.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue("swxButton")]
        public String DisplayText
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                Refresh();
            }
        }

        private bool _showHighlightColor = false;
        [PropertyTab("ShowHighlightColor")]
        [DisplayName("ShowHighlightColor")]
        [Description("Indicates whether the highlight color should be shown.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(false)]
        public bool ShowHighlightColor
        {
            get
            {
                return _showHighlightColor;
            }
            set
            {
                _showHighlightColor = value;
                Refresh();
            }
        }


        private SwxButtonBehavior _ButtonBehavior = SwxButtonBehavior.Normal;
        [PropertyTab("ButtonBehavior")]
        [DisplayName("ButtonBehavior")]
        [Description("The button behavior.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(SwxButtonBehavior.Normal)]
        public SwxButtonBehavior ButtonBehavior
        {
            get { return _ButtonBehavior; }
            set { ButtonBehavior = value; }
        }

        private Color OriginalForeColor { get; set;}

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            Image = PressedImage;
            if (mevent.Button != System.Windows.Forms.MouseButtons.Right)
            {
                this.ForeColor = ContrastColor(ColorMotif);
                base.OnMouseDown(mevent);
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            Image = OriginalImage;
            this.ForeColor = SelectedColor;
            base.OnMouseUp(mevent);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            IsMouseOver = true;

            this.FlatAppearance.BorderSize = ShowHighlightColor?1:2;
            if (FlatAppearance.BorderColor == Color.FromArgb(172, 172, 172))
            {
                this.FlatAppearance.BorderColor = ColorMotif;
            }

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            IsMouseOver = false;
            this.FlatAppearance.BorderSize = 1;
            //this.Enabled = false;
            //this.Enabled = true;
            this.FlatAppearance.BorderColor = _borderColor;
            this.ForeColor = SelectedColor;
            base.OnMouseLeave(e);
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!IsPainted)
            {
                this.FlatAppearance.MouseDownBackColor = ColorMotif;
                this.FlatAppearance.BorderColor = _borderColor;
                this.FlatAppearance.BorderSize = 1;
                this.FlatAppearance.CheckedBackColor = ColorMotif;

                IsPainted = true;
            }

            StringFormat sFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);

            Brush brush = new SolidBrush(base.ForeColor);
            Graphics g = e.Graphics;
            //g.DrawString(DisplayText, base.Font, brush, rect, sFormat);

            if (ShowHighlightColor)
            {
                g.FillRectangle(new SolidBrush(this.ColorMotif), new Rectangle(0, this.Height - 4, this.Width, 4));
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(DefaultBackgroundColor), this.ClientRectangle);
        }


        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.ForeColor = OriginalForeColor;
            }
            base.OnMouseClick(e);
        }

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                if (!IsOriginalColorSet)
                {
                    OriginalForeColor = base.ForeColor;
                    IsOriginalColorSet = true;
                }

                if (value == Color.FromKnownColor(KnownColor.ControlText) && OriginalForeColor != Color.FromKnownColor(KnownColor.ControlText))
                {
                    base.ForeColor = OriginalForeColor;
                    Console.WriteLine(OriginalForeColor);
                }
                else
                {
                    if (SelectedColor == Color.Empty)
                    {
                        base.ForeColor = value;
                        SelectedColor = base.ForeColor;
                        return;
                    }
                    else
                    {
                        base.ForeColor = value;
                    }
                }
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
        }

        private bool IsPainted { get; set; }
        private bool IsFontSet { get; set; }
        private bool IsPainting { get; set; }
        private bool IsMouseOver { get; set; }
        private bool IsOriginalColorSet { get; set; }

        private Image OriginalImage { get; set; }

        private Color SelectedColor { get; set; }

        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }

        public override void NotifyDefault(bool value)
        {
        }

        private Color ContrastColor(Color color)
        {
            double a = 1 - (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;
            int d = a < 0.2 ? 0 : 255; 
            return d == 0 ? OriginalForeColor : Color.White;
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new FlatStyle FlatStyle
        {
            get { return base.FlatStyle; }
            set { base.FlatStyle = value; }
        } 

        [PropertyTab("PressedImage")]
        [DisplayName("PressedImage")]
        [Browsable(true)]
        [Description("The image to be displayed when being pressed.")]
        [Category("Appearance")]
        public Image PressedImage
        {
            get
            {
                return _imageOnPress;
            }
            set
            {
                _imageOnPress = value;
            }
        }

        private Image _imageOnPress;

        private Color _borderColor = Color.FromArgb(172, 172, 172);
        [PropertyTab("BorderColor")]
        [DisplayName("BorderColor")]
        [Browsable(true)]
        [Description("The border color for the SwingWERX Button.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "172, 172, 172")]
        public Color BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
            }
        }

        private Color _motif = Color.DodgerBlue;
        [PropertyTab("ColorMotif")]
        [DisplayName("ColorMotif")]
        [Browsable(true)]
        [Description("The color motif for the SwingWERX Button.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "DodgerBlue")]
        public Color ColorMotif
        {
            get
            {
                return _motif;
            }
            set
            {
                _motif = value;
            }
        }

        private Color _dbg = Color.FromKnownColor(KnownColor.Control);
        [PropertyTab("DefaultBackgroundColor")]
        [DisplayName("DefaultBackgroundColor")]
        [Browsable(true)]
        [Description("The default bg color for the SwingWERX Button.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "Control")]
        public Color DefaultBackgroundColor
        {
            get
            {
                return _dbg;
            }
            set
            {
                _dbg = value;
            }
        }


        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color BackColor
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
    }

    public enum SwxButtonBehavior
    {
        Normal = 0,
        Toggle = 1
    }
}
