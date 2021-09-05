using BankAccounts.Data;
using BankAccounts.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccounts.Controllers
{
    public class AccountController
    {
        //create a new connection to database
        SqliteConnection conn = new SqliteConnection();
        public static List<Account> accounts = new List<Account>();

        /////////***** CRUD OPERATIONS *****\\\\\\\\

        //add customer
        public void AddAccount(int customer, int accountType, double balance, double interest, double overdraft)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                con.Execute("Insert into Account ( Customer, AccountType, Balance, Interest, Overdraft) values ( @Customer, @AccountType, @Balance, @Interest, @Overdraft)", new {Customer = customer, AccountType = accountType, Balance = balance, Interest = interest, Overdraft = overdraft });
            }
        }

        //not functional yet
        public async Task<IEnumerable<Account>> GetAccounts()
        {
            IEnumerable<Account> accounts;
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                accounts = await con.QueryAsync<Account>("Select * from Account");

               
            }
            return accounts;
        }

        //not functional
        public async Task<IEnumerable<Account>> GetAccountByCustomer(int id)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var clientAccount = await con.Query<Account>("Select * from Account Where Customer = @id", new { Customer = id });
                return clientAccount;
            }
        }

        // edit/ update account
        public void UpdateAccount(int id, int customer, int accountType, double balance, double interest, double overdraft)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var x = con.Execute("Update Account SET Customer = @Customer, AccountType = @AccountType, Balance = @Balance, Interest = @Interest, Overdraft = @Overdraft WHERE Id = @Id", new { Id = id, Customer = customer, AccountType = accountType, Balance = balance, Interest = interest, Overdraft = overdraft });
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
