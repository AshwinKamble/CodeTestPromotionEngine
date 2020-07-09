using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BaseClass
{
    public abstract class ProductBase
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public ProductBase(string name, decimal price)
        {
            this.ProductName = name;
            this.ProductPrice = price;
        }
    }
}
