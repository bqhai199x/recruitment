using Microsoft.AspNetCore.Mvc;
using Serilog;
using Recruitment.Core.Entities;
using Recruitment.Infrastructure.Interfaces;
using System.Reflection;

namespace Recruitment.Server.Controllers
{
    public class ProductController : BaseController
    {
        public ProductController(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        [HttpGet("list")]
        public async Task<IActionResult> GetProductList()
        {
            try
            {
                List<Product> productist = await _unitOfWork.Product.GetAllAsync();
                return Json(productist);
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, MethodBase.GetCurrentMethod()?.Name);
                return StatusCode(500, ex.Message);
            }
        }
    }
}
