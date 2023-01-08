using Microsoft.AspNetCore.Mvc;
using Serilog;
using Recruitment.Core.Entities;
using Recruitment.Infrastructure.Interfaces;
using System.Reflection;
using Recruitment.Core.Utils;

namespace Recruitment.Server.Controllers
{
    public class OrderController : BaseController
    {
        public OrderController(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        [HttpGet("getall")]
        public async Task<IActionResult> GetProductList()
        {
            try
            {
                List<Order> orderList = await _unitOfWork.Order.GetAllAsync();
                return Json(orderList);
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, MethodBase.GetCurrentMethod()?.Name);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetProductList(int pageNumber, int pageSize)
        {
            try
            {
                List<Order> orderList = await _unitOfWork.Order.GetAllAsync();
                PagedList<Order> orderPageList = PagedList<Order>.ToPagedList(orderList, pageNumber, pageSize);
                return Json(orderList);
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, MethodBase.GetCurrentMethod()?.Name);
                return StatusCode(500, ex.Message);
            }
        }
    }
}
