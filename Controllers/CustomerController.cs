using BankAccounts.Data;
using BankAccounts.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace BankAccounts
{
    /// <summary>
    /// Customer controller class fro CRUD operations
    /// </summary>
    public class CustomerController
    {

        SqliteConnection conn = new SqliteConnection();

        //add some lists that will hold data from database 
        public static List<Customer> people = new List<Customer>();
        public static List<Customer> isClient = new List<Customer>();
        public static string userLogged = "";
        //save the loggedd client in astatic variable to parse it on other forms 
        public static string userLoggedIn;

        /////////***** CRUD OPERATIONS *****\\\\\\\\

        /// <summary>
        /// Method to add customers
        /// </summary>
        /// <param name="name"></param>
        /// <param name="contact"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="staff"></param>
        public void SaveCustomer(string name, string contact, string username, string password, int staff)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                con.Execute("Insert into Customer (Name, Contact, Username, Password, Staff) values (@Name, @Contact, @Username, @Password, @Staff)", new { Name = name, Contact = contact, Username = username, Password = password, Staff = staff });
            }
        }

        /// <summary>
        /// //pull customers and transform the IEnumerable into  a list to be able to save it in the above lists
        /// </summary>
        /// <returns> a List of Customer </returns>
        public List<Customer> GetCustomers()
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var pep = con.Query<Customer>("Select * from Customer");
                return pep.ToList();
            }
        }

        /// <summary>
        /// Get customer by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns> customer </returns>
        public Customer GetCustomerById(int id)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var client = con.QuerySingleOrDefault<Customer>("Select * from Customer Where Id = @id", new { Id = id });
                return client;
            }
        }

        /// <summary>
        /// Updating customer
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="contact"></param>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <param name="staff"></param>
        public void UpdateCustomer(int id, string name, string contact, string user, string pass, int staff)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var x = con.Execute("Update Customer SET Name = @Name, Contact = @Contact, Username = @Username, Password = @Password, Staff = @Staff WHERE Id = @Id", new { Id = id, Name = name, Contact = contact, Username = user, Password = pass, Staff = staff });
            }
        }

        /// <summary>
        /// Deleting customer
        /// </summary>
        /// <param name="id"></param>
        public void DeleteCustomer(int id)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                con.Execute("Delete from Customer Where Id = @id", new { Id = id });
            }
        }
        /// <summary>
        /// Getting the customer if it is staff or not
        /// </summary>
        /// <param name="id"></param>
        /// <returns> staff </returns>
        public int GetStaff(int id)
        {
            using (IDbConnection con = new SQLiteConnection(conn.ConnSqlite()))
            {
                var staff = con.QuerySingleOrDefault<int>("Select Staff from Customer Where Id = @id", new { Id = id });
                return staff;
            }
        }
    }
}
