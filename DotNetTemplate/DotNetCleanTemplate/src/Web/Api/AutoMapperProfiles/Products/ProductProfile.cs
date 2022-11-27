using AutoMapper;
using DotNetCleanTemplate.Api.Controllers.v1.Products.Requests;
using DotNetCleanTemplate.Application.Products.Command.AddProduct;

namespace DotNetCleanTemplate.Api.AutoMapperProfiles.Products
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddProductRequest, AddProductCommand>();
        }
    }
}
