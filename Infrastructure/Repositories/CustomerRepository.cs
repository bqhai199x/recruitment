using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Recruitment.Core.Entities;
using Recruitment.Infrastructure.Interfaces;

namespace Recruitment.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IConfiguration _config;

        public CustomerRepository(IConfiguration config)
        {
            _config = config;
        }

        public Task<int> AddAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            using (var connection = new MySqlConnection(_config.GetConnectionString("SqlConnection")))
            {
                string sql = "Select * From Customer";

                var customerList = await connection.QueryAsync<Customer>(sql);

                return customerList.ToList();
            }
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
