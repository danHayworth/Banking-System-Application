using System.Configuration;

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
