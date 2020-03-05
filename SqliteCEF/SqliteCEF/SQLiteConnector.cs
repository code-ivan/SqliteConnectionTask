using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
        private SQLiteConnector()
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
                string connectionString = Base64Encode("Data Source=" + Path + ";Version=3;");
                Connection.ConnectionString = Base64Decode(connectionString);
                Connection.Open();

                return true;
            }
            catch
            {
                throw;
            }
        }

        public override void Close()
        {
            try
            {
                Connection.Close();
            }
            catch
            {
                throw;
            }

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
                    tables.Append(row.ItemArray[0].ToString()).Append("|");
                }

                return tables.ToString();
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetDataTable(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                SQLiteCommand command = new SQLiteCommand(query, Connection);
                SQLiteDataReader reader = command.ExecuteReader();

                dt.Load(reader);

                return dt;
            }
            catch
            {
                throw;
            }
        }

        public override string GetTableData(string tableName)
        {
            try
            {
                string query = $"SELECT name FROM PRAGMA_TABLE_INFO('{tableName}')";

                DataTable dt = GetDataTable(query);
                StringBuilder tableData = new StringBuilder();


                foreach (DataRow row in dt.Rows)
                {
                    tableData.Append(row.ItemArray[0].ToString()).Append("|");
                }

                return tableData.ToString();
            }
            catch
            {
                throw;
            }

        }

        public override string GetViews(string tableName)
        {
            throw new NotImplementedException();
        }

        public override int GetLastID(string columnName, string tableName)
        {
            try
            {
                string query = $"SELECT MAX({columnName}) FROM {tableName}";
                SQLiteCommand command = new SQLiteCommand(query, Connection);
                object result = command.ExecuteScalar();

                return Convert.ToInt32(result);
            }
            catch
            {
                throw;
            }

        }

        public override async Task<CEFFormat> Select(string query)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand(query, Connection);
                DbDataReader reader = await command.ExecuteReaderAsync();

                CEFFormat format = new CEFFormat();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        format.Version = reader.GetValue(0).ToString();
                        format.Device_Vendor = reader.GetValue(1).ToString();
                        format.Device_Product = reader.GetValue(2).ToString();
                        format.Device_Version = reader.GetValue(3).ToString();
                        format.DeviceEventClassId = reader.GetValue(4).ToString();
                        format.Name = reader.GetValue(5).ToString();
                        format.Severity = reader.GetValue(6).ToString();
                        format.Extension = reader.GetValue(7).ToString();
                    }
                }

                return format;
            }
            catch
            {
                throw;
            }
        }

        private string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        private string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }
}

