namespace integratorApplication.Backend;

public class DataRecordField
{
    public DataRecordField(string name, object? value)
    {
        Name = name;
        Value = value;
    }
    public string Name { get; set; }
    public object? Value { get; set; }
}