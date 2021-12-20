using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using LBTDTools.ServerApp.Config.Objects.Docs;
using LBTDTools.ServerApp.Scripts.CreateDocuments;
using Microsoft.AspNetCore.Mvc;
using NPOI.XWPF.UserModel;

namespace LBTDTools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateDocsController : Controller
    {
        [HttpPost]
        [Route("GetAct")]
        public PhysicalFileResult GetAct([FromBody] Act act)
        {
            string[] buffer = DocAct.CreateAct(act).Split(';');
            return PhysicalFile(buffer[0], buffer[1], buffer[2]);
        }
    }
}