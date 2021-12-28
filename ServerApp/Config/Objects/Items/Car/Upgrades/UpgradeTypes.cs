using System;
using System.Collections.Generic;
using LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties;
using LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Civilian;
using LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep;
using LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Special;

namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades
{
    public class UpgradeTypes
    {
        public List<bool> UpgradesBoolList { get; set; }
        private List<IUpgrade> ListOfUpgrades = new()
        {
            new PowerBumperFront(), new JennyFront(), new ProtectiveArcFront(), new Vizor(), new Steps(),
            new PowerBumperBack(), new JennyBack(), new ProtectiveArcBack(), new WheelBracket(), new WheelBracketDoor(),
            new Kung(), new Carrier(), new Ladder(), new Manhole(), new MetalRoof(), new FarLights(), 
            new DayLights(), new FogLights(), new WorkLights(), new Snorkel(), new EngineProtection(), 
            new PullProtection(), new TransmissionProtection(), new DiskBrakesFront(), new DiskBrakesBack(), 
            new Damper(), new WaterBooster(), new SleepingBag(), new LiftSpring(), new LiftSpacers(), 
            new BiggerTires(), new ArchExtenders(),
            
            new GasSet(), new GasDelete(), new SwapEngine(), new SwapCategory(), 
            
            new ArmorDelete()
        };

        public List<IUpgrade> JeepUpgrades = new();
        public List<IUpgrade> CivilianUpgrades = new();
        public List<IUpgrade> SpecialUpgrades = new();
        
        public List<IUpgrade> ListOfActiveUpgrades = new();
        
        public void InitializeListOfUpgrades()
        {
            for (int i = 0; i < UpgradesBoolList.Count; i++)
            {
                ListOfUpgrades[i].Done = UpgradesBoolList[i];
            }

            SortList();
        }

        public void SortList()
        {
            for (int i = 0; i < ListOfUpgrades.Count; i++)
            {
                switch (ListOfUpgrades[i].CategoryGet())
                {
                    case ECategory.JEEP:
                        if (ListOfUpgrades[i].Done)
                        {
                            JeepUpgrades.Add(ListOfUpgrades[i]);
                            ListOfActiveUpgrades.Add(ListOfUpgrades[i]);
                        }
                        break;
                    case ECategory.CIVILIAN:
                        if (ListOfUpgrades[i].Done)
                        {
                            CivilianUpgrades.Add(ListOfUpgrades[i]);
                            ListOfActiveUpgrades.Add(ListOfUpgrades[i]);
                        }
                        break;
                    case ECategory.SPECIAL:
                        if (ListOfUpgrades[i].Done)
                        {
                            SpecialUpgrades.Add(ListOfUpgrades[i]);
                            ListOfActiveUpgrades.Add(ListOfUpgrades[i]);
                        }
                        break;
                }
            }
        }

        public string GetUpgradeNames()
        {
            string result = " ";

            for (int i = 0; i < ListOfActiveUpgrades.Count; i++)
                result += ", " + ListOfActiveUpgrades[i].NameGet();

            return CorrectNamesList(result).Trim();
        }

        private string CorrectNamesList(string incorrectString)
        {
            char[] buffer = incorrectString.ToLower().ToCharArray();

            for (int i = 0; i < 2; i++)
                buffer[i] = ' ';

            buffer[3] = Char.ToUpper(buffer[3]);

            return (new string(buffer) + ".").Trim();
        }
    }
}