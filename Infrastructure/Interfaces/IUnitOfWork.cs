namespace Recruitment.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }

        IProductRepository Product { get; }

        IOrderRepository Order { get; }

        ICustomerRepository Customer { get; } 

    }
}
