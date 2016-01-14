namespace BankAccounts
{
    using System;

    public class Mortgage : Account
    {
        public Mortgage(CustomerType customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months cannot be < 0");
            }

            if (this.Customer == CustomerType.Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }

                return this.Balance * (this.InterestRate / 100) * (months - 6);
            }

            if (months <= 12)
            {
                return (this.Balance * (this.InterestRate / 100) * months) / 2;
            }

            return this.Balance * (this.InterestRate / 100) * (months - 12) + (this.Balance * (this.InterestRate / 100) * 6);
        }
    }
}
