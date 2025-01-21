using System.Data;
using System.IO;
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
    
    public DataTable GetDataForUI(string detName)
    {
        DataTable dataTable = new DataTable();
        try
        {
            string query = $@"SELECT job_status, workflow_id, workflow_status, error_detail, ""front_datapageHID_lady_003__Name"",""front_datapageHID_lady_004__Surname""
                            FROM {detName} ORDER BY job_status DESC";

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

    public List<string> GetTableColumns(string tableName)
    {
        var columns = new List<string>();
        // Rimuovi i doppi apici dal nome della tabella, se presenti
        string cleanedTableName = tableName.Trim('"');

        // Ora usa `cleanedTableName` nella query senza i doppi apici
        string query = $@"
        SELECT column_name
        FROM information_schema.columns
        WHERE table_name = @tableName
        AND table_schema = 'public'";

        using (var command = new NpgsqlCommand(query, _pgConn))
        {
            command.Parameters.AddWithValue("@tableName", cleanedTableName);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    columns.Add(reader.GetString(0));
                }
            }
        }
        return columns;
    }

public void InsertCsvData(string detName, List<EntityDescriptor> entities, List<string[]> csvRows)
{
    // image bbasepath
    string imagePathBase = Path.Combine(Directory.GetCurrentDirectory(), "Asset", "img");

    if (!Directory.Exists(imagePathBase))
    {
        throw new DirectoryNotFoundException($"Image path base does not exist: {imagePathBase}");
    }

    foreach (var row in csvRows)
    {
        if (row.Length != entities.Count)
        {
            throw new InvalidOperationException(
                "The number of values in the CSV row does not match the number of columns.");
        }

        // Column Name in double quotation mark
        var quotedColumns = entities.Select(entity => $"\"{entity.EntityName}\"").ToList();
        var parameterPlaceholders = entities.Select((_, index) => $"@value{index}").ToList();
        
        //query
        string query = $@"
        INSERT INTO {detName}
        ({string.Join(", ", quotedColumns)})
        VALUES
        ({string.Join(", ", parameterPlaceholders)})";

        using (var command = new NpgsqlCommand(query, _pgConn))
        {
            for (int i = 0; i < entities.Count; i++)
            {
                var entity = entities[i];
                string value = row[i];

                if (!string.IsNullOrEmpty(entity.ValueType.ToString()) &&
                    (string.Equals(entity.ValueType.ToString(), "Image", StringComparison.OrdinalIgnoreCase) ||
                     string.Equals(entity.ValueType.ToString(), "InkjetImage", StringComparison.OrdinalIgnoreCase) ||
                     string.Equals(entity.ValueType.ToString(), "Signature", StringComparison.OrdinalIgnoreCase)) &&
                    !string.IsNullOrEmpty(value))
                {
                    // path with image name
                    string fullImagePath = Path.Combine(imagePathBase, value);

                    if (File.Exists(fullImagePath))
                    {
                        // read image like byte array
                        byte[] imageBytes = File.ReadAllBytes(fullImagePath);

                        // add byte array
                        command.Parameters.AddWithValue($"@value{i}", imageBytes);
                    }
                    else
                    {
                        Console.WriteLine($"File not found: {fullImagePath}");
                        command.Parameters.AddWithValue($"@value{i}", DBNull.Value);
                    }
                }
                else
                {
                    command.Parameters.AddWithValue($"@value{i}",
                        string.IsNullOrEmpty(value) ? DBNull.Value : (object)value);
                }
            }
            // Esecute query
            command.ExecuteNonQuery();
        }
    }
}

    




public void InsertIntegratorData(List<EntityDescriptor> columns, string detName, List<IntegratorData> dataList)
{
    try
    {
        foreach (var record in dataList)
        {
            // Create columnNames and parameter placeholders
            string columnNames = string.Join(", ", columns.Select(c => $"\"{c.EntityName}\""));
            string parameterNames = string.Join(", ", columns.Select((c, index) => $"@param{index}"));

            // Build the query
            string query = $@"
                INSERT INTO {detName}
                ({columnNames})
                VALUES 
                ({parameterNames})";

            using (var command = new NpgsqlCommand(query, _pgConn))
            {
                // Add parameters dynamically for each column
                for (int i = 0; i < columns.Count; i++)
                {
                    var column = columns[i];
                    var value = GetValueForColumn(record, column.EntityName); // You need a method to get the value dynamically

                    // Add the parameter to the command
                    command.Parameters.AddWithValue($"@param{i}", value ?? DBNull.Value);
                }

                // Execute the query
                command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Insert record error: " + ex.Message);
    }
}

// This method is needed to retrieve the correct value from the record dynamically
private object GetValueForColumn(IntegratorData record, string columnName)
{
    switch (columnName)
    {
        case "TextFront":
            return record.TextFront;
        case "ImgFront":
            return record.ImgFront;
        // Add other cases here for each field in IntegratorData
        default:
            return null;
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