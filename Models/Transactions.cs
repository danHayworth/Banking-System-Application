﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace BankAccounts.Models
{
    /* Student Id: 92060016
    * Name: Dan Hayworth
    * Date: 17-06-2021
    */
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
