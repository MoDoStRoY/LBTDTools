import TicketBuilder from "./TicketBuilder";
import TicketPreview from "./TicketPreview";

export default class User
{
    public ticketsListPreview: TicketPreview[];
    public userID: number;
    
    constructor() 
    {
        this.ticketsListPreview = [];
        this.userID = 0;
    }
}