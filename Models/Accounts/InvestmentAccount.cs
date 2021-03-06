using BankAccounts.Controllers;
using System;
using System.Windows.Forms;

namespace BankAccounts.Models
{
    /* Student Id: 92060016
    * Name: Dan Hayworth
    * Date: 17-06-2021
    */
   /// <summary>
   /// Investment account model
   /// </summary>
    public class InvestmentAccount : Account
    {
        //add extra field and set up a fee 
        protected double _interestRate { get; set; }
        public InvestmentAccount(double aBalance, double interestRate, int customer) : base(aBalance, customer)
        
        {
            _interestRate = interestRate;
        }
        // override the interest and fee with self attributes
        public override double GetInterest() => _interestRate;

    }
}
