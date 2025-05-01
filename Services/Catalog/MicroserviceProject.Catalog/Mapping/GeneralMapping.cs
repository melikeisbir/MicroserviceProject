using AutoMapper;
using MicroserviceProject.Catalog.Dtos.CategoryDtos;
using MicroserviceProject.Catalog.Dtos.ProductDetailDtos;
using MicroserviceProject.Catalog.Dtos.ProductDtos;
using MicroserviceProject.Catalog.Dtos.ProductImageDtos;
using MicroserviceProject.Catalog.Entities;

namespace MicroserviceProject.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            //category sınıfı için mappleme işlemi
            CreateMap<Category, ResultCategoryDto>().ReverseMap(); //category sınıfı ile resultcategorydto sınıfını mapplemek,
                                                                   //resultcategorydto ile de category mapplenebilir
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();

            CreateMap<ProductDetail, ResultProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, GetByIdProductDetailDto>().ReverseMap();

            CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();
            CreateMap<ProductImage, CreateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, UpdateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, GetByIdProductImageDto>().ReverseMap();

            CreateMap<Product, ResultProductsWithCategoryDto>().ReverseMap();
        }
    }
}
