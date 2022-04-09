namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class LiftSpacers : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Лифт (проставки)";
        public string UpgradeDesk = "Кузов автомобиля приподнят при помощи специальных проставок заводского изготовления.";
        public string CheckUpgradeDesk = "Ослабление затяжки болтовых соединений и разрушения деталей подвески исключено. Обеспечиваются: работоспособность при максимальных динамических нагрузках, стабильность характеристик упругих элементов подвески, отсутствие вредных контактов в пределах полного хода подвески.";
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