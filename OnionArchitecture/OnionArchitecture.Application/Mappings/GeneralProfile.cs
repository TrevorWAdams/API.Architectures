using AutoMapper;
using OnionArchitecture.Application.Features.Products.Commands.CreateProduct;
using OnionArchitecture.Application.Features.Products.Queries.GetAllProducts;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
