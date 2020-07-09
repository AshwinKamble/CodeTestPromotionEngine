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
            try
            {
                foreach (ProductDiscountQuantity promo in Cart.AllProductPromo)
                {
                    foreach (Product prod in Cart.AllProducts.FindAll(x => x.ProductName.Equals(promo.ProdName)))
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        List<Product> IProductGroup.GetTotalAmount()
        {
            throw new NotImplementedException();
        }
    }
}
