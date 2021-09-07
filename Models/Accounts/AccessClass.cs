using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Models.Accounts
{

    //generated class for all types of accounts 
    public class AccessClass
    {
        public int Id { get; private set; }
        public int Customer { get; private set;}
        public int AccountType { get; private set;  }
        public double Balance { get; private set; }
        public double Interest { get; private set; }
        public double Overdraft { get; private set; }
    }
}
