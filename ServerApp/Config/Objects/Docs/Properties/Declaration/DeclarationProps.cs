using System.IO;

namespace LBTDTools.ServerApp.Config.Objects.Docs.Properties.Declaration
{
    public class DeclarationProps
    {
        public string PathToSample = Path.GetFullPath("ServerApp/Config/Docs/Samples/DeclarationSample.docx");
        public string PathToAnswerDoc = Path.GetFullPath("ServerApp/Config/Docs/Declarations/");
        public string TypeOfAnswerDoc = "application/docx";
        public string NameOfAnswerDoc = "Заявление-декларация.docx";
    }
}