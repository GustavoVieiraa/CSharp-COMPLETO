using CourseExSobreposicao.Entities;
using System;

namespace CourseExSobreposicao
{
    class Program 
    { 
        static void Main(string[] args)
        {
            
            Account acc1 = new Account(1, "Gustavo", 500.0);
            Account acc2 = new SavingsAccount(2, "José", 500.0, 0.1);

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1);
            Console.WriteLine(acc2);

        }
    }
}