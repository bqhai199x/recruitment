using Recruitment.Core.Entities;
using System.Net.Http.Json;

namespace Recruitment.Client.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
    }

    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>("api/product/list") ?? new();
        }
    }
}
