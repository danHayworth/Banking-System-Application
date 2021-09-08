using BankAccounts.Models;
using BankAccounts.Data;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace BankAccounts.Controllers
{
    public class TransactionController
    {
        //add a list for transactions 
        public static List<Transactions> statement = new List<Transactions>();
        //create a new connection to database
        SqliteConnection conn = new SqliteConnection();

        //add transaction
        public void Addtransaction(int account, DateTime date, string type, double amount, double balance)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                con.Execute("Insert into Transactions (Account, Date, Type, Amount, Balance) values ( @Account, @Date, @Type, @Amount, @Balance)", new { Account = account, Date=date, Type = type, Amount = amount, Balance = balance});
            }
        }

        //get list of all transactions
        public List<Transactions> GetTransactions( int id)
        {
            using (IDbConnection connection = new SQLiteConnection(conn.ConnSqlite()))
            {
                var tr = connection.Query<Transactions>("Select * from Transactions Where Account=@id", new { Id = id }).ToList();
                statement.Clear();
                statement.AddRange(tr);
            }
            return statement;
        }
    }

}
