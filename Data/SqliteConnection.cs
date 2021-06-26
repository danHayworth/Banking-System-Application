using BankAccounts.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace BankAccounts.Data
{
    class SqliteConnection
    {
        public string ConnSqlite(string id = "BitBank")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public void SaveCustomer(string name, string contact, string username, string password, int staff)
        {
            using (IDbConnection con = new SQLiteConnection(ConnSqlite()))
            {
               con.Execute("Insert into Customer (Name, Contact, Username, Password, Staff) values (@Name, @Contact, @Username, @Password, @Staff)", new { Name = name, Contact = contact, Username = username, Password = password, Staff = staff });  
            }
        }

        public List<Customer> GetCustomers()
        {
            using (IDbConnection con = new SQLiteConnection(ConnSqlite()))
            {
                var pep = con.Query<Customer>("Select * from Customer");
                return pep.ToList();
            }
        }

        public Customer GetCustomerById(int id)
        {
            using (IDbConnection con = new SQLiteConnection(ConnSqlite()))
            {
                var client = con.QuerySingleOrDefault<Customer>("Select * from Customer Where Id = @id", new { Id = id });
                return client;
            }
        }
        public void UpdateCustomer(int id, string name, string contact, int staff)
        {
            using (IDbConnection con = new SQLiteConnection(ConnSqlite()))
            {
                var x = con.Execute("Update Customer SET Name = @Name, Contact = @Contact, Staff = @Staff WHERE Id = @Id", new { Id = id, Name = name, Contact = contact, Staff = staff });
               
            }
        }
    }

}
