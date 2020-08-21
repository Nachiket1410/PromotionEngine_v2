using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine_v2
{
    public class AdditionalItemOffer
    {
        public int calculateAdditionalCost(int quantity_C, int quantity_D, Product mainProduct)
        {
            int finalPrice = 0;
            if (quantity_C == (quantity_D + 1))
            {
                finalPrice = mainProduct.additionalItemDiscountPrice * quantity_C;
            }
            else if ((quantity_C > quantity_D))
            {
                quantity_D = quantity_D < 0 ? 0 : quantity_D;
                int additionalItems = quantity_C - quantity_D;
                finalPrice = (mainProduct.productPrice * additionalItems) + (mainProduct.additionalItemDiscountPrice * quantity_D);
            }
            return finalPrice;
        }
    }
}
