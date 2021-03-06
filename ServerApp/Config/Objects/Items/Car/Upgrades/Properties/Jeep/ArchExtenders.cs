namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class ArchExtenders : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Расширители колёсных арок";
        public string UpgradeDesk = "Установлены расширители колесных арок.";
        public string CheckUpgradeDesk = "Расширители колесных арок выполнены в соответствии с условиями п. 10 Приложения № 3 к ТР ТС 018/2011. Ширина устройств защиты достаточная, чтобы закрыть габаритную ширину колеса с шиной с учетом пределов комбинации шина/колесо. Конструкция расширителей колесных арок обеспечивает отсутствие зазоров между или внутри отдельных частей самого устройства и в месте крепления к кузову в собранном состоянии. Расширители колесных арок не имеют травмоопасных выступов, ни одна выступающая часть наружной поверхности не имеет радиус скругления менее 2,5 мм Расширители колесных арок закреплены стандартными крепежными элементами.";
        public string Equipment = "";

        private ECategory Category = ECategory.JEEP;
        private ECheck Check = ECheck.DIMENSIONSSAFE;
        
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