import Engine from "./Parts/Engine";
import UpgradeTypes from "./UpgradeTypes";
import Wheels from "./Parts/Wheels";
import CarPassport from "./CarPassport";
import CarCertificate from "./CarCertificate";
import Breaks from "./Parts/Breaks";
import Gearbox from "./Parts/Gearbox";
import Suspension from "./Parts/Suspension";
import Transmission from "./Parts/Transmission";
import Body from "./Parts/Body";

export default class Car
{
    //** Документы на машину **//
    public passport: CarPassport;
    public certificate: CarCertificate;
    
    //** Составные части **//
    public engine: Engine;
    public wheels: Wheels;
    public breaks: Breaks;
    public gearbox: Gearbox;
    public suspension: Suspension;
    public transmission: Transmission;
    public body: Body;
    public axisCount: string;
    
    //** Массив со списком изменений в конструкции
    public jeepTuningChanges: UpgradeTypes;
    public truckTuningChanges: UpgradeTypes;
    public changeCategoryTypeChanges: UpgradeTypes;
    public otherChanges: UpgradeTypes;

    constructor(passport: CarPassport, certificate: CarCertificate, engine: Engine, wheels: Wheels, 
                breaks: Breaks, gearbox: Gearbox, suspension: Suspension,
                transmission: Transmission, body: Body, axisCount: string, jeepTuningChanges: UpgradeTypes,
                truckTuningChanges: UpgradeTypes, changeCategoryTypeChanges: UpgradeTypes, otherChanges: UpgradeTypes,)
    {
        this.passport = passport;
        this.certificate = certificate;
        this.engine = engine;
        this.wheels = wheels;
        this.breaks = breaks;
        this.gearbox = gearbox;
        this.suspension = suspension;
        this.transmission = transmission;
        this.body = body;
        this.axisCount = axisCount;
        this.jeepTuningChanges = jeepTuningChanges;
        this.truckTuningChanges = truckTuningChanges;
        this.changeCategoryTypeChanges = changeCategoryTypeChanges;
        this.otherChanges = otherChanges;
    }
}