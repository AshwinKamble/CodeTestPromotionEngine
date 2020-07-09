using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BaseClass
{
    public abstract class PromotionBase
    {
        public PromotionBase(string productName)
        {
            this.Name = productName;
        }
        public string Name { get; set; }

        public abstract void AddPromotion()
        {
            
        }
    }
}
