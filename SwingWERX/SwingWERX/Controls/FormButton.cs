using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SwingWERX.Designers;

namespace SwingWERX.Controls
{
    [Designer(typeof(FormButtonDesigner))]
    public partial class FormButton : Button
    {
        public FormButton()
        {
            InitializeComponent();
        }

        public FormButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            //Brush brush = new SolidBrush(Color.FromArgb(0, 122, 204)); // color blue?
            Brush brush = IsHovered?new SolidBrush(IconHoveredColor):new SolidBrush(IconDefaultColor); // color blue?
            Pen pen2 = new Pen(brush, 2);
            Pen pen1 = new Pen(brush, 1);

            switch (Type)
            {
                case ButtonType.QUESTION:
                    StringFormat sFormat = new StringFormat()
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    };
                    Rectangle rect = new Rectangle(0, 0, 32, 26);
                    Font f;
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.DrawString("?", f = new Font("Segoe UI", 13, FontStyle.Bold), brush, 16, (SwingWERX.Utils.Utils.GetFontPixels(f) / 2) + 3, sFormat);
                    break;
                case ButtonType.MAXIMIZE:
                    Rectangle rect_max = new Rectangle(12, 9, 9, 9);
                    g.DrawRectangle(pen1, rect_max);
                    g.DrawLine(pen1, 12, 10, 20, 10);
                    break;
                case ButtonType.MINIMIZE:
                    Rectangle rect_min = new Rectangle(11, 15, 9, 3);
                    g.DrawRectangle(pen1, rect_min);
                    g.FillRectangle(brush, rect_min);
                    break;
                case ButtonType.RESTORE:
                    Point[] points1 = { new Point(14, 11), new Point(14, 9), new Point(20, 9), new Point(20, 15), new Point(17, 15), new Point(17, 12), new Point(11, 12), new Point(11, 18), new Point(17, 18), new Point(17, 16) };
                    g.DrawLines(pen1, points1);
                    g.DrawLine(pen1, 14, 10, 20, 10);
                    g.DrawLine(pen1, 11, 13, 17, 13);
                    break;
                case ButtonType.CLOSE:
                    g.DrawLine(pen2, 12, 9, 20, 17);
                    g.DrawLine(pen2, 20, 9, 12, 17);

                    g.DrawLine(pen1, 12, 8, 12, 8);
                    g.DrawLine(pen1, 21, 17, 21, 17);
                    break;
            }
        }

        protected override void OnCreateControl()
        {
            base.FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0; // alisin to mamaya.
            IsHovered = false;
            BackColor = Enabled?base.BackColor:SystemColors.ControlLightLight;
            BackColor2 = base.BackColor;
            // last dapat tong size
            base.Size = new System.Drawing.Size(32,26);
            base.TextAlign = ContentAlignment.MiddleCenter;
        }
        private bool IsHovered { get; set; } // private lang.
        private Color BackColor2 { get; set; } // hm..

        [Browsable(false)]
        [DefaultValue("")]
        public new FlatButtonAppearance FlatAppearance
        {
            get { return base.FlatAppearance; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        public new ContentAlignment TextAlign
        {
            get { return System.Drawing.ContentAlignment.MiddleCenter; }
            set { base.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        public override string Text
        {
            get { return ""; }
        }

        [Browsable(false)]
        [DefaultValue(FlatStyle.Flat)]
        public new FlatStyle FlatStyle
        {
            get { return FlatStyle.Flat; }
        }


        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new Size Size
        {
            get { return new Size(32,26); }
            set { base.Size = new Size(32, 26); }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new Size MinimumSize
        {
            get { return new Size(32, 26); }
        }

        [Browsable(false)]
        public new Size MaximumSize
        {
            get { return new Size(32,26); }
        }

        private Color _HoverColor = Color.FromArgb(229,229,229);
        [PropertyTab("HoverColor")]
        [DisplayName("HoverColor")]
        [Description("The hover color of the button.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(typeof(Color), "229,229,229")]
        public Color HoverColor
        {
            get { return _HoverColor; }
            set { _HoverColor = value; }
        }

        private Color _PressedColor = Color.FromArgb(0, 122, 204);
        [PropertyTab("PressedColor")]
        [DisplayName("PressedColor")]
        [Description("The pressed color of the button.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(typeof(Color), "0, 122, 204")]
        public Color PressedColor
        {
            get { return _PressedColor; }
            set { _PressedColor = value; }
        }

        private ButtonType _ButtonType;
        [PropertyTab("ButtonType")]
        [DisplayName("ButtonType")]
        [Browsable(true)]
        [Description("The type of button to be displayed.")]
        [Category("Appearance")]
        public ButtonType Type
        {
            get { return _ButtonType; }
            set 
            {
                _ButtonType = value;
            }
        }

        private Color _IconHoveredColor = Color.FromArgb(0, 122, 204);
        [PropertyTab("IconHoveredColor")]
        [DisplayName("IconHoveredColor")]
        [Browsable(true)]
        [Description("The color of the button's icon when hovered.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "0, 122, 204")]
        public Color IconHoveredColor
        {
            get { return _IconHoveredColor; }
            set { _IconHoveredColor = value; }
        }

        private Color _IconPressedColor = Color.Snow;
        [PropertyTab("IconPressedColor")]
        [DisplayName("IconPressedColor")]
        [Browsable(true)]
        [Description("The color of the button's icon when pressed.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "255, 255, 250")]
        public Color IconPressedColor
        {
            get { return _IconPressedColor; }
            set { _IconPressedColor = value; }
        }


        private Color _IconDefaultColor = Color.FromArgb(30, 30, 30);
        [PropertyTab("IconDefaultColor")]
        [DisplayName("IconDefaultColor")]
        [Browsable(true)]
        [Description("The default face color of the button's icon.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "30,30,30")]
        public Color IconDefaultColor
        {
            get { return _IconDefaultColor; }
            set { _IconDefaultColor = value; }
        }

        protected override void OnMouseHover(EventArgs e)
        {
            //base.OnMouseHover(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            IsHovered = true;
            BackColor = HoverColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            IsHovered = false;
            BackColor = BackColor2;
        }

        public override void NotifyDefault(bool value)
        {
            base.NotifyDefault(false);
        }


        public void SetButtonType(ButtonType buttonType)
        {
            _ButtonType = buttonType;
            Refresh();
        }
    }

    public enum ButtonType
    {
        /// <summary>
        /// Question
        /// </summary>
        QUESTION,
        /// <summary>
        /// Minimize
        /// </summary>
        MINIMIZE,
        /// <summary>
        /// Maximize
        /// </summary>
        MAXIMIZE,
        /// <summary>
        /// Restore
        /// </summary>
        RESTORE,
        /// <summary>
        /// Close
        /// </summary>
        CLOSE
    }
}
