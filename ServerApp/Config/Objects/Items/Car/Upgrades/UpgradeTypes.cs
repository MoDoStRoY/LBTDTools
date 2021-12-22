using System;
using LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties;

namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades
{
    public class UpgradeTypes
    {
        public bool PowerBumperFront { get; set; } // Передний силовой бампер
        public bool JennyFront { get; set; } // Лебёдка перед
        public bool ProtectiveArcFront { get; set; } // Передняя защитная дуга
        public bool Vizor { get; set; } // Козырёк
        public bool Steps { get; set; } // Пороги
        public bool PowerBumperBack { get; set; } // Задний силовой бампер
        public bool JennyBack { get; set; } // Лебёдка зад
        public bool ProtectiveArcBack { get; set; } // Задняя защитная дуга
        public bool WheelBracket { get; set; } // Кронштейн для запаски (бампер)
        public bool WheelBracketDoor { get; set; } // Кронштейн для запаски (дверь)
        public bool Kung { get; set; } // Кунг
        public bool Carrier { get; set; } // Багажник
        public bool Ladder { get; set; } // Лестница
        public bool Manhole { get; set; } // Люк в крыше
        public bool MetalRoof { get; set; } // Металлическая крыша
        public bool FarLights { get; set; } // Фары дальнего света
        public bool DayLights { get; set; } // Дневные ходовые огни
        public bool FogLights { get; set; } // Противотуманки
        public bool WorkLights { get; set; } // Рабочий свет
        public bool Snorkel { get; set; } // Шноркель
        public bool EngineProtection { get; set; } // Защита ДВС 
        public bool PullProtection { get; set; } // Защита рулевых тяг
        public bool TransmissionProtection { get; set; } // Защита КПП
        public bool DiskBrakesFront { get; set; } // Передние дисковые тормоза
        public bool DiskBrakesBack { get; set; } // Задние дисковые тормоза
        public bool Damper { get; set; } // Рулевой демпфер
        public bool WaterBooster { get; set; } // Гидроусилитель
        public bool SleepingBag { get; set; } // Спальник
        public bool LiftSpring { get; set; } // Лифт на пружинах
        public bool LiftSpacers { get; set; } // Лифт на проставках
        public bool BiggerTires { get; set; } // Увеличенные шины
        public bool ArchExtenders { get; set; } // Расширители арок
        
        public bool GasSet { get; set; } // Монтаж ГБО
        public bool GasDelete { get; set; } // Демонтаж ГБО
        public bool SwapEngine { get; set; } // Смена ДВС
        public bool SwapCategory { get; set; } // Смена категории
        
        public bool ArmorDelete { get; set; } // Снятие брони

        public string GetUpgradeNames()
        {
            string result = " ";

            if (PowerBumperFront) { result += ", " +  UpgradeNames.PowerBumperFrontName; }
            if (JennyFront) { result += ", " + UpgradeNames.JennyFrontName; }
            if (ProtectiveArcFront) { result += ", " + UpgradeNames.ProtectiveArcFrontName; }
            if (Vizor) { result += ", " + UpgradeNames.VizorName; }
            if (Steps) { result += ", " + UpgradeNames.StepsName; }
            if (PowerBumperBack) { result += ", " + UpgradeNames.PowerBumperBackName; }
            if (JennyBack) { result += ", " + UpgradeNames.JennyBackName; }
            if (ProtectiveArcBack) { result += ", " + UpgradeNames.ProtectiveArcBackName; }
            if (WheelBracket) { result += ", " + UpgradeNames.WheelBracketName; }
            if (WheelBracketDoor) { result += ", " + UpgradeNames.WheelBracketDoorName; }
            if (Kung) { result += ", " + UpgradeNames.KungName; }
            if (Carrier) { result += ", " + UpgradeNames.CarrierName; }
            if (Ladder) { result += ", " + UpgradeNames.LadderName; }
            if (Manhole) { result += ", " + UpgradeNames.ManholeName; }
            if (MetalRoof) { result += ", " + UpgradeNames.MetalRoofName; }
            if (FarLights) { result += ", " + UpgradeNames.FarLightsName; }
            if (DayLights) { result += ", " + UpgradeNames.DayLightsName; }
            if (FogLights) { result += ", " + UpgradeNames.FogLightsName; }
            if (WorkLights) { result += ", " + UpgradeNames.WorkLightsName; }
            if (Snorkel) { result += ", " + UpgradeNames.SnorkelName; }
            if (EngineProtection) { result += ", " + UpgradeNames.EngineProtectionName; }
            if (PullProtection) { result += ", " + UpgradeNames.PullProtectionName; }
            if (TransmissionProtection) { result += ", " + UpgradeNames.TransmissionProtectionName; }
            if (DiskBrakesFront) { result += ", " + UpgradeNames.DiskBrakesFrontName; }
            if (DiskBrakesBack) { result += ", " + UpgradeNames.DiskBrakesBackName; }
            if (Damper) { result += ", " + UpgradeNames.DamperName; }
            if (WaterBooster) { result += ", " + UpgradeNames.WaterBoosterName; }
            if (SleepingBag) { result += ", " + UpgradeNames.SleepingBagName; }
            if (LiftSpring) { result += ", " + UpgradeNames.LiftSpringName; }
            if (LiftSpacers) { result += ", " + UpgradeNames.LiftSpacersName; }
            if (BiggerTires) { result += ", " + UpgradeNames.BiggerTiresName; }
            if (ArchExtenders) { result += ", " + UpgradeNames.ArchExtendersName; }
            if (GasSet) { result += ", " + UpgradeNames.GasSetName; }
            if (GasDelete) { result += ", " + UpgradeNames.GasDeleteName; }
            if (SwapEngine) { result += ", " + UpgradeNames.SwapEngineName; }
            if (SwapCategory) { result += ", " + UpgradeNames.SwapCategoryName; }
            if (ArmorDelete) { result += ", " + UpgradeNames.ArmorDeleteName; }

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