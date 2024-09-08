 
export class A {
  name: string;

  constructor(name: string) {
      this.name = name;
  }

  show() {
      console.log("OUR NAME IS  : " + this.name);
  }
}

export class B extends A {
  constructor(name: string) {
      super(name);
  }
}

export class C extends B {
  private lastName: string;

  constructor(firstName: string, lastName: string) {
      super(firstName);
      this.lastName = lastName;
  }

  show() {
      console.log("OUR FULL NAME IS: " + this.name + " " + this.lastName);
  }
}
 
interface students
{
  ID :number
  NAME ?:string
  CLASS_NAME :string
  AGE:number
}

export class college
{
   studentsList  : students []= [] ;
   show(DATA:students)
   {
      this.studentsList.push(DATA); 

      for(var res of this.studentsList)
      {
        console.log("ID : "+ res.ID);
        console.log("NAME : "+ res.NAME);
        console.log("CLASS NAME : "+ res.CLASS_NAME);
        console.log("AGE : "+ res.AGE);
      }
   }
  
 

}
export enum colors
{
  red ="RED",
  green ="GREEN",
  blue ="BLUE",
  orange ="ORANGE"
}
abstract class C1
{
   
  constructor(protected name:string)
  {
    console.log("OUR NAME IS "+name);
  }
   
   abstract show():void;
}
export class C2 extends C1
{
  corlor :colors
  constructor(name ,color :colors)
  {
    super(name)
    this.corlor=color
  }

   show(): void {
    console.log("MY NAME IS "+this.name);

    switch(this.corlor)
    {
      case colors.red :
      {
       console.log("OUR COLOR IS " +colors.red);
        break ;
      }
      case colors.green :
        {
         console.log("OUR COLOR IS " + colors.green );
          break ;
        }
        
    }
  }
   
}

//#region Property Types 

export class car 
{

settings :string | number
constructor(settings)
{
  this.settings = settings
}
display ()
{
  console.log(this.settings);
}
}


//#endregion