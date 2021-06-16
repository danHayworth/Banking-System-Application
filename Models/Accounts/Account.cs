using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace BankAccounts.Models
{
    public abstract class Account
    {
        [Key]
        private int _aId;
        protected double _aBalance;

        public Account(int aId, double aBalance)
        {
            _aId = aId;
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
            MessageBox.Show("Transfer complete.");
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
        }
    }
}
