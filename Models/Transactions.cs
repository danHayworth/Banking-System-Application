using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankAccounts.Models
{
    public class Transactions
    {
        static int nextIdT;
        private int _id { get; set; }
        private DateTime _date { get; set; }
        private string _type { get; set; }
        private double _amount { get; set; }
        private double _balance { get; set; }

        public Transactions(DateTime date, string type, double amount, double balance)
        {
            _id = Interlocked.Increment(ref nextIdT);
            _date = date;
            _type = type;
            _amount = amount;
            _balance = balance;
        }
        public int Id() => _id;
        public DateTime Date() => _date;
        public string Type() => _type;
        public double Amount() => _amount;
        public double Balance() => _balance;

    }
}
