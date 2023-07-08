using si730ebu202023992.Infraestructure.Maintenance.Model;

namespace si730ebu202023992.Domain.Maintenance.Interface;

public interface IMActivitiesDomain
{
    public Task<bool> SaveAsync(MaintenanceActivities maintenanceActivities);
    public void ValidateAndUpdateActivityResult(MaintenanceActivities maintenanceActivities);
}