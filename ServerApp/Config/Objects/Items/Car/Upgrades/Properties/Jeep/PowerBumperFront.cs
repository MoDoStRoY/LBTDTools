namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties
{
    public class PowerBumperFront : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Передний силовой бампер";
        public string UpgradeDesk = "Вместо штатного переднего бампера произведена установка сертифицированного переднего силового бампера.";
        public string CheckUpgradeDesk = "Бампер не имеет травмоопасных выступов, ни одна выступающая часть наружной поверхности не имеет радиус скругления менее 2,5 мм. Бампер надежно закреплен с помощью стандартных крепежных элементов. Концы бампера загнуты в направлении наружной поверхности таким образом, что сведена к минимуму опасность зацепления окружающих предметов.";
        public string Equipment = "";

        public const ECategory Category = ECategory.JEEP;
        public const ECheck Check = ECheck.DIMENSIONSSAFE;
        
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