namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Special
{
    public class ArmorDelete : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Снятие брони";
        public string UpgradeDesk = "";
        public string CheckUpgradeDesk = "";
        public string Equipment = "";

        public ECategory Category = ECategory.SPECIAL;
        public ECheck Check = ECheck.STANDART;
        
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