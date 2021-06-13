using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Models
{
    class OmniAccount : Account
    {
        private decimal _interestRate;
        private int _failedFee = 10;
        private int _overdraft;
        public OmniAccount(int aId, double aBalance, decimal interestRate, int failedFee, int overdraft) : base(aId, aBalance)
        {
            interestRate = _interestRate;
            failedFee = _failedFee;
            overdraft = _overdraft;
        }
    }
}
