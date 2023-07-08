using System.ComponentModel.DataAnnotations.Schema;

namespace si730ebu202023992.Infraestructure.Maintenance.Model;

public class MaintenanceActivities
{
    [Column("id")]
    public long Id { get; set; }
    
    [Column("product_serial_number")]
    public string ProductSerialNumber { get; set; }
    
    [Column("summary")]
    public string Summary { get; set; }
    
    [Column("description")]
    public string Description { get; set; }
    
    [Column("activity_result")]
    public int ActivityResult { get; set; }
}