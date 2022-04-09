using System.Collections.Generic;
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
        private string[,] ttxMassive;

        private List<string> upgradesDeskList;
        private List<string> upgradesDeskCheckList;

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
            
            ttxMassive = new[,]
            {
                //{"{$weightWithEquipment}", _declarationObj.Car.GetFullName()},
                //{"{$maxWeight}", _declarationObj.ToString()},
                //{"{$length}", _declarationObj.ToString()},
                //{"{$width}", _declarationObj.ToString()},
                //{"{$height}", _declarationObj.ToString()},
                //{"{$wheelBaseLength}", _declarationObj.ToString()},
                {"{$modelNumberEngine}", _declarationObj.Car.Engine.GetFullName()},
                //{"{$ecoClass}", _declarationObj.ToString()},
                //{"{$cylindersCount}", _declarationObj.ToString()},
                //{"{$cylindersVolume}", _declarationObj.ToString()},
                //{"{$compression}", _declarationObj.ToString()},
                //{"{$maxPower}", _declarationObj.ToString()},
                //{"{$maxRotateMoment}", _declarationObj.ToString()},
                {"{$fuel}", _declarationObj.Car.Engine.Fuel},
                //{"{$supplySystem}", _declarationObj.ToString()},
                //{"{$wheels}", _declarationObj.ToString()},
                {"{$equipment}", _declarationObj.Car.Upgrades.GetUpgradeNames()},
            };

            upgradesDeskList = new();
            upgradesDeskCheckList = new();
            for (int i = 0; i < _declarationObj.Car.Upgrades.ListOfActiveUpgrades.Count; i++)
            {
                upgradesDeskList.Add(_declarationObj.Car.Upgrades.ListOfActiveUpgrades[i].GetName() + " - " +
                                              _declarationObj.Car.Upgrades.ListOfActiveUpgrades[i].GetUpgradeDesk());
                upgradesDeskCheckList.Add(_declarationObj.Car.Upgrades.ListOfActiveUpgrades[i].GetName() + " - " +
                                     _declarationObj.Car.Upgrades.ListOfActiveUpgrades[i].GetCheckUpgradeDesk());
            }
        }

        private void PutData()
        {
            SampleDoc.Paragraphs.ParseReplace(paragraphsMassive);
            SampleDoc.Tables[0].ParseReplaceWrap("{$upgradesList}", upgradesDeskList);
            SampleDoc.Tables[1].ParseReplaceWrap("{$checkUpgradesList}", upgradesDeskCheckList);
            SampleDoc.Tables[2].ParseReplace(ttxMassive);
        }
    }
}