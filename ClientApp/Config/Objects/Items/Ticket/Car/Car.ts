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
    public VIN: string;
    public mark: string;
    public model: string;
    public type: string;
    public drivingLicense: string;
    public carCategory: string;
    public yearProduction: string;
    public engine: Engine;
    public chassisNumber: string;
    public maxMass: string;
    public carManufacturer: string;
    public otts: string;
    public color: string;
    
    public wheels: Wheels;
    public passport: CarPassport;
    public certificate: CarCertificate;
    public breaks: Breaks;
    public gearbox: Gearbox;
    public suspension: Suspension;
    public transmission: Transmission;
    public body: Body;
    public axisCount: string;
    
    public upgrades: UpgradeTypes;

    constructor(VIN: string, mark: string, model: string, type: string, drivingLicense: string, carCategory: string, 
                yearProduction: string, engine: Engine, chassisNumber: string, maxMass: string, 
                carManufacturer: string, otts: string, color: string, wheels: Wheels, passport: CarPassport, 
                certificate: CarCertificate, breaks: Breaks, gearbox: Gearbox, suspension: Suspension,
                transmission: Transmission, body: Body, axisCount: string, upgrades: UpgradeTypes)
    {
        this.VIN = VIN;
        this.mark = mark;
        this.model = model;
        this.type = type;
        this.drivingLicense = drivingLicense;
        this.carCategory = carCategory;
        this.yearProduction = yearProduction;
        this.engine = engine;
        this.chassisNumber = chassisNumber;
        this.maxMass = maxMass;
        this.carManufacturer = carManufacturer;
        this.otts = otts;
        this.color = color;
        this.wheels = wheels;
        this.passport = passport;
        this.certificate = certificate;
        this.breaks = breaks;
        this.gearbox = gearbox;
        this.suspension = suspension;
        this.transmission = transmission;
        this.body = body;
        this.axisCount = axisCount;
        this.upgrades = upgrades;
    }
}