using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Windows.Forms;

namespace BankAccounts.Models
{
    public abstract class Account
    {
        static int nextIdA;
        private int _aId;
        protected double _aBalance;

        public Account(double aBalance)
        {
            _aId = Interlocked.Increment(ref nextIdA);
            _aBalance = aBalance;
        }

        public int getId()
        {
            return _aId;
        }
        public double getBalance()
        {
            return _aBalance;
        }
        public virtual void Deposit(double deposit)
        {
            _aBalance += deposit;
            MessageBox.Show("Transfer complete. Your new balance is "+ getBalance());
            if(deposit > 0)
            {
                var dep = new Transactions(DateTime.Now, "Deposit", deposit, getBalance());
                frmLogin.statement.Add(dep);
            }
                   
        }
        public abstract void Withdraw( double withdraw);

        public virtual double GetInterest() 
        {
            return 0;
        }
        public virtual double GetFee()
        {
            return 0;
        }
        public virtual void CalculateInterest( double interest)
        {
           double a = interest * getBalance() / 100;
            _aBalance += a;
            var inter = new Transactions(DateTime.Now, "Interest", a, getBalance());
            frmLogin.statement.Add(inter);
        }
    }
}
