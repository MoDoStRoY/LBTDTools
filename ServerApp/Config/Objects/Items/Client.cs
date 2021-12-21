namespace LBTDTools.ServerApp.Config.Objects.Items
{
    public class Client
    {
        public string NameClient { get; set; }
        public string PassportNumberClient { get; set; }
        public string PassportAuthorClient { get; set; }
        public string AddressClient { get; set; }

        public string GetInfo()
        {
            return NameClient + " паспорт " + PassportNumberClient + " выдан " + PassportAuthorClient +
                   ". Адрес: " + AddressClient;
        }
    }
}