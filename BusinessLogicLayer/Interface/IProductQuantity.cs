using BusinessLogicLayer.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IProductQuantity
    {
        List<Product> GetTotalAmount();
    }
}
