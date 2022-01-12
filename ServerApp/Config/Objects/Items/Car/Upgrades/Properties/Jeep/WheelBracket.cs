namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class WheelBracket : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Кронштейн для крепления запасного колеса на заднем бампере";
        public string UpgradeDesk = "На заднем бампере установлен кронштейн под запасное колесо.";
        public string CheckUpgradeDesk = "Кронштейн крепления запасного колеса не имеет травмоопасных выступов, ни одна выступающая часть наружной поверхности не имеет радиус скругления менее 2,5 мм. Кронштейн крепления запасного колеса надежно закреплён с помощью стандартных крепёжных элементов. Место расположения и установка задних внешних световых приборов и приборов освещения заднего государственного регистрационного знака соответствуют требованиям. На ТС предусмотрены места для крепления регистрационных знаков в соответствии с требованиями. После крепления запасного колеса на кронштейне соблюдены требования по углам видимости государственного регистрационного знака.";

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