using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Recruitment.Core.Entities;
using Recruitment.Infrastructure.Interfaces;

namespace Recruitment.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConfiguration _config;

        public ProductRepository(IConfiguration config)
        {
            _config = config;
        }

        public Task<int> AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            using (var connection = new MySqlConnection(_config.GetConnectionString("SqlConnection")))
            {
                string sql = "Select * From Product";

                var productList = await connection.QueryAsync<Product>(sql);

                return productList.ToList();
            }
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
