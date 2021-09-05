using BankAccounts.Data;
using BankAccounts.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace BankAccounts.Controllers
{
    class AccountController
    {
        //create a new connection to database
        SqliteConnection conn = new SqliteConnection();


        /////////***** CRUD OPERATIONS *****\\\\\\\\

        //add customer
        public void AddAccount(Customer customer, int accountType, double balance, double interest, double overdraft)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                con.Execute("Insert into Account (Customer, AccountType, Balance, Interest, Overdraft) values (@Customer, @AccountType, @Balance, @Interest, @Overdraft)", new { Customer = customer, AccountType = accountType, Balance = balance, Interest = interest, Overdraft = overdraft });
            }
        }

        //pull accounts and transform the IEnumerable into  a list to be able to save it localy
        public List<Account> GetAccounts()
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var acc = con.Query<Account>("Select * from Account");
                return acc.ToList();
            }
        }

        // get accounts by customer
        public Account GetAccountByCustomer(int id)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var clientAccount = con.QuerySingleOrDefault<Account>("Select * from Account Where Customer = @id", new { Customer = id });
                return clientAccount;
            }
        }

        // edit/ update account
        public void UpdateAccount(int id, Customer customer, int accountType, double balance, double interest, double overdraft)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var x = con.Execute("Update Account SET Customer = @Customer, AccounType = @AccountType, Balance = @balance, Interest = @Interest, Overdraft = @Overdraft WHERE Id = @Id", new { Id = id, Customer = customer, AccountType = accountType, Balance = balance, Interest = interest, Overdraft = overdraft });
            }
        }

        //delete account
        public void DeleteAccount(int id)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                con.Execute("Delete from Account Where Id = @id", new { Id = id });
            }
        }

    }
}
