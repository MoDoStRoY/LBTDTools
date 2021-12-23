using System.Collections.Generic;
using LBTDTools.ServerApp.Config.Objects.Docs.Properties.Act;
using LBTDTools.ServerApp.Config.Objects.Items;
using LBTDTools.ServerApp.Config.Objects.Items.Car;

namespace LBTDTools.ServerApp.Config.Objects.Docs
{
    public class Act
    {
        public Laboratory Laboratory { get; set; }
        public Service Service { get; set; }
        public Car Car { get; set; }
        public Client Client { get; set; }

        public VisualControl VisualControl = new();
        public WeightControl WeightControl = new();
        public COControl COControl = new();
        public SoundControl SoundControl = new();
        public DimensionsControl DimensionsControl = new();
        public SafeControl SafeControl = new();
        
        public string Number { get; set; }
        public string SampleCloseDate { get; set; }
        public string CarGiveDate { get; set; }
        public string PPTOAddress { get; set; }
        public string NamePPTOExpert { get; set; }
    }
}