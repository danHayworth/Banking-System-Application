using BankAccounts.Data;
using BankAccounts.Models.Accounts;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace BankAccounts.Controllers
{
    /// <summary>
    /// Account controller for performing CRUD operations
    /// </summary>
    public class AccountController 
    {       
        SqliteConnection conn = new SqliteConnection();
        /// <summary>
        /// Public List accounts that will hold the accounts from db while running
        /// </summary>
        public static List<AccessClass> accounts = new List<AccessClass>();


        /////////***** CRUD OPERATIONS *****\\\\\\\\

        /// <summary>
        /// Creating an account
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="accountType"></param>
        /// <param name="balance"></param>
        /// <param name="interest"></param>
        /// <param name="overdraft"></param>
        public void AddAccount(int customer, int accountType, double balance, double interest, double overdraft)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                con.Execute("Insert into Account ( Customer, AccountType, Balance, Interest, Overdraft) values ( @Customer, @AccountType, @Balance, @Interest, @Overdraft)", new {Customer = customer, AccountType = accountType, Balance = balance, Interest = interest, Overdraft = overdraft });
            }
        }

        /// <summary>
        /// Updating account
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customer"></param>
        /// <param name="accountType"></param>
        /// <param name="balance"></param>
        /// <param name="interest"></param>
        /// <param name="overdraft"></param>
        public void UpdateAccount(int id, int customer, int accountType, double balance, double interest, double overdraft)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var x = con.Execute("Update Account SET Customer = @Customer, AccountType = @AccountType, Balance = @Balance, Interest = @Interest, Overdraft = @Overdraft WHERE Id = @Id", new { Id = id, Customer = customer, AccountType = accountType, Balance = balance, Interest = interest, Overdraft = overdraft });
            }
        }

        /// <summary>
        /// Delete account
        /// </summary>
        /// <param name="id"></param>
        public void DeleteAccount(int id)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                con.Execute("Delete from Account Where Id = @id", new { Id = id });
            }
        }

        /// <summary>
        /// Accessing all accounts in database
        /// </summary>
        /// <returns>List of accounts model based</returns>
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

        /// <summary>
        /// Accessing individual account
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Account model </returns>
        public AccessClass GetAccountById(int id)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var x = con.QuerySingleOrDefault<AccessClass>("Select * from Account Where Id = @id", new { Id = id });
                return x;
            }
        }

        /// <summary>
        /// Retrieve an account by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns> the name of the account </returns>
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
        /// <summary>
        /// Updates the account balance based in the id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="balance"></param>
        public void updateBalance(int id, double balance)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                con.Execute("Update Account SET Balance = @Balance Where Id = @id", new { Id = id, Balance = balance });
            }
        }
        /// <summary>
        /// Get the account balance based on its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public double getAccBalance(int id)
        {
            double balance;
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                
                var c = con.QueryFirstOrDefault<double>("Select Balance from Account Where Id=@id", new { Id = id });
                balance = c;
            }
            return balance;
        }
        /// <summary>
        /// Method to deposit funds
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deposit"></param>
        public void Deposit(int id, double deposit)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                double balance = getAccBalance(id);
                balance += deposit;
                updateBalance(id, balance);
            }
        }
        /// <summary>
        /// Method to withdraw funds
        /// </summary>
        /// <remarks>
        /// The calculations are performed as per the account type
        /// since some accounts have overdraft as well
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="withdraw"></param>
        /// <param name="staff"></param>
        /// <param name="overdraft"></param>
        public void Withdraw(int id, int type, double withdraw, int staff, double overdraft)
        {
            double fee = 10;
            double balance = getAccBalance(id);
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                if(type == 3)
                {
                    if ((balance + overdraft) < withdraw || balance <= (0 - overdraft))
                    {
                        if(staff == 1)
                        {
                            balance -= (fee / 2);
                      
                        }
                        else
                        {
                            balance -= fee;
                            
                        }
                        updateBalance(id, balance);

                    }
                    else
                    {
                        balance -= withdraw;
                        updateBalance(id, balance);
                    }
                }
                else
                {
                    if (balance < withdraw)
                    {
                        if (staff == 1)
                        {
                            balance = balance - withdraw - (fee / 2);
                          
                        }
                        else
                        {
                            balance = balance - withdraw - fee;
                        }
                        updateBalance(id, balance);
                    }
                    else
                    {
                        balance -= withdraw;
                        updateBalance(id, balance);
                    }
                }
                
            }
                
        }
    }
}
