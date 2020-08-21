using PromotionEngine_v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine_V2
{
    class Program
    {
        List<Product> cartProducts;
        Product productA;
        Product productB;
        Product productC;
        Product productD;
        Program()
        {
            cartProducts = new List<Product>();
        }
        static void Main(string[] args)
        {
            int productA_quantity, productB_quantity, productC_quantity, productD_quantity;
            List<float> productPrices = new List<float>();
            List<float> allDiscountOnProduct = new List<float>();
            ProductOperations productOperations = new ProductOperations();
            productOperations.registerProducts();

            Console.WriteLine("Enter Quantity of Product A");
            string quantity_A = Console.ReadLine();
            int.TryParse(quantity_A, out productA_quantity);
            productOperations.productA.quantity = productOperations.productA.quantity + productA_quantity;

            Console.WriteLine("Enter Quantity of Product B");
            string quantity_B = Console.ReadLine();
            int.TryParse(quantity_B, out productB_quantity);
            productOperations.productB.quantity = productOperations.productB.quantity + productB_quantity;

            Console.WriteLine("Enter Quantity of Product C");
            string quantity_C = Console.ReadLine();
            int.TryParse(quantity_C, out productC_quantity);
            productOperations.productC.quantity = productOperations.productC.quantity + productC_quantity;

            Console.WriteLine("Enter Quantity of Product D");
            string quantity_D = Console.ReadLine();
            int.TryParse(quantity_D, out productD_quantity);
            productOperations.productD.quantity = productOperations.productD.quantity + productD_quantity;


            foreach (Product product in productOperations.cartProducts)
            {
                allDiscountOnProduct.Clear();
                foreach (string discountList in product.discountList)
                {
                    if (discountList.Equals("Combo"))
                    {
                        ComboOffers comboOffers = new ComboOffers();
                        float comboDiscount = comboOffers.calculatePrice(product);
                        allDiscountOnProduct.Add(comboDiscount);
                    }
                    else if (discountList.Equals("Additional Item"))
                    {
                        AdditionalItemOffer additionalItemOffer = new AdditionalItemOffer();
                        float comboDiscount = additionalItemOffer.calculateAdditionalCost(product.quantity, product.freeProduct.quantity, product);
                        allDiscountOnProduct.Add(comboDiscount);
                    }
                    else if (discountList.Equals("No Offer"))
                    {
                        NoOffer noOffer = new NoOffer();
                        float comboDiscount = noOffer.calculatePrice(product);
                        allDiscountOnProduct.Add(comboDiscount);
                    }
                    else if (discountList.Equals("Percent Offer"))
                    {
                        PercentDiscountOffer percentDiscountOffer = new PercentDiscountOffer();
                        float comboDiscount = percentDiscountOffer.calculatePrice(product);
                        allDiscountOnProduct.Add(comboDiscount);
                    }

                }
                Console.WriteLine("\n\nPrice of Product " + product.productName + " is:" + allDiscountOnProduct.Min());
                productPrices.Add(allDiscountOnProduct.Min());

            }
            Console.WriteLine("\n\nTotal Cart value is:" + productPrices.Sum());
            Console.ReadLine();
        }
    }
}
