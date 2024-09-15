import { Component, Injectable, OnInit, ViewChild } from '@angular/core';
import { LoginService } from '../../services/login.service';
import {Router } from '@angular/router';
 

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
 
export class LoginComponent    {
  
  DATA : any = [];

  @ViewChild("username") username:any
  @ViewChild("password") password:any
 

 
  constructor(private Login: LoginService, private router: Router) 
  {

  }

  txtBox = "password"

  checkedBox(Data:any)
  {
   if(Data.target.checked==true){this.txtBox = "text";}else{this.txtBox  = "password";}
    
  }

  login()
  {
    var name = this.username.nativeElement.value;
    var pass = this.password.nativeElement.value
    var userLogin  = {USERNAME:name,PASSWORD:pass}
    this.Login.userLogin(userLogin).subscribe((res:any)=>{

      this.DATA = res

      console.log(this.DATA)

      this.DATA.map((item:any) => {
        console.log(item.IS_ACTIVE)
        if(item.IS_ACTIVE==true)
        {
          this.router.navigate(["home"])
    
          sessionStorage.setItem('boolvalue', "false" );  
          sessionStorage.setItem('username', item.USERNAME);  
        }
        else
        {
          sessionStorage.setItem('boolvalue', "true" );  
          console.log("INVILIDE USER")
        }
      })

    });
    
           
 
 

  }
}
