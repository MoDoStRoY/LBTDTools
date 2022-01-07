import Car from "../Items/Car/Car";
import Client from "../Items/Client";
import Laboratory from "../Items/Laboratory";
import Service from "../Items/Service";

export default class Declaration {
    public Laboratory: Laboratory;
    public Service: Service;
    public Car: Car;
    public Client: Client;

    constructor(laboratory: Laboratory, service: Service, car: Car, client: Client) 
    {
        this.Laboratory = laboratory;
        this.Service = service;
        this.Car = car;
        this.Client = client;
    }

}