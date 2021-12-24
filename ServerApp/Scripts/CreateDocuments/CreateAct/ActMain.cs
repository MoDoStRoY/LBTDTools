using System.IO;
using LBTDTools.ServerApp.Config.Docs;
using LBTDTools.ServerApp.Config.Docs.Properties;
using LBTDTools.ServerApp.Config.Objects.Docs;
using NPOI.XWPF.UserModel;

namespace LBTDTools.ServerApp.Scripts.CreateDocuments.CreateAct
{
    public interface IActMain
    {
        public string CreateAct(Act act);
    }

    public class ActMain : IActMain
    {
        private readonly ActProps _props = new();
        private string _pathToAnswerDoc;
        public XWPFDocument SampleDoc;
        private FileStream _outStream;
        public Act _actObj;

        public string CreateAct(Act actObjIn)
        {
            _actObj = actObjIn;

            ReadSample();
            CorrectPathToAnswerDoc();
            CreateBufferFile();
            actObjIn.Car.Upgrades.InitializeListOfUpgrades();
            this.Put();
            WriteData();
            CloseStreams();

            return _pathToAnswerDoc + ";" + _props.TypeOfAnswerDoc + ";" + _props.NameOfAnswerDoc;
        }

        private void ReadSample()
        {
            FileStream inStream = new FileStream(_props.PathToSample, FileMode.Open, FileAccess.Read);
            SampleDoc = new XWPFDocument(inStream);
            inStream.Close();
            inStream.Dispose();
        }

        private void CorrectPathToAnswerDoc()
        {
            Program.Server.DocActCounter++;
            _pathToAnswerDoc = _props.PathToAnswerDoc + "Act_" + Program.Server.DocActCounter + ".docx";
        }

        private void CreateBufferFile()
        {
            File.Create(_pathToAnswerDoc).Close();
        }

        private void WriteData()
        {
            _outStream = new FileStream(_pathToAnswerDoc, FileMode.Create);
            SampleDoc.Write(_outStream);
        }

        private void CloseStreams()
        {
            _outStream.Close();
            _outStream.Dispose();
        }
    }
}