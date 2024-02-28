using ExFixaçãoExceçõesPersonalizadas.Entities.Exceptions;

namespace ExFixaçãoExceçõesPersonalizadas.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < Balance && amount < WithdrawLimit)
            {
                Balance -= amount;
                Console.Write($"New Balance: {Balance}");
            }
            else
            {
                throw new AccountException($"You not have limit for this operation. Your limit is {WithdrawLimit}");
            }
        }

    }
}
