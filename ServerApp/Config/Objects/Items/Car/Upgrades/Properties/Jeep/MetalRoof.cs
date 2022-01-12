namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class MetalRoof : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Металлическая крыша";
        public string UpgradeDesk = "Демонтирован матерчатый тент, при этом предусмотрены крепления для установки металлической крыши. Удален внутри кузова каркас безопасности, состоящий из круглых металлических труб, сваренных между собой. На предусмотренные места крепления установлена металлическая крыша заводского изготовления. На выступающие внутрь салона части крыши установлены энергопоглащающие накладки для предотвращения травмирования пассажиров.";
        public string CheckUpgradeDesk = "Металлическая крыша не имеет травмоопасных выступов и ни одна выступающая часть наружной поверхности не имеет радиус скругления менее 2,5 мм. Травмобезопасность внутреннего оборудования соответствует требованиям.";

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