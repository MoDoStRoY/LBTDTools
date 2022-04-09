namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties
{
    public interface IUpgrade
    {
        public bool Done { get; set; }
        private const string Name = "";
        private const string UpgradeDesk = "";
        private const string CheckUpgradeDesk = "";
        private const string Equipment = "";

        private const ECategory Category = ECategory.JEEP;
        private const ECheck Check = ECheck.STANDART;

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