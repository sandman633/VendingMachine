using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingBL.Core.Products
{
    class ProductContext : DbContext
    {
        public ProductContext(): base("DbConnection")
        { }
        public DbSet<Snack> Snacks { get; set; }

    }
}
