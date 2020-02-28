using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteCEF
{
    class SQLiteConnector : DbConnector
    {
        public string Path { get; set; }
        public SQLiteConnector()
        {
        }

        private SQLiteConnection connection = new SQLiteConnection();
        public new SQLiteConnection Connection
        {
            get { return connection; }
        }

        private static SQLiteConnector _instance;
        public new static SQLiteConnector Instance()
        {
            if (_instance == null)
                _instance = new SQLiteConnector();
            return _instance;
        }

        public override bool IsConnect()
        {
            if (Path == String.Empty)
                return false;

            try
            {
                string connectionString = @"Data Source=" + Path + ";Version=3;";
                Connection.ConnectionString = connectionString;
                Connection.Open();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void Close()
        {
            Connection.Close();
        }

        public override string GetTables()
        {
            StringBuilder tables = new StringBuilder();

            string query = "SELECT name FROM sqlite_master " +
                    "WHERE type = 'table'" +
                    "ORDER BY 1";
            try
            {

                DataTable table = GetDataTable(query);


                foreach (DataRow row in table.Rows)
                {
                    tables.Append(row.ItemArray[0].ToString()).Append(" ");
                }
            }
            catch
            {

            }
            return tables.ToString();
        }

        public DataTable GetDataTable(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SQLiteCommand cmd = new SQLiteCommand(query, Connection))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        dt.Load(rdr);
                        return dt;
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        public override string GetTableData(string tableName)
        {
            throw new NotImplementedException();
        }

        public override string GetViews(string tableName)
        {
            throw new NotImplementedException();
        }

        public override int GetLastID(string columnName, string tableName)
        {
            throw new NotImplementedException();
        }

        public override Task<CEFFormat> Select(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, Connection);
            SQLiteDataReader reader = command.ExecuteReader();

            CEFFormat format = new CEFFormat();

            return Task.Run(() =>
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        format.Version = reader.GetString(0);
                        format.Device_Vendor = reader.GetString(1);
                        format.Device_Product = reader.GetString(2);
                        format.Device_Version = reader.GetString(3);
                        format.DeviceEventClassId = reader.GetString(4);
                        format.Name = reader.GetString(5);
                        format.Severity = reader.GetString(6);
                        format.Extension = reader.GetString(7);
                    }
                }

                return format;
            });

        }
    }
}

