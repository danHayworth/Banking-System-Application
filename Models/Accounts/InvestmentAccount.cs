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
    public class InvestmentAccount : Account
    {
        //add extra field and set up a fee 
        protected double _interestRate { get; set; }
        protected double _fee = 10;
        public InvestmentAccount(double aBalance, double interestRate, int customer) : base(aBalance, customer)
        
        {
            _interestRate = interestRate;
        }
        // override the interest and fee with self attributes
        public override double GetInterest() => _interestRate;
        public override double GetFee() => _fee;

        //override withdraw
        public override void Withdraw(double withdraw)
        {
            
        }

    }
}
