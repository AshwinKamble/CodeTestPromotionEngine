using BusinessLogicLayer.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BusinessObject
{
   public class ProductCart : ProductCartBase
    {
        public ProductCart() : base()
        {
            this._lstProduct = new List<Product>();
        }

        private List<Product> _lstProduct;
        public List<Product> AllProducts
        {
            get
            {
                return _lstProduct;
            }
        }

        public void AddProductToCart(Product prd)
        {
            this._lstProduct.Add(prd);
        }
    }
}
