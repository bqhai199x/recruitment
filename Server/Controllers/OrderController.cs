using Microsoft.AspNetCore.Mvc;
using Serilog;
using Recruitment.Core.Entities;
using Recruitment.Infrastructure.Interfaces;
using System.Reflection;
using Recruitment.Core.Utils;
using System.Text.Json;

namespace Recruitment.Server.Controllers
{
    public class OrderController : BaseController
    {
        public OrderController(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        [HttpGet("list")]
        public async Task<IActionResult> GetOrderList(int pageNumber, int pageSize, string categoryName)
        {
            try
            {
                List<Order> orderList = await _unitOfWork.Order.GetAllAsync();
                if (!string.IsNullOrEmpty(categoryName))
                {
                    orderList = orderList.Where(x => x.Product.Category.Name.ToLower().Contains(categoryName.ToLower())).ToList();
                }
                PagedList<Order> orderPageList = PagedList<Order>.ToPagedList(orderList, pageNumber, pageSize);
                Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(orderPageList.MetaData));
                return Json(orderPageList);
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, MethodBase.GetCurrentMethod()?.Name);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            try
            {
                int result = await _unitOfWork.Order.AddAsync(order);
                return Json(result > 0);
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, MethodBase.GetCurrentMethod()?.Name);
                return StatusCode(500, ex.Message);
            }
        }
    }
}
