using System;
using System.Collections.Generic;
using VendingBL.Core.Products;

namespace VendingBL.Core
{
    public class VendingWorker
    {
        Coins Coins { get; }
        VendingMachine Machine { get; set; }

        public event Action Buying;

        public VendingWorker()
        {
            Machine = new VendingMachine();
            Machine.CoinBalance += Coins.AllSum();
        }
        public void Buy(Snack product)
        {



        }
        public List<Coin> PayCoin(int sum)
        {
            var result = new List<Coin>();






            return result;
        }
        public void PayCard(decimal sum)
        {
            Machine.Balance += sum;
        }
    }
}
