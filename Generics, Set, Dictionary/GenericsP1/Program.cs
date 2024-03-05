using GenericsP1;
using System;
using System.IO;

/*
 
            ### Problema Motivador - by Gusta : x:II ###

    Deseja-se fazer um programa que leia um conjunto
    N de números inteiros (N de 1 a 10), e depois imprima
    esses números de forma organizada. E também, informar
    qual foi o primeiro valor informado.
 
 */


namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintService printService = new PrintService();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                printService.AddValue(value);
            }

            printService.Print();

            Console.WriteLine($"First: {printService.First()}");

        }
    }
}