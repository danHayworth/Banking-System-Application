using System.ComponentModel.DataAnnotations;

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
        }

        public abstract void Withdraw( double withdraw);
    }
}
