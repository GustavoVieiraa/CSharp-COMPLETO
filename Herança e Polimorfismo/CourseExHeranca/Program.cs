using System;
using CourseExHeranca.Entities;

namespace CourseExHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(01, "Gustavo", 0);
            BusinessAccount bacc = new BusinessAccount(02, "GV Developer", 0, 500.0);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(03, "MegaTron", 50.0, 500.0);
            Account acc3 = new SavingsAccount(04, "FaceTrue", 0, 300.0);


            // DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            // BusinessAccount acc5 = (BusinessAccount)acc3;
            
            if (acc3 is BusinessAccount)
            {
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(350.00);
                Console.WriteLine(acc5);
            }

            if (acc3 is SavingsAccount)
            {
                // SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine($"Good -> \n{acc5}");
            }
        }
    }
}  