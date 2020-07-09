using BusinessLogicLayer.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BusinessObject
{
   public class ProductDiscount : PromotionBase
    {
        public string ProdName { get; set; }
        public int ProdQuantity { get; set; }
        public int ProdRate { get; set; }

        public ProductDiscount(string productName, int productQuantity, int productRate) : base (productName)
        {
            this.ProdName = productName;
            this.ProdQuantity = productQuantity;
            this.ProdRate = productRate;
        }

        public override void AddPromotion()
        {
            
        }
    }
}
