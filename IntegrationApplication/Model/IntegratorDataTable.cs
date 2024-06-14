namespace integratorApplication.Backend;

public class IntegratorData
{
    public string? FrontLblName { get; set; }
    public string? FrontName { get; set; }
    public string? FrontLblSurname { get; set; }
    public string? FrontSurname { get; set; }
    public string? FrontLblDateOfBirth { get; set; }
    public string? FrontDateOfBirth { get; set; }
    public string? FrontPhoto { get; set; }
    

    public IntegratorData(
        string? frontLblName,
        string? frontName,
        string? frontLblSurname,
        string? frontSurname,
        string? frontLblDateOfBirth,
        string? frontDateOfBirth,
        string? frontPhoto)

    {
        FrontLblName = frontLblName;
        FrontName = frontName;
        FrontLblSurname = frontLblSurname;
        FrontSurname = frontSurname;
        FrontLblDateOfBirth   = frontLblDateOfBirth;
        FrontDateOfBirth = frontDateOfBirth;
        FrontPhoto = frontPhoto;

    }
    
    public string[] GetColumnValues()
    {
        return new string[]
        {
            FrontLblName,
            FrontName,
            FrontLblSurname,
            FrontSurname,
            FrontLblDateOfBirth,
            FrontDateOfBirth,
            FrontPhoto

        };
    }
}