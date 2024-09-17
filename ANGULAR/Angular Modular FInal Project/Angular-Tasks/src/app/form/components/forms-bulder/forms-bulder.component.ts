import { Component } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-forms-bulder',
  templateUrl: './forms-bulder.component.html',
  styleUrl: './forms-bulder.component.css'
})
export class FormsBulderComponent {

  DATA:any=""
  myForm :any
  constructor(private formbulder:FormBuilder)
  {
  
    this.myForm = formbulder.group({
      
      FirstName : formbulder.control(""),
      LastName : formbulder.control(""),
      Country : formbulder.control("-select-"),
      State : formbulder.control("-select-"),
      Address : formbulder.control(""),
      Pin : formbulder.control("")
 

      
    })
   

  }
    submitform(DATA:any)
    {
      this.DATA =DATA;
    }

}
