import Laboratory from "../Items/Laboratory";
import Service from "../Items/Service";
import Car from "../Items/Car/Car";

export default class Act
{
    public laboratory: Laboratory;
    public service: Service;
    public car: Car;

    public number: string;
    public sampleCloseDate: string;
    public carGiveDate: string;
    public PPTOAddress: string;
    public namePPTOExpert: string;
    
    constructor(laboratory: Laboratory, service: Service, car: Car, number: string,
                sampleCloseDate: string, carGiveDate: string, PPTOAddress: string,
                namePPTOExpert: string) 
    {
        this.laboratory = laboratory;
        this.service = service;
        this.car = car;
        this.number = number;
        this.sampleCloseDate = sampleCloseDate;
        this.carGiveDate = carGiveDate;
        this.PPTOAddress = PPTOAddress;
        this.namePPTOExpert = namePPTOExpert
    }
}