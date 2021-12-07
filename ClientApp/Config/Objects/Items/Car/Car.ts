import Engine from "./Parts/Engine";
import UpgradeTypes from "./UpgradeTypes";

export default class Car
{
    public brand: string;
    public model: string;
    public color: string;
    public govRegNum: string;
    public VIN: string;
    public chassisNumber: string;
    public bodyNumber: string;
    public engine: Engine;
    public upgrades: UpgradeTypes;

    constructor(brand: string, model: string, color: string, govRegNum: string, VIN: string, chassisNumber: string,
                bodyNumber: string, engine: Engine, upgrades: UpgradeTypes)
    {
        this.brand = brand;
        this.model = model;
        this.color = color;
        this.govRegNum = govRegNum;
        this.VIN = VIN;
        this.chassisNumber = chassisNumber;
        this.bodyNumber = bodyNumber;
        this.engine = engine;
        this.upgrades = upgrades;
    }
}