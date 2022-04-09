namespace LBTDTools.ServerApp.Config.Objects.Items.Car.Upgrades.Properties.Civilian
{
    public class SwapCategory : IUpgrade
    {
        public bool Done { get; set; }
        public string Name = "Смена категории";
        public string UpgradeDesk = "- Выполнен демонтаж ВО ВТОРОМ РЯДУ ОДНО СПРАВА СЛЕВА ПОСЕРЕДИНЕ, В ТРЕТЬЕМ РЯДУ ТРИ СЛЕВА пассажирских сиденья и их крепления (описываются внесенные изменения в конструкцию систем, узлов и агрегатов ТС) - Демонтированы поручни. - В основание кузова, в местах установки пассажирских сидений введены усилители, на усиленное основание кузова с учетом требований в отношении прочности сидений и их креплений установлены два трехместных сертифицированных пассажирских сиденья. - Общее число пассажирских мест, не считая места водителя, стало равным 8 (восьми). - Пассажирские сиденья оборудованы сертифицированными ремнями безопасности в соответствии с требованиями п. 3.2 Приложения № 4 Технического регламента Таможенного союза «О безопасности колесных транспортных средств». - Исключена возможность использования мест крепления демонтированных сидений, установкой постоянных заглушек, которые невозможно снять с помощью обычного слесарно-монтажного инструмента.  ";
        public string CheckUpgradeDesk = "1. Сиденья надежно закреплены в местах, предусмотренных изготовителем в эксплуатационной документации транспортного средства с использованием штатных креплений. 2. Ремни безопасности установлены так, что: - Отсутствует возможность соскальзывания с плеча правильно надетого ремня в результате смещения водителя или пассажира вперед. - Отсутствует возможность повреждения лямки ремня при соприкосновении с острыми твердыми элементами конструкции транспортного средства. Конструкция и установка ремней безопасности позволяют пристегнуться ими в любое время. - Устройство, служащее для открывания пряжки, является хорошо заметным и легкодоступным для пользователя и исключает возможность его неожиданного или случайного открытия. - Пряжка располагается в легкодоступном месте для спасателя в том случае, если необходимо срочно высвободить из транспортного средства водителя или пассажира. - Пряжка установлена таким образом, что, как в открытом состоянии, так и под нагрузкой веса пользователя, он может ее открыть простым движением как левой, так и правой руки в одном направлении. - Надетый ремень легко регулируется пассажиром в соответствии со своей комплекцией. - Каждое место для сидения оборудовано местами крепления ремней безопасности, соответствующими типу применяемых ремней. - Места крепления располагаются на панелях с достаточной жесткостью и усилением. - При визуальном осмотре мест крепления ремней безопасности не наблюдается пропусков в сварном шве, видимых непроваров. - Болты, используемые в конструкции мест крепления ремней безопасности класса 8.8. 3. На установленных ремнях безопасности отсутствуют надрывы на лямке, видимые невооруженным глазом. Замок фиксирует \"язык\" лямки или выбрасывает его после нажатия на кнопку замыкающего устройства. Лямка вытягивается и втягивается во втягивающее устройство (катушку). При резком вытягивании лямки ремня с аварийным запирающимся втягивающим устройством обеспечивается прекращение (блокирование) ее вытягивания из втягивающего устройства (катушки). 4. Исключена возможность использования мест крепления демонтированных сидений, установкой постоянных заглушек, которые невозможно снять с помощью обычного слесарно-монтажного инструмента. ";
        public string Equipment = "";

        public ECategory Category = ECategory.CIVILIAN;
        public ECheck Check = ECheck.STANDART;
        
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