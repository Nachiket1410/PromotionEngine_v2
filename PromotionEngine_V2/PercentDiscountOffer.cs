using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine_v2
{
    public class PercentDiscountOffer
    {
        public float calculatePrice( Product product)
        {
            float totalDiscount = ((product.quantity * product.productPrice) / 100) * product.percentDiscount;
            float finalPrice = (product.quantity * product.productPrice) - totalDiscount;
            return finalPrice;
        }
    }
}
