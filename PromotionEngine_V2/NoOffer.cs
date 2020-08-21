using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine_v2
{
    public class NoOffer
    {
        public float calculatePrice(Product product)
        {
            if (product.quantity > 0)
            {

                float finalPrice = product.productPrice * product.quantity;
                return finalPrice;
            }
            else
            {
                return 0;
            }
        }
    }
}
