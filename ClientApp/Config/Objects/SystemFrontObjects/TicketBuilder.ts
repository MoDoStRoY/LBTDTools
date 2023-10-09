import ChangedParam from "../Items/Ticket/Car/ChangedParam";
import UpgradeTypes from "../Items/Ticket/Car/UpgradeTypes";
import Client from "../Items/Client";
import Car from "../Items/Ticket/Car/Car";
import Engine from "../Items/Ticket/Car/Parts/Engine";
import Wheels from "../Items/Ticket/Car/Parts/Wheels";
import Breaks from "../Items/Ticket/Car/Parts/Breaks";
import Gearbox from "../Items/Ticket/Car/Parts/Gearbox";
import Suspension from "../Items/Ticket/Car/Parts/Suspension";
import Transmission from "../Items/Ticket/Car/Parts/Transmission";
import Body from "../Items/Ticket/Car/Parts/Body";
import CarPassport from "../Items/Ticket/Car/CarPassport";
import CarCertificate from "../Items/Ticket/Car/CarCertificate";

export default class TicketBuilder 
{
    //Данные по обращению
    public currentClient: Client;
    public currentCar: Car;
    
    //Вид услуги
    public changeConstructionService: boolean;
    public sbksService: boolean;
    public eptsService: boolean;
    
    //Переоборудование виды
    public jeepTuningType: boolean;
    public truckTuningType: boolean;
    public changeCategoryTypeType: boolean;
    public otherType: boolean;
    
    //Массивы изменений в конструкции
    public jeepTuningChanges: UpgradeTypes;
    public truckTuningChanges: UpgradeTypes;
    public changeCategoryTypeChanges: UpgradeTypes;
    public otherChanges: UpgradeTypes;
    
    //Связь с юзерами
    public ownerID: number;
    
    public static buildJeepTuningChanges
    (
        frontBumper:boolean, rearBumper:boolean, frontWinch:boolean, rearWinch:boolean, bumperWheelBracket:boolean, 
        doorWheelBracket:boolean, trunk:boolean, ladder:boolean, farLights:boolean, dayLights:boolean, fogLights:boolean, 
        snorkel:boolean, sills:boolean, kung:boolean, suspensionLiftSprings:boolean, suspensionLiftSpacers:boolean, 
        biggerWheels:boolean, archExtenders:boolean, workLights:boolean, rodProtection:boolean,
        engineProtection:boolean, gearboxProtection:boolean, helmDamper:boolean, helmBooster:boolean, 
        frontDiskBrakes:boolean, rearDiskBrakes:boolean, frontProtectionArc:boolean, rearProtectionArc:boolean, 
        insideProtectionArc:boolean, protectiveVisor:boolean, hatch:boolean, sleepPlace:boolean, metalRoof: boolean
    ) 
    {
        let jeepTuningChanges: UpgradeTypes = new UpgradeTypes([], "jeepTuningType");
        if (frontBumper)
            jeepTuningChanges.upgradesList.push("frontBumper");
        if (rearBumper)
            jeepTuningChanges.upgradesList.push("rearBumper");
        if (frontWinch)
            jeepTuningChanges.upgradesList.push("frontWinch");
        if (rearWinch)
            jeepTuningChanges.upgradesList.push("rearWinch");
        if (bumperWheelBracket)
            jeepTuningChanges.upgradesList.push("bumperWheelBracket");
        if (doorWheelBracket)
            jeepTuningChanges.upgradesList.push("doorWheelBracket");
        if (trunk)
            jeepTuningChanges.upgradesList.push("trunk");
        if (ladder)
            jeepTuningChanges.upgradesList.push("ladder");
        if (farLights)
            jeepTuningChanges.upgradesList.push("farLights");
        if (dayLights)
            jeepTuningChanges.upgradesList.push("dayLights");
        if (fogLights)
            jeepTuningChanges.upgradesList.push("fogLights");
        if (snorkel)
            jeepTuningChanges.upgradesList.push("snorkel");
        if (sills)
            jeepTuningChanges.upgradesList.push("sills");
        if (kung)
            jeepTuningChanges.upgradesList.push("kung");
        if (suspensionLiftSprings)
            jeepTuningChanges.upgradesList.push("suspensionLiftSprings");
        if (suspensionLiftSpacers)
            jeepTuningChanges.upgradesList.push("suspensionLiftSpacers");
        if (biggerWheels)
            jeepTuningChanges.upgradesList.push("biggerWheels");
        if (archExtenders)
            jeepTuningChanges.upgradesList.push("archExtenders");
        if (workLights)
            jeepTuningChanges.upgradesList.push("workLights");
        if (rodProtection)
            jeepTuningChanges.upgradesList.push("rodProtection");
        if (engineProtection)
            jeepTuningChanges.upgradesList.push("engineProtection");
        if (gearboxProtection)
            jeepTuningChanges.upgradesList.push("gearboxProtection");
        if (helmDamper)
            jeepTuningChanges.upgradesList.push("helmDamper");
        if (helmBooster)
            jeepTuningChanges.upgradesList.push("helmBooster");
        if (frontDiskBrakes)
            jeepTuningChanges.upgradesList.push("frontDiskBrakes");
        if (rearDiskBrakes)
            jeepTuningChanges.upgradesList.push("rearDiskBrakes");
        if (frontProtectionArc)
            jeepTuningChanges.upgradesList.push("frontProtectionArc");
        if (rearProtectionArc)
            jeepTuningChanges.upgradesList.push("rearProtectionArc");
        if (insideProtectionArc)
            jeepTuningChanges.upgradesList.push("insideProtectionArc");
        if (protectiveVisor)
            jeepTuningChanges.upgradesList.push("protectiveVisor");
        if (hatch)
            jeepTuningChanges.upgradesList.push("hatch");
        if (sleepPlace)
            jeepTuningChanges.upgradesList.push("sleepPlace");
        if (metalRoof)
            jeepTuningChanges.upgradesList.push("metalRoof");
        
        return jeepTuningChanges;
    }

    public static buildTruckTuningChanges
    (
        HOU: boolean
    )
    {
        let truckTuningChanges: UpgradeTypes = new UpgradeTypes([], "truckTuningChanges");
        if (HOU)
            truckTuningChanges.upgradesList.push("HOU");

        return truckTuningChanges;
    }

    public static buildChangeCategoryTypeChanges
    (
        replaceCategoryDB: boolean, replaceCategoryDC: boolean, 
        replaceCategoryCD: boolean, flatbedIsothermalBody: boolean
    )
    {
        let changeCategoryTypeChanges: UpgradeTypes = new UpgradeTypes([], "changeCategoryTypeChanges");
        if (replaceCategoryDB)
            changeCategoryTypeChanges.upgradesList.push("replaceCategoryDB");
        if (replaceCategoryDC)
            changeCategoryTypeChanges.upgradesList.push("replaceCategoryDC");
        if (replaceCategoryCD)
            changeCategoryTypeChanges.upgradesList.push("replaceCategoryCD");
        if (flatbedIsothermalBody)
            changeCategoryTypeChanges.upgradesList.push("flatbedIsothermalBody");

        return changeCategoryTypeChanges;
    }

    public static buildOtherChanges
    (
        installGboSng: boolean, installGboKpg: boolean, replaceEngine: boolean, 
        uninstallGbo: boolean, installStudyEquipment: boolean, uninstallStudyEquipment: boolean
    )
    {
        let otherChanges: UpgradeTypes = new UpgradeTypes([], "truckTuningChanges");
        if (installGboSng)
            otherChanges.upgradesList.push("installGboSng");
        if (installGboKpg)
            otherChanges.upgradesList.push("installGboKpg");
        if (replaceEngine)
            otherChanges.upgradesList.push("replaceEngine");
        if (uninstallGbo)
            otherChanges.upgradesList.push("uninstallGbo");
        if (installStudyEquipment)
            otherChanges.upgradesList.push("installStudyEquipment");
        if (uninstallStudyEquipment)
            otherChanges.upgradesList.push("uninstallStudyEquipment");

        return otherChanges;
    }
    
    public static buildClient
    (
        clientLastName: string, clientName: string, clientMiddleName: string, 
        clientPhoneNumber: string, clientPassportNumber: string, clientPassportAuthor: string, 
        clientAddress: string
    )
    {
        return new Client 
        (
            clientLastName, clientName, clientMiddleName, 
            clientPhoneNumber, clientPassportNumber, clientPassportAuthor, 
            clientAddress
        )
    }
    
    public static buildCar
    (
        //ПТС
        ptsNumber: string, ptsDate: string, VIN: string,carMark: string, carModel: string, 
        carType: string, carDrivingLicense: string, carCategoryDefault: string, 
        carYearProduction: string, engineModelDefault: string, engineNumberDefault: string, chassisNumber: string,
        bodyNumber: string, enginePowerHorseDefault: string, enginePowerKwtDefault: string, workVolumeDefault: string, 
        engineTypeDefault: string, ecoClassDefault: string, maxMassDefault: string, massInDefaultDefault: string, 
        carManufacturer: string, otts: string, 
        //СТС
        stsNumber: string, stsDate: string, 
        carNumber: string, carColor: string, 
        //Двигатель
        engineModel: string, engineNumber: string,
        engineType: string, engineFuel: string, engineEcoClass: string, 
        engineCylindersCount: string, engineCylindersVolume: string, engineCompression: string,
        engineMaxPower: string, engineMaxRotateMoment: string, engineSupplySystem: string,
        //Колёса
        wheelName: string, wheelWidth: string, wheelProfileSize: string, wheelRadius: string,
        //Тормоза
        breaksWorkType: string, breaksSpareType: string, breaksParkingType: string,
        //КПП
        gearboxMark: string, gearboxType: string,
        //Подвеска
        suspensionFrontType: string, suspensionRearType: string,
        //Трансмиссия
        transmissionType: string, 
        //Кузов
        bodyType: string, bodyPassengerSeatsFrontRear: string, bodyLoadingSpaceType: string,
        bodyCabinType: string, bodyPassengerSeatsBus: string, bodySeatsBus: string, bodyLoadCompartment: string,
        bodyFrame: string,
        //Количество осей
        axisCount: string,
        //Массивы с переоборудованием
        jeepTuningChanges: UpgradeTypes, truckTuningChanges: UpgradeTypes, 
        changeCategoryTypeChanges: UpgradeTypes, otherChanges: UpgradeTypes,
    )
    {
        return new Car(new CarPassport(ptsNumber, ptsDate, VIN, carMark, carModel, carType, carDrivingLicense,
                carCategoryDefault, carYearProduction, engineModelDefault, engineNumberDefault, chassisNumber,
                bodyNumber, enginePowerHorseDefault, enginePowerKwtDefault, workVolumeDefault, engineTypeDefault,
                ecoClassDefault, maxMassDefault, massInDefaultDefault, carManufacturer, otts),
            //СТС
            new CarCertificate(stsNumber, stsDate, carNumber, carColor),
            //Составные части
            new Engine(engineModel, engineNumber, engineType, engineFuel, engineEcoClass, engineCylindersCount,
                engineCylindersVolume, engineCompression, engineMaxPower, engineMaxRotateMoment,
                engineSupplySystem),
            new Wheels(wheelName, wheelWidth, wheelProfileSize, wheelRadius),
            new Breaks(breaksWorkType, breaksSpareType, breaksParkingType),
            new Gearbox(gearboxMark, gearboxType),
            new Suspension(suspensionFrontType, suspensionRearType),
            new Transmission(transmissionType),
            new Body(bodyType, bodyPassengerSeatsFrontRear, bodyLoadingSpaceType,
                bodyCabinType, bodyPassengerSeatsBus, bodySeatsBus, bodyLoadCompartment,
                bodyFrame, carCategoryDefault),
            //Количество осей
            axisCount,
            //Массивы с изменениями в конструкции
            jeepTuningChanges, truckTuningChanges, changeCategoryTypeChanges, otherChanges)
    }
    
    public static initializationConstructor()
    {
        return new TicketBuilder
        (
            new Client("", "", "", "", "", "", ""), 
            new Car(new CarPassport("", "", "", "", "", "",
                    "", "", "", "", "", 
                    "", "", "", "", "",
                    "", "", "", "", "", ""), 
                new CarCertificate("", "", "", ""), new Engine("", 
                    "", "", "", "", "", "",
                "", "", "", ""), new Wheels("", "",
                "", ""), new Breaks("", "", ""), new Gearbox("", ""),
                new Suspension("", ""), new Transmission(""), new Body("", "", 
                    "", "", "", "", "", "",
                    ""), "", new UpgradeTypes([],""), new UpgradeTypes([],""),
                new UpgradeTypes([],""), new UpgradeTypes([],"")), false, false, false, 
            false, false, false, false, 
            new UpgradeTypes([""], ""), new UpgradeTypes([], ""), 
            new UpgradeTypes([""], ""), new UpgradeTypes([], ""), 0
            );
    }
    
    constructor(currentClient: Client, currentCar: Car, changeConstructionService: boolean, sbksService: boolean,
    eptsService: boolean, jeepTuningType: boolean, truckTuningType: boolean, changeCategoryTypeType: boolean,
                otherType: boolean, jeepTuningChanges: UpgradeTypes, truckTuningChanges: UpgradeTypes, 
                changeCategoryTypeChanges: UpgradeTypes, otherChanges: UpgradeTypes, ownerID: number) 
    {
        this.currentClient = currentClient;
        this.currentCar = currentCar;
        this.changeConstructionService = changeConstructionService;
        this.sbksService = sbksService;
        this.eptsService = eptsService;
        this.jeepTuningType = jeepTuningType;
        this.truckTuningType = truckTuningType;
        this.changeCategoryTypeType = changeCategoryTypeType;
        this.otherType = otherType;
        this.jeepTuningChanges = jeepTuningChanges;
        this.truckTuningChanges = truckTuningChanges;
        this.changeCategoryTypeChanges = changeCategoryTypeChanges;
        this.otherChanges = otherChanges;
        this.ownerID = ownerID;
    }
    
}