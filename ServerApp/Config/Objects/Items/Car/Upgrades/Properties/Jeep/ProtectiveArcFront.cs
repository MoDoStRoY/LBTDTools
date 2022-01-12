namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class ProtectiveArcFront : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Передняя защитная дуга";
        public string UpgradeDesk = "Под передним бампером установлена защитная дуга.";
        public string CheckUpgradeDesk = "Защитная дуга не имеет травмоопасных выступов, ни одна часть наружной поверхности не выступает вперед относительно линии бампера. Защитная дуга не имеет травмоопасных выступов, ни одна выступающая часть наружной поверхности не имеет радиус скругления менее 2,5 мм. Защитная дуга надежно закреплена с помощью стандартных крепежных элементов.";

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