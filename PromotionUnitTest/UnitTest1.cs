using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogicLayer.BusinessObject;
using BusinessLogicLayer.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PromotionUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestScenario1()
        {
            ProductCart cart = new ProductCart();

            cart.AddProductToCart(new Product("A", 50));
            cart.AddProductToCart(new Product("B", 50));
            cart.AddProductToCart(new Product("C", 50));

            cart.AddPromption(new ProductDiscountQuantity("A", 3, 130));
            cart.AddPromption(new ProductDiscountQuantity("B", 2, 45));

            IProductQuantity checkout = new ProductCheckout(cart);
            List<Product> lstProd1 = checkout.GetTotalAmount();

            cart.AddPromption(new ProductDiscountGroup("C&D", 30));

            IProductGroup checkout1 = new ProductCheckout(cart);
            List<Product> lstProd2 = checkout1.GetTotalAmount();

            Assert.AreEqual(lstProd1.Sum(x => x.ProductPriceWithDiscount) + lstProd2.Sum(x => x.ProductPriceWithDiscount), 100);
        }

        [TestMethod]
        public void TestScenario2()
        {
            ProductCart cart = new ProductCart();

            cart.AddProductToCart(new Product("A", 50));
            cart.AddProductToCart(new Product("A", 50));
            cart.AddProductToCart(new Product("A", 50));
            cart.AddProductToCart(new Product("A", 50));
            cart.AddProductToCart(new Product("A", 50));

            cart.AddProductToCart(new Product("B", 30));
            cart.AddProductToCart(new Product("B", 30));
            cart.AddProductToCart(new Product("B", 30));
            cart.AddProductToCart(new Product("B", 30));
            cart.AddProductToCart(new Product("B", 30));

            cart.AddProductToCart(new Product("C", 20));

            cart.AddPromption(new ProductDiscountQuantity("A", 3, 130));
            cart.AddPromption(new ProductDiscountQuantity("B", 2, 45));

            IProductQuantity checkout = new ProductCheckout(cart);
            List<Product> lstProd1 = checkout.GetTotalAmount();

            cart.AddPromption(new ProductDiscountGroup("C&D", 30));

            IProductGroup checkout1 = new ProductCheckout(cart);
            List<Product> lstProd2 = checkout1.GetTotalAmount();

            Assert.AreEqual(lstProd1.Sum(x => x.ProductPriceWithDiscount) + lstProd2.Sum(x => x.ProductPriceWithDiscount), 370);
        }

        [TestMethod]
        public void TestScenario3()
        {
            ProductCart cart = new ProductCart();

            cart.AddProductToCart(new Product("A", 50));
            cart.AddProductToCart(new Product("A", 50));
            cart.AddProductToCart(new Product("A", 50));

            cart.AddProductToCart(new Product("B", 30));
            cart.AddProductToCart(new Product("B", 30));
            cart.AddProductToCart(new Product("B", 30));
            cart.AddProductToCart(new Product("B", 30));
            cart.AddProductToCart(new Product("B", 30));

            cart.AddProductToCart(new Product("C", 20));

            cart.AddProductToCart(new Product("D", 15));

            cart.AddPromption(new ProductDiscountQuantity("A", 3, 130));
            cart.AddPromption(new ProductDiscountQuantity("B", 2, 45));

            IProductQuantity checkout = new ProductCheckout(cart);
            List<Product> lstProd1 = checkout.GetTotalAmount();

            cart.AddPromption(new ProductDiscountGroup("C&D", 30));

            IProductGroup checkout1 = new ProductCheckout(cart);
            List<Product> lstProd2 = checkout1.GetTotalAmount();

            Assert.AreEqual(lstProd1.Sum(x => x.ProductPriceWithDiscount) + lstProd2.Sum(x => x.ProductPriceWithDiscount), 280);

        }
    }
}
