using Microsoft.EntityFrameworkCore;
using si730ebu202023992.Infraestructure.Context;
using si730ebu202023992.Infraestructure.Inventory.Model;
using si730ebu202023992.Infraestructure.Maintenance.Interface;
using si730ebu202023992.Infraestructure.Maintenance.Model;

namespace si730ebu202023992.Infraestructure.Maintenance;

public class MActivitiesDBInfraestructure : IMActivitiesInfraestructure
{
    private si730ebu202023992DBContext _si730Ebu202023992DbContext;
    
    public MActivitiesDBInfraestructure(si730ebu202023992DBContext si730Ebu202023992DbContext)
    {
        _si730Ebu202023992DbContext = si730Ebu202023992DbContext;
    }
    
    public async Task<bool> SaveAsync(MaintenanceActivities maintenanceActivities)
    {
        try
        {
            await _si730Ebu202023992DbContext.Snapshots.AddAsync(maintenanceActivities);
            await _si730Ebu202023992DbContext.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public void UpdateProductByStatus(string productSerialNumber, int statusUpdated)
    {
        try
        {
            var product = _si730Ebu202023992DbContext.Products.Where(p => p.SerialNumber == productSerialNumber).FirstOrDefault();;
            if (product == null)
            {
                throw new InvalidOperationException("Product id not related to any product");
            }
            product.Status = statusUpdated;
            _si730Ebu202023992DbContext.Update(product);
            _si730Ebu202023992DbContext.SaveChanges();
        }
        catch (Exception e)
        {
            throw new InvalidOperationException("UpdateProductByStatus() failed ", e);
        }
    }
}