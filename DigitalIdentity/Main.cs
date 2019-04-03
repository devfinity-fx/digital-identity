using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
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
namespace DevFINITY.DigitalIdentity
{
    public partial class Main : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public Main()
        {
            InitializeComponent();
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

        }

        private void LoginAction(object sender, EventArgs e)
        {
            new Login().ShowDialog();
        }

        private async void AddRecordAction(object sender, EventArgs e)
        {
            panelManager.SelectedPanel = addRecordManagedPanel;



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
    }
}