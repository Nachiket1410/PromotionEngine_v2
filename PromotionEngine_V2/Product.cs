using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine_v2
{
    public class Product
    {
        public string productName { get; set; }
        public string productType { get; set; }

        public int productPrice { get; set; }

        public int requiredNumberOfItems { get; set; }

        public int comboDiscountPrice { get; set; }
        public int additionalItemDiscountPrice { get; set; }
        public List<string> discountList { get; set; }
        public float percentDiscount { get; set; }
        public int quantity { get; set; }

        public Product freeProduct { get; set; }
    }
}
