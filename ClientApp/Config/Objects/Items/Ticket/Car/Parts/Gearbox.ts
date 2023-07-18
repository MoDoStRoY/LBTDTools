export default class Gearbox
{
    public mark: string;
    public type: string;

    constructor(mark: string, type: string)
    {
        if ((mark + type) == "")
        {
            this.mark = " без изменений";
            this.type = "";
        }
        else
        {
            this.mark = mark;
            this.type = type;  
        }
    }
}