using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Models
{
    class Account
    {
        [Key]
        private int _aId;
        private double _aBalance;

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
        public void Deposit( double deposit)
        {
            _aBalance += deposit;
        }
        public void Withdraw(double withdrawal)
        {
            _aBalance -= withdrawal;
        }
    }
}
