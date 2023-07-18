export default class Suspension
{
    public frontType: string;
    public rearType: string;
    
    constructor(frontType: string, rearType: string) 
    {
        if (frontType == "")
            this.frontType = " без изменений";
        else 
            this.frontType = frontType;
        if (rearType == "")
            this.rearType = " без изменений";
        else 
            this.rearType = rearType;
    }
}