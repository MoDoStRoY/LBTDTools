namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class EngineProtection : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Защита ДВС";
        public string UpgradeDesk = "Установлена защита ДВС.";
        public string CheckUpgradeDesk = "Закреплена с помощью стандартных крепежных инструментов.";

        public ECategory Category = ECategory.JEEP;
        public ECheck Check = ECheck.DIMENSIONSSAFE;
        
        public string NameGet()
        {
            return Name;
        }
        
        public ECategory CategoryGet()
        {
            return Category;
        }
        public ECheck CheckGet()
        {
            return Check;
        }
    }
}