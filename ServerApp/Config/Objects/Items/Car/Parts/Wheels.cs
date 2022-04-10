using System;

namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Parts
{
    public class Wheels
    {
        public string Name  { get; set; }
        public string WheelWidth { get; set; }
        public string ProfileSize { get; set; }
        public string Radius { get; set; }

        public string GetFullName()
        {
            return Name + " " + WheelWidth + "/" + ProfileSize + "/R" + Radius;
        }
    }
}