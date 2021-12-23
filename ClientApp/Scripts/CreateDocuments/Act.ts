import Act from "../../Config/Objects/Docs/Act";
import Laboratory from "../../Config/Objects/Items/Laboratory";
import Service from "../../Config/Objects/Items/Service";
import Car from "../../Config/Objects/Items/Car/Car";
import Engine from "../../Config/Objects/Items/Car/Parts/Engine";
import UpgradeTypes from "../../Config/Objects/Items/Car/UpgradeTypes";
import axios from "axios";

export function actRequest(act: Act): string
{
    let downloadLink: string = "";
    
    axios(
        {
            method: "post",
            url: "api/CreateDocs/GetAct",
            data: JSON.stringify(act),
            headers: {"Content-Type": "application/json"},
            responseType: "blob",
        })
        .then((response: any) => {
            downloadLink = window.URL.createObjectURL(new Blob([response.data]));

            var a = document.createElement("a");
            document.body.appendChild(a);
            a.href = downloadLink;
            a.download = "Акт измерения.docx";
            a.click();
            document.body.removeChild(a);
        })
        .catch()
    
    return downloadLink;
}

export function getUpgradesList(powerBumperFront: boolean, jennyFront: boolean, protectiveArcFront: boolean, 
                                vizor: boolean, steps: boolean, powerBumperBack: boolean, jennyBack: boolean, 
                                protectiveArcBack: boolean, wheelBracket: boolean, wheelBracketDoor: boolean, 
                                kung: boolean, carrier: boolean, ladder: boolean, manhole: boolean, 
                                metalRoof: boolean, farLights: boolean, dayLights: boolean, fogLights: boolean, 
                                workLights: boolean, snorkel: boolean, engineProtection: boolean, pullProtection: boolean, 
                                transmissionProtection: boolean, diskBrakesFront: boolean, diskBrakesBack: boolean, 
                                damper: boolean, waterBooster: boolean, sleepingBag: boolean, liftSpring: boolean, 
                                liftSpacers: boolean, biggerTires: boolean, archExtenders: boolean, gasSet: boolean, 
                                gasDelete: boolean, swapEngine: boolean, swapCategory: boolean, armorDelete: boolean): UpgradeTypes
{
    let upgradeTypes: UpgradeTypes= new UpgradeTypes();
    
    if (powerBumperFront) upgradeTypes.powerBumperFront = true;
    if (jennyFront) upgradeTypes.jennyFront = true;
    if (protectiveArcFront) upgradeTypes.protectiveArcFront = true;
    if (vizor) upgradeTypes.vizor = true;
    if (steps) upgradeTypes.steps = true;
    if (powerBumperBack) upgradeTypes.powerBumperBack = true;
    if (jennyBack) upgradeTypes.jennyBack = true;
    if (protectiveArcBack) upgradeTypes.protectiveArcBack = true;
    if (wheelBracket) upgradeTypes.wheelBracket = true;
    if (wheelBracketDoor) upgradeTypes.wheelBracketDoor = true;
    if (kung) upgradeTypes.kung = true;
    if (carrier) upgradeTypes.carrier = true;
    if (ladder) upgradeTypes.ladder = true;
    if (manhole) upgradeTypes.manhole = true;
    if (metalRoof) upgradeTypes.metalRoof = true;
    if (farLights) upgradeTypes.farLights = true;
    if (dayLights) upgradeTypes.dayLights = true;
    if (fogLights) upgradeTypes.fogLights = true;
    if (workLights) upgradeTypes.workLights = true;
    if (snorkel) upgradeTypes.snorkel = true;
    if (engineProtection) upgradeTypes.engineProtection = true;
    if (pullProtection) upgradeTypes.pullProtection = true;
    if (transmissionProtection) upgradeTypes.transmissionProtection = true;
    if (diskBrakesFront) upgradeTypes.diskBrakesFront = true;
    if (diskBrakesBack) upgradeTypes.diskBrakesBack = true;
    if (damper) upgradeTypes.damper = true;
    if (waterBooster) upgradeTypes.waterBooster = true;
    if (sleepingBag) upgradeTypes.sleepingBag = true;
    if (liftSpring) upgradeTypes.liftSpring = true;
    if (liftSpacers) upgradeTypes.liftSpacers = true;
    if (biggerTires) upgradeTypes.biggerTires = true;
    if (archExtenders) upgradeTypes.archExtenders = true;
    if (gasSet) upgradeTypes.gasSet = true;
    if (gasDelete) upgradeTypes.gasDelete = true;
    if (swapEngine) upgradeTypes.swapEngine = true;
    if (swapCategory) upgradeTypes.swapCategory = true;
    if (armorDelete) upgradeTypes.armorDelete = true;
    
    return upgradeTypes;
}