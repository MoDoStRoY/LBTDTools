namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Civilian
{
    public class GasSet : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Монтаж ГБО";

        public ECategory Category = ECategory.CIVILIAN;
        public ECheck Check = ECheck.COSOUND;
        
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