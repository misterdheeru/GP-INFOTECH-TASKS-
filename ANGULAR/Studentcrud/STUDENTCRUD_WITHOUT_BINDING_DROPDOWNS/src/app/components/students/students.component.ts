import { Component, OnInit } from '@angular/core';
import { FormBuilder, ReactiveFormsModule } from '@angular/forms';
import { ArraysDropdownsService } from '../../Services/arrays-dropdowns.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-students',
  standalone: true,
  imports: [ReactiveFormsModule,CommonModule],
  templateUrl: './students.component.html',
  styleUrl: './students.component.css'
})
export class StudentsComponent implements OnInit  {

   myForm:any
   arraybrop:any
   Country :any = []
   States:any = []
  constructor ( private fb :FormBuilder , arraybrop :ArraysDropdownsService)
  {
  this.arraybrop = arraybrop;
  }
  ngOnInit(): void {
    this.myForm = this.fb.group(
      {
        FNAME : this.fb.control(""),
        LNAME : this.fb.control(""),
        AGE : this.fb.control(""),
        MOBILE  : this.fb.control(""),
        EMAIL : this.fb.control(""),
        COUNTRY : this.fb.control(""),    
        STATE : this.fb.control(""),  
        CITY : this.fb.control(""),  
        UNIVERSITY : this.fb.control(""),  
        COLLEGE : this.fb.control(""),  
        PROGRAM : this.fb.control(""),  
        YEAR : this.fb.control("")
      }
      )
   
       this.arraybrop.ArrayDropDownList.map((res:any)=>{
        res.country.map((res:any)=>{
          this.Country.push(res)
        })
           
       
       

      })
  
 
  
      

  }
  gp_countryChanges(val:any)
  {
   
    
       this.States = [];
       this.arraybrop.ArrayDropDownList.filter((res:any)=>{
         res.states.filter((res:any)=>{
           if(res.REFID==val.target.value)
           {
             this.States.push(res)
           }
         })
       })
     
     
  }
 

  Show()
  {
    console.log(this.myForm.value)
    console.log(`FIRSTNAME  : ${this.myForm.get('FNAME').value}`)
  }
 
 

  


}
