using Microsoft.Extensions.DependencyInjection;
using Recruitment.Infrastructure.Interfaces;
using Recruitment.Infrastructure.Repositories;

namespace Recruitment.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
