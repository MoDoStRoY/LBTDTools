namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class BiggerTires : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Колёса с шинами увеличенного размера";
        public string UpgradeDesk = "На автомобиль установлены колеса с шинами большего размера.";
        public string CheckUpgradeDesk = "При увеличении радиуса колеса, сохраняется превышение показаний спидометра относительно фактической скорости ТС.";

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