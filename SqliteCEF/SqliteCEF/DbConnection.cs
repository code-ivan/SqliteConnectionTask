using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SqliteCEF
{
    public abstract class DbConnector 
    {
        public DbConnector()
        {
        }

        public string DatabaseName { get; set; } = string.Empty;
        public string IP { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Port { get; set; } = string.Empty;

        private readonly DbConnector connection = null;
        public DbConnector Connection
        {
            get { return connection; }
        }

        private static DbConnector _instance = null;
        public static DbConnector Instance()
        {
            return _instance;
        }

        public abstract bool IsConnect();

        public abstract void Close();

        public abstract string GetTables();

        public abstract string GetTableData(string tableName);

        public abstract string GetViews(string tableName);

        public abstract int GetLastID(string columnName, string tableName);

        public abstract Task<CEFFormat> Select(string query);

    }
}
