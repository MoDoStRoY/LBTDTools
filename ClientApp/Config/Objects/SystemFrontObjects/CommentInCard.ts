export default class CommentInCard 
{
    public date: string;
    public text: string;
    public author: string;

    constructor(date: string, text: string, author: string) 
    {
        this.date = date;
        this.text = text;
        this.author = author;
    }
}