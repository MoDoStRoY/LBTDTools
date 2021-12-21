using LBTDTools.ServerApp.Config.Objects.Items;
using LBTDTools.ServerApp.Config.Objects.Items.Car;

namespace LBTDTools.ServerApp.Config.Objects.Docs
{
    public class Act
    {
        public Laboratory Laboratory { get; set; }
        public Service Service { get; set; }
        public Car Car { get; set; }
        public string Number { get; set; }
        public string SampleCloseDate { get; set; }
        public string CarGiveDate { get; set; }
        public string PPTOAddress { get; set; }
        public string NamePPTOExpert { get; set; }
    }
}