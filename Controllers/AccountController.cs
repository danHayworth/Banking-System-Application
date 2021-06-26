using BankAccounts.Models;
using System.Collections.Generic;

namespace BankAccounts.Controllers
{
    class AccountController
    {
        public List<Account> accounts = new List<Account>();

        public void AddAccounts()
        {
            Account everyday = new EverydayAccount(200.00);
            Account investment = new InvestmentAccount(1000.00, 10);
            Account omni = new OmniAccount(1500, 10, 500);

            if (accounts.Count.Equals(0))
            {
                accounts.Add(everyday);
                accounts.Add(investment);
                accounts.Add(omni);
            }
        }
    }
}
