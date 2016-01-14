namespace BankAccounts
{
    using System;

    public class Loan : Account
    {
        public Loan(CustomerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months cannot be < 0");
            }

            if ((this.Customer == CustomerType.Individual && months <= 3) || (this.Customer == CustomerType.Company && months <= 2))
            {
                return 0;
            }

            return this.Balance * (this.InterestRate / 100) * (months - (this.Customer == CustomerType.Individual ? 3 : 2));
        }
    }
}
