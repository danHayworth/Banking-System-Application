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
        private int _customer { get; set; }
        protected double _aBalance { get; set; }
        public Account(double aBalance, int customer)
        {
            // auto incrementing the id
            _aId = Interlocked.Increment(ref nextIdA);
            _aBalance = aBalance;
            _customer = customer;
        }
        public int GetId() => _aId;
        public int GetCustomer() => _customer;
        public double GetBalance() => _aBalance;
        

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

        
    }
}
