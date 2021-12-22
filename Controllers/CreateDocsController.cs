using JetBrains.Annotations;
using LBTDTools.ServerApp.Config.Objects.Docs;
using LBTDTools.ServerApp.Scripts.CreateDocuments;
using LBTDTools.ServerApp.Scripts.CreateDocuments.CreateAct;
using Microsoft.AspNetCore.Mvc;

namespace LBTDTools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateDocsController : Controller
    {
        [NotNull]
        private IActMain actMain;

        public CreateDocsController([NotNull] IActMain act)
        {
            actMain = act;
        }
        
        [HttpPost]
        [Route("GetAct")]
        public PhysicalFileResult GetAct([FromBody] Act act)
        {
            string[] buffer = actMain.CreateAct(act).Split(';');
            return PhysicalFile(buffer[0], buffer[1], buffer[2]);
        }
    }
}