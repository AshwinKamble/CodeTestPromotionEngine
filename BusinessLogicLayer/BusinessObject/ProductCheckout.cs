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
                    int countOfProdut = Cart.AllProducts.Where(y => y.ProductName.Equals(promo.ProdName)).Count();
                    foreach (Product prod in Cart.AllProducts.FindAll(x => x.ProductName.Equals(promo.ProdName)))
                    {
                        decimal price = (countOfProdut / promo.ProdQuantity) * promo.ProdRate + (countOfProdut % promo.ProdQuantity * prod.ProductPrice);

                        Product prd = new Product(prod.ProductName, prod.ProductPrice);
                        prd.ProductPriceWithDiscount = price;
                        lstProduct.Add(prd);
                        break;
                    }
                }
                return lstProduct;
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
