namespace si730ebu202023992.API.Maintenance.Dto.Response;

public class MActivitiesResponse
{
    public int Id { get; set; }
    public string ProductSerialNumber { get; set; }
    public double Temperature { get; set; }
    public double Energy { get; set; }
    public int Leakage { get; set; }
}