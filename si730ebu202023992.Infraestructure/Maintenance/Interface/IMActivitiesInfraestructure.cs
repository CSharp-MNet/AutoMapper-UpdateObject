using si730ebu202023992.Infraestructure.Inventory.Model;
using si730ebu202023992.Infraestructure.Maintenance.Model;

namespace si730ebu202023992.Infraestructure.Maintenance.Interface;

public interface IMActivitiesInfraestructure
{
    public Task<bool> SaveAsync(MaintenanceActivities maintenanceActivities);
    public void UpdateProductByStatus(string productSerialNumber, int statusUpdated);
}