using LBTDTools.ServerApp.Config.Objects.Docs;
using NPOI.XWPF.UserModel;

namespace LBTDTools.ServerApp.Scripts.CreateDocuments.CreateAct
{
    public static class PutData
    {
        public static void Put(this ActMain actMain)
        {
            PutParagraph(actMain);
            PutTable(actMain);
        }

        private static void PutParagraph(ActMain actMain)
        {
            foreach (var para in actMain._sampleDoc.Paragraphs)
            {
                string oldText = para.ParagraphText;
                
                if (oldText == "")
                    continue;
                
                string newText = para.ParagraphText;

                newText = newText.Replace("{$entity}", actMain._actObj.Service.Name);
                newText = newText.Replace("{$checkPointAddress}", actMain._actObj.PPTOAddress);
                newText = newText.Replace("{$actNumber}", actMain._actObj.Number);
                newText = newText.Replace("{$date}", actMain._actObj.CarGiveDate);
                newText = newText.Replace("{$PPTOExpertFIO}", actMain._actObj.NamePPTOExpert);

                para.ReplaceText(oldText, newText);
            }
        }

        private static void PutTable(ActMain actMain)
        {
            DataTables(actMain);
            StandartTable(actMain);
        }

        private static void DataTables(ActMain actMain)
        {
            foreach (XWPFTable tbl in actMain._sampleDoc.Tables) 
            {
                foreach (XWPFTableRow row in tbl.Rows) 
                {
                    foreach (XWPFTableCell cell in row.GetTableCells()) 
                    {
                        foreach (XWPFParagraph p in cell.Paragraphs) 
                        {
                            foreach (XWPFRun r in p.Runs)
                            {
                                r.Replace("{$expertFinaleNumber}", actMain._actObj.Laboratory.FinaleNumber);
                                r.Replace("{$checkDate}", actMain._actObj.SampleCloseDate);
                                r.Replace("{$giveAutoDate}", actMain._actObj.CarGiveDate);
                                r.Replace("{$checkPointAddress}", actMain._actObj.PPTOAddress);
                                r.Replace("{$brandModelAuto}", actMain._actObj.Car.GetFullName());
                                r.Replace("{$govRegNum}", actMain._actObj.Car.GovRegNum);
                                r.Replace("{$releaseDate}", actMain._actObj.Car.ReleaseDate);
                                r.Replace("{$clientAndAddress}", actMain._actObj.Client.GetInfo());
                                r.Replace("{$VIN}", actMain._actObj.Car.VIN);
                                r.Replace("{$modelNumberEngine}", actMain._actObj.Car.Engine.GetFullName());
                                r.Replace("{$color}", actMain._actObj.Car.Color);
                                r.Replace("{$engineType}", actMain._actObj.Car.Engine.Type);
                                r.Replace("{$fuel}", actMain._actObj.Car.Engine.Fuel);
                                r.Replace("{$equipment}", actMain._actObj.Car.Upgrades.GetUpgradeNames());
                            }
                        }
                    }
                }
            }
        }

        private static void StandartTable(ActMain actMain)
        {
            int test1 = 0;
            int test2 = 0;
            int test3 = 0;
            bool yes = false;
            
            foreach (XWPFTable tbl in actMain._sampleDoc.Tables) 
            {
                foreach (XWPFTableRow row in tbl.Rows) 
                {
                    foreach (XWPFTableCell cell in row.GetTableCells()) 
                    {
                        foreach (XWPFParagraph p in cell.Paragraphs) 
                        {
                            foreach (XWPFRun r in p.Runs)
                            {
                                if (r.Contains("№ п.п."))
                                {
                                    if (!actMain._actObj.Car.Upgrades.GasSet && !actMain._actObj.Car.Upgrades.GasDelete &&
                                        !actMain._actObj.Car.Upgrades.SwapEngine)
                                    {
                                        test1 = actMain._sampleDoc.Tables.IndexOf(tbl);
                                        test2 = tbl.Rows.IndexOf(row) + 3;
                                        test3 = tbl.Rows.IndexOf(row) + 5;
                                        yes = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (yes)
            {
                actMain._sampleDoc.Tables[test1].RemoveRow(test2);
                actMain._sampleDoc.Tables[test1].RemoveRow(test3);
            }
        }
    }
}