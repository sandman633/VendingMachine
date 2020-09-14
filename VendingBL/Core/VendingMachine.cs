using VendingBL.Core.Products;

namespace VendingBL.Core
{
    class VendingMachine
    {
        public decimal Balance { get; set; }
        public decimal CoinBalance { get; set; }
        public Snacks Snacks { get; set; }

        public VendingMachine(decimal balance = 0)
        {
            Balance = balance;
            Snacks = new Snacks();
        }
        public void AddMoney(decimal money)
        {
            Balance += money;
        }
    }
}
