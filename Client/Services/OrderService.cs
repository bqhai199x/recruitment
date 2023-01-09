using Recruitment.Core.Entities;
using Recruitment.Core.Utils;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

namespace Recruitment.Client.Services
{
    public interface IOrderService
    {
        Task<PagingResponse<Order>> List(int pageSize, int pageNumber, string categoryName);

        Task<bool> Create(Order order);
    }

    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;

        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PagingResponse<Order>> List(int pageSize, int pageNumber, string categoryName)
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "pageSize", $"{pageSize}" },
                { "pageNumber", $"{pageNumber}"},
                { "categoryName", categoryName}
            };
            var dictFormUrlEncoded = new FormUrlEncodedContent(queryParameters);
            var queryString = await dictFormUrlEncoded.ReadAsStringAsync();

            var response = await _httpClient.GetAsync($"api/order/list?{queryString}");
            var content = await response.Content.ReadAsStringAsync();
            var pagingResponse = new PagingResponse<Order>
            {
                Items = JsonSerializer.Deserialize<List<Order>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new(),
                MetaData = JsonSerializer.Deserialize<MetaData>(response.Headers.GetValues("X-Pagination").First(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new()
            };
            return pagingResponse;
        }

        public async Task<bool> Create(Order order)
        {
            var response = await _httpClient.PostAsJsonAsync<Order>("api/order/create", order);
            var content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode != HttpStatusCode.OK) return false;
            return content == "true";
        }
    }
}
