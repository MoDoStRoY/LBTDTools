namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Parts
{
    public class Engine
    {
        public string Model { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public string Fuel { get; set; }

        public string GetFullName() { return Model + " " + Number; }
    }
}