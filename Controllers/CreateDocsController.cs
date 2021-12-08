using System;
using System.Diagnostics;
using System.IO;
using LBTDTools.ServerApp.Config.Objects.Docs;
using Microsoft.AspNetCore.Mvc;

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
            string path = Path.GetFullPath("test.pdf");
            string type="application/pdf";
            string name = "file.pdf";
            return PhysicalFile(path, type, name);
        }
    }
}