using Microsoft.AspNetCore.Mvc;

namespace LBTDTools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateDocsController : Controller
    {
        [HttpPost]
        [Route("getAct")]
        public void GetAct([FromBody] string Test)
        {
            
        }
    }
}