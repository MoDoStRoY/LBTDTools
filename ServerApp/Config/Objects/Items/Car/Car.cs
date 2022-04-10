using LBTDTools.ServerApp.Config.Objects.Items.Car;
using LBTDTools.ServerApp.Config.Objects.Items.Car.Parts;
using LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades;

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
        public Wheels Wheels { get; set; }
        public UpgradeTypes Upgrades { get; set; }
        public string WeightWithEquipment { get; set; }
        public string MaxWeight { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string WheelBaseLength { get; set; }

        public string GetFullName() { return Brand + " " + Model; }
    }
}