using System;

namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Parts
{
    public class Engine
    {
        public string Model { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public string Fuel { get; set; }
        public string EcoClass { get; set; }
        public string CylindersCount{ get; set; }
        public string CylindersVolume{ get; set; }
        public string Compression{ get; set; }
        public string MaxPower{ get; set; }
        public string MaxRotateMoment{ get; set; }
        public string SupplySystem{ get; set; }

        public string GetFullName() { return Model + " " + Number; }
    }
}