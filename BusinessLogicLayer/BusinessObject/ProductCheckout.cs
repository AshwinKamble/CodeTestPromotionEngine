using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BusinessObject
{
    public class ProductCheckout
    {
        private ProductCart Cart;
        private List<Product> lstProduct { get; set; }

        public ProductCheckout(ProductCart pCart)
        {
            this.Cart = pCart;
        }

        public List<Product> CheckOutCart()
        {
            return null;
        }
    }
}
