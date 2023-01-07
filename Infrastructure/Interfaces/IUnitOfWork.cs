namespace Recruitment.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }

        IProductRepository Product { get; }

        IOrderRepository Order { get; }

        IOrderDetailRepository OrderDetail { get; }

        ICustomerRepository Customer { get; } 

    }
}
