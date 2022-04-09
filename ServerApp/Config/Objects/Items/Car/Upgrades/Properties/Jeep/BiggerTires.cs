namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class BiggerTires : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Колёса с шинами увеличенного размера";
        public string UpgradeDesk = "На автомобиль установлены колеса с шинами большего размера.";
        public string CheckUpgradeDesk = "При увеличении радиуса колеса, сохраняется превышение показаний спидометра относительно фактической скорости ТС.";
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