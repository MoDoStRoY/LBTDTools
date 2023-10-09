import User from "../../Config/Objects/SystemFrontObjects/User";
import axios from "axios";
import TicketBuilder from "../../Config/Objects/SystemFrontObjects/TicketBuilder";

export default class TicketsUpload
{
    public static uploadCurrentTicket(ticket: TicketBuilder)
    {
        axios(
            {
                method: "post",
                url: "api/Tickets/TicketsUpload/UploadCurrentTicket",
                data: JSON.stringify(ticket),
                headers: {"Content-Type": "application/json"},
                responseType: "json",
            })
            .then((response: any) => 
            {
                console.log("Успех!")
            })
            .catch(function (error)
            {
                console.log(error);
            })
    }
}