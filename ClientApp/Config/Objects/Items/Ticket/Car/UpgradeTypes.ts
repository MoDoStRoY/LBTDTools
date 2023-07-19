import Upgrade from "./Parts/Upgrade";

export default class UpgradeTypes
{
    public upgradesList: Upgrade[];
    
    constructor(upgradesList: Upgrade[]) 
    {
        this.upgradesList = upgradesList;
    }
    
}