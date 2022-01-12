namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Civilian
{
    public class GasSet : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Монтаж ГБО";
        public string UpgradeDesk = "";
        public string CheckUpgradeDesk = "";

        public ECategory Category = ECategory.CIVILIAN;
        public ECheck Check = ECheck.COSOUND;
        
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
    }
}