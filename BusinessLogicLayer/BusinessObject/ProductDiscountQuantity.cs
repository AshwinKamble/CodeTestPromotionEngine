using BusinessLogicLayer.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BusinessObject
{
   public class ProductDiscountQuantity : ProductPromotion
    {
        public string ProdName { get; set; }
        public int ProdQuantity { get; set; }

        public ProductDiscountQuantity(string productName, int productQuantity, int productRate) : base(productName)
        {
            this.ProdName = productName;
            this.ProdQuantity = productQuantity;
            this.ProdRate = productRate;
        }
    }
}
