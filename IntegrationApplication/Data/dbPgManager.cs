using System.Data;
using System.Windows;
using System.Windows.Documents;
using Aida.Sdk.Mini.Model;
using Npgsql;

namespace integratorApplication.Backend;

public class dbPgManager
{
    private  string _user = "postgres";
    private  string _dBname = "ixla_iws";
    private  string _password = "root";
    private  string _port = "5432";

    private  NpgsqlConnection _pgConn;

    public bool DbPgConnect(string host)
    {
        try
        {
            // Build connection string using parameters
            string connString = String.Format(
                "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                host, _user, _dBname, _port, _password);

            _pgConn = new NpgsqlConnection(connString);

            Console.Out.WriteLine("Opening connection");
            _pgConn.Open();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error connecting to the database: " + ex.Message);
            return false;
        }
    }


    public List<string> GetColumnNames(NpgsqlDataReader reader)
    {
        var names = new List<string>();
        var fieldCount = reader.FieldCount;
        for (var i = 0; i < fieldCount; i++)
        {
            names.Add(reader.GetName(i));
        }

        return names;
    }

    //select entity from DETName
    public DataTable SelectEntityFromDET(string detName, List<EntityDescriptor> columns)
    {
        DataTable dataTable = new DataTable();
        try
        {
            string columnNames = string.Join(", ", columns.Select(c => $"\"{c.EntityName}\""));

            string query = $@"SELECT {columnNames} FROM {detName}";

            using (var command = new NpgsqlCommand(query, _pgConn))
            {
                using (var reader = command.ExecuteReader())
                {
                    // add dynamic columns
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataTable.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                    }
                    //add rows
                    while (reader.Read())
                    {
                        DataRow row = dataTable.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[i] = reader.GetValue(i);
                        }
                        dataTable.Rows.Add(row);
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return dataTable;
    }
    
    //select all from DET
    public DataTable SelectAllFromDET(string detName)
    {
        DataTable dataTable = new DataTable();
        try
        {
            string query = $@"SELECT * FROM {detName} ORDER BY job_status DESC";

            using (var command = new NpgsqlCommand(query, _pgConn))
            {
                using (var reader = command.ExecuteReader())
                {
                    // Add dynamic columns
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataTable.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                    }
                    // Add rows
                    while (reader.Read())
                    {
                        DataRow row = dataTable.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[i] = reader.GetValue(i);
                        }
                        dataTable.Rows.Add(row);
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return dataTable;
    }

    

    //insert example record in DET table
    public void InsertEmptyRecord(List<EntityDescriptor> columns, string detName)
    {
        try
        {
            // create columnName and columnValues List
            string columnNames = string.Join(", ", columns.Select(c => $"\"{c.EntityName}\""));
            string parameterNames  = string.Join(", ", columns.Select(c => $"@{c.EntityName}"));

            // build query
            string query = $@"
            INSERT INTO {detName}
            ({columnNames})
            VALUES 
            ({parameterNames})";

            using (var command = new NpgsqlCommand(query, _pgConn))
            {
                // Add parameter to the command
                foreach (var column in columns)
                {
                    command.Parameters.AddWithValue($"@{column.EntityName}", DBNull.Value);
                }
                
                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Insert record error: " + ex.Message);
        }
    }


    public void InsertIntegratorData(List<EntityDescriptor> columns, string detName, List<IntegratorData> dataList)
    {
        try
        {
            foreach (var record in dataList)
            {
                // create columnName and columnValues List
                string columnNames = string.Join(", ", columns.Select(c => $"\"{c.EntityName}\""));

                // build query
                string query = $@"
                    INSERT INTO {detName}
                    ({columnNames})
                    VALUES 
                    (@Name,
                     @LName,
                     @Surname,
                     @LSurname,
                     @DateOfBirth,
                     @LDateOfBirth,
                     @Photo)";

                using (var command = new NpgsqlCommand(query, _pgConn))
                {
                    command.Parameters.AddWithValue("@Name",record.FrontName);
                    command.Parameters.AddWithValue("@LName",record.FrontLblName);
                    command.Parameters.AddWithValue("@Surname",record.FrontSurname);
                    command.Parameters.AddWithValue("@LSurname",record.FrontLblSurname);
                    command.Parameters.AddWithValue("@DateOfBirth",record.FrontDateOfBirth);
                    command.Parameters.AddWithValue("@LDateOfBirth",record.FrontLblDateOfBirth);
                    command.Parameters.AddWithValue("@Photo",DBNull.Value);
                    
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Insert record error: " + ex.Message);
        }
    }

    public void ClearTable(string detName)
    {
        try
        {
            var delete = $@"DELETE FROM {detName};";
            using (var command = new NpgsqlCommand(delete, _pgConn))
            {
                command.Prepare();
                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Delete table error: " + ex.Message);
        }
    }
}