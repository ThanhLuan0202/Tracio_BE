using Microsoft.Extensions.DependencyInjection;

using System.Runtime.CompilerServices;
using Tracio.Data.Interfaces;
using Tracio.Data.Repositories;

namespace Tracio.Data
{
    public static  class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection service)
        {
            service.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork));
            service.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            service.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
            service.AddTransient<IAuthenRepository, AuthenRepository>();
            service.AddTransient<IServiceCategoryRepository, ServiceCategoryRepository>();
            service.AddTransient<IServiceRepository, ServiceRepository>();

            service.AddTransient<IProductRepository, ProductRepository>();
            service.AddTransient<IUserRepository, UserRepository>();






            return service;
        }

    }
}
