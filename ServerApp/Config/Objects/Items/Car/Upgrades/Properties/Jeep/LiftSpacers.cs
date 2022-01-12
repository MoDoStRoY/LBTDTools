namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class LiftSpacers : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Лифт (проставки)";
        public string UpgradeDesk = "Кузов автомобиля приподнят при помощи специальных проставок заводского изготовления.";
        public string CheckUpgradeDesk = "Ослабление затяжки болтовых соединений и разрушения деталей подвески исключено. Обеспечиваются: работоспособность при максимальных динамических нагрузках, стабильность характеристик упругих элементов подвески, отсутствие вредных контактов в пределах полного хода подвески.";

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