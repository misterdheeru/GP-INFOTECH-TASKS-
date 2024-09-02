import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ArraysDropdownsService {

  constructor() { }

  

  ArrayDropDownList = [{
 
    country : [ {ID : 1,NAME:"india"} , {ID:2 , NAME : "usa"} ],
    states : [    {ID:1 , NAME : "Telangana" ,REFID:1} ,{ID:2 , NAME : "Andhra Pradesh" , REFID:1} ,{ID:2 , NAME : "Texas" ,  REFID:2 },{ID:2 , NAME : "Florida" ,  REFID:2}]

  }]

}
