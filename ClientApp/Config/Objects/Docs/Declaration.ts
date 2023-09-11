import Client from "../Items/Client";
import Laboratory from "../Items/Laboratory";
import Service from "../Items/Service";

export default class Declaration 
{
    public Laboratory: Laboratory;
    public Service: Service;
    public Client: Client;
    
    public WorksDate: string;

    constructor(laboratory: Laboratory, service: Service, client: Client, WorksDate: string) 
    {
        this.Laboratory = laboratory;
        this.Service = service;
        this.Client = client;
        
        this.WorksDate = WorksDate;
    }

}