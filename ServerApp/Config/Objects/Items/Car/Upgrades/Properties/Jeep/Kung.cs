namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class Kung : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Кунг";
        public string UpgradeDesk = "Установлена съемная крыша кузова (кунг) на бортовой кузов.";
        public string CheckUpgradeDesk = "Съемная крыша кузова не имеет травмоопасных выступов, ни одна выступающая часть наружной поверхности не имеет радиус скругления менее 2,5 мм. Съемная крыша надежно закреплена с помощью стандартных крепежных элементов.";

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