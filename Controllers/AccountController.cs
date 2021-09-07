using BankAccounts.Data;
using BankAccounts.Models;
using BankAccounts.Models.Accounts;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccounts.Controllers
{
    public class AccountController 
    {
        //create a new connection to database
        SqliteConnection conn = new SqliteConnection();
        public static List<AccessClass> accounts = new List<AccessClass>();


        /////////***** CRUD OPERATIONS *****\\\\\\\\

        //add customer
        public void AddAccount(int customer, int accountType, double balance, double interest, double overdraft)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                con.Execute("Insert into Account ( Customer, AccountType, Balance, Interest, Overdraft) values ( @Customer, @AccountType, @Balance, @Interest, @Overdraft)", new {Customer = customer, AccountType = accountType, Balance = balance, Interest = interest, Overdraft = overdraft });
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

        //get list of all accounts
        public  List<AccessClass> GetAccounts()
        {
            using(IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                try
                {
                    var acc = con.Query<AccessClass>("Select * from Account", new DynamicParameters()).ToList();
                    accounts.Clear();
                    accounts.AddRange(acc);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }               
            }
            return accounts;
        }

        public string getAccName(int id)
        {
            string name = "";
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var c = con.QueryFirstOrDefault<string>("Select TypeName from AccountTypes Where Id=@id", new { Id = id });
                name = c;
            }
            return name;
        }

        public void updateBalance(int id, double balance)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                con.Execute("Update Account SET Balance = @Balance Where Id = @id", new { Id = id, Balance = balance });
            }
        }
    }
}
