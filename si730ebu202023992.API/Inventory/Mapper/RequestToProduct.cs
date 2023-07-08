using AutoMapper;
using si730ebu202023992.API.Inventory.Dto.Request;
using si730ebu202023992.Infraestructure.Inventory.Model;

namespace si730ebu202023992.API.Inventory.Mapper;

public class RequestToProduct : Profile
{
    public RequestToProduct()
    {
        CreateMap<ProductRequest, Product>();
    }
}