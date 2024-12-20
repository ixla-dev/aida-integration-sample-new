namespace integratorApplication.Backend;

public class IntegratorData
{
    public string? TextFront { get; set; }
    public string? ImgFront { get; set; }
    public string? TextRear { get; set; }
    public string? Magnetic_track_1_w { get; set; }
    public string? Magnetic_track_2_w { get; set; }
    public string? Magnetic_track_3_w { get; set; }

    

    public IntegratorData(
        string? textFront,
        string? imgFront,
        string? textRear,
        string? magnetic_track_1_w,
        string? magnetic_track_2_w,
        string? magnetic_track_3_w)

    {
        TextFront = textFront;
        ImgFront = imgFront;
        TextRear = textRear;
        Magnetic_track_1_w = magnetic_track_1_w;
        Magnetic_track_2_w = magnetic_track_2_w;
        Magnetic_track_3_w = magnetic_track_3_w;
    }
    
    public string[] GetColumnValues()
    {
        return new string[]
        {
            TextFront,
            ImgFront,
            TextRear,
            Magnetic_track_1_w,
            Magnetic_track_2_w,
            Magnetic_track_3_w
        };
    }
}