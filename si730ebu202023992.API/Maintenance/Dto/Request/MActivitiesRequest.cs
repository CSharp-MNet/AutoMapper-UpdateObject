namespace si730ebu202023992.API.Maintenance.Dto.Request;

public class MActivitiesRequest
{
    public string ProductSerialNumber { get; set; }
    public string Summary { get; set; }
    public string Description { get; set; }
    public int ActivityResult { get; set; }
}