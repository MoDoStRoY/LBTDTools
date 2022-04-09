namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class FogLights : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Противотуманные фары";
        public string UpgradeDesk = "На переднем бампере установлены противотуманные фары.";
        public string CheckUpgradeDesk = "Подключены к штатной электропроводке автомобиля, установлены на транспортном средстве симметрично средней продольной плоскости.";
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