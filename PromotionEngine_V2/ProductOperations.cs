using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine_v2
{
    public class ProductOperations
    {
        public List<Product> cartProducts;
        public Product productA;
        public Product productB;
        public Product productC;
        public Product productD;

        public ProductOperations()
        {
            cartProducts = new List<Product>();
        }
        public void registerProducts()
        {
            productA = new Product();
            productA.productName = "A";
            productA.productPrice = 50;
            productA.productType = "book";
            productA.comboDiscountPrice = 130;
            productA.requiredNumberOfItems = 3;
            productA.percentDiscount = 10;
            productA.freeProduct = null;
            productA.discountList = new List<string>();
            productA.discountList.Add("Combo");
            productA.discountList.Add("Percent Offer");
            cartProducts.Add(productA);

            productB = new Product();
            productB.productName = "B";
            productB.productPrice = 30;
            productB.productType = "TV";
            productB.comboDiscountPrice = 45;
            productB.requiredNumberOfItems = 2;
            productB.freeProduct = null;
            productB.discountList = new List<string>();
            productB.discountList.Add("Combo");
            cartProducts.Add(productB);
            

            productD = new Product();
            productD.productName = "D";
            productD.productPrice = 15;
            productD.productType = "Mobile";
            productD.comboDiscountPrice = 0;
            productD.requiredNumberOfItems = 0;
            productD.freeProduct = null;
            productD.discountList = new List<string>();
            productD.discountList.Add("No Offer");
            cartProducts.Add(productD);

            productC = new Product();
            productC.productName = "C";
            productC.productPrice = 20;
            productC.productType = "Book";
            productC.comboDiscountPrice = 0;
            productC.requiredNumberOfItems = 0;
            productC.freeProduct = productD;
            // Made this change to give one free product of additional item in offer
            productD.quantity = -1;
            productC.additionalItemDiscountPrice = 30;
            productC.discountList = new List<string>();
            productC.discountList.Add("Additional Item");
            cartProducts.Add(productC);
        }
    }
}
