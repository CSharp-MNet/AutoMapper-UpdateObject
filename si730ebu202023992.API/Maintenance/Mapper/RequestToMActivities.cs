using AutoMapper;
using si730ebu202023992.API.Maintenance.Dto.Request;
using si730ebu202023992.Infraestructure.Maintenance.Model;

namespace si730ebu202023992.API.Maintenance.Mapper;

public class RequestToMActivities : Profile
{
    public RequestToMActivities()
    {
        CreateMap<MActivitiesRequest, MaintenanceActivities>();
    }
}