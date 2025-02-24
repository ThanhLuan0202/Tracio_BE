using Microsoft.Extensions.DependencyInjection;

using System.Runtime.CompilerServices;

namespace Tracio.Data
{
    public static  class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection repo)
        {



            return repo;
        }

    }
}
