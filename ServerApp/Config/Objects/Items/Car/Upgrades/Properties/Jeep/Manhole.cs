namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Jeep
{
    public class Manhole : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Люк в крыше";
        public string UpgradeDesk = "В крыше салона установлен аварийно-вентиляционный люк, который не имеет травмоопасных выступов.";
        public string CheckUpgradeDesk = "Сохранены прочностные свойства крыши. Выполнены требования в отношении внутреннего оборудования ТС.";

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