export default class Engine 
{
    public model: string;
    public number: string;
    public type: string;
    public fuel: string;
    public ecoClass: string;
    public cylindersCount: string;
    public cylindersVolume: string;
    public compression: string;
    public maxPower: string;
    public maxRotateMoment: string;
    public supplySystem: string;
    
    constructor(model: string, number: string, type: string, fuel: string, ecoClass: string, cylindersCount: string, 
                cylindersVolume: string, compression: string, maxPower: string, maxRotateMoment: string, supplySystem: string) 
    {
        if (model == "")
        {
            this.model = " без изменений";
            this.number = " -";
            this.type = " -";
            this.fuel = " -";
            this.ecoClass = " -";
            this.cylindersCount = " -";
            this.cylindersVolume = " -";
            this.compression = " -";
            this.maxPower = " -";
            this.maxRotateMoment = " -";
            this.supplySystem = " -";
        }
        else
        {
            this.model = model;
            this.number = number;
            this.type = type;
            this.fuel = fuel;
            this.ecoClass = ecoClass;
            this.cylindersCount = cylindersCount;
            this.cylindersVolume = cylindersVolume;
            this.compression = compression;
            this.maxPower = maxPower;
            this.maxRotateMoment = maxRotateMoment;
            this.supplySystem = supplySystem;
        }
    }
}