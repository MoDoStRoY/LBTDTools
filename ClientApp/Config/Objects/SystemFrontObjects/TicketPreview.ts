export default class TicketPreview
{
    public id: string;
    public name: string;
    public dateAndTime: string;

    constructor(id: string, name: string, dateAndTime: string)
    {
        this.id = id;
        this.name = name;
        this.dateAndTime = dateAndTime;
    }
}