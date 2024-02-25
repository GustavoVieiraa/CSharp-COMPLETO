using ExCadProducts.Entities;
using System;
using System.Globalization;

namespace CadProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int nProducts = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= nProducts; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");

                string typeBuy = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (typeBuy)
                {
                    case "c":

                        Product product = new Product(name, price);
                        products.Add(product);
                        break;
                    case "i":
                        Console.Write("Customs Fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        ImportedProduct importedProduct = new ImportedProduct(name, price, customsFee);
                        importedProduct.TotalPrice();
                        products.Add(importedProduct);

                        break;
                    case "u":
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, manufactureDate));
                        break;
                    default:
                        Console.WriteLine("Choose wrong, choose other.");
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}