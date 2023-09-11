import Laboratory from "../Items/Laboratory";
import Service from "../Items/Service";
import Client from "../Items/Client";

export default class Act
{
    public Laboratory: Laboratory;
    public Service: Service;
    //public Car: Car;
    public Client: Client;

    public Number: string;
    public SampleCloseDate: string;
    public CarGiveDate: string;
    public PPTOAddress: string;
    public NamePPTOExpert: string;
    
    constructor(Laboratory: Laboratory, Service: Service, Client: Client, Number: string,
                SampleCloseDate: string, CarGiveDate: string, PPTOAddress: string,
                NamePPTOExpert: string) 
    {
        this.Laboratory = Laboratory;
        this.Service = Service;
        this.Client = Client;
        this.Number = Number;
        this.SampleCloseDate = SampleCloseDate;
        this.CarGiveDate = CarGiveDate;
        this.PPTOAddress = PPTOAddress;
        this.NamePPTOExpert = NamePPTOExpert
    }
}