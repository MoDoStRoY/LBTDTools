namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class DiskBrakesFront : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Передние дисковые тормоза";
        public string UpgradeDesk = "На автомобиле смонтированы передние дисковые тормозные механизмы.";
        public string CheckUpgradeDesk = "При монтаже дисковых тормозных механизмов использованы штатные монтажные элементы, соблюдена герметичность соединения тормозных шлангов, регулятор тормозных сил установлен и настроен таким образом, что обеспечивается необходимая эффективность и распределение тормозных усилий по осям автомобиля. Показатели эффективности тормозной системы и устойчивости транспортного средства соответствуют требованиям (удельная тормозная сила рабочей и стояночной тормозной системы, относительная разность тормозных сил колес оси, усилие на органе управления рабочей и стояночной тормозной системы).";

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