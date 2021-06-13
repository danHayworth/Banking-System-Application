using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Models
{
    class InvestmentAccount : Account
    {
        private decimal _interestRate;
        private int _failedFee = 10;
        public InvestmentAccount(int aId, double aBalance, decimal interestRate, int failedFee) : base(aId, aBalance)
        {
            _interestRate = interestRate;
            _failedFee = failedFee;
        }
        protected decimal getInvestInterest()
        {
            return _interestRate;
        }
        protected int getInvestFee()
        {
            return _failedFee;
        }

    }
}
