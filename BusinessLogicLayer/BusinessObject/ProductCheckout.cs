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
                        prd.prodCount = countOfProdut;
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
            try
            {
                int cntrC = Cart.AllProducts.Where(y => y.ProductName.Equals("C")).Count();
                int cntrD = Cart.AllProducts.Where(y => y.ProductName.Equals("D")).Count();

                foreach (var promo in Cart.AllProductPromo)
                {
                    if (promo is ProductDiscountGroup)
                    {
                        foreach (Product prod in Cart.AllProducts.FindAll(x => x.ProductName.Equals("C")))
                        {
                            decimal cost = ((cntrC < cntrD || cntrC == 0)) ? 0 : ((cntrC - cntrD) * prod.ProductPrice);

                            Product prd = new Product(prod.ProductName, prod.ProductPrice);
                            prd.ProductPriceWithDiscount = cost;
                            prd.prodCount = cntrC;
                            lstProduct.Add(prd);
                            break;
                        }
                        foreach (Product prod in Cart.AllProducts.FindAll(x => x.ProductName.Equals("D")))
                        {
                            decimal cost = (cntrD == cntrC) ? ((cntrD + cntrC) / 2 * promo.ProdRate) : (((cntrD + cntrC) / 2 * promo.ProdRate) + ((cntrD) % 2) * prod.ProductPrice);

                            Product prd = new Product(prod.ProductName, prod.ProductPrice);
                            prd.ProductPriceWithDiscount = cost;
                            prd.prodCount = cntrD;
                            lstProduct.Add(prd);
                            break;
                        }
                    }
                }
                return lstProduct;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
