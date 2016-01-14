namespace BankAccounts
{
    using System.Collections.Generic;

    public class Bank : IBank
    {
        private List<Account> accounts = new List<Account>();

        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
        }

        public IEnumerable<Account> Accounts
        {
            get { return new List<Account>(this.accounts); }
        }
    }
}
