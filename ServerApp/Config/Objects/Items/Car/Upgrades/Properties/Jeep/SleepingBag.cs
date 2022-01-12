namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class SleepingBag : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Спальное место.";
        public string UpgradeDesk = "Демонтирован третий ряд пассажирских сидений, их крепления. На места креплений демонтированных сидений установлены постоянные заглушки, которые невозможно снять с помощью обычного слесарно-монтажного инструмента. В задней части салона смонтировано при помощи болтового соединения спальное место, изготовленное из металлического каркаса и пружинного матраса. Общее число пассажирских мест, не считая места водителя, равно 4 (четырем).";
        public string CheckUpgradeDesk = "Исключена возможность использования мест крепления демонтированных сидений, установкой постоянных заглушек, которые невозможно снять с помощью обычного слесарно-монтажного инструмента. Несъемное оборудование надежно закреплено стандартными крепежными деталями. Специальное оборудование, установленное в салоне легкового автомобиля, не имеет травмоопасных выступов. В легковом автомобиле специальное оборудование не установлено в зоне размещения органов управления и не загораживает заднее окно.";

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