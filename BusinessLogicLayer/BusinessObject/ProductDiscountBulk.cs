using BusinessLogicLayer.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BusinessObject
{
   public class ProductDiscountBulk : ProductPromotion
    {
        public string ProdName { get; set; }
        public int ProdQuantity { get; set; }
        public int ProdRate { get; set; }

        public ProductDiscountBulk(string productName, int productQuantity, int productRate) : base (productName)
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
