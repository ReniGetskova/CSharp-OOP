namespace BankAccounts
{
    using System;

    public class StartPoint
    {
        static void Main()
        {
            Bank accounts = new Bank();
            accounts.AddAccount(new Deposit(CustomerType.Individual, 300, 0.07M));
            accounts.AddAccount(new Deposit(CustomerType.Company, 10000, 0.08M));
            accounts.AddAccount(new Loan(CustomerType.Individual, 2000, 0.03M));
            accounts.AddAccount(new Loan(CustomerType.Company, 12000, 0.04M));
            accounts.AddAccount(new Mortgage(CustomerType.Individual, 15000, 0.02M));
            accounts.AddAccount(new Mortgage(CustomerType.Company, 30000, 0.05M));

            foreach (var account in accounts.Accounts)
            {
                Console.WriteLine(account);
                Console.WriteLine();
            }

            Console.WriteLine("Calculated interest for each type account");
            foreach (var account in accounts.Accounts)
            {
                Console.WriteLine("{0}: {1}",account.GetType().Name, account.CalculateInterest(10));
            }
            Console.WriteLine();

            Deposit myDeposit = new Deposit(CustomerType.Individual, 1500, 0.05M);
            Console.WriteLine("My account transaction:");
            myDeposit.Deposit(500);
            myDeposit.Withdraw(700);
            Console.WriteLine(myDeposit);
        }
    }
}
