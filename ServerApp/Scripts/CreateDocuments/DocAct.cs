using System.IO;
using LBTDTools.ServerApp.Config.Objects.Docs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NPOI.XWPF.UserModel;

namespace LBTDTools.ServerApp.Scripts.CreateDocuments
{
    public class DocAct
    {
        private static string PathToSample = Path.GetFullPath("ServerApp/Config/Docs/Samples/ActSample.docx");
        private static string PathToAnswerDoc = Path.GetFullPath("ServerApp/Config/Docs/Acts/");
        private static string TypeOfAnswerDoc = "application/docx";
        private static string NameOfAnswerDoc = "Акт измерения.docx";
        private static XWPFDocument SampleDoc;
        private static FileStream OutStream;
        private static Act actObj;

        public static string CreateAct(Act actObj)
        {
            DocAct.actObj = actObj;
            
            ReadSample();
            CorrectPathToAnswerDoc();
            CreateBufferFile();
            PutData();
            WriteData();
            CloseStreams();

            return PathToAnswerDoc + ";" + TypeOfAnswerDoc + ";" + NameOfAnswerDoc;
        }

        private static void ReadSample()
        {
            FileStream inStream = new FileStream(PathToSample, FileMode.Open, FileAccess.Read);
            SampleDoc = new XWPFDocument(inStream);
            inStream.Close();
            inStream.Dispose();
        }

        private static void CorrectPathToAnswerDoc()
        {
            Program.Server.DocActCounter++;
            PathToAnswerDoc += "Act_" + Program.Server.DocActCounter + ".docx";
        }

        private static void CreateBufferFile()
        {
            File.Create(PathToAnswerDoc).Close();
        }
        

        private static void PutData()
        {
            foreach (var para in SampleDoc.Paragraphs)
            {
                string oldText = para.ParagraphText;
                
                if (oldText == "")

                    continue;
                
                string tempText = para.ParagraphText;
                
                tempText = tempText.Replace("{$entity}", actObj.Service.Name);
                tempText = tempText.Replace("{$checkPointAddress}", actObj.PPTOAddress);
                tempText = tempText.Replace("{$actNumber}", actObj.Number);
                tempText = tempText.Replace("{$date}", actObj.CarGiveDate);
                tempText = tempText.Replace("{$PPTOExpertFIO}", actObj.NamePPTOExpert);

                para.ReplaceText(oldText, tempText);
            }
            
            foreach (XWPFTable tbl in SampleDoc.Tables) 
            {
                foreach (XWPFTableRow row in tbl.Rows) 
                {
                    foreach (XWPFTableCell cell in row.GetTableCells()) 
                    {
                        foreach (XWPFParagraph p in cell.Paragraphs) 
                        {
                            foreach (XWPFRun r in p.Runs) 
                            {
                                string text = r.GetText(0);
                                if (text != null && text.Contains("{$expertFinaleNumber}"))
                                {
                                    text = text.Replace("{$expertFinaleNumber}", actObj.Laboratory.FinaleNumber);
                                    r.SetText(text, 0);
                                }
                                if (text != null && text.Contains("{$checkDate}"))
                                {
                                    text = text.Replace("{$checkDate}", actObj.SampleCloseDate);
                                    r.SetText(text, 0);
                                }
                                if (text != null && text.Contains("{$giveAutoDate}"))
                                {
                                    text = text.Replace("{$giveAutoDate}", actObj.CarGiveDate);
                                    r.SetText(text, 0);
                                }
                                if (text != null && text.Contains("{$checkPointAddress}"))
                                {
                                    text = text.Replace("{$checkPointAddress}", actObj.PPTOAddress);
                                    r.SetText(text, 0);
                                }
                                if (text != null && text.Contains("{$brandModelAuto}"))
                                {
                                    text = text.Replace("{$brandModelAuto}", actObj.Car.Brand + " " + actObj.Car.Model);
                                    r.SetText(text, 0);
                                }
                                if (text != null && text.Contains("{$govRegNum}"))
                                {
                                    text = text.Replace("{$govRegNum}", actObj.Car.GovRegNum);
                                    r.SetText(text, 0);
                                }
                                if (text != null && text.Contains("{$VIN}"))
                                {
                                    text = text.Replace("{$VIN}", actObj.Car.VIN);
                                    r.SetText(text, 0);
                                }
                                if (text != null && text.Contains("{$modelNumberEngine}"))
                                {
                                    text = text.Replace("{$modelNumberEngine}", actObj.Car.Engine.Model + " " + actObj.Car.Engine.Number);
                                    r.SetText(text, 0);
                                }
                                if (text != null && text.Contains("{$color}"))
                                {
                                    text = text.Replace("{$color}", actObj.Car.Color);
                                    r.SetText(text, 0);
                                }
                                if (text != null && text.Contains("{$engineType}"))
                                {
                                    text = text.Replace("{$engineType}", actObj.Car.Engine.Type);
                                    r.SetText(text, 0);
                                }
                                if (text != null && text.Contains("{$fuel}"))
                                {
                                    text = text.Replace("{$fuel}", actObj.Car.Engine.Fuel);
                                    r.SetText(text, 0);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void WriteData()
        {
            OutStream = new FileStream(PathToAnswerDoc, FileMode.Create);
            SampleDoc.Write(OutStream);
        }

        private static void CloseStreams()
        {
            OutStream.Close();
            OutStream.Dispose();
            //PathToAnswerDoc = Path.GetFullPath("ServerApp/Config/Docs/Acts/");
        }
    }
}