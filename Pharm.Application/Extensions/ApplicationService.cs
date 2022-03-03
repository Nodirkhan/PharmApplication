using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pharm.Application.Interface;
using Pharm.Application.Profiles;
using Pharm.Application.Services;

namespace Pharm.Application.Extensions
{
    public static class ApplicationService
    {
        public static void AddAplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingInitializer));
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICategoryServiceAsync, CategoryServiceAsync>();
            services.AddTransient<ISupplierServiceAsync, SupplierServiceAsync>();
        }
    }
}
