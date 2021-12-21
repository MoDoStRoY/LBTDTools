export default class Client 
{
    public nameClient: string;
    public passportNumberClient: string;
    public passportAuthorClient: string;
    public addressClient: string;

    constructor(nameClient: string, passportNumberClient: string, passportAuthorClient: string,
                addressClient: string) 
    {
        this.nameClient = nameClient;
        this.passportNumberClient = passportNumberClient;
        this.passportAuthorClient = passportAuthorClient;
        this.addressClient = addressClient;
    }
}