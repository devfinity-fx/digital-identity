using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Linq;
using System.Windows.Forms;
using DevFINITY.DigitalIdentity.Classes;

using io.nem1.sdk.Core;
using io.nem1.sdk.Infrastructure;
using io.nem1.sdk.Infrastructure.HttpRepositories;
using io.nem1.sdk.Model.Accounts;
using io.nem1.sdk.Model.Blockchain;
using io.nem1.sdk.Model.Mosaics;
using io.nem1.sdk.Model.Transactions;
using io.nem1.sdk.Model.Transactions.Messages;

using System.Reactive.Linq;

using DevFINITY.DigitalIdentity.Models;
using DPUruNet;
using System.Drawing.Imaging;

namespace DevFINITY.DigitalIdentity
{
    public partial class Main : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public Dictionary<int, String> _provinces;
        public Dictionary<int, String> _cities;
        public Dictionary<int, String> _barangays;


        #region FingerPrint Codes
        EnrollmentControl enrollmentControl;
        IdentificationControl identificationControl;
        private ReaderCollection _readers;
        private Reader currentReader;

        /// <summary>
        /// Holds fmds enrolled by the enrollment GUI.
        /// </summary>
        public Dictionary<int, Fmd> Fmds
        {
            get { return fmds; }
            set { fmds = value; }
        }
        private Dictionary<int, Fmd> fmds = new Dictionary<int, Fmd>();

        // When set by child forms, shows s/n and enables buttons.        
        public Reader CurrentReader
        {
            get { return currentReader; }
            set
            {
                currentReader = value;
                SendMessage(Action.UpdateReaderState, value);
            }
        }
        private enum Action
        {
            UpdateReaderState
        }
        private delegate void SendMessageCallback(Action state, object payload);
        private void SendMessage(Action state, object payload)
        {
            if (this.txtReaderSelected.InvokeRequired)
            {
                SendMessageCallback d = new SendMessageCallback(SendMessage);
                this.Invoke(d, new object[] { state, payload });
            }
            else
            {
                switch (state)
                {
                    case Action.UpdateReaderState:
                        if ((Reader)payload != null)
                        {
                            //txtReaderSelected.Text = ((Reader)payload).Description.SerialNumber;
                            //btnCapture.Enabled = true;
                            //btnStreaming.Enabled = true;
                            //btnVerify.Enabled = true;
                            //btnIdentify.Enabled = true;
                            //btnEnroll.Enabled = true;
                            //btnEnrollmentControl.Enabled = true;
                            //if (fmds.Count > 0)
                            //{
                            //    btnIdentificationControl.Enabled = true;
                            //}
                        }
                        else
                        {
                            //txtReaderSelected.Text = String.Empty;
                            //btnCapture.Enabled = false;
                            //btnStreaming.Enabled = false;
                            //btnVerify.Enabled = false;
                            //btnIdentify.Enabled = false;
                            //btnEnroll.Enabled = false;
                            //btnEnrollmentControl.Enabled = false;
                            //btnIdentificationControl.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        public Bitmap CreateBitmap(byte[] bytes, int width, int height)
        {
            byte[] rgbBytes = new byte[bytes.Length * 3];

            for (int i = 0; i <= bytes.Length - 1; i++)
            {
                rgbBytes[(i * 3)] = bytes[i];
                rgbBytes[(i * 3) + 1] = bytes[i];
                rgbBytes[(i * 3) + 2] = bytes[i];
            }
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            for (int i = 0; i <= bmp.Height - 1; i++)
            {
                IntPtr p = new IntPtr(data.Scan0.ToInt64() + data.Stride * i);
                System.Runtime.InteropServices.Marshal.Copy(rgbBytes, i * bmp.Width * 3, p, bmp.Width * 3);
            }

            bmp.UnlockBits(data);

            return bmp;
        }

        #endregion

        public Main()
        {
            InitializeComponent();
            //_readers = ReaderCollection.GetReaders();
            //CurrentReader = _readers[0];
            //Console.WriteLine(CurrentReader.Description.Technology);
        }
        
        #region Form Button Functions
        private void CloseAction(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void ToggleSizeAction(object sender, EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Maximized)
        //    {
        //        this.WindowState = FormWindowState.Normal;
        //        maximizeButton.SetButtonType(SwingWERX.Controls.ButtonType.MAXIMIZE);
        //    }
        //    else
        //    {
        //        this.WindowState = FormWindowState.Maximized;
        //        maximizeButton.SetButtonType(SwingWERX.Controls.ButtonType.RESTORE);
        //    }
        //}

        private void MinimizeAction(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MouseDownEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion


        private async void LoadEvent(object sender, EventArgs e)
        {
            labelX1.ForeColor = Color.Silver;

            _readers = ReaderCollection.GetReaders();
            CurrentReader = _readers[0];


            //KeyPair keyPair = KeyPair.CreateFromPrivateKey(Config.PrivateKeyMain);

            //var transaction = TransferTransaction.Create(
            //    NetworkType.Types.TEST_NET,
            //    Deadline.CreateHours(2),
            //    Address.CreateFromEncoded("TCPCAZ-7XJ2X4-SWR6AG-6BUEKS-6DQ7DL-Z2D6QB-5M2V"),
            //    new List<Mosaic> { Mosaic.CreateFromIdentifier("nem:xem", 10) },
            //    //SecureMessage.Create("hello", Config.PrivateKeyMain, "d72f89db8d0a3655168c9d2abe8de2910aaf4506a47d46e22ca48c7e0442e8ef")
            //    PlainMessage.Create("batas")
            //);


            //SignedTransaction signedTransaction = transaction.SignWith(keyPair);
            //TransactionHttp transactionHttp = new TransactionHttp("http://" + Config.Domain + ":7890");
            //Thread.Sleep(2000);
            //await transactionHttp.Announce(signedTransaction);
            //Thread.Sleep(1000);
            //Console.WriteLine(signedTransaction.Hash);

            //_provinces = new Dictionary<int, string>();
            //Model.All<Province>().Get<Province>().ToList<Province>().ForEach(item =>
            //{
            //    _provinces.Add(item.ID, item.Name);
            //});

            //_cities = new Dictionary<int, string>();
            //Model.All<Province>().Get<Province>().ToList<Province>().ForEach(item =>
            //{
            //    _cities.Add(item.ID, item.Name);
            //});

            //_barangays = new Dictionary<int, string>();
            //Model.All<Province>().Get<Province>().ToList<Province>().ForEach(item =>
            //{
            //    _barangays.Add(item.ID, item.Name);
            //});

        }

        private void LoginAction(object sender, EventArgs e)
        {
            new Login().ShowDialog();
        }

        private async void AddRecordAction(object sender, EventArgs e)
        {
            panelManager.SelectedPanel = addRecordManagedPanel;

            cmbMaritalStatus.BestFitItems();
            cmbBloodType.BestFitItems();

            //KeyPair keyPair = KeyPair.CreateFromPrivateKey(Config.PrivateKeyMain);

            //var transaction = TransferTransaction.Create(
            //    NetworkType.Types.TEST_NET,
            //    Deadline.CreateHours(2),
            //    Address.CreateFromEncoded("TCPCAZ-7XJ2X4-SWR6AG-6BUEKS-6DQ7DL-Z2D6QB-5M2V"),
            //    new List<Mosaic> { Mosaic.CreateFromIdentifier("nem:xem", 10) },
            //    //SecureMessage.Create("hello", Config.PrivateKeyMain, "d72f89db8d0a3655168c9d2abe8de2910aaf4506a47d46e22ca48c7e0442e8ef")
            //    PlainMessage.Create("batas")
            //);


            //SignedTransaction signedTransaction = transaction.SignWith(keyPair);
            //TransactionHttp transactionHttp = new TransactionHttp("http://" + Config.Domain + ":7890");
            //Thread.Sleep(2000);
            //await transactionHttp.Announce(signedTransaction);
            //Thread.Sleep(2000);
            //Console.WriteLine(signedTransaction.Hash);

        }

        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
            new TakePhotoForm().ShowDialog();
        }

        private void btnOpenFingerPrint_Click(object sender, EventArgs e)
        {
            if (enrollmentControl == null)
            {
                enrollmentControl = new EnrollmentControl
                {
                    _sender = this
                };
            }

            enrollmentControl.ShowDialog();
        }

        private void btnIdentificationControl_Click(object sender, EventArgs e)
        {
            if (identificationControl == null)
            {
                identificationControl = new IdentificationControl();
                identificationControl._sender = this;
            }

            identificationControl.ShowDialog();

            identificationControl.Dispose();
            identificationControl = null;
        }
    }
}