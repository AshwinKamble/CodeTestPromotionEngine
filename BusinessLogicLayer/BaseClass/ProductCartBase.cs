using BusinessLogicLayer.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BaseClass
{
    public abstract class ProductCartBase
    {
        private List<Product> _lstProduct;

        public ProductCartBase()
        {
            this._lstProduct = new List<Product>();
        }
    }
}
