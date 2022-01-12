using System.IO;
using LBTDTools.ServerApp.Config.Objects.Docs;
using LBTDTools.ServerApp.Config.Objects.Docs.Properties.Declaration;
using LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties;
using NPOI.XWPF.UserModel;

namespace LBTDTools.ServerApp.Scripts.CreateDocuments.CreateDecrlaration
{
    public interface IDeclarationMain
    {
        public string CreateAct(Declaration declaration);
    }

    public class DeclarationMain : IDeclarationMain
    {
        private DeclarationProps _props = new();
        private string _pathToAnswerDoc;
        public XWPFDocument SampleDoc;
        private FileStream _outStream;
        public Declaration _declarationObj;

        private string[,] paragraphsMassive;

        private string[,] firstTableMassive;
        private string[,] secondTableMassive;
        private string[,] thirdTableMassive;
        private string[,] fourTableMassive;

        public string CreateAct(Declaration declarationObj)
        {
            _declarationObj = declarationObj;
            SampleDoc = CreateMain.ReadSample(_props.PathToSample);
            _pathToAnswerDoc = CreateMain.CorrectPathToAnswerDoc(_props.PathToAnswerDoc, "Declaration_", ".docx");
            
            CreateMain.CreateAnswerFile(_pathToAnswerDoc);
            
            _declarationObj.Car.Upgrades.InitializeListOfUpgrades();
            InitializeStringsForReplace();

            PutData();
            //RemoveUselessRows();
            //NumberingRows();

            CreateMain.WriteData(_pathToAnswerDoc, SampleDoc);

            return _pathToAnswerDoc + ";" + _props.TypeOfAnswerDoc + ";" + _props.NameOfAnswerDoc;
        }

        private void PutData()
        {
            SampleDoc.Paragraphs.ParseReplace(paragraphsMassive);
            //SampleDoc.Tables[0].ParseReplace(firstTableMassive);
            //SampleDoc.Tables[1].ParseReplace(secondTableMassive);
            //SampleDoc.Tables[2].ParseReplace(thirdTableMassive);
            //SampleDoc.Tables[3].ParseReplace(fourTableMassive);
        }

        private void RemoveUselessRows()
        {
            bool needCoSoundRows = false;
            bool needDimensionsSafeRows = false;

            for (int i = 0; i < _declarationObj.Car.Upgrades.ListOfActiveUpgrades.Count; i++)
            {
                switch (_declarationObj.Car.Upgrades.ListOfActiveUpgrades[i].GetCheck())
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
                //SampleDoc.Tables[3].RemoveRow(3);
                //SampleDoc.Tables[3].RemoveRow(3);
            }

            if (!needDimensionsSafeRows)
            {
                if (!needCoSoundRows)
                {
                    //SampleDoc.Tables[3].RemoveRow(3);
                    //SampleDoc.Tables[3].RemoveRow(3);
                }
                else
                {
                    //SampleDoc.Tables[3].RemoveRow(5);
                    //SampleDoc.Tables[3].RemoveRow(5);
                }
            }
        }

        private void NumberingRows()
        {
            int counterOfControls = 1;
            foreach (XWPFTableRow row in SampleDoc.Tables[2].Rows)
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
                {"{$brandModelAuto}", _declarationObj.Car.GetFullName()},
                {"{$govRegNum}", _declarationObj.Car.GovRegNum},
                {"{$VIN}", _declarationObj.Car.VIN},
                {"{$chassisNumberCar}", _declarationObj.Car.ChassisNumber},
                {"{$bodyNumberCar}", _declarationObj.Car.BodyNumber},
                {"{$modelNumberEngine}", _declarationObj.Car.Engine.GetFullName()},
                {"{$entity}", _declarationObj.Service.Name},
                {"{$entityAddressService}", _declarationObj.Service.EntityAddress},
                {"{$certificateDateService}", _declarationObj.Service.CertificateDate},
                {"{$certificateNumberService}", _declarationObj.Service.CertificateNumber},
                {"{$certificateAuthorService}", _declarationObj.Service.CertificateAuthor},
                {"{$finaleNumber}", _declarationObj.Laboratory.FinaleNumber},
                {"{$finaleDate}", _declarationObj.Laboratory.FinaleDate},
                {"{$laboratoryName}", _declarationObj.Laboratory.Name},
                {"{$worksDate}", _declarationObj.WorksDate}
            };
            
            firstTableMassive = new [,] 
            {
                {"{$expertFinaleNumber}", _declarationObj.Laboratory.FinaleNumber},
            };

            secondTableMassive = new [,]
            {
                {"{$brandModelAuto}", _declarationObj.Car.GetFullName()},
            };

            thirdTableMassive = new [,]
            {
                {"{$modelNumberEngine}", _declarationObj.Car.Engine.GetFullName()},
            };
            
            fourTableMassive = new[,]
            {
                {"{$1StandartName}", _declarationObj.Car.Model},
            };
        }
    }
}