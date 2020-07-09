using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BaseClass
{
    public abstract class ProductBase
    {
        public ProductBase(string name, decimal price)
        {
            this.ProductName = name;
            this.ProductPrice = price;
        }

        public decimal ProductPriceWithDiscount { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
