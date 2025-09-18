using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AcountController : ControllerBase
    {
        [HttpGet]
        public string HI()
        { 
            return "HI";
        }

    }
}