namespace BankAccounts
{
    using System;

    public class Deposit : Account
    {
        public Deposit(CustomerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public void Withdraw(decimal money)
        {
            if (this.balance - money < 0)
            {
                throw new ArgumentOutOfRangeException("You have not enought money to withdraw");
            }

            this.balance -= money;
            Console.WriteLine("Balance after withdraw: {0}", this.balance);
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months cannot be < 0");
            }

            if (this.Balance < 1000)
            {
                return 0;
            }

            return this.Balance * (this.InterestRate / 100) * months;
        }
    }
}
