namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties
{
    public interface IUpgrade
    {
        public bool Done { get; set; }
        private const string Name = "";

        private const ECategory Category = ECategory.JEEP;
        private const ECheck Check = ECheck.STANDART;

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