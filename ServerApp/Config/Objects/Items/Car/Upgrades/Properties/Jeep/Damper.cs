namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class Damper : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Рулевой демпфер";
        public string UpgradeDesk = "Во избежание биения рулевого колеса установлен рулевой демпфер, закреплен с помощью стандартных крепежных инструментов.";
        public string CheckUpgradeDesk = "Рулевой демпфер закреплен с помощью стандартных крепежных инструментов. Изменение усилия при повороте рулевого колеса происходит плавно во всем диапазоне угла его поворота. Самопроизвольный поворот рулевого колеса с усилителем рулевого управления от нейтрального положения при работающем двигателе, вопреки желанию и ожиданиям водителя, исключен. Характеристики демпфирующих элементов подвески и рулевого привода обеспечивают выполнение требований к устойчивости и управляемости транспортного средства. Ход штока обеспечивает полный ход подвески и максимальный угол поворота управляемых колес. Обеспечиваются: демпфирующие характеристики; температурные характеристики; герметичность; работа без стуков и заеданий.";
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