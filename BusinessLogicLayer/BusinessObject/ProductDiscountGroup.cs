using BusinessLogicLayer.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BusinessObject
{
    public class ProductDiscountGroup : ProductPromotion
    {
        public string GroupName { get; set; }
        public ProductDiscountGroup(string grpName, int price) : base(grpName)
        {
            this.GroupName = grpName;
            this.ProdRate = price;
        }
    }
}
