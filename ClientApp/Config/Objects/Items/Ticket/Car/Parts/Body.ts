export default class Body
{
    public number: string;
    public type: string;
    public passengerSeatsFrontRear: string;
    public loadingSpaceType: string;
    public cabinType: string;
    public passengerSeatsBus: string;
    public seatsBus: string;
    public loadCompartment: string;
    public frame: string;
    
    constructor(number: string, type: string, passengerSeatsFrontRear: string, loadingSpaceType: string, cabinType: string,
                passengerSeatsBus: string, seatsBus: string, loadCompartment: string, frame: string, carCategory: string) 
    {
        this.number = number;
        if (carCategory == "M1")
        {
            if (type == "")
                this.type = " без изменений";
            else
                this.type = type;
            if (passengerSeatsFrontRear == "")
                this.passengerSeatsFrontRear = " без изменений";
            else
                this.passengerSeatsFrontRear = passengerSeatsFrontRear;
        }
        else
        {
            this.type = " -";
            this.passengerSeatsFrontRear = " -";
        }
        if (carCategory == "N1" || carCategory == "N2" || carCategory == "N3")
        {
            if (loadingSpaceType == "")
                this.loadingSpaceType = " без изменений";
            else
                this.loadingSpaceType = loadingSpaceType;
            if (cabinType == "")
                this.cabinType = " без изменений";
            else
                this.cabinType = cabinType;
        }
        else
        {
            this.loadingSpaceType = " -";
            this.cabinType = " -";
        }
        if (carCategory == "M2" || carCategory == "M3")
        {
            if (passengerSeatsBus == "") 
                this.passengerSeatsBus = " без изменений";
            else 
                this.passengerSeatsBus = passengerSeatsBus;
            if (seatsBus == "") 
                this.seatsBus = " без изменений";
            else 
                this.seatsBus = seatsBus;
            if (carCategory == "M3")
            {
                if (loadCompartment == "")
                    this.loadCompartment = " без изменений";
                else
                    this.loadCompartment = loadCompartment;
            }
            else
                this.loadCompartment = " -";
        }
        else
        {
            this.passengerSeatsBus = " -";
            this.seatsBus = " -";
            this.loadCompartment = " -"
        }
        if (carCategory == "L")
            if (frame == "")
                this.frame = " без изменений";
            else
                this.frame = frame;
        else
            this.frame = frame;
    }
}