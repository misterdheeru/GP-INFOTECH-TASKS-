import { Component, ViewChild } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  @ViewChild("username")username:any
  @ViewChild("password")password:any

  LoginData:any[] = [];

  constructor(private routing : Router){}

  txtboxvalue:any = "password";
  erromsg=false;

  checkedbox(data:any)
  {
    if(data.target.checked==true)
    {
      this.txtboxvalue= "text";
    }
    else{
      this.txtboxvalue= "password";
    }
  }

  // Login()
  // {
  //  const data= {USERNAME:this.username.nativeElement.value,PASSWORD:this.password.nativeElement.value}
  //  this.loginservice.Login(data).subscribe((res:any)=>{

  //   if(res==1)
  //   {

  //     this.erromsg=false;

  //     this.loginservice.GetLoginData(data).subscribe((res:any)=>{

  //     this.LoginData = res

  //     this.LoginData.map(res=>{

  //     sessionStorage.setItem("username",res.USERNAME);

  //     this.routing.navigate(["home"]);

  //   })

  //  })
  //   }
  //   else
  //   {
  //     this.erromsg=true;
  //   }

  //  })

  // }
}
