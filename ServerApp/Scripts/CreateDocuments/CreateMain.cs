using System.IO;
using NPOI.XWPF.UserModel;

namespace LBTDTools.ServerApp.Scripts.CreateDocuments
{
    public static class CreateMain
    {
        public static XWPFDocument ReadSample(string pathToSample)
        {
            FileStream inStream = new FileStream(pathToSample, FileMode.Open, FileAccess.Read);
            XWPFDocument result = new XWPFDocument(inStream);
            inStream.Close();
            inStream.Dispose();

            return result;
        }
        
        public static string CorrectPathToAnswerDoc(string pathToAnswerDoc, string preFix, string format)
        {
            Program.Server.DocActCounter++;

            switch (preFix)
            {
                case "Act_":
                    return pathToAnswerDoc + preFix + Program.Server.DocActCounter + format;
                case "Declaration_":
                    return pathToAnswerDoc + preFix + Program.Server.DocDeclarationCounter + format;
            }

            return null;
        }
        
        public static void CreateAnswerFile(string pathToAnswerDoc)
        {
            File.Create(pathToAnswerDoc).Close();
        }
        
        public static void WriteData(string path, XWPFDocument document)
        {
            FileStream outStream = new FileStream(path, FileMode.Create);
            document.Write(outStream);
            
            outStream.Close();
            outStream.Dispose();
        }
    }
}