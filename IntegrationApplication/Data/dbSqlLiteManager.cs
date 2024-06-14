using System;
using System.Windows;
using System.Windows.Documents;
using Microsoft.Data.Sqlite;
using SQLitePCL;


namespace integratorApplication.Backend
{
    public class dbSqlLiteManager
    {
        private static string _dbName = "C:\\code\\db-integration-app\\db.sqlite";
        private static SqliteConnection _sqliteConn;
        
        public void DbSqlLiteConnect()
        {
            try
            {
                Batteries.Init();
                // Build connection string using parameters
                string connString = $"Data Source={_dbName}";

                _sqliteConn = new SqliteConnection(connString);

                Console.Out.WriteLine("Opening connection");
                _sqliteConn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to the internal database: " + ex.Message);
            }
        }
        
        public List<IntegratorData> selectAllIntegratorDataTable()
        {
            List<IntegratorData> integratorDataTableList = new List<IntegratorData>();
            try
            {
                using (var command = new SqliteCommand("SELECT * FROM IntegratorDataTable;", _sqliteConn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IntegratorData integratorData = new IntegratorData(

                                reader.IsDBNull(0) ? null :reader.GetString(0),
                                reader.IsDBNull(1) ? null : reader.GetString(1),
                                reader.IsDBNull(2) ? null : reader.GetString(2),
                                reader.IsDBNull(3) ? null : reader.GetString(3),
                                reader.IsDBNull(4) ? null : reader.GetString(4),
                                reader.IsDBNull(5) ? null : reader.GetString(5),
                                reader.IsDBNull(6) ? null : reader.GetString(6)
                            );
                            integratorDataTableList.Add(integratorData);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return integratorDataTableList;
        }
    }
}