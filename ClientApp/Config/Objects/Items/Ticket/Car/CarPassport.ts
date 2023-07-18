export default class CarPassport
{
    public ptsNumber: string;
    public ptsDate: string;
    public VIN: string;
    public carMark: string;
    public carModel: string;
    public carType: string;
    public carDrivingLicense: string;
    public carCategory: string;
    public carYearProduction: string;
    public engineModel: string;
    public engineNumber: string;
    public chassisNumber: string;
    public bodyNumber: string;
    public enginePowerHorse: string;
    public enginePowerKwt: string;
    public workVolume: string;
    public engineType: string;
    public ecoClass: string;
    public maxMass: string;
    public massInDefault: string;
    public carManufacturer: string;
    public otts: string;

    constructor(ptsNumber: string, ptsDate: string, VIN: string, carMark: string, carModel: string, carType: string, 
                carDrivingLicense: string, carCategory: string, carYearProduction: string, engineModel: string, 
                engineNumber: string, chassisNumber: string, bodyNumber: string, enginePowerHorse: string, 
                enginePowerKwt: string, workVolume: string, engineType: string, ecoClass: string, maxMass: string,
                massInDefault: string, carManufacturer: string, otts: string)
    {
        this.ptsNumber = ptsNumber;
        this.ptsDate = ptsDate;
        this.VIN = VIN;
        this.carMark = carMark;
        this.carModel = carModel;
        this.carType = carType;
        this.carDrivingLicense = carDrivingLicense;
        this.carCategory = carCategory;
        this.carYearProduction = carYearProduction;
        this.engineModel = engineModel;
        this.engineNumber = engineNumber;
        this.chassisNumber = chassisNumber;
        this.bodyNumber = bodyNumber;
        this.enginePowerHorse = enginePowerHorse;
        this.enginePowerKwt = enginePowerKwt;
        this.workVolume = workVolume;
        this.engineType = engineType;
        this.ecoClass = ecoClass;
        this.maxMass = maxMass;
        this.massInDefault = massInDefault;
        this.carManufacturer = carManufacturer;
        this.otts = otts;
    }
}