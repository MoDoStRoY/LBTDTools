namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Special
{
    public class ArmorDelete : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Снятие брони";

        public ECategory Category = ECategory.SPECIAL;
        public ECheck Check = ECheck.STANDART;
        
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