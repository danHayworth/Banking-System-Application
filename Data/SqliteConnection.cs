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
        // create a public string connection to connect to the database
        public string ConnSqlite(string id = "BitBank")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }

}
