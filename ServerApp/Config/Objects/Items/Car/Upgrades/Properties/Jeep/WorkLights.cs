namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class WorkLights : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Фары рабочего света";
        public string UpgradeDesk = "Установлены фары рабочего света, подключенные к штатной электропроводке автомобиля. Выведен отдельный тумблер включения.";
        public string CheckUpgradeDesk = "При монтаже фар рабочего света, электрическая схема включения светотехнических приборов выполнена таким образом, что их включение возможно только отдельным тумблером. Фары рабочего света не имеют травмоопасных выступов, ни одна выступающая часть наружной поверхности не имеет радиус скругления менее 2,5 мм. Фары рабочего света надежно закреплены с помощью стандартных крепежных элементов.";

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