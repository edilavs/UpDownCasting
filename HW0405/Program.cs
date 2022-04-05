
using System;
using ClassLibrary;

namespace HW0405
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Product product = new Product();
            product.Name = "xdfscfga";
            product.No = 89;
            product.Price = 57;
            product.DiscountPercent = 10;

            Store store = new Store();
            store.AddProduct(product);

            //Product[] products = new Product[0];
            //foreach (var pr in products)
            //{
            //    Console.WriteLine(pr);
            //}

            Phone phone1 = new Phone();
            phone1.No = 23;
            phone1.Price = 2300;
            phone1.SimCount = 1;
            phone1.DiscountPercent = 10;

            Phone phone2 = new Phone();
            phone2.No = 23;
            phone2.Price = 2300;
            phone2.SimCount = 1;
            phone2.DiscountPercent = 10;
            store.PhoneLimit = 2;
            Console.WriteLine(store.FindByNo(23));
            store.AddProduct(product);
        }

        
    }
}
