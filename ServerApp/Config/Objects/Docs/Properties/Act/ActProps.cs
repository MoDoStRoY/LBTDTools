using System.IO;

namespace LBTDTools.ServerApp.Config.Objects.Docs.Properties.Act
{
    public class ActProps
    {
        public string PathToSample = Path.GetFullPath("ServerApp/Config/Docs/Samples/ActSample.docx");
        public string PathToAnswerDoc = Path.GetFullPath("ServerApp/Config/Docs/Acts/");
        public string TypeOfAnswerDoc = "application/docx";
        public string NameOfAnswerDoc = "Акт измерения.docx";
    }
}