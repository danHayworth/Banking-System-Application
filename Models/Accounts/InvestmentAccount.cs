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
        public InvestmentAccount(int aId, double aBalance, double interestRate) : base(aId, aBalance)
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
                MessageBox.Show("Not sufficient funds for this withdrawal, $10 fee has been applied");
            }
            else
            {
                _aBalance -= withdraw;
                MessageBox.Show("Transfer complete.");
            }
        }

    }
}
