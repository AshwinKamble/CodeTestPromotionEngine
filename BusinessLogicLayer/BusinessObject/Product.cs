using BusinessLogicLayer.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BusinessObject
{
    public class Product : ProductBase
    {
        public Product(string name, decimal price) : base(name, price)
        {

        }
    }
}
