using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccounts.Models
{
    public class OmniAccount : Account
    {
        protected double _interestRate;
        protected double _failedFee = 10;
        private int _overdraft;
        public OmniAccount(int aId, double aBalance, double interestRate, int overdraft) : base(aId, aBalance)
        {
            _interestRate = interestRate;
            _overdraft = overdraft;
        }
        public override double GetInterest() => _interestRate;
        public override double GetFee() => _failedFee;
        public override void Withdraw(double withdraw)
        {
            if ((_aBalance + _overdraft) < withdraw || _aBalance <= (0 - _overdraft))
            {
                _aBalance -= _failedFee;
                MessageBox.Show("Not sufficient funds for this withdrawal. A fee of $10 has been applied. Your new balance is "+_aBalance);
            }
            else
            {
                _aBalance -= withdraw;
                MessageBox.Show("Transfer complete. Your new balance is "+_aBalance);
            }
        }
    }
}
