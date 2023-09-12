export default class Client 
{
    public nameClient: string;
    public passportNumberClient: string;
    public passportAuthorClient: string;
    public addressClient: string;
    public phoneNumber: string;

    constructor(nameClient: string, passportNumberClient: string, passportAuthorClient: string,
                addressClient: string, phoneNumber: string) 
    {
        this.nameClient = nameClient;
        this.passportNumberClient = passportNumberClient;
        this.passportAuthorClient = passportAuthorClient;
        this.addressClient = addressClient;
        this.phoneNumber = phoneNumber;
    }
}