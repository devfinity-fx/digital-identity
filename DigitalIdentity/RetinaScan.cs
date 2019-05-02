using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DevFINITY.DigitalIdentity
{
    public partial class RetinaScan : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        string retinaIdentity = null;
        Capture camera;
        Image<Bgr, Byte> Frame;

        public RetinaScan(string wholeName)
        {
            InitializeComponent();
            retinaIdentity = wholeName;

            camera = new Capture();
            camera.QueryFrame();
            Application.Idle += new EventHandler(FrameProcedure);
        }

        private void FrameProcedure(object sender, EventArgs e)
        {
            Frame = camera.QueryFrame().Resize(202, 202, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
            cameraRetina.Image = Frame;
            cameraRetina.SetZoomScale(5, new Point(78, 55));
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            MessageBox.Show(retinaIdentity + " Added Successfully");
        }
    }
}