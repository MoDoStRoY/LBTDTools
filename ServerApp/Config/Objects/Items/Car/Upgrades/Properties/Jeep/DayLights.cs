namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class DayLights : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Дневные ходовые огни";
        public string UpgradeDesk = "На переднем бампере установлены дневные ходовые огни.";
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