import Engine from "./Parts/Engine";
import UpgradeTypes from "./UpgradeTypes";
import Wheels from "./Parts/Wheels";

export default class Car
{
    public brand: string;
    public model: string;
    public color: string;
    public govRegNum: string;
    public releaseDate: string;
    public VIN: string;
    public chassisNumber: string;
    public bodyNumber: string;
    public engine: Engine;
    public wheels: Wheels;
    public upgrades: UpgradeTypes;
    public weightWithEquipment: string;
    public maxWeight: string;
    public length: string;
    public width: string;
    public height: string;
    public wheelBaseLength: string;

    constructor(brand: string, model: string, color: string, govRegNum: string, releaseDate:string, VIN: string, chassisNumber: string,
                bodyNumber: string, engine: Engine, wheels: Wheels, upgrades: UpgradeTypes, weightWithEquipment: string,
                maxWeight: string, length: string, width: string, height: string, wheelBaseLength: string)
    {
        this.brand = brand;
        this.model = model;
        this.color = color;
        this.govRegNum = govRegNum;
        this.releaseDate = releaseDate;
        this.VIN = VIN;
        this.chassisNumber = chassisNumber;
        this.bodyNumber = bodyNumber;
        this.engine = engine;
        this.wheels = wheels;
        this.upgrades = upgrades;
        this.weightWithEquipment = weightWithEquipment;
        this.maxWeight = maxWeight;
        this.length = length;
        this.width = width;
        this.height = height;
        this.wheelBaseLength = wheelBaseLength;
    }
}