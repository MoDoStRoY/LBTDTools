export default class Transmission
{
    public type: string;
    
    constructor(type: string) 
    {
        if (type == "")
            this.type = " без изменений";
        else 
            this.type = type;
    }
}