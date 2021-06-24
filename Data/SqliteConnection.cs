using BankAccounts.Models;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace BankAccounts.Data
{
    public class SqliteConnection
    {
        private static string ConnectionSqlite( string id = "BitBank")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void SaveCustomer(Customer customer)
        {
            using (IDbConnection con = new SQLiteConnection(ConnectionSqlite()))
            {
                con.Execute("Insert into Customer (Name, Contact, Username, Password, Staff) values (@_cName, @_cContact, @_cUsername, @_cPassword, @_isStaff) ", customer);
            }
        }

        public static List<Customer> GetCustomers()
        {
            using (IDbConnection con = new SQLiteConnection(ConnectionSqlite()))
            {
                var people = con.Query<Customer>("Select * from Customer");
                return people.ToList();
            }
        }
    }
}
