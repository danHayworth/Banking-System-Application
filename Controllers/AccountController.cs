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

        public AccessClass GetAccountById(int id)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var x = con.QuerySingleOrDefault<AccessClass>("Select * from Account Where Id = @id", new { Id = id });
                return x;
            }
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

        public void Deposit(int id, double deposit)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                double balance = getAccBalance(id);
                balance += deposit;
                updateBalance(id, balance);
            }
        }

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
