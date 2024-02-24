using System;
using System.Globalization;
using CourseExPolimorfismo;
using CourseExPolimorfismo.Entities;

namespace ExPolimorfismo 
{ 
    class Program
    {

        /*
                    ### Exercício Proposto ###

        Uma empresa possui funcionários próprios e terceirizados.
        Para cada funcionário, deseja-se registrar nome, horas trabalhadas
        e valor por hora. Funcionários tercerizados possuem ainda uma 
        despesa adicional.

        O pagamento dos funcionários corresponde ao valor da hora multiplicado
        pelas horas trabalhadas, sendo que os funcionários terceirizados ainda
        recebem um bônus correspondente a 110% de sua despesa adicional.

        Fazer um programa para ler os dados de N funcionários (N fornecido pelo
        usuário) e armazená-los em uma lista. Depois de ler todos os dados,
        mostrar nome e pagamento de cada funcionário na mesma ordem em
        que foram digitados.

         */

        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int nEmployees = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                string isOutsourced = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hours: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (isOutsourced == "y")
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHours, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHours));
                }
            }

            Console.WriteLine("PAYMENTS: ");
            foreach (Employee worked in employees)
            {
                Console.WriteLine(worked);
            }
        }
    }
}