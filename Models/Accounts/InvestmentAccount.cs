using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        protected double _interestRate;
        protected double _fee = 10;
        public InvestmentAccount(double aBalance, double interestRate) : base(aBalance)
        {
            _interestRate = interestRate;
        }
        // override the interest and fee with self attributes
        public override double GetInterest() => _interestRate;
        public override double GetFee() => _fee;

        //override withdraw
        public override void Withdraw(double withdraw)
        {
            if (_aBalance < withdraw)
            {
                //if balance is smaller than the actual withdrawal charge the fee
                _aBalance -= _fee;
                MessageBox.Show("Not sufficient funds for this withdrawal, $10 fee has been applied. Your new balance is "+_aBalance);
                //record transaction for fee
                var fees = new Transactions(DateTime.Now, "Failed Fee", GetFee(), getBalance());
                frmLogin.statement.Add(fees);
            }
            else
            {
                _aBalance -= withdraw;
                
                if (withdraw > 0)
                {
                    //if there are funds, withdraw without fee and send notification
                    MessageBox.Show("Transfer complete. Your new balance is " + _aBalance);
                    //record transaction
                    var withd = new Transactions(DateTime.Now, "Withdrawal", withdraw, getBalance());
                    frmLogin.statement.Add(withd);
                }

            }
        }

    }
}
