import {C2, college ,colors ,car} from './Exmp1'

 
 
export class DisplayStudents
{

display()
{
  var  Data = {ID:1,NAME:"RAMA",CLASS_NAME :"V",AGE:25};
  var  std1 = new college()
  std1.show(Data);
   
}

}

// var res  = new DisplayStudents()

// res.display()

// var res2 = new C2("RAMA",colors.red)
// res2.show();

var car1 = new car("RAMA");
car1.display();