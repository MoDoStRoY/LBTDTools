import axios from "axios";
import User from "../../Config/Objects/SystemFrontObjects/User";
import TicketPreview from "../../Config/Objects/SystemFrontObjects/TicketPreview";

export default class TicketsDownload
{
    
    public static async downloadAllTicketsPreview(userID: number): Promise<TicketPreview[]>
    {
        try
        {
            let response = await axios(
                {
                    method: "post",
                    url: "api/Tickets/TicketsDownload/DownloadAllTicketsPreview",
                    data: userID,
                    headers: {"Content-Type": "application/json"},
                    responseType: "json",
                })
            return JSON.parse(response.data);
        }
        catch(error) 
        {
                console.log(error);
                return [];
        }
        
    }
    
    public static downloadCurrentTicket(ticketID:number)
    {
        axios(
            {
                method: "post",
                url: "api/Tickets/TicketsDownload/DownloadCurrentTicket",
                data: ticketID,
                headers: {"Content-Type": "application/json"},
                responseType: "json",
            })
            .then((response: any) =>
            {
                return JSON.parse(response);
            })
            .catch(function (error)
            {
                console.log(error);
            })
    }
    
}