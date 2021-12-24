using System;
using LBTDTools.ServerApp.Config.Objects.Docs;
using LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties;
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
            foreach (var para in actMain.SampleDoc.Paragraphs)
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
            string[,] firstTableMassive =
            {
                {"{$expertFinaleNumber}", actMain._actObj.Laboratory.FinaleNumber},
                {"{$checkDate}", actMain._actObj.SampleCloseDate},
                {"{$giveAutoDate}", actMain._actObj.CarGiveDate},
                {"{$checkPointAddress}", actMain._actObj.PPTOAddress}
            };

            string[,] secondTableMassive =
            {
                {"{$brandModelAuto}", actMain._actObj.Car.GetFullName()},
                {"{$govRegNum}", actMain._actObj.Car.GovRegNum},
                {"{$VIN}", actMain._actObj.Car.VIN},
                {"{$releaseDate}", actMain._actObj.Car.ReleaseDate},
                {"{$clientAndAddress}", actMain._actObj.Client.GetInfo()}
            };

            string[,] thirdTableMassive =
            {
                {"{$modelNumberEngine}", actMain._actObj.Car.Engine.GetFullName()},
                {"{$color}", actMain._actObj.Car.Color},
                {"{$engineType}", actMain._actObj.Car.Engine.Type},
                {"{$fuel}", actMain._actObj.Car.Engine.Fuel},
                {"{$equipment}", actMain._actObj.Car.Upgrades.GetUpgradeNames()}
            };

            actMain.SampleDoc.Tables[0].ParseReplace(firstTableMassive);
            actMain.SampleDoc.Tables[1].ParseReplace(secondTableMassive);
            actMain.SampleDoc.Tables[2].ParseReplace(thirdTableMassive);
        }

        private static void StandartTable(ActMain actMain)
        {
            string[,] fourTableMassive =
            {
                {"{$1StandartName}", actMain._actObj.VisualControl.StandartName},
                {"{$1Equipment}", actMain._actObj.VisualControl.Equipment},
                {"{$1ControledRequire}", actMain._actObj.VisualControl.ControledRequire},
                {"{$1ControlResult}", actMain._actObj.VisualControl.ControlResult},

                {"{$2StandartName}", actMain._actObj.WeightControl.StandartName},
                {"{$2Equipment}", actMain._actObj.WeightControl.Equipment},
                {"{$2ControledRequire}", actMain._actObj.WeightControl.ControledRequire},
                {"{$2ControlResult}", actMain._actObj.WeightControl.ControlResult},

                {"{$3StandartName}", actMain._actObj.COControl.StandartName},
                {"{$3Equipment}", actMain._actObj.COControl.Equipment},
                {"{$3ControledRequire}", actMain._actObj.COControl.ControledRequire},
                {"{$3ControlResult}", actMain._actObj.COControl.ControlResult},

                {"{$4StandartName}", actMain._actObj.SoundControl.StandartName},
                {"{$4Equipment}", actMain._actObj.SoundControl.Equipment},
                {"{$4ControledRequire}", actMain._actObj.SoundControl.ControledRequire},
                {"{$4ControlResult}", actMain._actObj.SoundControl.ControlResult},

                {"{$5StandartName}", actMain._actObj.DimensionsControl.StandartName},
                {"{$5Equipment}", actMain._actObj.DimensionsControl.Equipment},
                {"{$5ControledRequire}", actMain._actObj.DimensionsControl.ControledRequire},
                {"{$5ControlResult}", actMain._actObj.DimensionsControl.ControlResult},

                {"{$6StandartName}", actMain._actObj.SafeControl.StandartName},
                {"{$6Equipment}", actMain._actObj.SafeControl.Equipment},
                {"{$6ControledRequire}", actMain._actObj.SafeControl.ControledRequire},
                {"{$6ControlResult}", actMain._actObj.SafeControl.ControlResult}
            };

            actMain.SampleDoc.Tables[3].ParseReplace(fourTableMassive);

            bool needCoSoundRows = false;
            bool needDimensionsSafeRows = false;
            int counterOfControls = 1;
            
            for (int i = 0; i < actMain._actObj.Car.Upgrades.ListOfActiveUpgrades.Count; i++)
            {
                switch (actMain._actObj.Car.Upgrades.ListOfActiveUpgrades[i].CheckGet())
                {
                    case ECheck.COSOUND:
                        needCoSoundRows = true;
                        break;
                    case ECheck.DIMENSIONSSAFE:
                        needDimensionsSafeRows = true;
                        break;
                }
            }

            if (!needCoSoundRows)
            {
                actMain.SampleDoc.Tables[3].RemoveRow(3);
                actMain.SampleDoc.Tables[3].RemoveRow(3);
            }

            if (!needDimensionsSafeRows)
            {
                if (!needCoSoundRows)
                {
                    actMain.SampleDoc.Tables[3].RemoveRow(3);
                    actMain.SampleDoc.Tables[3].RemoveRow(3);
                }
                else
                {
                    actMain.SampleDoc.Tables[3].RemoveRow(5);
                    actMain.SampleDoc.Tables[3].RemoveRow(5);
                }
            }

            foreach (XWPFTable tbl in actMain.SampleDoc.Tables)
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