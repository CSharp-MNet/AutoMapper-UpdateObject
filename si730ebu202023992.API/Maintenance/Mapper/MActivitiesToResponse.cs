using AutoMapper;
using si730ebu202023992.API.Maintenance.Dto.Response;
using si730ebu202023992.Infraestructure.Maintenance.Model;

namespace si730ebu202023992.API.Maintenance.Mapper;

public class MActivitiesToResponse : Profile
{
    public MActivitiesToResponse()
    {
        CreateMap<MaintenanceActivities, MActivitiesResponse>();
    }
}