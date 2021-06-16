using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Models
{
    public class InvestmentAccount : Account
    {
        private double _interestRate;
        public double fee = 10;
        public InvestmentAccount(int aId, double aBalance, double interestRate) : base(aId, aBalance)
        {
            _interestRate = interestRate;
        }

        public override void Withdraw(double withdraw)
        {
            if (_aBalance < withdraw)
            {
                _aBalance -= fee;
                throw new InvalidOperationException("Not sufficient funds for this withdrawal, $10 fee has been applied");
            }
            else
            {
                _aBalance -= withdraw;
            }
        }


    }
}
