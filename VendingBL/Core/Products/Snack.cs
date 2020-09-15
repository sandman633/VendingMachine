using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingBL.Core.Products
{
    public class Snack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public Snack(string name, decimal price, int count = 1)
        {
            Name = name;
            Price = price;
            Count = count;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
