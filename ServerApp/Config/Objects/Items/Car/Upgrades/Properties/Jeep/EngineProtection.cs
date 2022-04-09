namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class EngineProtection : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Защита ДВС";
        public string UpgradeDesk = "Установлена защита ДВС.";
        public string CheckUpgradeDesk = "Закреплена с помощью стандартных крепежных инструментов.";
        public string Equipment = "";

        public ECategory Category = ECategory.JEEP;
        public ECheck Check = ECheck.DIMENSIONSSAFE;
        
        public string GetName()
        {
            return Name;
        }
        
        public ECategory GetCategory()
        {
            return Category;
        }
        public ECheck GetCheck()
        {
            return Check;
        }

        public string GetUpgradeDesk()
        {
            return UpgradeDesk;
        }

        public string GetCheckUpgradeDesk()
        {
            return CheckUpgradeDesk;
        }

        public string GetEquipment()
        {
            return Equipment;
        }
    }
}