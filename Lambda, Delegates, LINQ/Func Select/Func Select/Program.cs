using System;
using System.Linq;
using Course.Entities;

/*
                Func (System)

    Representa um método que recebe zero
    ou mais argumentos, e retorna um valor.
 
 */

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            products.Add(new Product("TV lG", 900.00));
            products.Add(new Product("Mouse DragonRed", 50.00));
            products.Add(new Product("Tablet Xiaomi", 350.50));
            products.Add(new Product("SSD KingsTags", 80.90));

            /*Func<Product, string> resultProducts = p => p.Name.ToUpper();*/

            List<string> result = products.Select(p => p.Name.ToUpper()).ToList();

            foreach (string product in result)
            {
                Console.WriteLine(product);
            }

        }

        /*static string ReturnNameUpper(Product p)
        {
            return p.Name.ToUpper();
        }*/

    }
}