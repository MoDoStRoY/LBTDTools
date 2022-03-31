using JetBrains.Annotations;
using LBTDTools.ServerApp.Config.Objects.Docs;
using LBTDTools.ServerApp.Scripts.CreateDocuments;
using LBTDTools.ServerApp.Scripts.CreateDocuments.CreateAct;
using LBTDTools.ServerApp.Scripts.CreateDocuments.CreateDecrlaration;
using Microsoft.AspNetCore.Mvc;

namespace LBTDTools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateDocsController : Controller
    {
        [NotNull] private IActMain actMain;
        [NotNull] private IDeclarationMain declarationMain;

        public CreateDocsController([NotNull] IActMain act, [NotNull] IDeclarationMain declaration)
        {
            actMain = act;
            declarationMain = declaration;
        }
        
        [HttpPost]
        [Route("GetAct")]
        public PhysicalFileResult GetAct([FromBody] Act act)
        {
            string[] buffer = actMain.CreateAct(act).Split(';');
            return PhysicalFile(buffer[0], buffer[1], buffer[2]);
        }
        
        [HttpPost]
        [Route("GetDeclaration")]
        public PhysicalFileResult GetDeclaration([FromBody] Declaration declaration)
        {
            string[] buffer = declarationMain.CreateDeclaration(declaration).Split(';');
            return PhysicalFile(buffer[0], buffer[1], buffer[2]);
        }
    }
}