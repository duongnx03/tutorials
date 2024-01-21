using System;
using System.Collections;
using System.Security.Cryptography;

namespace lap4
{
    delegate void ProductDelegate(string mes);

    internal class ProductManager
	{
         ArrayList products = new ArrayList();
         public event ProductDelegate ProductEvent;

        public void Add()
        {
            Product product = new Product();
            Console.WriteLine("Input ProductId: ");
            product.ProductId = Console.ReadLine();
            Console.WriteLine("Input ProductName: ");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Input UnitPrice: ");
            product.UnitPrice = int.Parse(Console.ReadLine());
            ProductDelegate productDelegate = ProductEvent;
            if (productDelegate != null)
            {
                ProductEvent("Add new product successfully!");
            }
            products.Add(product);
        }

        public void Show()
        {
            foreach (Product product in products)
            {
                product.PrintInfo();
            }
        }

        public void DeleteId()
        {
            Console.WriteLine("Input Id: ");
            string did = Console.ReadLine();
            foreach(Product product in products)
            {
                if (product.ProductId == did)
                {
                    ProductDelegate productDelegate = ProductEvent;
                    if (productDelegate != null)
                    {
                        ProductEvent("Delete product successfully!");
                    }
                    products.Remove(product);
                    break;
                }
            }
        }

        public void SearchByName()
        {
            Console.WriteLine("Input name to search: ");
            string sName = Console.ReadLine();
            foreach (Product product in products)
            {
                if (product.ProductName.Contains(sName))
                {
                    product.PrintInfo();
                }
            }
        }
    }

}

