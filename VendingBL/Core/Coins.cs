using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingBL.Core
{
    public class Coins
    {
        List<Coin> coins { get; set; }
        public Coins()
        {
            coins = new List<Coin>
            {
                new Coin(1),
                new Coin(2),
                new Coin(5),
                new Coin(10)

            };
        }
        public decimal AllSum()   //сумма всех монеток 
        {
            decimal sum = 0;
            foreach(var coin in coins)
            {
                sum += coin.Cost * coin.Count;
            }
            return sum;
        }
        public void AddCoin(int nominal, int count = 1) //добавить монетку 
        {
            if(Find(nominal)!=null)
            {
                var coin = Find(nominal);
                coin.Count += count;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        public bool CheckSum(int nominal, int sum) //
        {
            var coin = Find(nominal);
            if(coin.AllSum()>=sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Coin> OutCoin(int change) // метод который должен сдачу в виде списка монет
        {
            List<Coin> result = new List<Coin>();
            foreach (var coin in coins.Where(coin => change == coin.Cost).Select(coin => coin))
            {
                result.Add(new Coin(coin.Cost, 1));
                return result;
            }

            decimal sum, remain;
            int count;
            
            return result;
        }

        private decimal GetRemain(List<Coin> result, int count,int nominal)
        {
            for (int i = count; 0 < i; i -= 1)
            {
                if (CheckSum(nominal, count))
                {
                    Coin coin = Find(nominal);
                    coin.Count -= count;
                    result.Add(new Coin(nominal, count));
                    break;
                }
            }
            return result.Find((x)=> x.Cost == nominal).AllSum();
        }

        public Coin Find(int nominal)
        {
            Coin expectedcoin = new Coin(nominal); 
            var coin = coins.Find((x) => x.Cost == nominal);
            if(coin.Cost == expectedcoin.Cost)
            {
                return coin;
            }
            else
            {
                return null;
            }
        }
        //public void Checkin()
        //{
        //    coins.ForEach((x)=> Console.WriteLine(x.Count+$" {x.ToString()}"));
        //}
    }
}
