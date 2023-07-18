namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Civilian
{
    public class GasSet : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Монтаж ГБО";
        public string UpgradeDesk = "На автомобиле, на места установки вышедшего из строя штатного ДВС установлен ДВС T20SED / 087281. Оба двигателя имеют близкие параметры по мощности, габаритам и массе. В процессе замены двигателя использованы штатные монтажные элементы и сохраняются параметры вспомогательного оборудования. Топливная система подсоединяется с помощью стандартных элементов (штуцеры, трубопроводы, шланги), при этом обеспечена герметичность соединения. Устанавливаемое на двигателе навесное оборудование обеспечивает требуемый уровень энергии для питания потребителей автомобиля. Стыковка устанавливаемого силового агрегата с агрегатами и системами автомобиля произведена в соответствии с принятыми в автомобилестроении нормами при проведении капитального ремонта автомобилей.";
        public string CheckUpgradeDesk = "";
        public string Equipment = "";

        public ECategory Category = ECategory.CIVILIAN;
        public ECheck Check = ECheck.COSOUND;
        
        public string GetName()
        {
            return Name;
        }
        
        public ECategory GetCategory()
        {
            return Category;
        }
        public ECheck GetCheck()
        {
            return Check;
        }

        public string GetUpgradeDesk()
        {
            return UpgradeDesk;
        }

        public string GetCheckUpgradeDesk()
        {
            return CheckUpgradeDesk;
        }

        public string GetEquipment()
        {
            return Equipment;
        }
    }
}