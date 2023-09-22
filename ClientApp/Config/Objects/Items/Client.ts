export default class Client 
{
    public lastName: string = "";
    public name: string = "";
    public middleName: string = "";
    public phoneNumber: string;
    public passportNumberClient: string;
    public passportAuthorClient: string;
    public addressClient: string;

    constructor(lastName: string, name: string, middleName: string, phoneNumber: string, passportNumberClient: string, 
                passportAuthorClient: string, addressClient: string) 
    {
        this.lastName = lastName;
        this.name = name;
        this.middleName = middleName;
        this.phoneNumber = phoneNumber;
        this.passportNumberClient = passportNumberClient;
        this.passportAuthorClient = passportAuthorClient;
        this.addressClient = addressClient;
    }
}