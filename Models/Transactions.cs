using System;
using System.Collections.Generic;
using System.Threading;

namespace BankAccounts.Models
{
    /* Student Id: 92060016
    * Name: Dan Hayworth
    * Date: 08-09-2021
    */
    public class Transactions
    {
        private int Id { get; set; }
        private int Account { get; set; }
        private DateTime Date { get; set; }
        private string Type { get; set; }
        private double Amount { get; set; }
        private double Balance { get; set; }

        public Transactions() { }
        public Transactions(int acc, DateTime date, string type, double amount, double balance)
        {
            this.Account = acc;
            this.Date = date;
            this.Type = type;
            this.Amount = amount;
            this.Balance = balance;
        }

        public int GetId() => Id;
        public int GetAcc() => Account;
        public DateTime GetDate() => Date;
        public string GetTType() => Type;
        public double GetAmount() => Amount;
        public double GetBalance() => Balance;
        
    }
}
