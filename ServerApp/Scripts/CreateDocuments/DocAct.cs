using System.IO;
using LBTDTools.ServerApp.Config.Docs.Properties;
using LBTDTools.ServerApp.Config.Objects.Docs;
using NPOI.XWPF.UserModel;

namespace LBTDTools.ServerApp.Scripts.CreateDocuments
{
    public interface IDocAct
    {
        public string CreateAct(Act actObjIn);
    }

    public class DocAct : IDocAct
    {
        private readonly ActProps Props = new();
        private string _pathToAnswerDoc;
        private XWPFDocument _sampleDoc;
        private FileStream _outStream;
        private Act _actObj;

        public string CreateAct(Act actObjIn)
        {
            _actObj = actObjIn;

            ReadSample();
            CorrectPathToAnswerDoc();
            CreateBufferFile();
            PutData();
            WriteData();
            CloseStreams();

            return _pathToAnswerDoc + ";" + Props.TypeOfAnswerDoc + ";" + Props.NameOfAnswerDoc;
        }

        private void ReadSample()
        {
            FileStream inStream = new FileStream(Props.PathToSample, FileMode.Open, FileAccess.Read);
            _sampleDoc = new XWPFDocument(inStream);
            inStream.Close();
            inStream.Dispose();
        }

        private void CorrectPathToAnswerDoc()
        {
            Program.Server.DocActCounter++;
            _pathToAnswerDoc = Props.PathToAnswerDoc + "Act_" + Program.Server.DocActCounter + ".docx";
        }

        private void CreateBufferFile()
        {
            File.Create(_pathToAnswerDoc).Close();
        }
        

        private void PutData()
        {
            foreach (var para in _sampleDoc.Paragraphs)
            {
                string oldText = para.ParagraphText;
                
                if (oldText == "")
                    continue;
                
                string newText = para.ParagraphText;

                newText = newText.Replace("{$entity}", _actObj.Service.Name);
                newText = newText.Replace("{$checkPointAddress}", _actObj.PPTOAddress);
                newText = newText.Replace("{$actNumber}", _actObj.Number);
                newText = newText.Replace("{$date}", _actObj.CarGiveDate);
                newText = newText.Replace("{$PPTOExpertFIO}", _actObj.NamePPTOExpert);

                para.ReplaceText(oldText, newText);
            }
            
            foreach (XWPFTable tbl in _sampleDoc.Tables) 
            {
                foreach (XWPFTableRow row in tbl.Rows) 
                {
                    foreach (XWPFTableCell cell in row.GetTableCells()) 
                    {
                        foreach (XWPFParagraph p in cell.Paragraphs) 
                        {
                            foreach (XWPFRun r in p.Runs)
                            {
                                r.Replace("{$expertFinaleNumber}", _actObj.Laboratory.FinaleNumber);
                                r.Replace("{$checkDate}", _actObj.SampleCloseDate);
                                r.Replace("{$giveAutoDate}", _actObj.CarGiveDate);
                                r.Replace("{$checkPointAddress}", _actObj.PPTOAddress);
                                r.Replace("{$brandModelAuto}", _actObj.Car.GetFullName());
                                r.Replace("{$govRegNum}", _actObj.Car.GovRegNum);
                                r.Replace("{$releaseDate}", _actObj.Car.ReleaseDate);
                                r.Replace("{$clientAndAddress}", _actObj.Client.GetInfo());
                                r.Replace("{$VIN}", _actObj.Car.VIN);
                                r.Replace("{$modelNumberEngine}", _actObj.Car.Engine.GetFullName());
                                r.Replace("{$color}", _actObj.Car.Color);
                                r.Replace("{$engineType}", _actObj.Car.Engine.Type);
                                r.Replace("{$fuel}", _actObj.Car.Engine.Fuel);
                                r.Replace("{$equipment}", _actObj.Car.Upgrades.GetUpgradesList());
                            }
                        }
                    }
                }
            }
        }

        private void WriteData()
        {
            _outStream = new FileStream(_pathToAnswerDoc, FileMode.Create);
            _sampleDoc.Write(_outStream);
        }

        private void CloseStreams()
        {
            _outStream.Close();
            _outStream.Dispose();
        }
    }
}