namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties
{
    public class Vizor : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Защитный козырёк";
        public string UpgradeDesk = "На крыше автомобиля над лобовым стеклом при помощи стандартных крепежных элементов установлен козырек заводского производства.";
        public string CheckUpgradeDesk = "Защитный козырек не имеет травмоопасных выступов, ни одна выступающая часть наружной поверхности не имеет радиус скругления менее 2,5 мм. Защитный козырек надежно закреплен с помощью стандартных крепежных элементов. Защитный козырек не нарушает обзорность с места водителя.";
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