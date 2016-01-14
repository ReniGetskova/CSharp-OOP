namespace BankAccounts
{
    using System.Collections.Generic;

    public interface IBank
    {
        void AddAccount(Account account);

        IEnumerable<Account> Accounts {get;}
    }
}
