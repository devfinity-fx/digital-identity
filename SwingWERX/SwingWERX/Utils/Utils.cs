using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SwingWERX.Utils
{
    public class Utils
    {
        public static int GetFontPixels(Font f)
        {
            int Ascent = 0;
            float AscentPx = 0;
            int Descent = 0;
            float DescentPx = 0;

            Ascent = f.FontFamily.GetCellAscent(FontStyle.Regular);
            AscentPx = f.Size * Ascent / f.FontFamily.GetEmHeight(FontStyle.Regular);

            Descent = f.FontFamily.GetCellDescent(FontStyle.Regular);
            DescentPx = f.Size * Descent / f.FontFamily.GetEmHeight(FontStyle.Regular);

            double d = (double)AscentPx + (DescentPx * 2);
            return Convert.ToInt32(Math.Round(d));
        }

        public static Point CenterImage(Image img, Rectangle bgRect)
        {
            return new Point((bgRect.Width / 2) - (img.Width / 2), (bgRect.Height / 2) - (img.Height / 2));
        }

        /// <summary>
        /// Converts <b>TextAlignment</b> to <b>StringAlignment</b>.
        /// </summary>
        /// <param name="align">The TextAlignment <value>value</value> to be converted into StringAlignment</param>
        /// <returns></returns>
        public static StringAlignment TA2SA(TextAlignment align)
        {
            switch (align)
            {
                case TextAlignment.Center: return StringAlignment.Center;
                case TextAlignment.Left: return StringAlignment.Near;
                case TextAlignment.Right: return StringAlignment.Far;
            }
            return StringAlignment.Center;
        }


        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        #region Animation
        public enum Effect { Roll, Slide, Center, Blend }

        public static void Animate(Control ctl, Effect effect, int msec, int angle)
        {
            int flags = effmap[(int)effect];
            if (ctl.Visible) { flags |= 0x10000; angle += 180; }
            else
            {
                if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                else if (effect == Effect.Blend) throw new ArgumentException();
            }
            flags |= dirmap[(angle % 360) / 45];
            bool ok = AnimateWindow(ctl.Handle, msec, flags);
            if (!ok) throw new Exception("Animation failed");
            ctl.Visible = !ctl.Visible;
        }

        public static void Animate(Control ctl, Effect effect, int msec, Direction direction)
        {
            int flags = effmap[(int)effect];
            if (ctl.Visible) { flags |= 0x10000; direction += 180; }
            else
            {
                if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                else if (effect == Effect.Blend) throw new ArgumentException();
            }
            flags |= dirmap[((int)direction % 360) / 45];
            bool ok = AnimateWindow(ctl.Handle, msec, flags);
            if (!ok) throw new Exception("Animation failed");
            ctl.Visible = !ctl.Visible;
        }


        private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
        private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);
        #endregion
    }

    public enum Direction : int
    {
        Left = 0,
        Top = 90,
        Right = 180,
        Bottom = 270
    }


    public enum TextAlignment
    {
        Left = StringAlignment.Near,
        Right = StringAlignment.Far,
        Center = StringAlignment.Center
    }

}
