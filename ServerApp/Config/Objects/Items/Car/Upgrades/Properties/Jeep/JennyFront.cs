namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties
{
    public class JennyFront : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Лебёдка в переднем бампере";
        public string UpgradeDesk = "На переднем бампере установлена электролебедка.";
        public string CheckUpgradeDesk = "Электролебедка надежно закреплена с помощью стандартных крепежных элементов. Электролебедка не выступает за переднюю поверхность бампера. На ТС предусмотрены места для крепления регистрационных знаков в соответствии с требованиями.";

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