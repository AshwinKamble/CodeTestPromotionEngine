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
        public ProductCheckout(ProductCart pCart)
        {
            this.Cart = pCart;
        }

        public void CheckOutCart()
        {

        }
    }
}
