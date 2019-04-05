using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevFINITY.DigitalIdentity
{
    public partial class SnapshotForm : Form
    {
        public SnapshotForm()
        {
            InitializeComponent();
        }
        public void SetImage(Bitmap bitmap)
        {

            //Bitmap old = (Bitmap)pictureBox.Image;
            //pictureBox.Image = bitmap;


            //picCropped.Image = bitmap;

            //OriginalImage = bitmap;
            //CroppedImage = (Bitmap)bitmap.Clone();
            //DisplayImage = (Bitmap)CroppedImage.Clone();
            //DisplayGraphics = Graphics.FromImage(DisplayImage);

            //picCropped.Image = DisplayImage;
            //picCropped.Visible = true;




            //Bitmap nb = new Bitmap("test");

            Bitmap nb = new Bitmap(480, 480);
            Graphics g = Graphics.FromImage(nb);
            g.DrawImage(bitmap, -394, -150);
            picCropped.Image = nb;

            //if ( old != null )
            //{
            //    old.Dispose( );
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(saveFileDialog.FileName).ToLower();
                ImageFormat format = ImageFormat.Jpeg;

                if (ext == ".bmp")
                {
                    format = ImageFormat.Bmp;
                }
                else if (ext == ".png")
                {
                    format = ImageFormat.Png;
                }

                try
                {
                    lock (this)
                    {
                        Bitmap image = (Bitmap)picCropped.Image;
                        image.Save(saveFileDialog.FileName, format);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed saving the snapshot.\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
