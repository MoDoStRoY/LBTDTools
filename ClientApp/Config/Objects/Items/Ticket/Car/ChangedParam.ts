export default class ChangedParam
{
    public name: string;
    public params: string[];
    
    constructor(name: string, params: string[]) 
    {
        this.name = name;
        this.params = params;
    }
}