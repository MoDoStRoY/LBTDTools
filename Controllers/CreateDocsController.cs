using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using LBTDTools.ServerApp.Config.Objects.Docs;
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
            string path = Path.GetFullPath("test.docx");
            string type="application/docx";
            string name = "file.docx";

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            XWPFDocument myDocx = new XWPFDocument(fs);

            foreach (var para in myDocx.Paragraphs)
            {
                string oldtext = para.ParagraphText;

                if (oldtext == "")

                    continue;
                
                string temptext = para.ParagraphText;
                
                if (temptext.Contains("$FinaleNumber"))
                    temptext = temptext.Replace("$FinaleNumber", act.Laboratory.FinaleNumber);
                if (temptext.Contains("$Name"))
                    temptext = temptext.Replace("$Name", act.Laboratory.Name);
                
                para.ReplaceText(oldtext, temptext);
                
                FileStream output = new FileStream(path, FileMode.Create); 
                
                myDocx.Write(output); 
                fs.Close();
                fs.Dispose();
                output.Close();
                output.Dispose();
            } 
            
            return PhysicalFile(path, type, name);
        }
    }
}