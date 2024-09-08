export class Students
{
    private id:number;
    private name:string;
    constructor(id:number,name:string)
    {
     this.id = id;
     this.name = name;
    }
    Show()
    {
        console.log("ID : " +this.id);
        console.log("NAME : " +this.name);
    }
}