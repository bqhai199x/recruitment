using Recruitment.Core.Entities;
using System.Net.Http.Json;

namespace Recruitment.Client.Services
{
    public interface IOrderService
    {
        Task<List<Order>> GetAll();
    }

    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;

        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Order>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<Order>>("api/order/list") ?? new();
        }
    }
}
