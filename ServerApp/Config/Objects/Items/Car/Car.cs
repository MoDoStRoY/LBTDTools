using LBTDTools.ServerApp.Config.Objects.Items.Car.Parts;

namespace LBTDTools.ServerApp.Config.Objects.Items.Car
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string GovRegNum { get; set; }
        public string ReleaseDate { get; set; }
        public string VIN { get; set; }
        public string ChassisNumber { get; set; }
        public string BodyNumber { get; set; }
        public Engine Engine { get; set; }
        public UpgradeTypes Upgrades { get; set; }

        public string GetFullName() { return Brand + " " + Model; }
    }
}