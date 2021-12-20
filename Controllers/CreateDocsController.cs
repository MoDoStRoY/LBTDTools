using JetBrains.Annotations;
using LBTDTools.ServerApp.Config.Objects.Docs;
using LBTDTools.ServerApp.Scripts.CreateDocuments;
using Microsoft.AspNetCore.Mvc;

namespace LBTDTools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateDocsController : Controller
    {
        [NotNull]
        private IDocAct docAct;

        public CreateDocsController([NotNull] IDocAct act)
        {
            docAct = act;
        }
        
        [HttpPost]
        [Route("GetAct")]
        public PhysicalFileResult GetAct([FromBody] Act act)
        {
            string[] buffer = docAct.CreateAct(act).Split(';');
            return PhysicalFile(buffer[0], buffer[1], buffer[2]);
        }
    }
}