using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using DAL;

namespace Uppgift3EntityFramework.Controllers
{
    [Route("department")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        public List<DepartmentManagerDTO> DepartmentManager()
        {
            return DatabaseService.Instance.GetEmailToDepartment();
        }

    }
}
