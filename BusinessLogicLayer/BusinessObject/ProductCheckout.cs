using BusinessLogicLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BusinessObject
{
    public class ProductCheckout : IProductQuantity, IProductGroup
    {
        private ProductCart Cart;
        private List<Product> lstProduct { get; set; }

        public ProductCheckout(ProductCart pCart)
        {
            this.Cart = pCart;
            lstProduct = new List<Product>();
        }

        List<Product> IProductQuantity.GetTotalAmount()
        {
            throw new NotImplementedException();
        }

        List<Product> IProductGroup.GetTotalAmount()
        {
            throw new NotImplementedException();
        }
    }
}
