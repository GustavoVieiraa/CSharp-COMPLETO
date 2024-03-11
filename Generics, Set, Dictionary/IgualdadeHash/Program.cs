using System;
using Course.Entities;

/*
 
                ### Como coleções hash comparam igualdade ###
    - Se GetHashCode e Equals estiverem implementados:
        ~ Primeiro GetHashCode. Se der igual, usa Equals para confirmar.

    - Se GetHashCode e Equals NÃO estiverem implementados:
        ~ Tipos referência: compara as referências dos objetos.
        ~ Tipos valor: comparar os valores do atributos.
 
 
 */


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<Product> productA = new HashSet<Product>();
            productA.Add(new Product("Iphone", 1200.00));
            productA.Add(new Product("Tablet", 950.00));
            

            HashSet<Point> pointB = new HashSet<Point>();
            pointB.Add(new Point(4, 7));
            pointB.Add(new Point(5, 12));


            Product prod = new Product("Iphone", 1200.00);
            Console.WriteLine(productA.Contains(prod));


            Point p = new Point(5, 12);
            Console.WriteLine(pointB.Contains(p));
        }
    }
}