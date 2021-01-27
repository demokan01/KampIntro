using System;

namespace Odev2Gun
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Elma";
            product1.ProductDescription = "Yeşil";

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Karpuz";
            product2.ProductDescription = "Adana";

            Product[] products = new Product[] { product1,product2};

            //while (products.Length>0)
            //{
            //    Console.WriteLine(products);
            //    break;
            //}

            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.ProductName);
            //}


            //for (int i = 0; i < products.Length; i++)
            //{
                
            //    Console.WriteLine(i.ToString());
            //}
        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
    }
}
