using BusinessLogicLayer.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BusinessObject
{
    public class ProductDiscountCombined : ProductPromotion
    {
        public string GroupName { get; set; }
        public ProductDiscountCombined(string grpName, int price) : base(grpName)
        {
            this.GroupName = grpName;
            this.ProdRate = price;
        }
    }
}
