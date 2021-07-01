using BankAccounts.Models;
using System.Collections.Generic;

namespace BankAccounts.Controllers
{
    class AccountController
    {
        //create a static list for accounts
        public static  List<Account> accounts = new List<Account>();


        //create a method to add manually some accounts for each type 
        public void AddAccounts()
        {
            if (accounts.Count.Equals(0))
            {
                Account everyday = new EverydayAccount(200.00);
                Account investment = new InvestmentAccount(1000.00, 10);
                Account omni = new OmniAccount(1500, 10, 500);
                accounts.Add(everyday);
                accounts.Add(investment);
                accounts.Add(omni);
            }
        }
        // add a method to check whether the client that is logged in is staff
        //so we can apply the discount
        public static bool IsStaff(string name)
        {
            bool correct = false;
            foreach(Customer c in CustomerController.isClient)
            {
                if(name == c.GetName() && c.GetStaff() == 1)
                {
                    correct = true;
                    break;
                }
                else
                {
                    correct = false;
                }
            }
            return correct;
        }

    }
}
