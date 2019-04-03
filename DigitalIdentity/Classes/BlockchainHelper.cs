using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using io.nem1.sdk.Core;
using io.nem1.sdk.Infrastructure;
using io.nem1.sdk.Infrastructure.HttpRepositories;
using io.nem1.sdk.Model.Accounts;
using io.nem1.sdk.Model.Blockchain;
using io.nem1.sdk.Model.Mosaics;
using io.nem1.sdk.Model.Transactions;
using io.nem1.sdk.Model.Transactions.Messages;

using System.Reactive.Linq;

namespace DevFINITY.DigitalIdentity.Classes
{
    public class BlockchainHelper
    {
        public static async Task<bool> CreateTransaction(String address, String message)
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
            await transactionHttp.Announce(signedTransaction);
            Console.WriteLine(signedTransaction.Hash);

            return true;
        }
    }
}
