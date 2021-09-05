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
        protected double _failedFee = 10;
        protected double _overdraft;
        public OmniAccount(double aBalance, double interestRate, double overdraft, Customer customer) : base(aBalance, customer )
        {
            _interestRate = interestRate;
            _overdraft = overdraft;
        }
        //override the methods 
        public override double GetInterest() => _interestRate;
        public override double GetFee() => _failedFee;
        public override double GetOverdraft() => _overdraft;
        public override void Withdraw(double withdraw)
        {
            if ((_aBalance + _overdraft) < withdraw || _aBalance <= (0 - _overdraft))
            {
                _aBalance -= _failedFee;
                MessageBox.Show("Not sufficient funds for this withdrawal. A fee of $10 has been applied. Your new balance is "+_aBalance);
                var fees = new Transactions(DateTime.Now, "Failed Fee", GetFee(), GetBalance());
                TransactionController.statement.Add(fees);
            }
            else
            {
                _aBalance -= withdraw;
                
                if (withdraw > 0)
                {
                    MessageBox.Show("Transfer complete. Your new balance is " + _aBalance);
                    var withd = new Transactions(DateTime.Now, "Withdrawal", withdraw, GetBalance());
                    TransactionController.statement.Add(withd);
                }

            }
        }
    }
}
