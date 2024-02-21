namespace CourseExSobreposicao.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0 ;
        }


        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            return "=------Client------=\n"
                + $"|Number Account| #{Number}\n"
                + $"|Holder| {Holder} \n"
                + $"|Balance| ${Balance} \n"
                + "=------Client------=\n";
        }

    }
}
