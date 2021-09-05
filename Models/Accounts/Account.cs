using BankAccounts.Controllers;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;
using System.Windows.Forms;

namespace BankAccounts.Models
{
    public abstract class Account
    {
        /* Student Id: 92060016
         * Name: Dan Hayworth
         * Date: 17-06-2021
         */
        static int nextIdA;
        private int _aId { get; set; }

        [ForeignKey("Id")]
        private Customer _customer { get; set; }
        protected double _aBalance { get; set; }
        public Account(double aBalance, Customer customer)
        {
            // auto incrementing the id
            _aId = Interlocked.Increment(ref nextIdA);
            _aBalance = aBalance;
            _customer = customer;
        }

        public int GetId()
        {
            return _aId;
        }
        public Customer GetCustomer() => _customer;
        public double GetBalance()
        {
            return _aBalance;
        }
        //adding method for deposits based on amount called deposit
        public virtual void Deposit(double deposit)
        {
            _aBalance += deposit;
            //if the deposit is greater than 0 then perform calculations and show  notification
            if(deposit > 0)
            {
                MessageBox.Show("Transfer complete. Your new balance is " + GetBalance());
                var dep = new Transactions(DateTime.Now, "Deposit", deposit, GetBalance());
                TransactionController.statement.Add(dep);
            }
                   
        }
        // setting an abstract method for withdrawals 
        public abstract void Withdraw( double withdraw);

        // since not all have interest but they may have in future we set up a virtual interest, fee and overdraft
        public virtual double GetInterest() 
        {
            return 0;
        }
        public virtual double GetFee()
        {
            return 0;
        }
        public virtual double GetOverdraft()
        {
            return 0;
        }
        //perform calculation for interest based on a percentage interest
        public virtual void CalculateInterest( double interest)
        {
           double a = interest * GetBalance() / 100;
            _aBalance += a;
            var inter = new Transactions(DateTime.Now, "Interest", a, GetBalance());
            TransactionController.statement.Add(inter);
        }

        
    }
}
