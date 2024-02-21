namespace CourseExSobreposicao.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public int QuantityLoans { get; set; }


        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
                LoanLimit -= amount;
                QuantityLoans++;
            }
            else
            {
                Console.WriteLine("Do you not have limit to this operation.");
            }
            
        }

        public override string ToString()
        {
            return "=------Business------=\n"
                + $"|Account Business| #{Number}\n"
                + $"|Holder| {Holder} \n"
                + $"|Balance| ${Balance} \n"
                + $"|Loan| ${LoanLimit} \n" 
                + $"|Quantity Loans| {QuantityLoans}\n"
                + "=------Business------=\n";
        }

    }
}
