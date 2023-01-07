using Recruitment.Core.Entities;
using Recruitment.Infrastructure.Interfaces;

namespace Recruitment.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<int> AddAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
