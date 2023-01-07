using Microsoft.AspNetCore.Mvc;
using Recruitment.Infrastructure.Interfaces;

namespace Recruitment.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : Controller
    {
        protected readonly IUnitOfWork _unitOfWork;

        public BaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
