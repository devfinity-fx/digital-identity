using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
//AForge.Video dll
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge;


namespace DevFINITY.DigitalIdentity
{
    public partial class Camera : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        private FilterInfoCollection CaptureDevice; // list of webcam
        private VideoCaptureDevice FinalFrame;

        public Camera()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (FinalFrame.IsRunning == true) FinalFrame.Stop();
            this.Dispose();
        }

        private void LoadEvent(object sender, EventArgs e)
        {

            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);//constructor
            foreach (FilterInfo Device in CaptureDevice)
            {
                cmbCameraList.Items.Add(Device.Name);
            }

            cmbCameraList.SelectedIndex = 0; // default
            FinalFrame = new VideoCaptureDevice();

            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmbCameraList.SelectedIndex].MonikerString);// specified web cam and its filter moniker string
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);// click button event is fired, 
            FinalFrame.Start();
        }


        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();// clone the bitmap
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            if (FinalFrame.IsRunning == true) FinalFrame.Stop();

            Bitmap image = (Bitmap)pictureBox.Image.Clone();

            Rectangle cloneRect = new Rectangle((image.Width / 2) - 128, (image.Height / 2) - 128, 256, 256);
            System.Drawing.Imaging.PixelFormat format =
                image.PixelFormat;
            Bitmap cloneBitmap = image.Clone(cloneRect, format);

            pictureBox.Image = image.Clone(cloneRect, format);
        }
    }
}