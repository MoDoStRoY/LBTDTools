namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class TransmissionProtection : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Защита коробки передач";
        public string UpgradeDesk = "Установлена защита коробки передач.";
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