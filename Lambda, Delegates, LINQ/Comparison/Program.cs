using System;
using Course.Entities;

/*                          Problema      
 
        Suponha que uma classe Product com os atributos
        name e price.
        Suponha que precisamos ordenar uma lista de objetos
        Product.

        Podemos implementar a comparação de produtos por meio
        da implementação da interface IComparable<Product>.

        Entretanto, desta forma nossa classe não fica fechada
        para alteração: se o critério de comparação mudar,
        precisaremos alterar a classe Product.

        Podemos então usar outra sobrecarga do método "Sort"
        da classe list:
            public void Sort(Comparison<T> comparison)
 */

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Notebook", 1200.00));
            products.Add(new Product("Tablet", 450.00));

            /*Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());*/

            products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // ordener list

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            /*static int CompareProducts(Product p1, Product p2)
            {
                return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            }*/

        }
    }
}