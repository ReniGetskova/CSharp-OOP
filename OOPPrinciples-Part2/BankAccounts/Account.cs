namespace BankAccounts
{
    using System;

    public abstract class Account
    {
        protected decimal balance;
        protected decimal interestRate;

        public Account(CustomerType customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public CustomerType Customer { get; private set; }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest cannot be < 0");
                }

                this.interestRate = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance cannot be < 0");
                }

                this.balance = value;
            }
        }

        public virtual decimal CalculateInterest(int months)
        {
            return this.Balance * (this.InterestRate / 100) * months;
        }

        public virtual void Deposit(decimal money)
        {
            this.balance += money;
            Console.WriteLine("Balance after deposit: {0}", this.balance);
        }

        public override string ToString()
        {
            return string.Format("Account Information:\n\tCustomer Type: {0}\n\tBalance: {1}\n\tInterest Rate: {2}",
                                 this.Customer,
                                 this.balance,
                                 this.interestRate);
        }
    }
}
