using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinRiskManager.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpPost("AddBusinessMatter")]
        public IActionResult AddBusinessMatter(string tenantId,string aggrementName,string tenantName,string desc)
        {
            if (businessMatterDto == null)
            {
                return BadRequest("Business matter data is null.");
            }

            return Ok("Business matter added successfully.");
        }
    }
}
