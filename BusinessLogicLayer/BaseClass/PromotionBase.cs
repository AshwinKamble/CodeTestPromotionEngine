using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BaseClass
{
    public class ProductPromotion
    {
        public ProductPromotion(string productName)
        {
            this.Name = productName;
        }
        public ProductCartBase Cart { get; set; }
        public string Name { get; set; }
        public int ProdRate { get; set; }
    }
}
