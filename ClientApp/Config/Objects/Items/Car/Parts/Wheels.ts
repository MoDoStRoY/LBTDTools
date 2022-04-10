export default class Wheels
{
    public name: string;
    public wheelWidth: string;
    public profileSize: string;
    public radius: string;

    constructor(name: string, wheelWidth: string, profileSize: string, radius: string)
    {
        this.name = name;
        this.wheelWidth = wheelWidth;
        this.profileSize = profileSize;
        this.radius = radius;
    }
}