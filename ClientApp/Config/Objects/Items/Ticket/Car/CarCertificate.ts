export default class CarCertificate
{
    public stsNumber: string;
    public stsDate: string;
    public carNumber: string;
    public carColor: string;

    constructor(stsNumber: string, stsDate: string, carNumber: string, carColor: string)
    {
        this.stsNumber = stsNumber;
        this.stsDate = stsDate;
        this.carNumber = carNumber;
        this.carColor = carColor;
    }
}