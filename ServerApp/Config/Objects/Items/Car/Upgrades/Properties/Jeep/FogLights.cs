namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class FogLights : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Противотуманные фары";
        public string UpgradeDesk = "На переднем бампере установлены противотуманные фары.";
        public string CheckUpgradeDesk = "Подключены к штатной электропроводке автомобиля, установлены на транспортном средстве симметрично средней продольной плоскости.";

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