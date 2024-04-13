using Course.Entities;
using System;

/*          
 
            Predicate (System)
    
    Representa um método que recebe um objeto
    do tipo T e retorna um valor booleano

            Problema exemplo

    Fazer um programa que, a partir de uma lista
    de produtos, remova da lista somente aqueles
    cujo preço mínimo seja 100.


 */

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            products.Add(new Product("TV LG", 900.00));
            products.Add(new Product("Mouse Razer", 50.00));
            products.Add(new Product("Tablet Samsung", 350.50));
            products.Add(new Product("SSD", 80.90));

            products.RemoveAll(ProductTest);

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}