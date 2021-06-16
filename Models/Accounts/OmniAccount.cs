using System;
using System.Windows.Forms;

namespace BankAccounts.Models
{
    public class OmniAccount : Account
    {
        protected double _interestRate;
        protected double _failedFee = 10;
        protected double _overdraft;
        public OmniAccount(double aBalance, double interestRate, double overdraft) : base(aBalance)
        {
            _interestRate = interestRate;
            _overdraft = overdraft;
        }
        public override double GetInterest() => _interestRate;
        public override double GetFee() => _failedFee;
        public override double GetOverdraft() => _overdraft;
        public override void Withdraw(double withdraw)
        {
            if ((_aBalance + _overdraft) < withdraw || _aBalance <= (0 - _overdraft))
            {
                _aBalance -= _failedFee;
                MessageBox.Show("Not sufficient funds for this withdrawal. A fee of $10 has been applied. Your new balance is "+_aBalance);
                var fees = new Transactions(DateTime.Now, "Failed Fee", GetFee(), getBalance());
                frmLogin.statement.Add(fees);
            }
            else
            {
                _aBalance -= withdraw;
                MessageBox.Show("Transfer complete. Your new balance is "+_aBalance);
                if (withdraw > 0)
                {
                    var withd = new Transactions(DateTime.Now, "Withdrawal", withdraw, getBalance());
                    frmLogin.statement.Add(withd);
                }

            }
        }
    }
}
