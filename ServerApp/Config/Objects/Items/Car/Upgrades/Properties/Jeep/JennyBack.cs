namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class JennyBack : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Лебёдка в заднем бампере";
        public string UpgradeDesk = "На заднем бампере установлена электролебедка.";
        public string CheckUpgradeDesk = "Электролебедка не имеет травмоопасных выступов, ни одна выступающая часть наружной поверхности не имеет радиус скругления менее 2,5 мм. Электролебедка надежно закреплена с помощью стандартных крепежных элементов. На ТС предусмотрены места для крепления регистрационных знаков в соответствии с требованиями.";

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