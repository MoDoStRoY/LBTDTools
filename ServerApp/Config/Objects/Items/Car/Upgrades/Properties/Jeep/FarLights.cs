namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class FarLights : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Фары дальнего света";
        public string UpgradeDesk = "На переднем бампере установлены фары дальнего света.";
        public string CheckUpgradeDesk = "Подключены к штатной электропроводке автомобиля, установлены на транспортном средстве симметрично средней продольной плоскости.";

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
    }
}