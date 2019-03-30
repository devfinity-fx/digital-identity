using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Design;

using System.Windows.Forms;
using System.ComponentModel.Design;
using System.ComponentModel;

using SwingWERX.Editors;
using SwingWERX.Extensions;

namespace SwingWERX.Controls
{
    [Editor(typeof(ToolTipEditor), typeof(UITypeEditor))]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Serializable]
    public class SwxToolTip : ToolTip
    {
        public SwxToolTip()
        {
            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }

        public SwxToolTip(String HeaderText, String ContentText)
        {
            this.HeaderText = HeaderText;
            this.ContentText = ContentText;

            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }


        private String _headerText = "headerText";
        [PropertyTab("HeaderText")]
        [DisplayName("HeaderText")]
        [Description("The HeaderText.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue("headerText")]
        public string HeaderText
        {
            get
            {
                return _headerText;
            }
            set
            {
                _headerText = value;
            }
        }

        private String _contentText = "contentText";
        [PropertyTab("ContentText")]
        [DisplayName("ContentText")]
        [Description("The ContentText.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue("contentText")]
        public string ContentText
        {
            get
            {
                return _contentText;
            }
            set
            {
                _contentText = value;
            }
        }

        
        private Size _size = new Size(200,100);

        private void OnPopup(object sender, PopupEventArgs e) // use this event to set the size of the tool tip
        {
            e.ToolTipSize = _size;
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e) // use this event to customise the tool tip
        {
            Rectangle rect = new Rectangle(new Point(0, 0), _size);
            using (Brush brush = new LinearGradientBrush(rect,
                Color.WhiteSmoke,
                Color.Snow, LinearGradientMode.ForwardDiagonal))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
            

            Rectangle topRect = new Rectangle(new Point(10,  0), new Size(180, 26));
            Rectangle cntRect = new Rectangle(new Point(20, 26), new Size(160, 74));

            StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };

            Graphics g = e.Graphics;
            g.DrawString(_headerText, new Font("Segoe UI Semibold", 11, FontStyle.Regular), new SolidBrush(SystemColors.ControlDarkDark), topRect, sf);

            sf = new StringFormat()
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            };

            g.DrawString(_contentText, new Font("Segoe UI Light", 11, FontStyle.Regular), new SolidBrush(SystemColors.ControlDarkDark), cntRect, sf);
            
        }
    }
}