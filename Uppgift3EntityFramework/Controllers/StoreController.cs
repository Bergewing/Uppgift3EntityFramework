using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL;
using Service;

namespace Uppgift3EntityFramework.Controllers
{
    [Route("products")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        [HttpGet("count")]
        public IOrderedEnumerable<ProductCountDTO> Count()
        {
            return DatabaseService.Instance.ListCount();

        }
    }
}
