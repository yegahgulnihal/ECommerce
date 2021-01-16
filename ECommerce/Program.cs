using System;

namespace ECommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example Products
            Product product1 = new Product();
            product1.Id = 0001;
            product1.ProductName = "Apple";
            product1.ProductAmount = 120;
            product1.ProductPrice = 3.99;
            product1.ProductDetail = "Red Apple";

            Product product2 = new Product();
            product2.Id = 0002;
            product2.ProductName = "Pear";
            product2.ProductAmount = 135;
            product2.ProductPrice=3.75;
            product2.ProductDetail = "Yellow Pear";

            Product product3 = new Product();
            product3.Id = 0003;
            product3.ProductName = "Grape";
            product3.ProductAmount = 150;
            product3.ProductPrice = 5.00;
            product3.ProductDetail = "Black Grapes";

            Product[] products = new Product[] { product1, product2, product3 };
            foreach (var product in products)
            {
                Console.WriteLine("We have "+product.ProductName+"!" );
                Console.WriteLine("------------------");
            }

            Console.WriteLine("If you want to see all the details please click Escape button!");

            System.ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.Escape)
            {
                foreach (var item in products)
                {
                    Console.WriteLine("The "+item.ProductName+" is "+item.ProductPrice+"$ and "+item.ProductAmount+" kg has left!");
                }

            }
           


        }
    }
}
