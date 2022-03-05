using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pharm.Infrastructure.Context;
using Pharm.Infrastructure.Interface;
using Pharm.Infrastructure.Repositories;

namespace Pharm.Infrastructure.Extensions
{
    public static class ServiceCollection
    {
        public static void AddInfraStructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                m=>m.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
                )) ;
            services.AddScoped(typeof(IGenericRepositoriesAsync<>), typeof(GenericRepositoriesAsync<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepositoryAsync, CategoryRepositoryAsync>();
            services.AddScoped<ISupplierRepositoryAsync, SupplierRepositoryAsync>();
            services.AddScoped<IEmployeeRepositoryAsync, EmployeeRepositoryAsync>();
            services.AddScoped<IOrderRepositoryAsync, OrderRepositoryAsync>();
            services.AddScoped<IOrderDetailRepositoryAsync, OrderDetailRepositoryAsync>();
        }
    }
}
