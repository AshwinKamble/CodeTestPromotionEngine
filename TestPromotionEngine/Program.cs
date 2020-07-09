using BusinessLogicLayer.BusinessObject;
using BusinessLogicLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCart cart = new ProductCart();

            cart.AddProductToCart(new Product("A", 50));
            cart.AddProductToCart(new Product("A", 50));
            cart.AddProductToCart(new Product("A", 50));

            cart.AddProductToCart(new Product("B", 30));
            cart.AddProductToCart(new Product("B", 30));

            cart.AddProductToCart(new Product("C", 20));
            cart.AddProductToCart(new Product("D", 15));

            cart.AddPromption(new ProductDiscountQuantity("A", 3, 130));
            cart.AddPromption(new ProductDiscountQuantity("B", 2, 45));

            IProductQuantity checkout1 = new ProductCheckout(cart);
            List<Product> lstProd1 = checkout1.GetTotalAmount();

            ShowInvoice(lstProd1);

            cart.AddPromption(new ProductDiscountGroup("C&D", 30));
            IProductGroup checkout2 = new ProductCheckout(cart);
            List<Product> lstProd2 = checkout2.GetTotalAmount();

            ShowInvoice(lstProd2);
        }

        public static void ShowInvoice(List<Product> lstProd)
        {
            foreach (Product item in lstProd)
            {
                Console.WriteLine(item.prodCount + " of Product : " + item.ProductName + " with Discount : " + item.ProductPriceWithDiscount);
            }
        }
    }
}
