using BusinessLogicLayer.BusinessObject;
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
            Product p1 = new Product("A", 50);
            Product p2 = new Product("B", 30);
            Product p3 = new Product("C", 20);
            Product p4 = new Product("D", 15);

            ProductCart cart = new ProductCart();
            cart.AddProductToCart(p1);
            cart.AddProductToCart(p2);
            cart.AddProductToCart(p3);
            cart.AddProductToCart(p4);

            cart.AddPromption(new ProductDiscountQuantity("A", 3, 130));
            cart.AddPromption(new ProductDiscountQuantity("B", 2, 45));

        }
    }
}
