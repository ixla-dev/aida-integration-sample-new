using System;
using System.IO;
using System.Runtime.InteropServices.JavaScript;
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

        private static string[] _imagePaths = new string[]
        {
            "C:\\code\\Resources\\imgTestingId7\\02.bmp",
            "C:\\code\\Resources\\imgTestingId7\\03.bmp",
            "C:\\code\\Resources\\imgTestingId7\\04.bmp",
            "C:\\code\\Resources\\imgTestingId7\\01.bmp",
            "C:\\code\\Resources\\imgtestingId7\\05.bmp"
        };

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

                var data = selectAllIntegratorDataTable();
                if (data.Count == 0)
                {
                    InsertData();
                }
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
                                reader.IsDBNull(0) ? null : reader.GetString(0),
                                reader.IsDBNull(1) ? null : reader.GetString(1),
                                reader.IsDBNull(2) ? null : reader.GetString(2),
                                reader.IsDBNull(2) ? null : reader.GetString(3),
                                reader.IsDBNull(2) ? null : reader.GetString(4),
                                reader.IsDBNull(2) ? null : reader.GetString(5)
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

        public void InsertData()
        {
            int counter = 1;
            foreach (var imagePath in _imagePaths)
            {
                byte[] imageBlob = File.ReadAllBytes(imagePath);
                string textFront = GenerateTextFront(counter);
                string textRear = GenerateTextRear(counter);
                string magneticTrack1 = GenerateMagneticTrack1(counter);
                string magneticTrack2 = GenerateMagneticTrack2(counter);
                string magneticTrack3 = GenerateMagneticTrack3(counter);
                

                // DB INSERT
                string insertQuery =
                    "INSERT INTO IntegratorDataTable (TextFront) " +
                    "VALUES (@textFront)";
                using (var cmd = new SqliteCommand(insertQuery, _sqliteConn))
                {
                    // cmd.Parameters.AddWithValue("@imgFront", imageBlob);
                    cmd.Parameters.AddWithValue("@textFront", textFront);
                    // cmd.Parameters.AddWithValue("@textRear", textRear);
                    // cmd.Parameters.AddWithValue("@magneticTrack1", magneticTrack1);
                    // cmd.Parameters.AddWithValue("@magneticTrack2", magneticTrack2);
                    // cmd.Parameters.AddWithValue("@magneticTrack3", magneticTrack3);
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("Inserted data successfully.");
                counter++;
            }
        }

        private string GenerateMagneticTrack3(int counter)
        {
            return counter.ToString("D9");
        }

        private string GenerateMagneticTrack2(int counter)
        {
            return counter.ToString();
        }

        private string GenerateMagneticTrack1(int counter)
        {
            return "TRACK1" + counter.ToString("D5");
        }

        //receive in input the incremented number for generate a string with 5 decimal and F at the end. example 00001F. 
        static string GenerateTextFront(int counter)
        {
            return counter.ToString("D5") + "F";
        }        
        
        //idem but with R in the end
        static string GenerateTextRear(int counter)
        {
            return counter.ToString("D5") + "R";
        }
    }
}