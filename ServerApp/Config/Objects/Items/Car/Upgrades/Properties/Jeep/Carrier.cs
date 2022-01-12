namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class Carrier : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Экспедиционный багажник";
        public string UpgradeDesk = "К водосточным желобам на крыше автомобиля при помощи стандартных крепежных элементов установлен багажник заводского производства.";
        public string CheckUpgradeDesk = "Багажник не имеет травмоопасных выступов и ни одна выступающая часть наружной поверхности не имеет радиус скругления менее 2,5 мм. Багажник надежно закреплён с помощью стандартных крепёжных элементов.";

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