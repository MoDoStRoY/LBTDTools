export default class Wheels
{
    public name: string;
    public wheelWidth: string;
    public profileSize: string;
    public radius: string;

    constructor(name: string, wheelWidth: string, profileSize: string, radius: string)
    {
        if (name == "")
        {
            this.name = " без изменений";
            this.wheelWidth = "";
            this.profileSize = "";
            this.radius = "";
        }
        else
        {
            this.name = name;
            this.wheelWidth = wheelWidth;
            this.profileSize = profileSize;
            this.radius = radius;
        }
    }
}