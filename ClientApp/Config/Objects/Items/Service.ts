export default class Service
{
    public name: string;
    public entityAddress: string;
    public certificateDate: string;
    public certificateNumber: string;
    public certificateAuthor: string;
    
    constructor(name: string, entityAddress: string, certificateDate: string, 
                certificateNumber: string, certificateAuthor: string) 
    {
        this.name = name;
        this.entityAddress = entityAddress;
        this.certificateDate = certificateDate;
        this.certificateNumber = certificateNumber;
        this.certificateAuthor = certificateAuthor;
    }
}