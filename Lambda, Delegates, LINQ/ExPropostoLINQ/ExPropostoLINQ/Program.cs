using System.Linq;
using System;
using System.Globalization;
using ExPropostoLINQ.Entities;

/*
                    Exercício proposto
    
    Fazer um programa para ler um conjunto de produtos
    a partir de um arquivo em formato .csv (suponha que
    exista pelo menos um produto).

    Em seguida mostrar o preço médio dos produtos. Depois,
    mostrar os nomes, em ordem decrescente, dos produtos
    que possuem preço inferior ao preço médio.


 */

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> products = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));
                }
            }

            var avg = products.Select(prod => prod.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Average price = {avg.ToString("F2", CultureInfo.InvariantCulture)}");

            var names = products.Where(prod => prod.Price < avg)
                .OrderByDescending(prod => prod.Name)
                .Select(prod => prod.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}