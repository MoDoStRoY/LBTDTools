namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class Snorkel : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Воздухозаборник ДВС";
        public string UpgradeDesk = "Наружный воздухозаборник (шноркель) установлен на переднее крыло и боковую стойку кузова.";
        public string CheckUpgradeDesk = "Воздухозаборник не имеет травмоопасных выступов, ни одна выступающая часть наружной поверхности не имеет радиус скругления менее 2,5 мм. Воздухозаборник двигателя надежно закреплён с помощью стандартных крепёжных элементов.";

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