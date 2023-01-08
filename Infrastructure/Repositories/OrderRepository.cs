using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Recruitment.Core.Entities;
using Recruitment.Infrastructure.Interfaces;

namespace Recruitment.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IConfiguration _config;

        public async Task<List<Order>> GetAllAsync()
        {
            using (var connection = new MySqlConnection(_config.GetConnectionString("SqlConnection")))
            {
                string sql =
                    @"Select * From `Order` ord 
                      Inner Join Customer cus On ord.CustomerId = cus.Id 
                      Inner Join Product prod On ord.ProductId = prod.Id 
                      Inner Join Category cate On prod.CategoryId = cate.Id;";

                var productList = await connection.QueryAsync<Order, Customer, Product, Category, Order>(sql, (ord, cus, prod, cate) =>
                {
                    ord.Customer = cus;
                    ord.Product = prod;
                    ord.Product.Category = cate;
                    return ord;
                }, splitOn: "Id");

                return productList.ToList();
            }
        }

        public OrderRepository(IConfiguration config)
        {
            _config = config;
        }

        public async Task<int> AddAsync(Order entity)
        {
            using (var connection = new MySqlConnection(_config.GetConnectionString("SqlConnection")))
            {
                string sql =
                    @"Insert Into `Order` (ProductId, CustomerId, OrderDate, Amount) 
                      Values (@ProductId, @CustomerId, @OrderDate, @Amount)";

                return await connection.ExecuteAsync(sql, new
                {
                    ProductId = entity.ProductId,
                    CustomerId = entity.CustomerId,
                    OrderDate = entity.OrderDate,
                    Amount = entity.Amount
                });
            }
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
