using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingBL.Core
{
    public class Coin
    {
        public readonly decimal Cost;
        public int Count { get;  set; }

        public Coin(decimal cost, int count = 10)
        {
            Cost = cost;
            Count = count;
        }
        public decimal AllSum()
        {
            return Cost * Count;
        }
        public override string ToString()
        {
            return Cost.ToString();
        }

    }
}
