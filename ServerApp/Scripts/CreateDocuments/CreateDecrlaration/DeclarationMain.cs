using System.IO;
using LBTDTools.ServerApp.Config.Objects.Docs;
using LBTDTools.ServerApp.Config.Objects.Docs.Properties.Declaration;
using LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties;
using NPOI.XWPF.UserModel;

namespace LBTDTools.ServerApp.Scripts.CreateDocuments.CreateDecrlaration
{
    public interface IDeclarationMain
    {
        public string CreateDeclaration(Declaration declaration);
    }

    public class DeclarationMain : IDeclarationMain
    {
        private DeclarationProps _props = new();
        private string _pathToAnswerDoc;
        public XWPFDocument SampleDoc;
        private FileStream _outStream;
        public Declaration _declarationObj;

        private string[,] paragraphsMassive;

        private string[,] upgradesDeskMassive;

        public string CreateDeclaration(Declaration declarationObj)
        {
            _declarationObj = declarationObj;
            SampleDoc = CreateMain.ReadSample(_props.PathToSample);
            _pathToAnswerDoc = CreateMain.CorrectPathToAnswerDoc(_props.PathToAnswerDoc, "Declaration_", ".docx");
            
            CreateMain.CreateAnswerFile(_pathToAnswerDoc);
            
            _declarationObj.Car.Upgrades.InitializeListOfUpgrades();
            InitializeStringsForReplace();

            PutData();

            CreateMain.WriteData(_pathToAnswerDoc, SampleDoc);

            return _pathToAnswerDoc + ";" + _props.TypeOfAnswerDoc + ";" + _props.NameOfAnswerDoc;
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

            string bufferStringOfUpgradesDesk = "";
            for (int i = 0; i < _declarationObj.Car.Upgrades.ListOfActiveUpgrades.Count; i++)
            {
                bufferStringOfUpgradesDesk += _declarationObj.Car.Upgrades.ListOfActiveUpgrades[i].GetName() + "\r\n" +
                                              _declarationObj.Car.Upgrades.ListOfActiveUpgrades[i].GetUpgradeDesk() +
                                              "\r\n\r\n";
            }
            upgradesDeskMassive = new[,]{{"{$upgradesList}", bufferStringOfUpgradesDesk}};
        }

        private void PutData()
        {
            SampleDoc.Paragraphs.ParseReplace(paragraphsMassive);
            SampleDoc.Paragraphs.ParseReplaceWrap(upgradesDeskMassive);
        }
    }
}