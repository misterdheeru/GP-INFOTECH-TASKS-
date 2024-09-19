import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-rectiveforms',
  templateUrl: './rectiveforms.component.html',
  styleUrl: './rectiveforms.component.css'
})
export class RectiveformsComponent {
  myForm = new FormGroup({

    Fname :new FormControl("" ,[Validators.required,Validators.minLength(8)]),
    Lname:new FormControl("" ,Validators.required),
    Number:new FormControl("" ,Validators.required),
    Country:new FormControl("-select-",Validators.required),
    Email:new FormControl("" ,Validators.required),
    Address:new FormControl("",Validators.required),
    Landmark:new FormControl("",Validators.required),
    Date:new FormControl("",Validators.required),
    Pin:new FormControl("",Validators.required),
    Mobile:new FormControl("",Validators.required),
    Age:new FormControl("",Validators.required)

   });

   DATA="";

   FormSubmitWithData(MyFromData:any)
   {

     this.DATA= MyFromData.value;

   }
}
