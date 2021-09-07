using BankAccounts.Controllers;
using System;
using System.Windows.Forms;

namespace BankAccounts.Models
{
    /* Student Id: 92060016
    * Name: Dan Hayworth
    * Date: 17-06-2021
    */
    //inherit account 
    public class OmniAccount : Account
    {
        //set up relevant fields to the account
        protected double _interestRate;
        protected double _overdraft;
        public OmniAccount(double aBalance, double interestRate, double overdraft, int customer) : base(aBalance, customer )
        {
            _interestRate = interestRate;
            _overdraft = overdraft;
        }
        //override the methods 
        public override double GetInterest() => _interestRate;
        public override double GetOverdraft() => _overdraft;

    }
}
