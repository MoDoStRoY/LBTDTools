export default class Upgrade
{
    public name: string;
    public parameter: string; //Абстрактный параметр, тут в виде строки будут доп.данные различных видов изменений
    public category: string; //Условная категория изменения в конструкции для упрощения обработки данных бэком

    constructor(name: string, parameter: string, category: string)
    {
        this.name = name;
        this.parameter = parameter;
        this.category = category;
    }
}