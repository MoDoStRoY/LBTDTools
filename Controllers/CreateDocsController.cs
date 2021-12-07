using System;
using System.Diagnostics;
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
        public Act GetAct([FromBody] Act act)
        {
            Debug.WriteLine("Да");
            return act;
        }
    }
}