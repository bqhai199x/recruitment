using Recruitment.Core.Entities;
using System.Net.Http.Json;

namespace Recruitment.Client.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAll();
    }

    public class CustomerService : ICustomerService
    {
        private readonly HttpClient _httpClient;

        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Customer>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<Customer>>("api/customer/list") ?? new();
        }
    }
}
