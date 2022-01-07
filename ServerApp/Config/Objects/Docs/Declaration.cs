using LBTDTools.ServerApp.Config.Objects.Docs.Properties.Act;
using LBTDTools.ServerApp.Config.Objects.Items;
using LBTDTools.ServerApp.Config.Objects.Items.Car;

namespace LBTDTools.ServerApp.Config.Objects.Docs
{
    public class Declaration
    {
        public Laboratory Laboratory { get; set; }
        public Service Service { get; set; }
        public Car Car { get; set; }
        public Client Client { get; set; }
    }
}