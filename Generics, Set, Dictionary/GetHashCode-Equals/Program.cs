using System;
using Entities;

/*
 
            ### GetHashCode & Equals ###
    ~ São operações da classe Object utilizadas
    para comparar se um objeto é igual ao outro.
    
    ~ Equals: Lento, resposta 100%.
    ~ GetHashCode: Rápido, porém resposta postiva não é 100%

    Os tipos pré-definidos já possuem implementação para essas
    operações. Classes e structs personalizados precisam
    sobrepô-las.
 
 */


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Client a = new Client { Name = "Gustavo", Email = "gusta@gmail.com" };
            Client b = new Client { Name = "Rafael", Email = "gusta@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }
    }
}