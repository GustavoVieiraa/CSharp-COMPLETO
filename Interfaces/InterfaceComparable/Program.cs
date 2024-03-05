using InterfaceComparable.Entities;
using System;
using System.IO;

/*
 
            ### Problema Motivador
    Faça um programa para ler um arquivo contendo
    nomes de pessoas (um nome por linha), armazenando-os
    em uma lista. Depois, ordenar os dados dessa lista e 
    mostra-los ordenadamente na tela. Nota: o caminho
    do arquivo pode ser informado "hardcode".
 
 */

namespace InterfaceComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFile = @"C:\dados\info1.txt";

            try
            {

                using (StreamReader sr = File.OpenText(myFile)) 
                {
                    List<Employee> employees = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        employees.Add(new Employee(sr.ReadLine()));
                    }
                    employees.Sort();
                    foreach (Employee employee in employees)
                    {
                        Console.WriteLine(employee);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

        }
    }
}