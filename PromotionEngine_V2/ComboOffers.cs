using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine_v2
{
    public class ComboOffers 
    {
        public  float calculatePrice(Product product)
        {
            if (product.quantity > 0)
            {
                int totalEligibleItems = product.quantity / product.requiredNumberOfItems;
                int remainingItems = product.quantity % product.requiredNumberOfItems;
                float finalPrice = product.comboDiscountPrice * totalEligibleItems + product.productPrice * remainingItems;
                return finalPrice;
            }
            else
            {
                return 0;
            }
        }
    }
}
