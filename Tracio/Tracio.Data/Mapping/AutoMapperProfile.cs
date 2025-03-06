using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Entities;
using Tracio.Data.Models;
using Tracio.Data.Models.LoginModel;
using Tracio.Data.Models.ProductCategoryModel;
using Tracio.Data.Models.ProductModel;
using Tracio.Data.Models.ServiceCategoryModel;

namespace Tracio.Data.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() { 
            CreateMap<ViewProductCategoryModel, ProductsCategory>().ReverseMap();
            CreateMap<CreateProductCategoryModel, ProductsCategory>().ReverseMap();
            CreateMap<UpdateProductCategoryModel, ProductsCategory>().ReverseMap();

            CreateMap<RegisterLoginModel, User>().ReverseMap();

            CreateMap<ViewServiceCategoryModel, ServiceCategory>().ReverseMap();
            CreateMap<CreateServiceCategoryModel, ServiceCategory>().ReverseMap();
            CreateMap<UpdateServiceCategoryModel, ServiceCategory>().ReverseMap();

            CreateMap<CreateProductModel, Product>().ReverseMap();
            CreateMap<UpdateProductModel, Product>().ReverseMap();
            CreateMap<ViewProductModel, Product>().ReverseMap();











        }
    }
}
