using System.Configuration;

namespace BankAccounts.Data
{
    class SqliteConnection
    {
        /// <summary>
        /// Creating the SQLite connection string
        /// </summary>
        /// <param name="id"></param>
        /// <returns> a connection string </returns>
        public string ConnSqlite(string id = "BitBank")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }

}
