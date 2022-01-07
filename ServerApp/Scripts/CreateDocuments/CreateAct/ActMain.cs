using System.IO;
using LBTDTools.ServerApp.Config.Objects.Docs;
using LBTDTools.ServerApp.Config.Objects.Docs.Properties.Act;
using LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties;
using NPOI.XWPF.UserModel;

namespace LBTDTools.ServerApp.Scripts.CreateDocuments.CreateAct
{
    public interface IActMain
    {
        public string CreateAct(Act act);
    }

    public class ActMain : IActMain
    {
        private ActProps _props = new();
        private string _pathToAnswerDoc;
        public XWPFDocument SampleDoc;
        private FileStream _outStream;
        public Act _actObj;

        private string[,] paragraphsMassive;

        private string[,] firstTableMassive;
        private string[,] secondTableMassive;
        private string[,] thirdTableMassive;
        private string[,] fourTableMassive;

        public string CreateAct(Act actObjIn)
        {
            _actObj = actObjIn;
            SampleDoc = CreateMain.ReadSample(_props.PathToSample);
            _pathToAnswerDoc = CreateMain.CorrectPathToAnswerDoc(_props.PathToAnswerDoc, "Act_", ".docx");
            
            CreateMain.CreateAnswerFile(_pathToAnswerDoc);
            
            actObjIn.Car.Upgrades.InitializeListOfUpgrades();
            InitializeStringsForReplace();

            PutData();
            RemoveUselessRows();
            NumberingRows();

            CreateMain.WriteData(_pathToAnswerDoc, SampleDoc);

            return _pathToAnswerDoc + ";" + _props.TypeOfAnswerDoc + ";" + _props.NameOfAnswerDoc;
        }

        private void PutData()
        {
            SampleDoc.Paragraphs.ParseReplace(paragraphsMassive);
            SampleDoc.Tables[0].ParseReplace(firstTableMassive);
            SampleDoc.Tables[1].ParseReplace(secondTableMassive);
            SampleDoc.Tables[2].ParseReplace(thirdTableMassive);
            SampleDoc.Tables[3].ParseReplace(fourTableMassive);
        }

        private void RemoveUselessRows()
        {
            bool needCoSoundRows = false;
            bool needDimensionsSafeRows = false;

            for (int i = 0; i < _actObj.Car.Upgrades.ListOfActiveUpgrades.Count; i++)
            {
                switch (_actObj.Car.Upgrades.ListOfActiveUpgrades[i].CheckGet())
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
                SampleDoc.Tables[3].RemoveRow(3);
                SampleDoc.Tables[3].RemoveRow(3);
            }

            if (!needDimensionsSafeRows)
            {
                if (!needCoSoundRows)
                {
                    SampleDoc.Tables[3].RemoveRow(3);
                    SampleDoc.Tables[3].RemoveRow(3);
                }
                else
                {
                    SampleDoc.Tables[3].RemoveRow(5);
                    SampleDoc.Tables[3].RemoveRow(5);
                }
            }
        }

        private void NumberingRows()
        {
            int counterOfControls = 1;
            foreach (XWPFTableRow row in SampleDoc.Tables[3].Rows)
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

        private void InitializeStringsForReplace()
        {
            paragraphsMassive = new[,]
            {
                {"{$entity}", _actObj.Service.Name},
                {"{$checkPointAddress}", _actObj.PPTOAddress},
                {"{$actNumber}", _actObj.Number},
                {"{$date}", _actObj.CarGiveDate},
                {"{$PPTOExpertFIO}", _actObj.NamePPTOExpert},
            };
            
            firstTableMassive = new [,] 
            {
                {"{$expertFinaleNumber}", _actObj.Laboratory.FinaleNumber},
                {"{$checkDate}", _actObj.SampleCloseDate},
                {"{$giveAutoDate}", _actObj.CarGiveDate},
                {"{$checkPointAddress}", _actObj.PPTOAddress}
            };

            secondTableMassive = new [,]
            {
                {"{$brandModelAuto}", _actObj.Car.GetFullName()},
                {"{$govRegNum}", _actObj.Car.GovRegNum},
                {"{$VIN}", _actObj.Car.VIN},
                {"{$releaseDate}", _actObj.Car.ReleaseDate},
                {"{$clientAndAddress}", _actObj.Client.GetInfo()}
            };

            thirdTableMassive = new [,]
            {
                {"{$modelNumberEngine}", _actObj.Car.Engine.GetFullName()},
                {"{$color}", _actObj.Car.Color},
                {"{$engineType}", _actObj.Car.Engine.Type},
                {"{$fuel}", _actObj.Car.Engine.Fuel},
                {"{$equipment}", _actObj.Car.Upgrades.GetUpgradeNames()}
            };
            
            fourTableMassive = new[,]
            {
                {"{$1StandartName}", _actObj.VisualControl.StandartName},
                {"{$1Equipment}", _actObj.VisualControl.Equipment},
                {"{$1ControledRequire}", _actObj.VisualControl.ControledRequire},
                {"{$1ControlResult}", _actObj.VisualControl.ControlResult},

                {"{$2StandartName}", _actObj.WeightControl.StandartName},
                {"{$2Equipment}", _actObj.WeightControl.Equipment},
                {"{$2ControledRequire}", _actObj.WeightControl.ControledRequire},
                {"{$2ControlResult}", _actObj.WeightControl.ControlResult},

                {"{$3StandartName}", _actObj.COControl.StandartName},
                {"{$3Equipment}", _actObj.COControl.Equipment},
                {"{$3ControledRequire}", _actObj.COControl.ControledRequire},
                {"{$3ControlResult}", _actObj.COControl.ControlResult},

                {"{$4StandartName}", _actObj.SoundControl.StandartName},
                {"{$4Equipment}", _actObj.SoundControl.Equipment},
                {"{$4ControledRequire}", _actObj.SoundControl.ControledRequire},
                {"{$4ControlResult}", _actObj.SoundControl.ControlResult},

                {"{$5StandartName}", _actObj.DimensionsControl.StandartName},
                {"{$5Equipment}", _actObj.DimensionsControl.Equipment},
                {"{$5ControledRequire}", _actObj.DimensionsControl.ControledRequire},
                {"{$5ControlResult}", _actObj.DimensionsControl.ControlResult},

                {"{$6StandartName}", _actObj.SafeControl.StandartName},
                {"{$6Equipment}", _actObj.SafeControl.Equipment},
                {"{$6ControledRequire}", _actObj.SafeControl.ControledRequire},
                {"{$6ControlResult}", _actObj.SafeControl.ControlResult}
            };
        }
    }
}