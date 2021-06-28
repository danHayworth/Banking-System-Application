﻿using BankAccounts.Data;
using BankAccounts.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace BankAccounts
{
    class CustomerController
    {
        SqliteConnection conn = new SqliteConnection();
        
        public static List<Customer> people = new List<Customer>();
        public static List<Customer> isClient = new List<Customer>();
        public static List<Customer> isStaff = new List<Customer>();
        public static string userLoggedIn;
        public void SaveCustomer(string name, string contact, string username, string password, int staff)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                con.Execute("Insert into Customer (Name, Contact, Username, Password, Staff) values (@Name, @Contact, @Username, @Password, @Staff)", new { Name = name, Contact = contact, Username = username, Password = password, Staff = staff });
            }
        }

        public List<Customer> GetCustomers()
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var pep = con.Query<Customer>("Select * from Customer");
                return pep.ToList();
                
            }
        }

        public Customer GetCustomerById(int id)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var client = con.QuerySingleOrDefault<Customer>("Select * from Customer Where Id = @id", new { Id = id });
                return client;
            }
        }
        public void UpdateCustomer(int id, string name, string contact, string user, string pass, int staff)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var x = con.Execute("Update Customer SET Name = @Name, Contact = @Contact, Username = @Username, Password = @Password, Staff = @Staff WHERE Id = @Id", new { Id = id, Name = name, Contact = contact, Username = user, Password = pass, Staff = staff });
            }
        }
        public void DeleteCustomer(int id)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                con.Execute("Delete from Customer Where Id = @id", new { Id = id });
            }
        }
    }
}
