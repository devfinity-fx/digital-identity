/* ButtonLabel - [Label used as Button]
 * Author name:           Aron Jhed Bautista Amiscosa
 * Current version:       1.0.0.4 (12b)
 * License information:   Microsoft Public License (Ms-PL) [http://www.opensource.org/licenses/ms-pl.html]
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace SwingWERX.Controls
{
    public class ButtonLabel : Label
    {
        private Color _HoverForeColor = Color.FromArgb(57, 95, 172);
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


        private Color _PressedForeColor = Color.White;
        [PropertyTab("PressedForeColor")]
        [DisplayName("PressedForeColor")]
        [Browsable(true)]
        [Description("ForeColor when pressed.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "White")]
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

        private Color _PressedBackColor = Color.FromArgb(57, 95, 172);
        [PropertyTab("PressedBackColor")]
        [DisplayName("PressedBackColor")]
        [Browsable(true)]
        [Description("BackColor when pressed.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "57, 95, 172")]
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


        private Color _HoverBackColor = SystemColors.Control;
        [PropertyTab("HoverBackColor")]
        [DisplayName("HoverBackColor")]
        [Browsable(true)]
        [Description("BackColor when hovered.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "Control")]
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


        protected override void OnMouseEnter(EventArgs e)
        {
            ForeColor = HoverForeColor;
            BackColor = HoverBackColor;

            Console.WriteLine("Mouse Enter");
            Console.WriteLine(BackColor);
            Console.WriteLine(ForeColor);

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            ForeColor = DefaultFontColor;
            BackColor = DefaultBackColor;

            Console.WriteLine("Mouse Leave");
            Console.WriteLine(BackColor);
            Console.WriteLine(ForeColor);

            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            ForeColor = PressedForeColor;
            BackColor = PressedBackColor;

            Console.WriteLine("Mouse Down");
            Console.WriteLine(BackColor);
            Console.WriteLine(ForeColor);

            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            ForeColor = this.Focused ? HoverForeColor : DefaultForeColor;
            BackColor = this.Focused ? HoverBackColor : DefaultBackColor;

            Console.WriteLine("Mouse Up");
            Console.WriteLine(BackColor);
            Console.WriteLine(ForeColor);

            base.OnMouseUp(e);
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


        protected new Color DefaultBackColor
        {
            get
            {
                return Color.Transparent;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public override bool AutoSize
        {
            get
            {
                return false;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            if(String.IsNullOrEmpty(Text))
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
            else if(!String.IsNullOrEmpty(Text) && Image != null)
            {
                Size szImgRect = new Size(Width, Height - 25);
                Size szTxtRect = new Size(Width, 25);

                Rectangle imgRect = new Rectangle(new Point(0, 0), szImgRect);
                Rectangle txtRect = new Rectangle(new Point(0, Height - 25), szTxtRect);

                StringFormat sFormat = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Near
                };

                Graphics g = e.Graphics;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                if (Image != null)
                {
                    g.DrawImage(Image, (Width / 2 - ImageSize.Width / 2), (szImgRect.Height / 2 - ImageSize.Height / 2), ImageSize.Width, ImageSize.Height);
                }
                g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), txtRect, sFormat);

            }
            else
            {
                Size szTxtRect = new Size(Width, Height);
                
                Rectangle txtRect = new Rectangle(new Point(0,0), szTxtRect);


                StringFormat cFormat = new StringFormat();
                Int32 lNum = (Int32)Math.Log((Double)this.TextAlign, 2);
                cFormat.LineAlignment = (StringAlignment)(lNum / 4);
                cFormat.Alignment = (StringAlignment)(lNum % 4);

                Graphics g = e.Graphics;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                
                g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), txtRect, cFormat);

            }
        }


        private Size _ImageSize = new Size(32,32);
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
