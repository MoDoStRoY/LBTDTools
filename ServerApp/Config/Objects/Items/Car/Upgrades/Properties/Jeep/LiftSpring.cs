namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class LiftSpring : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Лифт (пружины)";
        public string UpgradeDesk = "Кузов автомобиля приподнят при помощи сертифицированных усиленных элементов подвески (пружины, амортизаторы).";
        public string CheckUpgradeDesk = "При замене упругих и демпфирующих элементов подвески, ослабление затяжки болтовых соединений и разрушения деталей подвески исключено. Характеристики упругих и демпфирующих элементов подвески обеспечивают выполнение требований к устойчивости и управляемости транспортного средства. Для упругих элементов обеспечиваются: работоспособность при максимальных динамических нагрузках, стабильность характеристик упругих элементов подвески, отсутствие вредных контактов в пределах полного хода подвески. Ход штока демпфирующего элемента подвески обеспечивает полный ход подвески. Для демпфирующего элемента подвески обеспечиваются: демпфирующие характеристики, температурные характеристики, герметичность, работа без стуков и заеданий.";

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