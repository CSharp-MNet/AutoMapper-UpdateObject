using AutoMapper;
using si730ebu202023992.API.Inventory.Dto.Response;
using si730ebu202023992.Infraestructure.Inventory.Model;

namespace si730ebu202023992.API.Inventory.Mapper;

public class ProductToResponse : Profile
{
    public ProductToResponse()
    {
        CreateMap<Product, ProductResponse>();
    }
}