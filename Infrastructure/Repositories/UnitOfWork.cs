using Recruitment.Infrastructure.Interfaces;

namespace Recruitment.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ICategoryRepository category, IProductRepository product, IOrderRepository order, ICustomerRepository customer)
        {
            Category = category;
            Product = product;
            Order = order;
            Customer = customer;
        }

        public ICategoryRepository Category { get; }

        public IProductRepository Product { get; }

        public IOrderRepository Order { get; }

        public ICustomerRepository Customer { get; }
    }
}
