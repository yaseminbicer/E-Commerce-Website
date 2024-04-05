using AutoMapper;
using ECommerce.Catalog.Dtos.CategoryDtos;
using ECommerce.Catalog.Dtos.ProductDetailDtos;
using ECommerce.Catalog.Dtos.ProductDtos;
using ECommerce.Catalog.Dtos.ProductImageDtos;
using ECommerce.Catalog.Entities;

namespace ECommerce.Catalog.Mapping
{
    public class GeneralMapping :Profile
    {
        public GeneralMapping() 
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<Product,ResultProductDto>().ReverseMap();
            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product,UpdateProductDto>().ReverseMap();
            CreateMap<Product,GetByIdProductDto>().ReverseMap();

            CreateMap<Product,ResultProductDetailDto>().ReverseMap();
            CreateMap<Product,CreateProductDetailDto>().ReverseMap();
            CreateMap<Product,UpdateProductDetailDto>().ReverseMap();
            CreateMap<Product,GetByIdProductDetailDto>().ReverseMap();

            CreateMap<Product,ResultProductImageDto>().ReverseMap();
            CreateMap<Product,CreateProductImageDto>().ReverseMap();
            CreateMap<Product,UpdateProductImageDto>().ReverseMap();
            CreateMap<Product,GetByIdProductImageDto>().ReverseMap();

        }
    }
}
