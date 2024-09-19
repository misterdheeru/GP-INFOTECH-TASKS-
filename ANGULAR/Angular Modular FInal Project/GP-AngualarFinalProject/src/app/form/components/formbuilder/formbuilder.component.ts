import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-formbuilder',
  templateUrl: './formbuilder.component.html',
  styleUrl: './formbuilder.component.css'
})
export class FormbuilderComponent {
  myForm:any
  constructor(private formbulder:FormBuilder){

    this.myForm = this.formbulder.group({

      Fname :this.formbulder.control("" ,[Validators.required,Validators.minLength(8)]),
      Lname: this.formbulder.control("" ,Validators.required),
      Number:this.formbulder.control("" ,Validators.required),
      Country:this.formbulder.control("-select-",Validators.required),
      Email:this.formbulder.control("" ,Validators.required),
      Address:this.formbulder.control("",Validators.required),
      Landmark:this.formbulder.control("",Validators.required),
      Date:this.formbulder.control("",Validators.required),
      Pin:this.formbulder.control("",Validators.required),
      Mobile:this.formbulder.control("",Validators.required),
      Age:this.formbulder.control("",Validators.required)

    })
  }
  ngOnInit(): void {

  }


  FormSubmitWithData(DATA:any)
  {
   console.log(DATA.value)
  }
}
