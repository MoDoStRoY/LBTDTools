namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties
{
    public class PowerBumperFront : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Передний силовой бампер";

        public const ECategory Category = ECategory.JEEP;
        public const ECheck Check = ECheck.DIMENSIONSSAFE;
        
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