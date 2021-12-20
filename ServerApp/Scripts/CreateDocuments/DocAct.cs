using System.IO;
using LBTDTools.Extensions;
using LBTDTools.ServerApp.Config.Docs.Properties;
using LBTDTools.ServerApp.Config.Objects.Docs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
            _pathToAnswerDoc = Props.PathToAnswerDoc;
            
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
            _pathToAnswerDoc += "Act_" + Program.Server.DocActCounter + ".docx";
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

                newText = NpoiMethods.ReplaceRun(newText, "{$expertFinaleNumber}", _actObj.Laboratory.FinaleNumber);
                newText = NpoiMethods.ReplaceRun(newText, "{$entity}", _actObj.Service.Name);
                newText = NpoiMethods.ReplaceRun(newText, "{$checkPointAddress}", _actObj.PPTOAddress);
                newText = NpoiMethods.ReplaceRun(newText, "{$actNumber}", _actObj.Number);
                newText = NpoiMethods.ReplaceRun(newText, "{$date}", _actObj.CarGiveDate);
                newText = NpoiMethods.ReplaceRun(newText, "{$PPTOExpertFIO}", _actObj.NamePPTOExpert);

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
                                /*r.SetText(NpoiMethods.ReplaceRun(r.GetText(0), "{$expertFinaleNumber}",
                                    _actObj.Laboratory.FinaleNumber), 0);*/
                                
                                // за счет расширения Replace немного упрощаем вызов замены текста, подробней можешь увидеть при переходе в метод Replace
                                r.Replace("{$expertFinaleNumber}", _actObj.Laboratory.FinaleNumber);
                                
                                // @todo сделать по аналогии так же везде
                                r.SetText(NpoiMethods.ReplaceRun(r.GetText(0), "{$checkDate}",
                                    _actObj.SampleCloseDate), 0);
                                r.SetText(NpoiMethods.ReplaceRun(r.GetText(0), "{$giveAutoDate}", 
                                    _actObj.CarGiveDate), 0);
                                r.SetText(NpoiMethods.ReplaceRun(r.GetText(0), "{$checkPointAddress}",
                                    _actObj.PPTOAddress), 0);
                                r.SetText(NpoiMethods.ReplaceRun(r.GetText(0), "{$brandModelAuto}", 
                                    _actObj.Car.Brand + " " + _actObj.Car.Model), 0);
                                r.SetText(NpoiMethods.ReplaceRun(r.GetText(0), "{$govRegNum}", 
                                    _actObj.Car.GovRegNum), 0);
                                r.SetText(NpoiMethods.ReplaceRun(r.GetText(0), "{$VIN}", 
                                    _actObj.Car.VIN), 0);
                                r.SetText(NpoiMethods.ReplaceRun(r.GetText(0), "{$modelNumberEngine}",
                                    _actObj.Car.Engine.Model + " " + _actObj.Car.Engine.Number), 0);
                                r.SetText(NpoiMethods.ReplaceRun(r.GetText(0), "{$color}", 
                                    _actObj.Car.Color), 0);
                                r.SetText(NpoiMethods.ReplaceRun(r.GetText(0), "{$engineType}", 
                                    _actObj.Car.Engine.Type), 0);
                                r.SetText(NpoiMethods.ReplaceRun(r.GetText(0), "{$fuel}",
                                    _actObj.Car.Engine.Fuel), 0);
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
            //PathToAnswerDoc = Path.GetFullPath("ServerApp/Config/Docs/Acts/");
        }
    }
}