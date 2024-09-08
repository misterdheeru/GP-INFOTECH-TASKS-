export class Sports
{
   private name :string
   constructor(name:string)
   {
     this.name = name
     console.log("My Favorite Sports Name is : " +this.name)
   }

   Play()
   {
    console.log("My Favorite Sports Name is : " +this.name)
   }
}
export class Cricket extends Sports
{
   constructor(name:string)
   {
    super(name);
   }

   Play(): void {
       console.log("I LOVE PLAYING CRICKET");
   }
}
export class Football extends Sports
{
    constructor(name:string)
    {
        super(name)
    }
    Play(): void {
        console.log("I LOVE PLAYING FOOTBALL");
    }
} 

var cricket = new Cricket("CRICKET");
var football = new Football("FOOTBALL");

cricket.Play();
football.Play();



export class Animals
{
   private name :string
   constructor(name:string)
   {
     this.name = name
      
   }

   DisplayName()
   {
    console.log("My Favorite Animal  is : " +this.name);
   }
}
export class Dog extends Animals
{
   constructor(name:string)
   {
    super(name);
   }

   makesound(): void {
       console.log("Dog Tells Bow Bow....");
   }
}
export class Cat extends Animals
{
    constructor(name:string)
    {
        super(name)
    }
    makesound(): void {
        console.log("Cat Tells Meawoooo....");
    }
} 

var dog = new Dog("");
var cat = new Cat("Tom");
 
dog.DisplayName();
dog.makesound();
cat.DisplayName();
cat.makesound();
 