namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class WaterBooster : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Гидроусилитель руля";
        public string UpgradeDesk = "На автомобиль установлен гидроусилитель руля, закреплен с помощью стандартных крепежных инструментов.";
        public string CheckUpgradeDesk = "Гидроусилитель руля закреплен с помощью стандартных крепежных инструментов. Изменение усилия при повороте рулевого колеса должно происходить плавно во всем диапазоне угла его поворота. Самопроизвольный поворот рулевого колеса с усилителем рулевого управления от нейтрального положения при работающем двигателе, вопреки желанию и ожиданиям водителя, исключен.";

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