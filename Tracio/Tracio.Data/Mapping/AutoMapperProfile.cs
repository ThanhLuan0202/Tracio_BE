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

namespace Tracio.Data.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() { 
            CreateMap<ViewProductCategoryModel, ProductsCategory>().ReverseMap();
            CreateMap<CreateProductCategoryModel, ProductsCategory>().ReverseMap();
            CreateMap<UpdateProductCategoryModel, ProductsCategory>().ReverseMap();
            CreateMap<RegisterLoginModel, User>().ReverseMap();







        }
    }
}
