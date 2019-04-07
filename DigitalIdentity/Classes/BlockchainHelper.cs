using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using io.nem1.sdk.Core;
using io.nem1.sdk.Infrastructure;
using io.nem1.sdk.Infrastructure.HttpRepositories;
using io.nem1.sdk.Model.Accounts;
using io.nem1.sdk.Model.Wallet;
using io.nem1.sdk.Model.Blockchain;
using io.nem1.sdk.Model.Mosaics;
using io.nem1.sdk.Model.Transactions;
using io.nem1.sdk.Model.Transactions.Messages;

using System.Reactive.Linq;
using System.IO;
using System.Threading;

namespace DevFINITY.DigitalIdentity.Classes
{
    public class BlockchainHelper
    {
        public static async Task<bool> CreateTransaction()
        {

            KeyPair keyPair = KeyPair.CreateFromPrivateKey(Config.PrivateKeyMain);

            var transaction = TransferTransaction.Create(
                NetworkType.Types.TEST_NET,
                Deadline.CreateHours(2),
                Address.CreateFromEncoded("TCPCAZ-7XJ2X4-SWR6AG-6BUEKS-6DQ7DL-Z2D6QB-5M2V"),
                new List<Mosaic> { Mosaic.CreateFromIdentifier("nem:xem", 10) },
                SecureMessage.Create("hello", Config.PrivateKeyMain, "d72f89db8d0a3655168c9d2abe8de2910aaf4506a47d46e22ca48c7e0442e8ef")
            );

            TransactionHttp transactionHttp = new TransactionHttp("http://" + Config.Domain + ":7890");
            SignedTransaction signedTransaction = transaction.SignWith(keyPair);
            Thread.Sleep(2000);
            await transactionHttp.Announce(signedTransaction);
            Console.WriteLine(signedTransaction.Hash);
            Thread.Sleep(2000);
            return true;
        }

        public static async void CreateTransaction(Account receiverAcc, String message)
        {
            KeyPair keyPair = KeyPair.CreateFromPrivateKey(Config.PrivateKeyMain);

            var transaction = TransferTransaction.Create(
                NetworkType.Types.TEST_NET,
                Deadline.CreateHours(2),
                Address.CreateFromEncoded(receiverAcc.Address.Plain),
                new List<Mosaic> { Mosaic.CreateFromIdentifier("nem:xem", 2000000) },
                SecureMessage.Create(message, Config.PrivateKeyMain, receiverAcc.PublicKey)
            );
            TransactionHttp transactionHttp = new TransactionHttp("http://" + Config.Domain + ":7890");
            SignedTransaction signedTransaction = transaction.SignWith(keyPair);
            Thread.Sleep(2000);
            await transactionHttp.Announce(signedTransaction);
            Console.WriteLine(signedTransaction.Hash);
            Console.WriteLine(receiverAcc.Address.Plain + " recve something from : " + Config.Address);
            Thread.Sleep(2000);
        }

        public static async Task<bool> SendFromNewAccount(String message, Account newAcc)
        {
            KeyPair keyPair = KeyPair.CreateFromPrivateKey(newAcc.PrivateKey);

            var transaction = TransferTransaction.Create(
                NetworkType.Types.TEST_NET,
                Deadline.CreateHours(2),
                Address.CreateFromEncoded(Config.Address),
                new List<Mosaic> { Mosaic.CreateFromIdentifier("nem:xem", 10) },
                SecureMessage.Create(message, newAcc.PrivateKey, Config.PublicKey)
            );

            TransactionHttp transactionHttp = new TransactionHttp("http://" + Config.Domain + ":7890");
            SignedTransaction signedTransaction = transaction.SignWith(keyPair);
            Thread.Sleep(2000);
            await transactionHttp.Announce(signedTransaction);
            Thread.Sleep(2000);
            Console.WriteLine(signedTransaction.Hash);
            Console.WriteLine(Config.Address + " recve something from : " + newAcc.Address.Plain);

            return true;
        }

        public static void CreateWallet(string walletName, string password, NetworkType.Types nettype, string filePath)
        {
            var createSimpleWallet = SimpleWallet.CreateNewSimpleWallet(walletName, new Password(password), nettype);
            File.WriteAllText(filePath, createSimpleWallet.WriteFile());
        }

        public static Account GenerateAccount(string filePath)
        {
            Account newAcc = Account.GenerateNewAccount(NetworkType.Types.TEST_NET);
            File.WriteAllLines(filePath, new string[] { newAcc.Address.Plain , newAcc.PrivateKey });
            return newAcc;
        }
    }
}
