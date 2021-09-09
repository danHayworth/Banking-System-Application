using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Models.Accounts
{

     /// <summary>
     /// Generate a struct for all the accounts 
     /// </summary>
    public struct AccessClass
    {
        public int Id { get; set; }
        public int Customer { get; set;}
        public int AccountType { get; set;  }
        public double Balance { get; set; }
        public double Interest { get; set; }
        public double Overdraft { get; set; }
    }
}
