export default class UpgradeTypes
{
    public upgradesList: string[];
    public type: string;
    
    constructor(upgradesList: string[], type: string) 
    {
        this.upgradesList = upgradesList;
        this.type = type;
    }
    
}