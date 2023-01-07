using Recruitment.Core.Entities;
using Recruitment.Infrastructure.Interfaces;

namespace Recruitment.Infrastructure.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public Task<int> AddAsync(OrderDetail entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDetail>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetail> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(OrderDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
