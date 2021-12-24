namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Civilian
{
    public class SwapCategory : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Смена категории";

        public ECategory Category = ECategory.CIVILIAN;
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