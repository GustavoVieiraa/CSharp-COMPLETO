using System;
using System.Collections.Generic;
using Course.Entities;

/*
                Action (System)
    
    Representa um método void que recebe zero
    ou mais argumentos.

                Problema Exemplo
    
    Fazer um programa que, a partir de uma lista
    de produtos, aumento o preço dos produtos em
    10%.
 
 */

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            products.Add(new Product("TV Samsung", 900.00));
            products.Add(new Product("Mouse Razer", 50.00));
            products.Add(new Product("Tablet Samsung", 350.50));
            products.Add(new Product("SSD Kingston", 80.90));

            /*Action<Product> act = prod => { prod.Price += prod.Price * 0.1; };*/


            products.ForEach(prod => { prod.Price += prod.Price * 0.1; });
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }

        /*static void UpdatePrice(Product prod)
        {
            prod.Price += prod.Price * 0.1;
        }*/

    }
}