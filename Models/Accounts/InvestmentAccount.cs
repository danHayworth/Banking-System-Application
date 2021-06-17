using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccounts.Models
{
    public class InvestmentAccount : Account
    {
        protected double _interestRate;
        protected double _fee = 10;
        public InvestmentAccount(double aBalance, double interestRate) : base(aBalance)
        {
            _interestRate = interestRate;
        }
        public override double GetInterest() => _interestRate;
        public override double GetFee() => _fee;
        public override void Withdraw(double withdraw)
        {
            if (_aBalance < withdraw)
            {
                _aBalance -= _fee;
                MessageBox.Show("Not sufficient funds for this withdrawal, $10 fee has been applied. Your new balance is "+_aBalance);
                var fees = new Transactions(DateTime.Now, "Failed Fee", GetFee(), getBalance());
                frmLogin.statement.Add(fees);
            }
            else
            {
                _aBalance -= withdraw;
                
                if (withdraw > 0)
                {
                    MessageBox.Show("Transfer complete. Your new balance is " + _aBalance);
                    var withd = new Transactions(DateTime.Now, "Withdrawal", withdraw, getBalance());
                    frmLogin.statement.Add(withd);
                }

            }
        }

    }
}
