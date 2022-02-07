using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using DAL;

namespace Uppgift3EntityFramework.Controllers
{
    [Route("controller")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        public IOrderedEnumerable<DepartmentManagerDTO> DepartmentManager()
        {
            return DatabaseService.Instance.GetEmail();
        }

    }
}
