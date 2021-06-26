using BankAccounts.Models;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace BankAccounts.Data
{
    class SqliteConnection
    {
        public string ConnSqlite( string id = "BitBank")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public void SaveCustomer(Customer customer)
        {
            using (IDbConnection con = new SQLiteConnection(ConnSqlite()))
            {
                con.Execute("Insert into Customer (Name, Contact, Username, Password, Staff) values (@_cName, @_cContact, @_cUsername, @_cPassword, @_isStaff) ", customer);
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
    }
}
