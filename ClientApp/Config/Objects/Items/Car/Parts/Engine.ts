export default class Engine 
{
    public model: string;
    public number: string;
    public type: string;
    public fuel: string;
    
    constructor(model: string, number: string, type: string, fuel: string) 
    {
        this.model = model;
        this.number = number;
        this.type = type;
        this.fuel = fuel;
    }
}