using System.ComponentModel.DataAnnotations.Schema;

namespace si730ebu202023992.Infraestructure.Inventory.Model;

public class Product
{
    [Column("id")]
    public long Id { get; set; }
    
    [Column("brand")]
    public string Brand { get; set; }

    [Column("model")]
    public string Model { get; set; }

    [Column("serial_number")]
    public string SerialNumber { get; set; }
    
    [Column("status")]
    public int Status { get; set; }

    [Column("status_description")]
    public string StatusDescription
    {
        get
        {
            return Status == 1 ? "OPERATIONAL" : "UNOPERATIONAL";
        }
        set
        {
            Status = value == "OPERATIONAL" ? 1 : 2;
        }
    }
}