using System;
using System.Globalization;
using ExFixaçãoExceçõesPersonalizadas.Entities;
using ExFixaçãoExceçõesPersonalizadas.Entities.Exceptions;

/*
                ### Exercício de Fixação - by Gusta x:II
    Fazer um programa para ler os dados de uma conta bancária e depois realizar um
    saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
    se não tiver saldo na conta, ou se o valor do saque for superior ao limite de 
    saque da conta. Implemente a conta bancária conforme o projeto.
 
 */

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=-------------- BANK TEST --------------=");
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(amount);
                Console.WriteLine();
            }
            catch (AccountException ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
            
        }
    }
}