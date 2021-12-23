using System;
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
                            p.Replace("{$expertFinaleNumber}", actMain._actObj.Laboratory.FinaleNumber);
                            p.Replace("{$checkDate}", actMain._actObj.SampleCloseDate);
                            p.Replace("{$giveAutoDate}", actMain._actObj.CarGiveDate);
                            p.Replace("{$checkPointAddress}", actMain._actObj.PPTOAddress);
                            p.Replace("{$brandModelAuto}", actMain._actObj.Car.GetFullName());
                            p.Replace("{$govRegNum}", actMain._actObj.Car.GovRegNum);
                            p.Replace("{$releaseDate}", actMain._actObj.Car.ReleaseDate);
                            p.Replace("{$clientAndAddress}", actMain._actObj.Client.GetInfo());
                            p.Replace("{$VIN}", actMain._actObj.Car.VIN);
                            p.Replace("{$modelNumberEngine}", actMain._actObj.Car.Engine.GetFullName());
                            p.Replace("{$color}", actMain._actObj.Car.Color);
                            p.Replace("{$engineType}", actMain._actObj.Car.Engine.Type);
                            p.Replace("{$fuel}", actMain._actObj.Car.Engine.Fuel);
                            p.Replace("{$equipment}", actMain._actObj.Car.Upgrades.GetUpgradeNames());
                        }
                    }
                }
            }
        }

        private static void StandartTable(ActMain actMain)
        {
            int counterOfControls = 1;

            int tableRowDeleteIndex = 999;
            int rowDeleteIndex1 = 999;
            int rowDeleteIndex2 = 999;

            foreach (XWPFTable tbl in actMain._sampleDoc.Tables)
            {
                foreach (XWPFTableRow row in tbl.Rows)
                {
                    foreach (XWPFTableCell cell in row.GetTableCells())
                    {
                        foreach (XWPFParagraph p in cell.Paragraphs)
                        {
                            p.Replace("{$1StandartName}", actMain._actObj.VisualControl.StandartName);
                            p.Replace("{$1Equipment}", actMain._actObj.VisualControl.Equipment);
                            p.Replace("{$1ControledRequire}", actMain._actObj.VisualControl.ControledRequire);
                            p.Replace("{$1ControlResult}", actMain._actObj.VisualControl.ControlResult);

                            p.Replace("{$2StandartName}", actMain._actObj.WeightControl.StandartName);
                            p.Replace("{$2Equipment}", actMain._actObj.WeightControl.Equipment);
                            p.Replace("{$2ControledRequire}", actMain._actObj.WeightControl.ControledRequire);
                            p.Replace("{$2ControlResult}", actMain._actObj.WeightControl.ControlResult);

                            p.Replace("{$1StandartName}", actMain._actObj.VisualControl.StandartName);
                            p.Replace("{$1Equipment}", actMain._actObj.VisualControl.Equipment);
                            p.Replace("{$1ControledRequire}", actMain._actObj.VisualControl.ControledRequire);
                            p.Replace("{$1ControlResult}", actMain._actObj.VisualControl.ControlResult);

                            p.Replace("{$2StandartName}", actMain._actObj.WeightControl.StandartName);
                            p.Replace("{$2Equipment}", actMain._actObj.WeightControl.Equipment);
                            p.Replace("{$2ControledRequire}", actMain._actObj.WeightControl.ControledRequire);
                            p.Replace("{$2ControlResult}", actMain._actObj.WeightControl.ControlResult);

                            if (p.Contains("{$3N}"))
                            {
                                if (!actMain._actObj.Car.Upgrades.SwapEngine ||
                                    !actMain._actObj.Car.Upgrades.GasSet ||
                                    !actMain._actObj.Car.Upgrades.GasDelete)
                                {
                                    rowDeleteIndex1 = tbl.Rows.IndexOf(row);
                                    tableRowDeleteIndex = actMain._sampleDoc.Tables.IndexOf(tbl);
                                }
                            }

                            p.Replace("{$3StandartName}", actMain._actObj.COControl.StandartName);
                            p.Replace("{$3Equipment}", actMain._actObj.COControl.Equipment);
                            p.Replace("{$3ControledRequire}", actMain._actObj.COControl.ControledRequire);
                            p.Replace("{$3ControlResult}", actMain._actObj.COControl.ControlResult);

                            p.Replace("{$4StandartName}", actMain._actObj.SoundControl.StandartName);
                            p.Replace("{$4Equipment}", actMain._actObj.SoundControl.Equipment);
                            p.Replace("{$4ControledRequire}", actMain._actObj.SoundControl.ControledRequire);
                            p.Replace("{$4ControlResult}", actMain._actObj.SoundControl.ControlResult);

                            if (p.Contains("{$5N}"))
                            {
                                if (!actMain._actObj.Car.Upgrades.PowerBumperFront)
                                {
                                    rowDeleteIndex2 = tbl.Rows.IndexOf(row);
                                    tableRowDeleteIndex = actMain._sampleDoc.Tables.IndexOf(tbl);
                                }
                            }

                            p.Replace("{$5StandartName}", actMain._actObj.DimensionsControl.StandartName);
                            p.Replace("{$5Equipment}", actMain._actObj.DimensionsControl.Equipment);
                            p.Replace("{$5ControledRequire}", actMain._actObj.DimensionsControl.ControledRequire);
                            p.Replace("{$5ControlResult}", actMain._actObj.DimensionsControl.ControlResult);


                            p.Replace("{$6StandartName}", actMain._actObj.SafeControl.StandartName);
                            p.Replace("{$6Equipment}", actMain._actObj.SafeControl.Equipment);
                            p.Replace("{$6ControledRequire}", actMain._actObj.SafeControl.ControledRequire);
                            p.Replace("{$6ControlResult}", actMain._actObj.SafeControl.ControlResult);
                        }
                    }
                }
            }

            if (rowDeleteIndex1 != 999)
            {
                actMain._sampleDoc.Tables[tableRowDeleteIndex].RemoveRow(rowDeleteIndex1);
                actMain._sampleDoc.Tables[tableRowDeleteIndex].RemoveRow(rowDeleteIndex1);
            }

            if (rowDeleteIndex2 != 999)
            {
                actMain._sampleDoc.Tables[tableRowDeleteIndex].RemoveRow(rowDeleteIndex2 - 2);
                actMain._sampleDoc.Tables[tableRowDeleteIndex].RemoveRow(rowDeleteIndex2 - 2);
            }

            foreach (XWPFTable tbl in actMain._sampleDoc.Tables)
            {
                foreach (XWPFTableRow row in tbl.Rows)
                {
                    foreach (XWPFTableCell cell in row.GetTableCells())
                    {
                        foreach (XWPFParagraph p in cell.Paragraphs)
                            if (p.Contains("{$1N}") || p.Contains("{$2N}") ||
                                p.Contains("{$3N}") || p.Contains("{$4N}") ||
                                p.Contains("{$5N}") || p.Contains("{$6N}"))
                            {
                                p.Replace(p.Text, counterOfControls.ToString());
                                counterOfControls++;
                            }
                    }
                }
            }
        }
    }
}