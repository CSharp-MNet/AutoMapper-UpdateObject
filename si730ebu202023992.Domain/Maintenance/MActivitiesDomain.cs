using si730ebu202023992.Domain.Maintenance.Interface;
using si730ebu202023992.Infraestructure.Maintenance.Interface;
using si730ebu202023992.Infraestructure.Maintenance.Model;

namespace si730ebu202023992.Domain.Maintenance;

public class MActivitiesDomain : IMActivitiesDomain
{
    private IMActivitiesInfraestructure _imActivitiesInfraestructure;
    
    public MActivitiesDomain(IMActivitiesInfraestructure imActivitiesInfraestructure)
    {
        _imActivitiesInfraestructure = imActivitiesInfraestructure;
    }
    
    public Task<bool> SaveAsync(MaintenanceActivities maintenanceActivities)
    {
        ValidateMActivities(maintenanceActivities);
        return _imActivitiesInfraestructure.SaveAsync(maintenanceActivities);
    }

    private void ValidateMActivities(MaintenanceActivities maintenanceActivities)
    {
        if (string.IsNullOrWhiteSpace(maintenanceActivities.ProductSerialNumber))
        {
            throw new ArgumentException("ProductSerialNumber is required");
        }
        if (string.IsNullOrWhiteSpace(maintenanceActivities.Summary))
        {
            throw new ArgumentException("Summary is required");
        }
        if (string.IsNullOrWhiteSpace(maintenanceActivities.Description))
        {
            throw new ArgumentException("Description is required");
        }
        if (maintenanceActivities.ActivityResult < 0 || maintenanceActivities.ActivityResult >= 2)
        {
            throw new ArgumentException("ActivityResult cannot be empty and must be between 0 = Product still Unoperational, 1 = Product is Operational");
        }
    }
    
    public void ValidateAndUpdateActivityResult(MaintenanceActivities maintenanceActivities)
    {
        if (maintenanceActivities.ActivityResult == 0)
        {
            _imActivitiesInfraestructure.UpdateProductByStatus(maintenanceActivities.ProductSerialNumber, 2);
        }
        else
        {
            _imActivitiesInfraestructure.UpdateProductByStatus(maintenanceActivities.ProductSerialNumber, 1);
        }
    }
}