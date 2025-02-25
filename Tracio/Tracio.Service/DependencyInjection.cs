using Microsoft.Extensions.DependencyInjection;
using Tracio.Service.Interfaces;
using Tracio.Service.Services;

namespace Tracio.Service
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection service)
        {
            service.AddTransient<IProductCategoryService, ProductCategoryService>();
            
            return service;
        }
    }
}
