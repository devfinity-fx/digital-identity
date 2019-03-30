using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

using SwingWERX.Designers;
namespace SwingWERX.Controls
{
    [Designer(typeof(XButtonDesigner))]
    public class XButton : Control
    {
        public XButton()
            : base()
        {

        }

        #region Overrides

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        protected override Size DefaultSize
        {
            get
            {
                return new Size(64,64);
            }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override Size MinimumSize
        {
            get
            {
                return GetMinimumSize(ButtonSize);
            }
        }
        public override Size MaximumSize
        {
            get
            {
                return GetMaximumSize(ButtonSize);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (base.Size != base.MaximumSize) base.Size = GetMaximumSize(ButtonSize);

            ButtonState = SwingWERX.Controls.ButtonState.Expanded;

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (base.Size != base.MinimumSize) base.Size = GetMinimumSize(ButtonSize);

            ButtonState = SwingWERX.Controls.ButtonState.Collapsed;

            base.OnMouseLeave(e);
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            Size imgRectSz = GetMinimumSize(_size);
            Size txtRectSz = GetMaximumSize(_size);

            Rectangle imgRect = new Rectangle(new Point(0, 0), imgRectSz);
            Rectangle txtRect = new Rectangle(new Point(imgRectSz.Width, 0), new Size(txtRectSz.Width - imgRectSz.Width, txtRectSz.Height));

            //Console.WriteLine("ImgR: {0}\nTxtR:{1}", imgRect, txtRect);


            Pen dashedPen = new Pen(SystemColors.ActiveBorder);

            imgRect.Width -= 1;
            imgRect.Height -= 1;
            dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            e.Graphics.DrawRectangle(dashedPen, imgRect);

            txtRect.Width -= 1;
            txtRect.Height -= 1;
            dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            e.Graphics.DrawRectangle(dashedPen, txtRect);

            dashedPen.Dispose();

            e.Graphics.DrawImageUnscaled(_image, SwingWERX.Utils.Utils.CenterImage(_image, imgRect));

            StringFormat sFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            e.Graphics.DrawString(_text, this.Font, new SolidBrush(this.ForeColor), txtRect, sFormat);

            base.OnPaint(e);

            StringAlignment sa = sFormat.Alignment==StringAlignment.Center?StringAlignment.Center:sFormat.Alignment==StringAlignment.Far?StringAlignment.Far:StringAlignment.Near;
        }

        protected override void OnCreateControl()
        {
            BringToFront();
            base.OnCreateControl();
        }
        #endregion


        #region Methods

        private Size GetMinimumSize(ButtonSize size)
        {
            switch(size)
            {
                case ButtonSize.Small: return new Size(48, 48);
                case ButtonSize.Large: return new Size(80, 80);
            }
            return new Size(64, 64);
        }

        private Size GetMaximumSize(ButtonSize size)
        {
            switch (size)
            {
                case ButtonSize.Small: return Orientation == Orientation.Horizontal ? new Size(48, 48 * 3) : new Size(48 * 3, 48);
                case ButtonSize.Large: return Orientation == Orientation.Horizontal ? new Size(80, 80 * 3) : new Size(80 * 3, 80);
            }
            return Orientation == Orientation.Vertical ? new Size(64, 64 * 3) : new Size(64 * 3, 64);
        }


        #endregion


        #region Public Props
        private void shit()
        {

        }
            
        private Font _font = new Font("Segoe UI", 12, FontStyle.Regular);
        [DefaultValue(typeof(Font), "Segoe UI, 12pt, style=Regular")]
        public override Font Font
        {
            get { return _font; }
            set { _font = value; }
        }

        private ButtonSize _size = ButtonSize.Default;
        [PropertyTab("ButtonSize")]
        [DisplayName("ButtonSize")]
        [Description("The appearance size of the button.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(ButtonSize.Default)]
        public ButtonSize ButtonSize
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
                base.Size = GetMinimumSize(_size);
            }
        }


        private String _text = "xButton";
        [PropertyTab("Text")]
        [DisplayName("Text")]
        [Description("The text displayed by the button.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue("xButton")]
        public override String Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private Orientation _orientation = Orientation.Horizontal;
        [PropertyTab("Orientation")]
        [DisplayName("Orientation")]
        [Description("The orientation of the button.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(Orientation.Horizontal)]
        public Orientation Orientation
        {
            get { return _orientation; }
            set { _orientation = value; }
        }

        private ButtonState _state = ButtonState.Collapsed;
        [PropertyTab("ButtonState")]
        [DisplayName("ButtonState")]
        [Description("The ButtonState of the button.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(ButtonState.Collapsed)]
        public ButtonState ButtonState
        {
            get { return _state; }
            set { _state = value; }
        }


        private Image _image = SwingWERX.Properties.Resources.error;
        [PropertyTab("Image")]
        [DisplayName("Image")]
        [Description("The image to be displayed.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue("SwingWERX.Properties.Resources.error")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; }
        }

        
        [Browsable(false)]
        public bool IsCollapsed
        {
            get { return ButtonState == ButtonState.Collapsed; }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override Image BackgroundImage { get { return base.BackgroundImage; } }
        #endregion
    }

    public enum ButtonSize
    {
        Small = 0,
        Default = 1,
        Large = 2
    }

    public enum ButtonState
    {
        Collapsed = 0,
        Expanded = 1
    }
}
