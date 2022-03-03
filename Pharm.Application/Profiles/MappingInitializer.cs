using AutoMapper;
using Pharm.Application.DTOs;
using Pharm.Application.DTOs.Categories;
using Pharm.Application.DTOs.Product;
using Pharm.Application.DTOs.Suppliers;
using Pharm.Domain.Models;


namespace Pharm.Application.Profiles
{
    public class MappingInitializer : Profile
    {
        public MappingInitializer()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, ProductForCreationDTO>().ReverseMap();

            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryForCreationDTO>().ReverseMap();


            CreateMap<Supplier, SupplierDTO>().ReverseMap();
            CreateMap<Supplier, SupplierForCreationDTO>().ReverseMap();
        }
    }
}
