export default class Breaks
{
    public workType: string;
    public spareType: string;
    public parkingType: string;
    
    constructor(workType: string, spareType: string, parkingType: string) 
    {
        if (workType == "")
            this.workType = " без изменений";
        else 
            this.workType = workType;
        if (spareType == "")
            this.spareType = " без изменений";
        else 
            this.spareType = spareType;
        if (parkingType == "")
            this.parkingType = " без изменений";
        else 
            this.parkingType = parkingType;
    }
}