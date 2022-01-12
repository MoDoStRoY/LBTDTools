namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class PowerBumperBack : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Задний силовой бампер";
        public string UpgradeDesk = "Вместо штатного заднего бампера произведена установка сертифицированного заднего силового бампера.";
        public string CheckUpgradeDesk = "Бампер не имеет травмоопасных выступов, ни одна выступающая часть наружной поверхности не имеет радиус скругления менее 2,5 мм. Бампер надежно закреплен с помощью стандартных крепежных элементов. Концы бампера загнуты в направлении наружной поверхности таким образом, что сведена к минимуму опасность зацепления окружающих предметов.";

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