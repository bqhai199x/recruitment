using Recruitment.Core.Entities;
using Recruitment.Core.Utils;
using System.Net.Http.Json;

namespace Recruitment.Client.Services
{
    public interface IOrderService
    {
        Task<PagedList<Order>> List(int pageSize, int pageNumber, string categoryName);

        Task Create(Order order);
    }

    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;

        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PagedList<Order>> List(int pageSize, int pageNumber, string categoryName)
        {
            return await _httpClient.GetFromJsonAsync<PagedList<Order>>($"api/order/list?pageNumber={pageNumber}&pageSize={pageSize}&categoryName={categoryName}") ?? new();
        }

        public async Task Create(Order order)
        {
            await _httpClient.PostAsJsonAsync<Order>("api/order/create", order);
        }
    }
}
