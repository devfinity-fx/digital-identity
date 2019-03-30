/* CollapsablePanel
 * Author name:           Aron Jhed Bautista Amiscosa
 * Current version:       1.0.0.4 (bugged)
 * License information:   Microsoft Public License (Ms-PL) [http://www.opensource.org/licenses/ms-pl.html]
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using SwingWERX.Utils;

namespace SwingWERX.Controls
{
    public class CollapsablePanel : Control
    {
        public CollapsablePanel()
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnCreateControl()
        {
            this.Controls.Add(headerPanel);
            this.Controls.Add(contentPanel);

            base.OnCreateControl();
        }

        protected void InitComponents()
        {
            headerPanel = new FancyPanel()
            {
                Location = new System.Drawing.Point(0,0),
                Dock = DockStyle.Top,
                MaximumSize = new System.Drawing.Size(0, _HeaderHeight),
                GradientStartColor = _HeaderColor,
                GradientEndColor = _HeaderColor,
                RoundCornerRadius = _HeaderCornerRadius,
                
            };

            contentPanel = new FancyPanel()
            {
                Location = new System.Drawing.Point(0, _HeaderHeight),
                Dock = DockStyle.Fill,
                MaximumSize = new System.Drawing.Size(0, this.Height-_HeaderHeight),
                GradientStartColor = Color.White,
                GradientEndColor = Color.White
            };
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
        [DefaultValue(typeof(Color), "DarkSlateGray")]
        public Color HeaderColor
        {
            get { return _HeaderColor; }
            set { _HeaderColor = value; }
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
        #endregion

        private FancyPanel headerPanel;
        private FancyPanel contentPanel;
    }
}
