namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class Ladder : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Лестница для доступа к багажнику";
        public string UpgradeDesk = "На задней двери установлена лестница для доступа к багажнику.";
        public string CheckUpgradeDesk = "Лестница установлена так, что не имеет травмоопасных выступов, ни одна выступающая часть наружной поверхности не имеет радиус скругления менее 2,5 мм. Лестница для доступа к багажнику надежно закреплена с помощью стандартных крепёжных элементов. Место расположения и установка задних внешних световых приборов и приборов освещения заднего государственного регистрационного знака соответствуют требованиям. На ТС предусмотрены места для крепления регистрационных знаков в соответствии с требованиями. После крепления лестницы соблюдены требования по углам видимости государственного регистрационного знака.";

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