namespace LBTDTools.ServerApp.Config.Objects.Items.Car
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

        public string PowerBumperFrontText = "Передний силовой бампер";

        public string GetUpgradesList()
        {
            string result = " ";

            if (PowerBumperFront)
            {
                result += PowerBumperFrontText;
            }

            return result.Trim();
        }
    }
}