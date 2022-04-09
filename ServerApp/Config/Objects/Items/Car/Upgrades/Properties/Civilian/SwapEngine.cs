namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Civilian
{
    public class SwapEngine : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Смена ДВС";
        public string UpgradeDesk = "";
        public string CheckUpgradeDesk = "";
        public string Equipment = "";

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

        public string GetEquipment()
        {
            return Equipment;
        }
    }
}