using Microsoft.AspNetCore.Mvc;
using Serilog;
using Recruitment.Core.Entities;
using Recruitment.Infrastructure.Interfaces;
using System.Reflection;

namespace Recruitment.Server.Controllers
{
    public class CustomerController : BaseController
    {
        public CustomerController(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        [HttpGet("list")]
        public async Task<IActionResult> GetCustomerList()
        {
            try
            {
                List<Customer> customerList = await _unitOfWork.Customer.GetAllAsync();
                return Json(customerList);
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, MethodBase.GetCurrentMethod()?.Name);
                return StatusCode(500, ex.Message);
            }
        }
    }
}
