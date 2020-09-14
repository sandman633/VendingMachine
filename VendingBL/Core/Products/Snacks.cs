using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingBL.Core.Products
{
    public class Snacks
    {
        public List<Snack> products { get; set; }
        public Snacks()
        {
            products = new List<Snack>
                {
                    new Snack("Red Bull",110),
                    new Snack("Mounty dew",50),
                    new Snack("Cheetos",30),
                    new Snack("Lays",50)
                };
        }
        public void AddProduct(string name, decimal price)
        {
            var product = products.Find((x) => x.Name == name) ?? new Snack(name,price,0);
            product.Count++;
        }
        public decimal SellProduct(string name)
        {
            var product = products.Find((x) => x.Name == name) ?? null;
            if (product != null && product.Count > 0)
            {
                product.Count -= 1; 
                return product.Price; 
            }
            else
            {
                return 0;
            }
            
        }

    }
}
