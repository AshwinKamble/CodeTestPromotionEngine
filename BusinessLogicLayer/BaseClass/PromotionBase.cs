using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BaseClass
{
    public abstract class ProductPromotion
    {
        public string Name { get; set; }
        public ProductCartBase Cart { get; set; }
        public int ProdRate { get; set; }

        public ProductPromotion(string productName)
        {
            this.Name = productName;
        }
    }
}
