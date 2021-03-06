namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class WheelBracketDoor : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Кронштейн для крепления запасного колеса на задней двери";
        public string UpgradeDesk = "На задней двери установлен кронштейн крепления запасного колеса.";
        public string CheckUpgradeDesk = "Кронштейн крепления запасного колеса не имеет травмоопасных выступов, ни одна выступающая часть наружной поверхности не имеет радиус скругления менее 2,5 мм. Кронштейн крепления запасного колеса надежно закреплён с помощью стандартных крепёжных элементов. Место расположения и установка задних внешних световых приборов и приборов освещения заднего государственного регистрационного знака соответствуют требованиям. На ТС предусмотрены места для крепления регистрационных знаков в соответствии с требованиями. После крепления запасного колеса на кронштейне соблюдены требования по углам видимости государственного регистрационного знака.";
        public string Equipment = "";

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

        public string GetEquipment()
        {
            return Equipment;
        }
    }
}