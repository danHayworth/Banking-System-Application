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
        public double _failedFee = 10;
        private int _overdraft;
        public OmniAccount(int aId, double aBalance, decimal interestRate, int overdraft) : base(aId, aBalance)
        {
            interestRate = _interestRate;
            overdraft = _overdraft;
        }

        public override void Withdraw(double withdraw)
        {
            throw new NotImplementedException();
        }
    }
}
