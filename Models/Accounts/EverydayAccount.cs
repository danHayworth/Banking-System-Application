using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Models
{
    class EverydayAccount : Account
    {
        public EverydayAccount(int aId, double aBalance, decimal interestRate, int failFee) : base(aId, aBalance)
        {
        }
    }
}
