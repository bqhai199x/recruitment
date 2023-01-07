using Recruitment.Core.Entities;
using Recruitment.Infrastructure.Interfaces;

namespace Recruitment.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task<int> AddAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
