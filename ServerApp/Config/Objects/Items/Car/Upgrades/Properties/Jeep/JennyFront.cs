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